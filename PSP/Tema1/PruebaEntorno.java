package Tema1;
import java.io.IOException;
import java.util.Map;

public class PruebaEntorno {

	public static void main(String[] args) {
		
		Map<String, String> mp = System.getenv(); //saca las variables del sistema
		for(String key : mp.keySet())
		{
			String valor = mp.get(key);
			System.out.println("Key: " + "--------- " + valor);
			
		}
	
		try {
			
			ProcessBuilder pb = new ProcessBuilder("notepad","");
			Process p = pb.start();
			System.out.println("ESPERANDO...");
			p.waitFor();
			p.exitValue();
			System.out.println("Código de fin de proceso: " + p.exitValue());
		} 
		
		catch (IOException | InterruptedException e) {
			
			e.printStackTrace();
		}

	}

}
