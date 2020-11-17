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
			aHilos[1].join();
			aHilos[2].join();
			aHilos[3].join();
			aHilos[4].join();
		}
		
		catch(Exception e)
		{
			System.out.println("Exception found in Main.");
			Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, e);
		}
		
		System.out.println(finalizar1 + "" + finalizar2 + "" + finalizar3 + "" + finalizar4 + "" + finalizar5);
	}

}
