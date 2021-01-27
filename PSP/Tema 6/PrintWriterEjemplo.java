import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Random;
import java.util.Vector;

public class PrintWriterEjemplo {
	
	private Vector <Integer> numbers;
	private static int SIZE = 21;
	
	public PrintWriterEjemplo() throws IOException
	{
		numbers = new Vector(SIZE);
		Random randomGenerator = new Random();
		
		for(int i = 0; i<SIZE; i++)
		{
			Integer num = randomGenerator.nextInt(20);
			numbers.addElement(new Integer(num));
		}
		
		PrintWriter out;
		System.out.println("Entrando a la zona de impresión.");
		out = new PrintWriter(new FileWriter("salida.txt"));
		
		for(int a = 0; a < SIZE; a++)
		{
			System.out.println("Elemento " + a + " = " + numbers.elementAt(a)); //eco
			out.println("Elemento " + a + " = " + numbers.elementAt(a)); //guardado en fichero
		}
		
		out.close();
	}

	public static void main(String[] args) throws IOException {
		
		new PrintWriterEjemplo();

	}

}
