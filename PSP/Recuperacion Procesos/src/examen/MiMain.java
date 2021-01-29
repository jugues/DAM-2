package examen;

import java.io.IOException;
import java.util.Random;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;


public class MiMain {

	public static void main(String[] args) throws InterruptedException, SecurityException, IOException{
		
		String rutaLogMain = "logMain.log";
		Logger miLog = Logger.getLogger("logMain");
		miLog.setLevel(Level.ALL);
		FileHandler handler = new FileHandler(rutaLogMain, true); 
		miLog.addHandler(handler);
		SimpleFormatter formatter = new SimpleFormatter();
	    handler.setFormatter(formatter);
	    Random r = new Random();
	    int numCorredores = r.nextInt(50) + 5;
	    int corredoresDescalificados = r.nextInt(5);
	    
	    //creación de los hilos
	    Thread [] misCorredores = new Thread[numCorredores];
	    for(int i = 0; i<misCorredores.length; i++)
		{
			misCorredores[i] = new Corredor("Corredor " + i, true);
		}
	    
	    //arranque de los hilos
	    for(int a = 0; a<misCorredores.length; a++)
	    {
	    	misCorredores[a].start();
	    }
	    
	    //descalificacion
	    for(int b = 0; b<corredoresDescalificados; b++)
	    {
	    	Random rr = new Random();
		    int aDescalificar = rr.nextInt(5);
		    Corredor aux = (Corredor) misCorredores[aDescalificar];
		    aux.setDescalificado(true);
		    String cadenaDesc = "El árbitro ha mandado parar a " + aux.getNombre();
		    System.out.println(cadenaDesc);
		    miLog.log(Level.WARNING, cadenaDesc);
	    }
	    
	    //parada
	    for(int c = 0; c<misCorredores.length; c++)
	    {
	    	Corredor auxiliar = (Corredor) misCorredores[c];
	    	auxiliar.join();
	    }
	    
	    System.out.println("Fin del Main.");
	    miLog.log(Level.INFO, "Fin del Main");
	   
	}

}
