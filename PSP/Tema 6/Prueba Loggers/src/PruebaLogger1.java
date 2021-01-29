import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class PruebaLogger1 {
	
	private String rutaLog = "myLog.log";
	private String rutaXml = "miLog.xml";
	
	public PruebaLogger1()
	{
		try
		{
			Logger log = Logger.getLogger("myLog"); //nombre sin extensión o nombre.class.getName()
			log.setLevel(Level.ALL);
			//FileHandler handler = new FileHandler(rutaLog, true); 
			//log.addHandler(handler);
			
			//formateador de texto plano
			//SimpleFormatter formatter = new SimpleFormatter();
		    //handler.setFormatter(formatter);
		    
		    //formateador de xml
		    FileHandler handlerXml = new FileHandler(rutaXml);
		    log.addHandler(handlerXml);
		    
		    log.log(Level.WARNING, "Probando un warning.");
		    log.log(Level.SEVERE, "Probando un severe.");
		    log.info("Mensaje de info.");
		}
		
		catch(Exception e)
		{
			System.err.println("Error detectado.");
		}
	}

	public static void main(String[] args) {
		
		new PruebaLogger1();

	}

}
