/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg_2_4_entradaValidada;

/**
 *
 * @author profesor
 */
import java.io.*;
import java.util.regex.*;

class ValidarEntrada_v2 {

    public ValidarEntrada_v2() {

        try {
	    
// DNI cliente
	String dni_cliente = new String();
// DNI formato	
	String dniFormato = "[0-9]{8}-[a-zA-Z]";
// Comparación DNI con formato	
	Pattern pat=null;
	Matcher mat=null;
// acceso a teclado
	BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));	    

// repetimos si no cumple formato
            do {
                System.out.println("Introduce tu DNI (Formato 00000000-A):");
                dni_cliente = teclado.readLine();

// DNI verificación
                pat = Pattern.compile(dniFormato);
                mat = pat.matcher(dni_cliente);

                if (mat.matches()) {
                    System.out.println(" DNI formato correcto!!  " + dni_cliente);
                } else {
                    System.out.println(" DNI formato erroneo  " + dni_cliente);

                }
            } while (!mat.find());

        } catch (IOException e) {
            System.out.println(e.getMessage());
        }

    }

    public static void main(String[] arg) {

        new ValidarEntrada_v2();

    }

}
