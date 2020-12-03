package JAXBMangasLeer;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlType;

@XmlType(propOrder = {"id","titulo","autor","demografia"})
public class Manga {
	
	private String id, titulo, autor, demografia;
	
	public Manga()
	{
		
	}

	@Override
	public String toString() {
		return "Manga [id=" + id + ", titulo=" + titulo + ", autor=" + autor + ", demografia=" + demografia + "]";
	}
	@XmlAttribute(name="id")
	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public String getAutor() {
		return autor;
	}

	public void setAutor(String autor) {
		this.autor = autor;
	}

	public String getDemografia() {
		return demografia;
	}

	public void setDemografia(String demografia) {
		this.demografia = demografia;
	}
	
	

}
