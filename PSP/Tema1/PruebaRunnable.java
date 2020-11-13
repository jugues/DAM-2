package Tema1;

import java.util.Random;

public class PruebaRunnable implements Runnable {
	
	String name;
	
	PruebaRunnable(String nombre)
	{
		this.name = nombre;
	}

	@Override
	public void run() /*throws InterruptedException */ {
		
		//System.out.println("Runnable: " + name);
		int i; 
		Random r = new Random();
		int seconds = 1 + r.nextInt(10);
		System.out.println("Runnable: " + name + " --- " + seconds + " segundos.");
		
		try 
		{
			Thread.sleep(seconds * 1000);
		}
		
		catch(InterruptedException ex)
		{
			System.out.println("Excepción capturada: " + ex.getLocalizedMessage());
		}
		
		System.out.println("Saliendo del método run...");
		
	}
	
	public static void main(String[] args) throws InterruptedException 
	{
		
		PruebaRunnable r1 = new PruebaRunnable("Gaw");
		Thread h1 = new Thread(r1);
		h1.start();
		
		System.out.println("Saliendo del main.");

	}

}
