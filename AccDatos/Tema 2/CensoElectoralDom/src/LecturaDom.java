import org.w3c.dom.*;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

public class LecturaDom {
	
	private Document doc;
	
	public LecturaDom() throws ParserConfigurationException
	{
		DocumentBuilderFactory factoria = DocumentBuilderFactory.newInstance();
		DocumentBuilder constructor = factoria.newDocumentBuilder();
		doc = constructor.newDocument();
	}
	
	public void generarDocumento()
	{
		Element datos = doc.createElement("datos_censo"); //creamos el nodo raíz
		doc.appendChild(datos); 
		
		Element titulo = doc.createElement("titulo");
		datos.appendChild(titulo);
		
		Element totalVotantes = doc.createElement("total_votantes");
		datos.appendChild(totalVotantes);
		
		Element ayuntamientos = doc.createElement("ayuntamientos");
		datos.appendChild(ayuntamientos);
		
		Element ayuntamiento = doc.createElement("ayuntamiento");
		ayuntamientos.appendChild(ayuntamiento);
		ayuntamiento.setAttribute("ts", "");
		
		Element nombre = doc.createElement("nombre");
		Element concejales = doc.createElement("concejales");
		Element votantes = doc.createElement("votantes");
		
		ayuntamiento.appendChild(nombre);
		ayuntamiento.appendChild(concejales);
		ayuntamiento.appendChild(votantes);
	}
	
	public void generarXml() throws TransformerException, IOException
	{
		TransformerFactory tFactoria = TransformerFactory.newInstance();
		Transformer transformador = tFactoria.newTransformer();
		
		Source fuente = new DOMSource(doc); //origen
		File archivo = new File("censo.xml");
		FileWriter fw = new FileWriter(archivo);
		PrintWriter pw = new PrintWriter(fw);
		Result resul = new StreamResult(pw); //destino
		 transformador.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
	     transformador.setOutputProperty(OutputKeys.INDENT, "yes");
	     transformador.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "3");
		
		transformador.transform(fuente, resul);
	}

}
