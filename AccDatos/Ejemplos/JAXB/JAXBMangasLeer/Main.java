package JAXBMangasLeer;

import java.io.File;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.util.ArrayList;

public class Main {

	public static void main(String[] args) {
		
		lectura();
	}
	
	public static void lectura()
	{
		try {
			JAXBContext contexto = JAXBContext.newInstance(Mangas.class);
			Unmarshaller um = contexto.createUnmarshaller();
			Mangas misMangas = (Mangas)um.unmarshal(new File("mangas.xml"));
			System.out.println("Archivo cargado.");
			System.out.println("--------------------");
			ArrayList<Manga> m = misMangas.getMangas();
			
			for(Manga man : m)
			{
				System.out.println(man.getTitulo() + " " + man.getId() + " " + man.getAutor() + " " + man.getDemografia());
				System.out.println("--------------------");
			}
		} 
		
		catch (JAXBException e) {
			e.printStackTrace();
		}
	}

}
