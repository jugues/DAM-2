package Actividad2;

import java.util.Random;

public class MiHilo extends Thread{
	
private String nombreHilo;
	
	public MiHilo(String nombre)
	{
		nombreHilo = nombre;
		setName(nombreHilo);
	}
	
	public void run()
	{
		int espera;
		Random r = new Random();
		espera = 1 + r.nextInt(10); //espera de 0 a 10 segundos
		System.out.println(nombreHilo + " espera " + espera);
		
		try
		{
			Thread.sleep(espera * 1000); //espera pasiva
		}
		
		catch(InterruptedException e)
		{
			System.out.println("Excepción encontrada: " + e.getLocalizedMessage());
		}
		
		System.out.println(nombreHilo + " FIN.");
	}

}
