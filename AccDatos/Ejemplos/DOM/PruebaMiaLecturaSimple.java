import java.io.*;
import javax.xml.parsers.*;
import org.w3c.dom.*;

public class PruebaMiaLecturaSimple {

	public static void main(String[] args) {
		
		try 
		{
			File inputFile = new File("users.xml");
	        DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
	        DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
	        Document doc = dBuilder.parse(inputFile);
	        
	        System.out.println("Root element :" + doc.getDocumentElement().getNodeName());
	        NodeList nList = doc.getElementsByTagName("user");
	        
	        for (int i = 0;i < nList.getLength(); i++) {
	            Node nNode = nList.item(i);
	            System.out.println("Elemento actual :" + nNode.getNodeName());
	            
	            if (nNode.getNodeType() == Node.ELEMENT_NODE) {
	               Element eElement = (Element) nNode;
	               System.out.println("User: " 
	                  + eElement.getAttribute("id"));
	               System.out.println("First Name: " 
	                  + eElement
	                  .getElementsByTagName("firstname")
	                  .item(0)
	                  .getTextContent());
	               System.out.println("Last Name: " 
	                  + eElement
	                  .getElementsByTagName("lastname")
	                  .item(0)
	                  .getTextContent());
	               System.out.println("Occupation: " 
	                  + eElement
	                  .getElementsByTagName("occupation")
	                  .item(0)
	                  .getTextContent());
	            }
	         }
		}
		
		catch(Exception e)
		{
			e.getMessage();
		}

	}

}
