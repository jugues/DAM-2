package Tema1;

public class PruebaEntornoOtra {

	public static void main(String[] args) {
		
		ProcessBuilder pb = new ProcessBuilder();
		pb.command("notepad","");
		Process proceso;
		
		try
		{
			proceso = pb.start();
			System.out.println("ESPERANDO...");
			proceso.waitFor();
		}
		
		catch(Exception ex)
		{
			System.out.println(ex.toString());
		}
		
		System.out.println("PROGRAMA FINALIZADO.");
	}

}
