package pkg_2_4_entradaValidada;

import java.io.*;
import java.util.regex.*;

// corred el código para verificar que obliga a que el DNI tenga formato correcto
class ValidarEntrada {

    public ValidarEntrada() {
// DNI cliente
	String dni_cliente;
// DNI formato	
	String dniFormato = "[0-9]{8}-[a-zA-Z]";
// Comparación DNI con formato	
	Pattern pat;
	Matcher mat;
// acceso a teclado
	BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));

	try {
// DNI de cliente	    
	    System.out.println("Introduce tu DNI (Formato 00000000-A):");
	    dni_cliente = teclado.readLine();

// DNI verificación
	    pat = Pattern.compile(dniFormato);
	    mat = pat.matcher(dni_cliente);
	    if (mat.matches()) {
		System.out.println("Correcto!!  " + dni_cliente);
	    } else {
		System.out.println("Formato incorrecto   " + dni_cliente);
	    }
	} catch (IOException e) {
	    System.out.println(e.getMessage());

	}

    }

    public static void main(String[] arg) {

	new ValidarEntrada();

    }

}
