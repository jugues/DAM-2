import javax.xml.bind.annotation.XmlType;

@XmlType(propOrder = {"cantidad","precio"})
public class Detalle {
	
	private String cantidad, precio;

	public String getCantidad() {
		return cantidad;
	}

	public void setCantidad(String cantidad) {
		this.cantidad = cantidad;
	}

	public String getPrecio() {
		return precio;
	}

	public void setPrecio(String precio) {
		this.precio = precio;
	}

	@Override
	public String toString() {
		return "Detalle [cantidad=" + cantidad + ", precio=" + precio + "]";
	}

}
