import java.io.*;

public class Ejercicio2 {
	
	FileWriter fichero;
    PrintWriter pw = null;
    BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
    String nombre, dni, email;
    int numTelf;
    
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
        	System.out.println("Finalmente, necesitamos un n�mero de tel�fono:");
        	numTelf = teclado.read();
        	
    	}
    	
    	catch(Exception e)
    	{
    		e.printStackTrace();
    	}
    	
    }

	public static void main(String[] args) {
		
		

	}

}
