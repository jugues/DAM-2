package pkg_2_2_1_excepcionesTratamiento;

import java.io.*;
import java.util.Vector;
import java.util.Random;

/* fallos posibles :
    1.- fichero imposible abrir ( IOException )
    2.- excepción de entrada salida ( IOException )
    3.- excepción al ejecutar elementAt(i) , i fuera de rango
            (IndexOutOfBoundsEception )
 */
class EscribirNumeros_tryCatch {

    private Vector<Integer> numeros;
    private static final int SIZE = 100;

    public EscribirNumeros_tryCatch() {

// Generamos el vector con números aleatorios
	numeros = new Vector<Integer>(SIZE);
	Random randomGenerator = new Random();

	for (int i = 0; i < SIZE; i++) {
	    Integer num = randomGenerator.nextInt(100);
	    numeros.addElement(new Integer(num));
	}

// Guardamos el vector en un fichero
	PrintWriter out = null;
	try {
	    System.out.println("Entrando a la zona Try");
//          out = new PrintWriter(new FileWriter("C://Salida.txt"));
//       descomentar la línea superior , comentar la inferior  y correr
	    out = new PrintWriter(new FileWriter("Salida.txt"));

//            for (int i = 0; i < SIZE ; i++) {
// comentar la línea superior , descomentar la inferior y correr 
	    for (int i = 0; i <SIZE ; i++) {
// eco en TFT		
		System.out.println("elemento: " + i + " = " + numeros.elementAt(i));
// guardamos en fichero		
		out.println("Valor de: " + i + " = " + numeros.elementAt(i));
	    }

	} catch (ArrayIndexOutOfBoundsException e) {
	    System.err.println("Caught ArrayIndexOutOfBoundsException: " + e.getMessage());
	    System.out.println("Indice de array fuera de límites.");
	} catch (IOException e) {
	    System.err.println("Caught IOException: " + e.getMessage());
	    System.out.println("Error en apertura de fichero.");
	} finally {
	    if (out != null) {
		System.out.println("Cerrando el fichero.");
		out.close();
	    } else {
		System.out.println("NO se ha abierto el fichero");
	    }
	}
    }

    public static void main(String[] arg) {

	new EscribirNumeros_tryCatch();

    }
}
