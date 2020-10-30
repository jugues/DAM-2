package EscrituraJaxb;
import java.util.ArrayList;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

@XmlRootElement(name="libreria")
@XmlType(propOrder= {"nombre","libros"})
public class Libreria {
	
	private String nombre;
	private ArrayList<Libro> libros = new ArrayList();
	
	public Libreria()
	{
		
	}

	@XmlElement(name="nombre")
	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	
	//decimos que es wrapper al elemento que devuelve el array de elementos
	@XmlElementWrapper(name="libros")
	@XmlElement(name="libro") //indicamos el nombre de la etiqueta de cada elemento del arraylist
	public ArrayList<Libro> getLibros() {
		return libros;
	}

	public void setLibros(ArrayList<Libro> libros) {
		this.libros = libros;
	}
	
	

}
