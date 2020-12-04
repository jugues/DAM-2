package EntregaTestigo05;

import java.util.Random;

public class Corredor1 extends Thread {
	
	private Testigo testigo;
	private final Random r;
	
	public Corredor1(Testigo testigo)
	{
		r = new Random();
		this.testigo = testigo;
		setName("Corredor 1");
	}
	
	public void run() // coger siempre excepciones
	{
		try
		{
			int aleatorio = 1 + r.nextInt(1000);
			System.out.println(getName() + " sleep() " + testigo.getiTestigo());
			Thread.sleep(aleatorio * 10);
			
			synchronized(testigo)
			{
				System.out.println(getName() + " pongo el semáforo en VERDE");
				testigo.setBoolTestigo(true);
				System.out.println("Testigo dejado en semáforo.");
				testigo.notifyAll(); //importante 
			}
			
			System.out.println(getName() +  " FIN");
		}
		
		catch(InterruptedException e)
		{
			System.err.println("ERROR " + e);
		}
	}

}
