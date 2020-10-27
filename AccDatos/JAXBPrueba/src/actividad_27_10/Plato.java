package actividad_27_10;
import java.util.ArrayList;

public class Plato {
	
	private ArrayList<Ingrediente> miArrIngred = new ArrayList<>();
	String tipo, nombre;

	public void setMiArrIngred(ArrayList<Ingrediente> miArrIngred) {
		this.miArrIngred = miArrIngred;
	}

	public ArrayList<Ingrediente> getMiArrIngred() {
		return miArrIngred;
	}
	
	

}
