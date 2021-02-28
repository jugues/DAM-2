package Version1;

import java.util.Random;

public class Ninyo extends Thread{
	
	RCNevera neveraNinyo;
	
	public Ninyo(int i, RCNevera nevera)
	{
		neveraNinyo = nevera;
		this.setName("Niño " + i + getName());
	}
	
	public void run()
	{
		Random r = new Random();
		
		try
		{
			
		}
		
		catch(Exception ex)
		{
			
		}
	}

}
