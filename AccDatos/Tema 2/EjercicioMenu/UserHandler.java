package EjercicioMenu;
import javax.xml.*;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;
//num de men� y platos, y dentro de ello el tipo y el nombre de los ingredientes, y el total de men�s

public class UserHandler extends DefaultHandler {
	
	boolean nombre = false;
	
	 public void startElement(
		      String uri, String localName, String qName, Attributes attributes)
		      throws SAXException {
	 
	 }
	 
	 public void endElement(String uri,String localName, String qName) {
	       
         System.out.println("End Element :" + qName);
    
 }
	 
	 public void characters(char ch[], int start, int length){

	      
	   }

}
