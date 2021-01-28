package pkg_2_6_usoLogger;

import java.io.*;
import java.util.logging.*;

public class MyLogger_1 {

    private String ficheroLog = "MyLogFile_2_6.log";

    public MyLogger_1() {

	try {
// creo el logger   llamado     MyLog_2_6
	    Logger logger = Logger.getLogger("MyLog_2_6");

// nivel de seguridad del logger ( según interés , hay varios )   
	    logger.setLevel(Level.ALL);

// fichero asociado al logger creado
	    FileHandler fh = new FileHandler(ficheroLog, true);
	    logger.addHandler(fh);

// fichero asociado configurado como fichero de texto
	    SimpleFormatter formatter = new SimpleFormatter();
	    fh.setFormatter(formatter);

// Añado dos mensajes  mensaje al log   
	    logger.log(Level.WARNING, "Mi primer log");
	    logger.log(Level.SEVERE, "Mi segundo log");
	    
	} catch (SecurityException | IOException e) {
	    System.out.println("Saltó una excepción");
	    e.printStackTrace();
	}
    }

    public static void main(String[] args) {
	new MyLogger_1();
    }

}
