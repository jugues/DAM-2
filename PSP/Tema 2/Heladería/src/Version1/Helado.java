package Version1;

public class Helado {
	
	private String sabor;
	private float precio;
	
	public Helado() {}
	
	public Helado(String sabor, float precio)
	{
		this.sabor = sabor;
		this.precio = precio;
	}

	public String getSabor() {
		return sabor;
	}

	public void setSabor(String sabor) {
		this.sabor = sabor;
	}

	public float getPrecio() {
		return precio;
	}

	public void setPrecio(float precio) {
		this.precio = precio;
	}

}
