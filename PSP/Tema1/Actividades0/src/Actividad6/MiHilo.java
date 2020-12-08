package Actividad6;

public class MiHilo implements Runnable{
	
	private String name;
	
	public MiHilo(String name)
	{
		this.name = name;
	}

	@Override
	public void run() {
		
		System.out.println( name + " " + Math.PI + " END");
		
	}

}
