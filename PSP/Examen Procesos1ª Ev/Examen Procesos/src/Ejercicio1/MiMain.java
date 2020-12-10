package Ejercicio1;

import java.util.Random;

public class MiMain {

	public static void main(String[] args) throws InterruptedException {
		
		Random r = new Random();
		int numCorredores = r.nextInt(50) + 1;
		int tiempoSleep = r.nextInt(11) + 3;
		
		//creación de los hilos
		Thread[] misHilos = new Thread[numCorredores];
		for(int i = 0; i<misHilos.length; i++)
		{
			misHilos[i] = new Corredor("Hilo " + i, true);
		}
		
		//arranque 
		for(int a = 0; a<misHilos.length; a++)
		{
			misHilos[a].start();
		}
		
		//sleep del main
			Thread.currentThread();
			Thread.sleep(tiempoSleep * 1000);
		
		//parada de los hilos
		for(int b = 0; b<misHilos.length; b++)
		{
			Corredor aux = (Corredor) misHilos[b];
			aux.setIniciado(false);
			aux.join();
		}
		
		System.out.println("Orden de parada trasmitida a todos los corredores.");
		System.out.println("FIN del Main");

	}

}
