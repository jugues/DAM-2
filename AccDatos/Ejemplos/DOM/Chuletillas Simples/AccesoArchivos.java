import java.io.*;
public class AccesoArchivos {

	public static void main(String[] args) {

		File myFile = new File("myNewDocument.txt");
		//File myFile = new File("src","myNewDocument.txt");
		String extension;

		try
		{
			myFile.createNewFile();
			if(myFile.canRead())
			{
				System.out.println("El archivo es legible.");
				
				if(myFile.canWrite())
				{
					System.out.println("También podemos escribir en él.");
					System.out.println("Su ruta es " + myFile.getAbsolutePath());
					System.out.println("Se encuentra dentro del directorio " + myFile.getParentFile());
				}
			}
			
			else
			{
				System.out.println("No se puede acceder al contenido del archivo.");
			}
			
		}
		
		catch(IOException e)
		{
			e.getMessage();
		}
		

		//myFile.deleteOnExit();
		
		
		
	}

}
