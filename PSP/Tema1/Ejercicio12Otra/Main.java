package Ejercicio12Otra;

import java.util.Random;

//inicio: nombre de hilo, num entre 0 y 50 para sleep, arrancar hilo. espera indefiniada hasta que acaba hilo arrancado, eco del sistema

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		System.out.println(Thread.currentThread().getName());
		Random r = new Random();
		int espera = 1 + r.nextInt(50);
		Thread.sleep(espera);
		
		Hilo clon = new Hilo("HiloA", 1, 3); //nombre, contador, num de hilos a crear
		clon.start();
		clon.join();
		
		Hilo clon2 = new HiloB("", 1, 5);
		clon2.start();
		
		Hilo clon3 = new HiloC("", 1, 7);
		clon3.start();
		
		System.out.println("Nombre: " + Thread.currentThread().getName() + " tiempo de espera: " + espera + " nombre del hilo clon: " + clon.getName());

	}

}
