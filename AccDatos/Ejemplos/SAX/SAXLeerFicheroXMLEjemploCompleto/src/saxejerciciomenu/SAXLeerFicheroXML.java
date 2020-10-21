package saxejerciciomenu;

import java.io.File;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;



public class SAXLeerFicheroXML {

	public static void main(String[]args){
		try{
			
			File inputFile= new File("menu.xml");
			SAXParserFactory factory=SAXParserFactory.newInstance();
			SAXParser saxParser=factory.newSAXParser();
			UserHandlerMenu uhm=new UserHandlerMenu();
			saxParser.parse(inputFile, uhm);//el error en el parser desaparece en cuanto extiendo la clase UserHandler
			//System.out.println(uhm.toString());//imprimo el contador
		}catch(Exception e){
			  e.printStackTrace();
		}
		
	}
}
