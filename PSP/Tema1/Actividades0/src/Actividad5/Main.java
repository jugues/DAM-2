package Actividad5;

import java.util.Random;

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		MiHilo h1 = new MiHilo(Thread.currentThread(),"h1");
		MiHilo h2 = new MiHilo(Thread.currentThread(),"h2");
		Thread t = Thread.currentThread();
		h1.start();
		h2.start();
		
		int segundos;
		Random r = new Random();
		segundos = 1 + r.nextInt(10);
		t.sleep(segundos * 1000);
		System.out.println(Thread.currentThread().getName() + " FIN.");

	}

}
