package Tema1;

import java.util.Random;

public class PruebaHilosJoin implements Runnable {
	
	String name;

	public static void main(String[] args) throws InterruptedException {
		
		System.out.println("Inicio del main.");
		
		PruebaHilosJoin r1 = new PruebaHilosJoin("Yo");
		Thread h1 = new Thread(r1);
		h1.start();
		
		PruebaHilosJoin r2 = new PruebaHilosJoin("Pepito");
		Thread h2 = new Thread(r2);
		h2.start();
		
		PruebaHilosJoin r3 = new PruebaHilosJoin("Juanito");
		Thread h3 = new Thread(r3);
		h3.start();
		
		System.out.println("Esperando el final de los hilos...");
		h1.join();
		h2.join();
		h3.join();
		
		System.out.println("FIN del main.");

	}
	
	public PruebaHilosJoin(String nombre)
	{
		name = nombre;
	}

	@Override
	public void run() {
		
		int i; 
		Random r = new Random(); 
		int segundos = 1 + r.nextInt(10);
		System.out.println(name + " --inicio de espera-- " + String.valueOf(segundos));
		
		try
		{
			Thread.sleep(segundos * 1000);
		}
		
		catch(InterruptedException e)
		{
			System.out.println("Excepción encontrada.");
		}
		
		System.out.println( name + " fin.");
		
	}

}
