package LecturaJaxb;
import java.io.File;
import java.util.ArrayList;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

public class LecturaJaxb {

	public static void main(String[] args) throws JAXBException {
		
		JAXBContext contexto = JAXBContext.newInstance(Libreria.class);
		Unmarshaller um = contexto.createUnmarshaller();
		Libreria miLibreria = (Libreria)um.unmarshal(new File("C:\\Users\\Juli\\Desktop\\Programas\\Eclipse Workspace\\AccesoDatos\\src\\LecturaJaxb\\libreria.xml"));	
	
		System.out.println("Nombre de la librería: " + miLibreria.getNombre());
		System.out.println("---------------");
		ArrayList<Libro> misLibros = miLibreria.getLibros();
		for(Libro l : misLibros)
		{
			System.out.println(l.getIsbn() + " " + l.getTitulo() + " " + l.getAutor());
			System.out.println("---------------");
		}
	}

}
