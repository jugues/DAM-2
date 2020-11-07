package Libros;

import java.io.File;
import java.io.IOException;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

public class main {
	
	private static String ruta;

	public static void main(String[] args) {
		
		ruta = "books.xml";
		
		try
		{
			Document doc;
			doc = loadDom(ruta);
			System.out.println("Elemento raíz: " + doc.getDocumentElement().getNodeName());
			System.out.println("-------------------------");
			
			NodeList nLibros = doc.getElementsByTagName("book");
			
			for(int i=0;i<nLibros.getLength();i++)
			{
				Node nodoActual = nLibros.item(i);
				
				if(nodoActual.getNodeType() == Node.ELEMENT_NODE)
				{
					Element element = (Element) nodoActual;
					
					System.out.println("Libro " + (i + 1) + ":");
					
					System.out.println("Categoría: " + element.getAttribute("category"));
					System.out.println("Título: " + element.getElementsByTagName("title").item(0).getTextContent());
					
					NodeList nAutores = element.getElementsByTagName("author");
					System.out.println("Num de autores: " + nAutores.getLength());
					
					if(nAutores.getLength() == 0)
					{
						System.out.println("Autor no especificado o desconocido.");
					}
					
					else if(nAutores.getLength() == 1)
					{
						System.out.println("Autor: " + element.getElementsByTagName("author").item(0).getTextContent());
					}
					
					else
					{
					
						for (int j=0;j<nAutores.getLength();j++)
						{
							Node nActual = nAutores.item(j);
							//if no necesario
							if(nActual.getNodeType() == Node.ELEMENT_NODE)
							{
								Element eElement = (Element) nActual;
								System.out.println("Autor " + j + " :"+ eElement.getTextContent());
							}
							
						 }
					}
					
					System.out.println("-------------------------");
					
				}
			}
			
		}
		
		catch(Exception e)
		{
			
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


}
