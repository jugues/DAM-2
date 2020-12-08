package Actividad2;

import java.util.Random;

public class Main {

	public static void main(String[] args) {
		
		Random r = new Random();
		int numHilos = 1 + r.nextInt(10);
		
		for(int i = 0; i<numHilos;i++) {
			
			MiHilo m = new MiHilo("Hilo " + i);
			m.start();
		}
		
		System.out.println("FIN " + Thread.currentThread().getName());


	}

}
