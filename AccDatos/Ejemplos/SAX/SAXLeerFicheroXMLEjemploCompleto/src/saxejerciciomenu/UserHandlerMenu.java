package saxejerciciomenu;
import javax.xml.*;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class UserHandlerMenu extends DefaultHandler {

	boolean menuNombre=false;
	boolean menuCantidad=false;	
	int nmenus;

	@Override
	public void startElement(String uri, String localName,
			String qName, Attributes attributes) throws SAXException{
		
		if(qName.equalsIgnoreCase("menu")){
			String numero=attributes.getValue("id");
			System.out.println("\nMenu nº: "+numero);
			nmenus++;//el contador se iterará por cada menú.
		}else if(qName.equalsIgnoreCase("nombre")){
		    menuNombre=true;
		}else if(qName.equalsIgnoreCase("ingrediente")){
			String nombre=attributes.getValue("nombre");
			System.out.print(nombre);
		}else if(qName.equalsIgnoreCase("cantidad")){
			menuCantidad=true;
		}
	}
	public void endElement(String uri, String localName, String qName)throws SAXException{
		if(qName.equalsIgnoreCase("menu")){
			//DIRECTAMENTE NO SE PONE SI NO HAY nada que capturar
	
		}
	}
	@Override
	public void characters(char ch[],int start, int length)throws SAXException{
		if(menuNombre){
			System.out.println("\nNombre: "+new String(ch,start, length));
			menuNombre=false;
		}else if(menuCantidad){
			System.out.println(", cantidad: ("+new String(ch,start,length)+")");
			menuCantidad=false;
		}
	}
	@Override
	public String toString() {
		return "\nnº de menús: "+nmenus;//ponerlo en enddocument
	}
	
	public void endDocument(){
		
		System.out.println("\nnº de menús: "+nmenus);
	}
}
