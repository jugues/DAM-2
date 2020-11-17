package Ejercicio1_8;

public class Main {

	public static void main(String[] args) {
		
		Hilo h5 = new Hilo(Thread.currentThread(), "Hilo5");
		Hilo h4 = new Hilo(h5, "Hilo4");
		Hilo h3 = new Hilo(h4, "Hilo3");
		Hilo h2 = new Hilo(h3, "Hilo2");
		Hilo h1 = new Hilo(h2, "Hilo1");
		
		h1.start();
		h2.start();
		h3.start();
		h4.start();
		h5.start();

	}

}
