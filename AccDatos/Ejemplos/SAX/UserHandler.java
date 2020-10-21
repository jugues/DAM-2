import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

class UserHandler extends DefaultHandler {
   
   
     boolean nombre = false;
     boolean cantidad = false;


   public void startElement(
      String uri, String localName, String qName, Attributes attributes)
      throws SAXException {
     
      if (qName.equalsIgnoreCase("menu")) {
         String id = attributes.getValue("id");
         System.out.println("Menu : " + id);
      }
         else if (qName.equalsIgnoreCase("plato")) {
         String tipo = attributes.getValue("tipo");
         System.out.println("Tipo del plato : " + tipo);    
      }
         else if (qName.equalsIgnoreCase("nombre")) {
         nombre = true;
      }
         else if (qName.equalsIgnoreCase("ingrediente")) {
         String nombreingre = attributes.getValue("nombre");
         System.out.println("Ingrediente: " + nombreingre);
      }
      else if (qName.equalsIgnoreCase("cantidad")) {
         cantidad = true;
   }
   }


 

   public void endElement(String uri,String localName, String qName) {
       
           System.out.println("End Element :" + qName);
      
   }

 
   public void characters(char ch[], int start, int length){

      if (nombre) {
         System.out.println("Nombre: " + new String(ch, start, length));
         nombre = false;
      } else if (cantidad) {
         System.out.println("Cantidad: " + new String(ch, start, length));
         cantidad = false;
      }
   }
}