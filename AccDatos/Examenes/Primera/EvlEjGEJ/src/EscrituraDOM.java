import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.Unmarshaller;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

public class EscrituraDOM {
	
	private Document documento;
	
	public EscrituraDOM()throws ParserConfigurationException
	{
		DocumentBuilderFactory factoria = DocumentBuilderFactory.newInstance();
		DocumentBuilder constructor = factoria.newDocumentBuilder();
		documento = constructor.newDocument();
		LecturaFichero l = new LecturaFichero();
		l.lectura();
	}
	
	public void generarDocumento()
	{
		Element resumen = documento.createElement("resumen"); //elemento raíz
		documento.appendChild(resumen);
		
		Element productos = documento.createElement("productos");
		resumen.appendChild(productos);
		
		Element producto = documento.createElement("producto");
		producto.setAttribute("id", "");
		productos.appendChild(producto);
		
		Element nombre = documento.createElement("nombre");
		nombre.appendChild(documento.createTextNode("")); 
		producto.appendChild(nombre);
		
		Element cantidad = documento.createElement("cantidad");
		cantidad.appendChild(documento.createTextNode(""));
		producto.appendChild(cantidad);
		
		Element numLineas = documento.createElement("num_lineas");
		numLineas.appendChild(documento.createTextNode(""));
		producto.appendChild(numLineas);
	}
	
	public void llenarDocumento()
	{
		//falta insertar el contenido leído en jaxb 
	}
	
	public void generarXml()throws TransformerException, IOException
	{
		TransformerFactory tFactoria = TransformerFactory.newInstance();
		Transformer transformador = tFactoria.newTransformer();
		//me falta transformar la fuente en jaxb al resultado en dom, lo contrario lo sé hacer pero esto no
		
		/* JAXBContext contexto = JAXBContext.newInstance(Resumen.class);
		Unmarshaller um = contexto.createUnmarshaller();
		File archivo = new File("solucion.xml");
		Resumen miResumen = (Resumen)um.unmarshal(archivo);	
		FileWriter fw = new FileWriter(archivo);
		PrintWriter pw = new PrintWriter(fw);
		Result resul = new StreamResult(pw); //destino
		transformador.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
	    transformador.setOutputProperty(OutputKeys.INDENT, "yes");
	    transformador.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "3");
		transformador.transform(fuente, resul); */

	}

}
