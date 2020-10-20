import java.io.*;
import java.util.logging.*;

public class EjemploLogger {

	private String ficheroLog = "miLog2010.log";
	
	public EjemploLogger()
	{
		try
		{
			Logger miLog = Logger.getLogger("miLog2010");
			miLog.setLevel(Level.ALL);
			FileHandler fh = new FileHandler(ficheroLog, true);
		    miLog.addHandler(fh);
		    //establecer como archivo con texto
		    SimpleFormatter formatter = new SimpleFormatter();
		    fh.setFormatter(formatter);
		    
		    miLog.log(Level.WARNING, "Log grave.");
		    miLog.log(Level.SEVERE, "Log severo");
		}
		
		catch(SecurityException | IOException e)
		{
			System.out.println("Excepción detectada.");
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		
		new EjemploLogger();

	}

}
