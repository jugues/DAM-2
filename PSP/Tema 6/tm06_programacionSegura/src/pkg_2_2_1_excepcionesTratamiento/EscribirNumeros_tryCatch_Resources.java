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
class EscribirNumeros_tryCatch_Resources {

    private static final int SIZE = 100;
    private String ficheroSalida = "Salida.txt";
    private int MaxALEATORIO = 100;

    private Vector<Integer> numeros;

    public EscribirNumeros_tryCatch_Resources() {

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
	    System.out.println("Entrando a la zona Try");
	    for (int i = 0; i < SIZE + 1; i++) {
		System.out.println("elemento: " + i + " = " + numeros.elementAt(i));
		out.println("Valor de: " + i + " = " + numeros.elementAt(i));
	    }
	} catch (ArrayIndexOutOfBoundsException e) {
	    System.err.println("Caught ArrayIndexOutOfBoundsException: " + e.getMessage());
//	    out.close();
	} catch (IOException e) {
	    System.err.println("Caught IOException: " + e.getMessage());
	    System.err.println("no podemos escribir en el fichero : " + ficheroSalida);
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

	new EscribirNumeros_tryCatch_Resources();

    }
}
