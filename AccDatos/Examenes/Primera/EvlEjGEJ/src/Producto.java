import java.util.ArrayList;

import javax.xml.bind.annotation.XmlElement;

public class Producto {
	
	private String id;
	private String nombre;
	private ArrayList<Detalle> detalles = new ArrayList<>();
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public ArrayList<Detalle> getDetalles() {
		return detalles;
	}
	
	@XmlElement(name="detalle")
	public void setDetalles(ArrayList<Detalle> detalles) {
		this.detalles = detalles;
	}
	
	

}
