import java.io.*;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class Ejercicio1 {
	
	double a, b, resul;
	private String ficheroLog = "miLogDivision.log";
	Logger logger = Logger.getLogger(ficheroLog);

	public static void main(String[] args) {
		
		new Ejercicio1();

	}
	
	public Ejercicio1()
	{
		try
		{
			BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
			logger.setLevel(Level.ALL);
			FileHandler fh = new FileHandler(ficheroLog, true);
		    logger.addHandler(fh);
		    SimpleFormatter formatter = new SimpleFormatter();
		    fh.setFormatter(formatter);
			System.out.println("Introduce dos números para dividirlos, empecemos por el primero:");
			String stra = teclado.readLine();
			System.out.println("Ahora el segundo:");
			String strb = teclado.readLine();
			a = Double.parseDouble(stra);
			b = Double.parseDouble(strb);
			resul = a/b;
			System.out.println("División realizada correctamente. El resultado es " + resul);
			
		}
		catch(Exception e)
		{
			System.err.println("Excepcion capturada: " + e.getMessage());
			logger.log(Level.WARNING, "Excepción capturada. Más datos: " + e.getMessage());
		}
		
	}

}


