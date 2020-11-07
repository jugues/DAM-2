import java.io.*;
import javax.xml.parsers.*;
import org.w3c.dom.*;
import org.xml.sax.SAXException;

public class Restaurante {
	
	final static String path = "menu.xml";

	public static void main(String[] args) {
		
		try
		{
			System.out.println("Intentando cargar documento...");
			readDom(path);
			
		}
		
		catch(Exception e)
		{
			System.out.println("Excepción encontrada.");
		}

	}
	
	public static Document loadDom(String source) throws ParserConfigurationException, SAXException, IOException
	{
		File inputFile = new File(source);
		DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
		DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
		Document document = dBuilder.parse(inputFile);
		document.getDocumentElement().normalize();
		return document;
	}
	
	public static void readDom(String where) throws ParserConfigurationException
	{
		try {
			
			Document docDom = loadDom(where);
			System.out.println("Root element: " + docDom.getDocumentElement().getNodeName());
			NodeList nList = docDom.getElementsByTagName("menu");
			
			for(int i=0;i<nList.getLength();i++)
			{
				Node nNode = nList.item(i);
				System.out.println("Current element: " + nNode.getNodeName());
				
				if(nNode.getNodeType() == Node.ELEMENT_NODE)
				{
					Element element = (Element) nNode;
					System.out.println("Menu ID: " + element.getAttribute("id"));
					NodeList nDishes = docDom.getElementsByTagName("plato");
					
					for(int j = 0;j<nDishes.getLength();j++)
					{
						Node jNode = nDishes.item(j);
						System.out.println("Dish >");
						
						if(jNode.getNodeType() == Node.ELEMENT_NODE)
						{
							Element element2 = (Element) jNode;
							System.out.print("Type: " + element2.getAttribute("tipo") + " ");
							System.out.print("Name: " + element2.getElementsByTagName("nombre").item(0).getTextContent() + " ");
							
							NodeList nIngredients = element2.getElementsByTagName("ingrediente");
							
							for(int k = 0;k<nIngredients.getLength();k++)
							{
								Node kNode = nIngredients.item(k);
								
								if(kNode.getNodeType() == Node.ELEMENT_NODE)
								{
									Element element3 = (Element) kNode;
									System.out.println("Ingredient name: " + element3.getAttribute("nombre"));
								}
								
							}
							
						}
						
					}
				}
					
			}
		}	
		
		catch (Exception e) {
			
			e.printStackTrace();
		}
		
		
		
	}
}
