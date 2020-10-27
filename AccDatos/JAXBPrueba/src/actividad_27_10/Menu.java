package actividad_27_10;
import java.util.ArrayList;

//xml attribute para el id y arraylist de plato
@XMLRootElement
public class Menu {
	
	String id; 
	private ArrayList<Plato> miArrPlato = new ArrayList<>();
	
	public ArrayList<Plato> getMiArrPlato() {
		return miArrPlato;
	}
	

}
