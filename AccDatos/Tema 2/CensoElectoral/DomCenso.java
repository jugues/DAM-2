package CensoElectoral;

import java.io.File;
import java.io.IOException;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

public class DomCenso {
	
	private final static String docEntrada = "escrutinio_municipales_2015.xml";
	private final static String docSalida = "censo.xml";
	int votantes = 0; 
	int votosAyuntamiento = 0;

	public static void main(String[] args) { 
		
		try
		{
			Document doc = loadDom(docEntrada);
			Document docPrincipal = loadDocToDoc(doc);
			System.out.println("Cargando documento.");
			writeDom(docPrincipal, docSalida);
			System.out.println("Archivo guardado");
			
		}
		
		catch(Exception e)
		{
			System.out.println("Excepción encontrada: " + e.getMessage());
		}

	}
	
	public static Document loadDom(String pathXml) throws ParserConfigurationException, SAXException, IOException
	{
		File inputFile = new File(pathXml); 
		DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
		DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
		Document doc = dBuilder.parse(inputFile);
		doc.getDocumentElement().normalize();
		return doc;
	}
	
	public static void writeDom(Document doc, String path) throws TransformerException
	{
		TransformerFactory tFactory = TransformerFactory.newInstance();
		Transformer transformer = tFactory.newTransformer();
		
		transformer.setOutputProperty(OutputKeys.METHOD, "xml");
		transformer.setOutputProperty(OutputKeys.INDENT, "yes");
		transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount","2");
		transformer.setOutputProperty(OutputKeys.OMIT_XML_DECLARATION, "no");
		DOMSource source = new DOMSource(doc);
		StreamResult result = new StreamResult(new File(docSalida));
		
		transformer.transform(source, result);
	}
	
	public static Document loadDocToDoc (Document docLectura) throws ParserConfigurationException 
	
	{
	
		int iTotal = 0;
		DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
		DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
		Document doc = dBuilder.newDocument();
		
		//creación del árbol 
		Element rootElement = doc.createElement("datos_censo");
		doc.appendChild(rootElement);
		
		Element eTitulo = doc.createElement("titulo");
		eTitulo.appendChild(doc.createTextNode("ayuntamientos madrid"));
		rootElement.appendChild(eTitulo);
		
		NodeList nList = docLectura.getElementsByTagName("escrutinio_sitio");
		
		Element eAyuntamientos = doc.createElement("ayuntamientos");
		rootElement.appendChild(eAyuntamientos);
		
		for(int i=0;i<nList.getLength();i++)
		{
			Node nNode = nList.item(i);
			
			if(nNode.getNodeType() == Node.ELEMENT_NODE)
			{
				Element eElement = (Element) nNode; 
				
				Element eAyuntamiento = doc.createElement("ayuntamiento");
				eAyuntamiento.setAttribute("ts", eElement.getElementsByTagName("ts").item(0).getTextContent());
				eAyuntamientos.appendChild(eAyuntamiento);
				
				Element eNombre = doc.createElement("nombre");
				eNombre.appendChild(doc.createTextNode(eElement.getElementsByTagName("nombre_sitio").item(0).getTextContent()));
				eAyuntamiento.appendChild(eNombre);
				
				Element eConcejales = doc.createElement("concejales");
				eConcejales.appendChild(doc.createTextNode(eElement.getElementsByTagName("num_a_elegir").item(0).getTextContent()));
				eAyuntamiento.appendChild(eConcejales);
				
				//ahora cantidades
				int iCantidad = 0;
				NodeList nListCantidades = eElement.getElementsByTagName("cantidad");
				
				for(int j=0;j<nListCantidades.getLength();j++)
				{
					Node cNode = nListCantidades.item(j);
					if(cNode.getNodeType() == Node.ELEMENT_NODE)
					{
						Element cElement = (Element) cNode;
						iCantidad += Integer.parseInt(cElement.getTextContent());
					}
				}
				
				Element eCantidad = doc.createElement("votantes");
				eCantidad.appendChild(doc.createTextNode(iCantidad + ""));
				eAyuntamiento.appendChild(eCantidad);
			
				iTotal += iCantidad;
			}
		}
		
		return doc;
	}

}
