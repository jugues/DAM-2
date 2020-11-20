package Ejercicio12;

import java.util.Random;

//inicio: nombre de hilo, num entre 0 y 50 para sleep, arrancar hilo. espera indefiniada hasta que acaba hilo arrancado, eco del sistema

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		System.out.println(Thread.currentThread().getName());
		Random r = new Random();
		int espera = 1 + r.nextInt(50);
		Thread.sleep(espera);
		
		HiloA clon = new HiloA("", 1);
		clon.start();
		clon.join();
		
		HiloB clon2 = new HiloB("", 1);
		clon2.start();
		
		HiloC clon3 = new HiloC("", 1);
		clon3.start();
		
		System.out.println("Nombre: " + Thread.currentThread().getName() + " tiempo de espera: " + espera + " nombre del hilo clon: " + clon.getName());

	}

}
