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
			System.out.println("Excepci�n al parsear.");
			e.printStackTrace();
		} catch (TransformerException e) {
			System.out.println("Excepci�n al transformar.");
			e.printStackTrace();
		} catch (IOException e) {
			System.out.println("Excepci�n de E/S.");
			e.printStackTrace();
		}

	}

}
