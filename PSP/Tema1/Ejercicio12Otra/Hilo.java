package Ejercicio12Otra;

import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Hilo extends Thread {
	
	int contador;

	public Hilo(String name, int contador, int aCrear) {
		super.setName("HiloA- " + super.getName());
		this.contador = contador;
	}

	public void run() {
		try {
			System.out.println("Nombre " + Thread.currentThread().getName());
			System.out.println(Thread.currentThread().getName());
			Random r = new Random();
			int espera = 1 + r.nextInt(50);

			Thread.sleep(espera);
			if(contador <= 3)
			{
				contador++;
				Hilo clon = new Hilo("", contador);
				clon.start();
				clon.join(); // o join a secas
				//función recursiva 
				System.out.println("Nombre: " + Thread.currentThread().getName() + " tiempo de espera: " + espera
						+ " nombre del hilo clon: " + clon.getName());
			}
		}

		catch (InterruptedException e) {
			Logger.getLogger(Hilo.class.getName()).log(Level.SEVERE, null, e);
		}
	}

}
