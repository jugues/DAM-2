package Ejercicio1_3;

import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Hilo extends Thread {
	
	private String name;
	private String valor;
	
	public Hilo(String name, String valor)
	{
		this.name = name;
		this.valor = valor;
		super.setName(name);
	}
	
	public String getValor()
	{
		return valor;
	}
	
	public void run()
	{
		Random r = new Random();
		int time = 5 + r.nextInt(25);
		valor = null;
		
		System.out.println("");
		try
		{
			Thread.sleep(time * 1000);
			System.out.println(getName() + " has arrived to the goal after " + String.valueOf(time) + " seconds.");
		}
		
		catch(InterruptedException e)
		{
			System.out.println("Exception detected.");
			//Logger.getLogger(Hilo.class.getName()).log(Level.SEVERE, null, e);
		}
		
		valor = "Name: " + getName() + " time: " + String.valueOf(time);
	}

}
