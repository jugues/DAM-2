package Tema1;
import java.util.*;
import java.io.*;
import java.util.concurrent.TimeUnit;

public class PruebaAbrirProceso {

	public static void main(String[] args) {
		
		try
		{
			System.out.println("Creando proceso...");
			Process p = Runtime.getRuntime().exec("C:\\Users\\Juli\\AppData\\Local\\Kingsoft\\WPS Office\\ksolaunch.exe");
			//Process p = Runtime.getRuntime().exec("C:\\Archivos de programa(x86)\\Microsoft\\Edge\\Application\\msedge.exe" + "" + "https://github.com");
			System.out.println("Esperando 5 segundos...");
			p.waitFor(5, TimeUnit.SECONDS);
			System.out.println("Esperando dos m�s...");
			p.waitFor(2, TimeUnit.SECONDS);
			System.out.println("Destruyendo proceso.");
			p.destroy();
			System.out.println("Proceso destruido.");
			
			p.exitValue();
			System.out.println("Finalizado. C�digo de final de programa: " + p.exitValue());
			
		}
		
		catch(IOException | InterruptedException e)
		{
			e.printStackTrace();
		}
		

	}

}
