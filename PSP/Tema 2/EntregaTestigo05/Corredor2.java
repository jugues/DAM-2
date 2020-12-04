package EntregaTestigo05;

import java.util.Random;

public class Corredor2 extends Thread {

	private Testigo testigo;
	private final Random r;
	
	public Corredor2(Testigo testigo)
	{
		this.testigo = testigo;
		r = new Random();
		setName("Corredor 2");
	}
	
	public void run()
	{
		try
		{
			int aleatorio = 1 + r.nextInt(1000);
			System.out.println(getName() + " sleep() " + testigo.getiTestigo());
			Thread.sleep(aleatorio);
			
			synchronized(testigo)
			{
				while(!testigo.isBoolTestigo())
				{
					System.out.println(getName() + " espero, semáforo en ROJO.");
					testigo.wait();
				}
				
				System.out.println(getName() + ", testigo: " + testigo.getiTestigo() + " FIN");
			}	
		}
		
		catch(InterruptedException ex)
		{
			System.err.println("ERROR " + ex);
		}
	}
	
}
