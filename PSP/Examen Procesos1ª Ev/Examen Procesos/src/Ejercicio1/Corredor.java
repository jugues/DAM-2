package Ejercicio1;

import java.util.Random;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class Corredor extends Thread {
	
	private Boolean iniciado;
	int numVuelta = 0;
	int tiempoTotal = 0;
	final Logger LOG = Logger.getLogger("Corredor.class");
	
	public Corredor(String nombre, Boolean iniciado)
	{
		setName(nombre);
		this.iniciado = iniciado;
	}
	
	public Boolean getIniciado() {
		return iniciado;
	}

	public void setIniciado(Boolean iniciado) {
		this.iniciado = iniciado;
	}

	public void run()
	{
		int tiempoVuelta;
		Random r = new Random();
		tiempoVuelta = 15 + r.nextInt(10);
		
		while(iniciado)
		{
			try
			{
				Thread.sleep(tiempoVuelta);
				System.out.println(getName() + " ha tardado en dar una vuelta " + tiempoVuelta + " segundos");
				numVuelta++;
				tiempoTotal += tiempoVuelta;
				String cadena = getName() + " ha tardado en dar una vuelta " + tiempoVuelta + " segundos";
				System.out.println(cadena);
				//LOG.log(Level.SEVERE, cadena);
			}
			
			catch(InterruptedException e)
			{
				System.out.println(getName() + " estaba corriendo y ha sido interrumpido: " + e.getMessage());
			}
			
			String cadenaFin = getName() + " finalizado tras " + numVuelta + " vueltas y " + tiempoTotal + " segundos.";
			System.out.println(cadenaFin);
			//LOG.log(Level.SEVERE, cadenaFin);
		}
		
		
	}

}
