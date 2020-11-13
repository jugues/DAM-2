package Tema1;

public class PruebaHilos extends Thread {
	
	PruebaHilos(String name)
	{
		super.setName(name);
	}
	
	public void Run() 
	{
		System.out.println("Hilo: " + getName());
	}
	public static void main(String[] args) {
		
		PruebaHilos h1 = new PruebaHilos("Venuncio");
		h1.start();

	}

}
