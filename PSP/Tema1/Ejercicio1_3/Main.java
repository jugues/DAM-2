package Ejercicio1_3;

import java.util.logging.Level;
import java.util.logging.Logger;

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		Thread aHilos[] = new Thread[5];
		String finalizar1 = "";
		String finalizar2 = "";
		String finalizar3 = "";
		String finalizar4 = "";
		String finalizar5 = "";
		
		aHilos[0] = new Hilo("Ana", finalizar1);
		aHilos[1] = new Hilo("Borja", finalizar2);
		aHilos[2] = new Hilo("Casimiro", finalizar3);
		aHilos[3] = new Hilo("Daniel", finalizar4);
		aHilos[4] = new Hilo("Ezequiel", finalizar5);
		
		System.out.println("Starting race...");
		
		for(int i=0; i<aHilos.length;i++)
		{
			aHilos[i].start();
		}
		
		try
		{
			aHilos[0].join();
			finalizar1 = ((Hilo) aHilos[0]).getValor();
			aHilos[1].join();
			finalizar2 = ((Hilo)aHilos[1]).getValor();
			aHilos[2].join();
			finalizar3 = ((Hilo)aHilos[2]).getValor();
			aHilos[3].join();
			finalizar4 = ((Hilo)aHilos[3]).getValor();
			aHilos[4].join();
			finalizar5 = ((Hilo)aHilos[4]).getValor();
		}
		
		catch(Exception e)
		{
			System.out.println("Exception found in Main.");
			Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, e);
		}
		
		System.out.println(finalizar1 + " " + finalizar2 + " " + finalizar3 + " " + finalizar4 + " " + finalizar5);
	}

}
