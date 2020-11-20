package Ejercicio12;

import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class HiloC extends Thread {
	
	int contador;

	public HiloC(String name, int contador) {
		super.setName("HiloC- " + super.getName());
		this.contador = contador;
	}

	public void run() {
		try {
			System.out.println("Nombre " + Thread.currentThread().getName());
			System.out.println(Thread.currentThread().getName());
			Random r = new Random();
			int espera = 1 + r.nextInt(50);

			Thread.sleep(espera);
			if(contador < 10)
			{
				contador++;
				HiloC clon = new HiloC("", contador);
				clon.start();
				clon.join(); // o join a secas
				//función recursiva 
				System.out.println("Nombre: " + Thread.currentThread().getName() + " tiempo de espera: " + espera
						+ " nombre del hilo clon: " + clon.getName());
			}
		}

		catch (InterruptedException e) {
			Logger.getLogger(HiloC.class.getName()).log(Level.SEVERE, null, e);
		}
	}

}
