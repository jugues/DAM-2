



import java.io.File;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;



public class XMLSAX {

    /**
     * @param args the command line arguments
     * @throws org.xml.sax.SAXException
     */      


   public static void main(String[] args) {

      try {
         File inputFile = new File("menu.xml");
         SAXParserFactory factory = SAXParserFactory.newInstance();
         SAXParser saxParser = factory.newSAXParser();
         UserHandler userhandler = new UserHandler();
         saxParser.parse(inputFile, userhandler);    
      } catch (Exception e) {
         e.printStackTrace();
      }
   }  
}

