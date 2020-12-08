package Actividad1;

public class MiHilo extends Thread {
	
	private String nombreHilo;
	
	public MiHilo(String nombre)
	{
		nombreHilo = nombre;
		setName(nombreHilo);
	}
	
	public void run()
	{
		System.out.println("Nombre: " + getName());
	}

}
