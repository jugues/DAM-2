package Actividad6;

public class Main {

	public static void main(String[] args) {
		
		System.out.println("Inicio del MAIN.");
		
		MiHilo r1 = new MiHilo("Hilo 1");
		Thread h1 = new Thread(r1);
		h1.setPriority(Thread.MAX_PRIORITY);
		h1.start();
		
		MiHilo r2 = new MiHilo("Hilo 2");
		Thread h2 = new Thread(r2);
		h2.setPriority(Thread.NORM_PRIORITY);
		h2.start();
		
		MiHilo r3 = new MiHilo("Hilo 3");
		Thread h3 = new Thread(r3);
		h3.setPriority(Thread.MIN_PRIORITY);
		h3.start();
		
		System.out.println(Thread.currentThread().getName() + " FIN.");

	}

}
