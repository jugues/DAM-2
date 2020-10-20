import org.w3c.dom.*;
import javax.xml.parsers.*;
import java.io.*;

public class LecturaDom {

	public static void main(String[] args) {
		
		try
		{
			File archivoEntrada = new File("C:\\Users\\Juli\\Desktop\\Programas\\Eclipse Workspace\\AccesoDatos\\src\\datos.xml");
			DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
	        DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
	        Document doc = dBuilder.parse(archivoEntrada);
	        doc.getDocumentElement().normalize();
	        System.out.println("Elemento raíz: " + doc.getDocumentElement().getNodeName());
	        NodeList listaEmpleados = doc.getElementsByTagName("empleado");
	        System.out.println("---------------------");
	        
	        for(int i=0; i<listaEmpleados.getLength();i++)
	        {
	        	Node nodoActual = listaEmpleados.item(i);
	        	System.out.println("Nodo actual: " + nodoActual.getNodeName());
	        	
	        	if(nodoActual.getNodeType() == Node.ELEMENT_NODE)
	        	{
	        		Element elemento = (Element) nodoActual;
	        		System.out.println("Id: " + elemento.getAttribute("id"));
	        		System.out.println("Nombre: " + elemento.getElementsByTagName("nombre").item(0).getTextContent());
	        		System.out.println("Username: " + elemento.getElementsByTagName("username").item(0).getTextContent());
	        		System.out.println("Contraseña: " + elemento.getElementsByTagName("password").item(0).getTextContent());
	        		System.out.println("--------------------");
	        	}
	        }
		}
		
		catch(Exception e)
		{
			e.printStackTrace();
		}

	}

}
