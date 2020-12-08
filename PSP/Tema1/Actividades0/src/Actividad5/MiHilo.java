package Actividad5;

public class MiHilo extends Thread{
	
	Thread t;
	String name;
	
	public MiHilo(Thread t, String name)
	{
		this.t = t;
		this.name = name;
		setName(name);
	}
	
	public void run()
	{
		int i = 0;
		while(t.isAlive())
		{
			try {
				
				Thread.sleep(250);
				i++;
				System.out.println(getName() + " contador: " + i);
				
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		
		System.out.println(getName() + " FIN.");
		
	}

}
