import java.util.ArrayList;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;

@XmlType(propOrder = {"id","descripcion", "productos"})
public class Gama {
	
	private String id;
	private String descripcion;
	private ArrayList<Producto> productos = new ArrayList<>();
	
	@XmlAttribute(name="id")
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getDescripcion() {
		return descripcion;
	}
	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}
	public ArrayList<Producto> getProductos() {
		return productos;
	}
	
	@XmlElement(name="producto")
	public void setProductos(ArrayList<Producto> productos) {
		this.productos = productos;
	}
	
	

}
