package Actividad3;

import java.util.Random;

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		int numHilos;
		Random r = new Random();
		numHilos = 3 + r.nextInt(35);
		
		for(int i = 0; i < numHilos; i++)
		{
			MiHilo m = new MiHilo("Hilo " + i);
			m.start();
			m.join(); //espero a que finalice antes de crear otro
		}
		
		System.out.println("FIN " + Thread.currentThread().getName());

	}

}
