import java.util.ArrayList;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="resumen")
public class Resumen {

	public Resumen() {}
	
	private ArrayList<Gama> gamas = new ArrayList<>();

	public ArrayList<Gama> getGamas() {
		return gamas;
	}

	@XmlElement(name="gama")
	public void setGamas(ArrayList<Gama> gamas) {
		this.gamas = gamas;
	}
	
}
