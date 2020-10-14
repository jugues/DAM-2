import java.io.IOException;

import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.TransformerException;

public class PrincipalDom {

	public static void main(String[] args) {
		
		try {
			EscrituraDom escritor = new EscrituraDom();
			escritor.generarDocumento();
			escritor.generarXml();
		} catch (ParserConfigurationException e) {
			System.out.println("Excepción al parsear.");
			e.printStackTrace();
		} catch (TransformerException e) {
			System.out.println("Excepción al transformar.");
			e.printStackTrace();
		} catch (IOException e) {
			System.out.println("Excepción de E/S.");
			e.printStackTrace();
		}

	}

}
