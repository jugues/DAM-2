package pkg_2_2_1_excepciones;

import java.io.*;
import java.util.Vector;
import java.util.Random;

/* 
    correr y ver la funcionalidad del código
    fallos posibles :
    1.- fichero imposible abrir ( IOException )
    2.- excepción de entrada salida ( IOException )
    3.- excepción al ejecutar elementAt(i) , i fuera de rango        (IndexOutOfBoundsEception )
 */
class EscribirNumeros {

    private Vector<Integer> numeros;
    private static final int SIZE = 100;

    public EscribirNumeros() throws IOException {
// Generamos el vector con números aleatorios
	numeros = new Vector<Integer>(SIZE);
	Random randomGenerator = new Random();

// causa excepción        for (int i = 0; i <= SIZE; i++) {	
	for (int i = 0; i < SIZE; i++) {
	    Integer num = randomGenerator.nextInt(100);
	    numeros.addElement(new Integer(num));
	}

// Guardamos el vector en un fichero
	PrintWriter out = null;
	System.out.println("Entrando a la zona Try pueden haber excepciones. ");
// causa excepción 
// out = new PrintWriter(new FileWriter("c:\\Salida.txt"));
// no causa excepción
	out = new PrintWriter(new FileWriter("Salida.txt"));

// causa excepción        for (int i = 0; i <= SIZE; i++) {
	for (int i = 0; i <SIZE; i++) {
// eco en TFT	    
	    System.out.println("elemento: " + i + " = " + numeros.elementAt(i));
// guardamos en fichero	    
	    out.println("elemento: " + i + " = " + numeros.elementAt(i));
	}
	out.close();

    }

    public static void main(String[] arg) throws IOException {

	new EscribirNumeros();

    }

}
