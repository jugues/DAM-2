package Actividad4; //corregir haciendo 3 clases distintas

public class Main {

	public static void main(String[] args) throws InterruptedException {
		
		System.out.println("Inicio del MAIN.");
		
		MiHilo h3 = new MiHilo("h3");
		h3.start();
		
		MiHilo h2 = new MiHilo("h2");
		h2.start();
		
		MiHilo h1 = new MiHilo("h1");
		h1.start();
		
		h3.join();
		h2.join();
		h1.join();
		
		System.out.println("FIN de " + Thread.currentThread().getName());

	}

}
