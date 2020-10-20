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
    		System.out.println("--ENTRADA Y VALIDACIÓN DE DATOS--");
        	System.out.println("Introduce tu nombre y apellidos. SÓLO LETRAS:");
        	nombre = teclado.readLine();
        	System.out.println("Introduce un dni válido:");
        	dni = teclado.readLine();
        	System.out.println("Ahora un email válido");
        	email = teclado.readLine();
        	System.out.println("Finalmente, necesitamos un número de teléfono:");
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
