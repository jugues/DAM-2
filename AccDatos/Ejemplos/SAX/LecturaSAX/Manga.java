package LecturaSAX;

public class Manga {
	
	private int id; 
	private String titulo, autor, demografia;
	
	@Override
	public String toString() {
		return "Manga [id=" + id + ", titulo=" + titulo + ", autor=" + autor + ", demografia=" + demografia + "]";
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
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
