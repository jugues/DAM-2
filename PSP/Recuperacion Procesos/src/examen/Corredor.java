package examen;

import java.io.IOException;
import java.util.Random;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class Corredor extends Thread {
	
	private boolean iniciado;
	private boolean descalificado = false;
	private int numVuelta;
	private int maxVueltas = 25;
	private int tiempoTotal;
	private String rutaLog = "miLogCorredor.log";
	static Logger log;
	private String cadenaError;
	private String nombre;
	
	public Corredor(String nombre, boolean iniciado)
	{
		setName(nombre);
		this.nombre = nombre;
		this.iniciado = iniciado;
		log = Logger.getLogger("miLog"); 
		log.setLevel(Level.ALL);
		FileHandler handler;
		
		try {
			handler = new FileHandler(rutaLog, true);
			log.addHandler(handler);
			SimpleFormatter formatter = new SimpleFormatter();
		    handler.setFormatter(formatter);
		} 
		catch(SecurityException ex)
		{
			cadenaError = getName() + " estaba corriendo y ha surgido una excepción de seguridad: " + ex.getMessage();
			System.out.println(cadenaError);
			log.log(Level.WARNING, cadenaError);
		}
		
		catch(IOException ex)
		{
			cadenaError = getName() + " estaba corriendo y ha surgido una excepción de E/S: " + ex.getMessage();
			System.out.println(cadenaError);
			log.log(Level.WARNING, cadenaError);
		}
		
	}
	
	public boolean isDescalificado() {
		return descalificado;
	}



	public void setDescalificado(boolean descalificado) {
		this.descalificado = descalificado;
	}



	public void setIniciado(Boolean iniciado) {
		this.iniciado = iniciado;
	}
	
	public int getNumVuelta() {
		return numVuelta;
	}
	
	public String getNombre()
	{
		return nombre;
	}

	public void setNumVuelta(int numVuelta) {
		this.numVuelta = numVuelta;
	}

	public void run()
	{
		Random r = new Random();
		int tiempoSleep = r.nextInt(100) + 155;	
		
		while(iniciado) //cada vuelta
		{
			try
			{
				Thread.sleep(tiempoSleep);
				numVuelta++;
				String cadena = getName() + " ha tardado en dar la vuelta " + numVuelta + " en " + tiempoSleep;
				System.out.println(cadena);
				log.log(Level.WARNING, cadena);
				tiempoTotal += tiempoSleep;
				
				if(descalificado)
				{
					String cadenaDes = getName() + " ha sido descalificado tras dar " + numVuelta + " vueltas y tras haber corrido un total de " + tiempoTotal;
					System.out.println(cadena);
					log.log(Level.SEVERE, cadenaDes);
				}
				
				if(numVuelta == maxVueltas)
				{
					String cadenaMeta = getName() + " llegado a la meta tras " + numVuelta + " vueltas y tras este tiempo: " + tiempoTotal;
					System.out.println(cadenaMeta);
					log.log(Level.INFO, cadenaMeta);
					iniciado = false;
				}
			}
			
			catch(InterruptedException ex) 
			{
				cadenaError = getName() + " estaba corriendo y ha sido interrumpido súbitamente: " + ex.getMessage();
				System.out.println(cadenaError);
				log.log(Level.WARNING, cadenaError);
			}
			
		}
		
	}

}
