import org.w3c.dom.*;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

public class EscrituraDom {
	
	private Document documento;
	
	public EscrituraDom() throws ParserConfigurationException
	{
		//document = DocumentBuilderFactory.newInstance().newDocumentBuilder().newDocument();
		
		DocumentBuilderFactory factoria = DocumentBuilderFactory.newInstance();
		DocumentBuilder constructor = factoria.newDocumentBuilder();
		documento = constructor.newDocument();
		
	}
	
	public void generarDocumento()
	{
		Element productos = documento.createElement("productos"); //creamos el nodo raíz
		documento.appendChild(productos); 
		
		Element producto = documento.createElement("producto");
		productos.appendChild(producto);
		producto.setAttribute("cod", "1");
		
		Element nombre = documento.createElement("nombre");
		nombre.appendChild(documento.createTextNode("Monitor")); //nodo de texto entre dos etiquetas nombre
		producto.appendChild(nombre);
	}
	
	public void generarXml() throws TransformerException, IOException
	{
		TransformerFactory tFactoria = TransformerFactory.newInstance();
		Transformer transformador = tFactoria.newTransformer();
		
		Source fuente = new DOMSource(documento); //origen
		File archivo = new File("productos.xml");
		FileWriter fw = new FileWriter(archivo);
		PrintWriter pw = new PrintWriter(fw);
		Result resul = new StreamResult(pw); //destino
		 transformador.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
	     transformador.setOutputProperty(OutputKeys.INDENT, "yes");
	     transformador.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "3");
		
		transformador.transform(fuente, resul);
	}

}
