import java.io.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Ejercicio2 {
	
	FileWriter fichero;
    PrintWriter pw = null;
    BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
    String nombre, dni, email;
    String numTelf;
    
    public Ejercicio2()
    {
    	try
    	{
    		BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
    		System.out.println("--ENTRADA Y VALIDACIÓN DE DATOS--");
        	System.out.println("Introduce tu nombre y apellidos. SÓLO LETRAS:");
        	nombre = teclado.readLine();
        	System.out.println("Introduce un dni válido:");
        	dni = teclado.readLine();
        	System.out.println("Ahora un email válido");
        	email = teclado.readLine();
        	System.out.println("Finalmente, necesitamos un número de teléfono (9 números sin prefijo de país):");
        	numTelf = teclado.readLine();
        	
        	//patrones de todo lo anterior, comprobar si son correctos los datos introducidos, lanzar excepciones si no es así
        	
        	//Comprobar nombre 
        	String comprobarNombre = "[a-zA-Z]{1,}";
        	Pattern patternNombre = Pattern.compile(comprobarNombre); 
        	Matcher matcherNombre = patternNombre.matcher(nombre);
        	boolean matchesNombre = matcherNombre.matches();
        	
        	//comprobar dni
        	String comprobarDni = "\\d{8}[A-HJ-NP-TV-Z]"; 
        	Pattern patternDni = Pattern.compile(comprobarDni); 
        	Matcher matcherDni = patternDni.matcher(dni); 
        	boolean matchesDni = matcherDni.matches();
        	
        	//comprobar teléfono
        	String comprobarTelf = "\\d{9}";
        	Pattern patternTelf = Pattern.compile(comprobarTelf);
        	Matcher matcherTelf = patternTelf.matcher(numTelf);
        	boolean matchesTelf = matcherTelf.matches();
        	//comprobar formato del email
        	String comprobarEmail = "[^@]+@[^@]+\\.[a-zA-Z]{2,}";
        	Pattern patternEmail = Pattern.compile(comprobarEmail);
        	Matcher matcherEmail = patternEmail.matcher(email);
        	boolean matchesEmail = matcherEmail.matches();
        	
        	if(matchesNombre && matchesDni && matchesTelf && matchesEmail)
        	{
        		System.out.println("Todos los datos son correctos.");
        	}
        	
        	else
        	{
        		throw new Exception();
        	}
        	
    	}
    	
    	catch(Exception e)
    	{
    		System.out.println("Alguno de los datos introducidos no es correcto. Inténtalo de nuevo.");
    		e.printStackTrace();
    	}

    }

	public static void main(String[] args) {
		
		new Ejercicio2();

	}

}
