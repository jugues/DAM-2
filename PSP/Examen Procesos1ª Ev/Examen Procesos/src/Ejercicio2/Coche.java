package Ejercicio2;

import java.util.Random;
import java.util.logging.Logger;

public class Coche extends Thread{
	
	private Random r;
	private Random numSef;
	private int tiempoSleep;
	private int numSemaforo;
	private int tiempoFinalizado;
	private String nombre;
	Semaforo sf;
	private int idCoche;

	public int getIdCoche() {
		return idCoche;
	}

	public void setIdCoche(int idCoche) {
		this.idCoche = idCoche;
	}
	
	public Coche(String nombre, Semaforo sf)
	{
		this.nombre = nombre;
		this.sf = sf;
	}
	
	public void run()
	{
		r = new Random();
		numSef = new Random();
		tiempoSleep = r.nextInt(17) + 3;
		numSemaforo = numSef.nextInt() + 1;
		sf.setNumSem(numSemaforo);
		
		try
		{
			Thread.sleep(tiempoSleep * 1000); 
			tiempoFinalizado += tiempoSleep;
		}
		
		catch(InterruptedException e)
		{
			System.out.println(getName() + " estaba en marchar y ha sido interrumpido: " + e.getMessage());
		}
		
		synchronized(sf)
		{
			
			while(idCoche != sf.getNumSem())
			{
				try {
					System.out.println(getName() + " espera en semáforo. Tiempo trascurrido: " + tiempoFinalizado + " segundos.");
					sf.wait(); //se paran todos y el programa no sigue su ejecución
					Thread.sleep(tiempoSleep);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
			
			//si coinciden los ids
			numSemaforo++;
			sf.setNumSem(numSemaforo);
			sf.notifyAll();
			System.out.println(getName() + " FIN en " + tiempoFinalizado + " segundos.");
		}
	}

}
