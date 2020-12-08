package Actividad4;

import java.util.Random;

public class MiHilo extends Thread{
	
	String nombre;
	
	public MiHilo(String nombre)
	{
		this.nombre = nombre;
		setName(nombre);
	}
	
	public void run()
	{
		int segundos;
		Random r = new Random();
		segundos = 1 + r.nextInt(10);
		
		try
		{
			System.out.println(getName() + " duermo " + segundos);
			Thread.sleep(segundos * 1000);
			System.out.println(getName() + " finalizado.");
			
		}
		
		catch(InterruptedException e)
		{
			System.out.println("Excepción: " + e.getLocalizedMessage());
		}
	}

}
