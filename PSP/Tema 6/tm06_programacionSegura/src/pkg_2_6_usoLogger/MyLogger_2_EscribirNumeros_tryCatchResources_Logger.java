package pkg_2_6_usoLogger;

import java.io.*;
import java.util.Vector;
import java.util.Random;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

/* fallos posibles :
    1.- fichero imposible abrir ( IOException )
    2.- excepción de entrada salida ( IOException )
    3.- excepción al ejecutar elementAt(i) , i fuera de rango
            (IndexOutOfBoundsEception )
 */
class MyLogger_2_EscribirNumeros_tryCatchResources_Logger {

    private static final int SIZE = 100;
    private String ficheroSalida = "Salida.txt";
    private int MaxALEATORIO = 100;

    //declaro el Logger
    Logger logger;

    //nombre fichero Log
    private String ficheroLog = "MyLogFile_2_6_EscribirNumeros.log";

    private Vector<Integer> numeros;

    public MyLogger_2_EscribirNumeros_tryCatchResources_Logger() {

	numeros = new Vector<Integer>(SIZE);
	Random randomGenerator = new Random();
// Generamos el vector con números aleatorios
	for (int i = 0; i < SIZE; i += 2) {
	    Integer num = randomGenerator.nextInt(MaxALEATORIO);
	    numeros.addElement(new Integer(num));
	}
	//PrintWriter out ;
// Guardamos el vector en un fichero
	try (PrintWriter out = new PrintWriter(new FileWriter(ficheroSalida));) {
//_______________________________________________________---
// creo el logger        
	    logger = Logger.getLogger("MyLog");
	   
// nivel de seguridad del logger ( según interés )   
	    logger.setLevel(Level.ALL);
// fichero asociado al logger creado MyLogFile.log
//          FileHandler   fh = new FileHandler("c:\\MyLogFile.log", true);
	     FileHandler fh = new FileHandler(ficheroLog, true);
	    logger.addHandler(fh);
// fichero asociado configurado como fichero de texto
	    SimpleFormatter formatter = new SimpleFormatter();
	    fh.setFormatter(formatter);
//_________________________________________________________

	    System.out.println("Entrando a la zona Try");
	    for (int i = 0; i < SIZE + 1; i++) {
		out.println("Valor de: " + i + " = " + numeros.elementAt(i));
	    }
	} catch (ArrayIndexOutOfBoundsException e) {
	    System.err.println("Caught ArrayIndexOutOfBoundsException: " + e.getMessage());
	    logger.log(Level.WARNING, "Caught ArrayIndexOutOfBoundsException: "
		    + e.getMessage());
	} catch (IOException e) {
	    System.err.println("Caught IOException: " + e.getMessage());
	    System.err.println("no podemos escribir en el fichero : " + ficheroSalida);
	    logger.log(Level.WARNING, "Caught IOException: " + e.getMessage()
		    + ", no podemos escribir en el fichero : " + ficheroSalida);
	} finally {
// out está cerrado, no tiene sentido cerrarlo otra vez	    
////	    if (out != null) {
//		System.out.println("Cerrando el fichero");
////		out.close();
////	    } else {
//		System.out.println("NO se ha abierto el fichero");
////	    }
	}
    }

    public static void main(String[] arg) {

	new MyLogger_2_EscribirNumeros_tryCatchResources_Logger();

    }
}
