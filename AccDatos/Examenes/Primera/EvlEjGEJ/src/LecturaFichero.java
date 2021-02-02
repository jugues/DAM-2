import java.io.File;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

public class LecturaFichero {

	/* public static void main(String[] args) {
		
		lectura();
	} */
	
	public static void lectura()
	{
		try {
			JAXBContext contexto = JAXBContext.newInstance(Resumen.class);
			Unmarshaller um = contexto.createUnmarshaller();
			Resumen miResumen = (Resumen)um.unmarshal(new File("ResumenProductos.xml"));
			System.out.println("Archivo cargado.");
			System.out.println("--------------------");
		}
		
		catch(JAXBException e)
		{
			e.printStackTrace();
		}
	}

}
