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
    		System.out.println("--ENTRADA Y VALIDACI�N DE DATOS--");
        	System.out.println("Introduce tu nombre y apellidos. S�LO LETRAS:");
        	nombre = teclado.readLine();
        	System.out.println("Introduce un dni v�lido:");
        	dni = teclado.readLine();
        	System.out.println("Ahora un email v�lido");
        	email = teclado.readLine();
        	System.out.println("Finalmente, necesitamos un n�mero de tel�fono (9 n�meros sin prefijo de pa�s):");
        	numTelf = teclado.readLine();
        	
        	//patrones de todo lo anterior, comprobar si son correctos los datos introducidos, lanzar excepciones si no es as�
        	
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
        	
        	//comprobar tel�fono
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
    		System.out.println("Alguno de los datos introducidos no es correcto. Int�ntalo de nuevo.");
    		e.printStackTrace();
    	}

    }

	public static void main(String[] args) {
		
		new Ejercicio2();

	}

}
