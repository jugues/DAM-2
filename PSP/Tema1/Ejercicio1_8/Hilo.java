package Ejercicio1_8;

import java.util.Random;

public class Hilo extends Thread {
	
	Thread hilo;
	String nombreHilo;
	int tiempo;
	
	public Hilo (Thread t, String nombreHilo)
	{
		hilo = t;
		this.nombreHilo = nombreHilo;
		this.setName(nombreHilo);
	}
	
	public String getNombreHilo()
	{
		return nombreHilo;
	}
	
	public void run()
	{
		Random r = new Random();
		tiempo = 1 + r.nextInt(10);
		
		System.out.println(getName() + " espera " + tiempo + " segundos.");
		
		try
		{
			Thread.sleep(tiempo * 1000);
			hilo.join();
		}
		
		catch(InterruptedException e)
		{
			System.out.println("Excepción encontrada.");
		}
		
		System.out.println(getName() + " finalizado.");
	}

}
