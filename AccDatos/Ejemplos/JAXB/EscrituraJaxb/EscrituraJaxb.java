package EscrituraJaxb;

import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

public class EscrituraJaxb {

	public static void main(String[] args) throws JAXBException, IOException {
		
		JAXBContext contexto = JAXBContext.newInstance(Libreria.class);
		Marshaller ms = contexto.createMarshaller();
		
		Libreria miLibreria = new Libreria();
		miLibreria.setNombre("Libros de informática");
		ArrayList<Libro> misLibros = new ArrayList();
		Libro lb = new Libro();
		lb.setIsbn("123456");
		lb.setTitulo("Python para dummies");
		lb.setAutor("Pepito Grillo");
		misLibros.add(lb);
		lb = new Libro();
		lb.setIsbn("7890123");
		lb.setTitulo("C# para Unity");
		lb.setAutor("Anónimo");
		misLibros.add(lb);
		//le pasamos el Arraylist para rellenar la libreria
		miLibreria.setLibros(misLibros);
		
		ms.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
		// ms.marshal(miLibreria, System.out); --con esto vemos la salida por pantalla
		ms.marshal(miLibreria, new FileWriter("C:\\Users\\Juli\\Desktop\\Programas\\Eclipse Workspace\\AccesoDatos\\src\\EscrituraJaxb\\miLibreria.xml"));
		

	}

}
