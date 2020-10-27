package actividad_27_10;
import java.util.ArrayList;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlType;

@XmlRootElement(name="Menus")
public class Menus {
	
	@XmlElementWrapper(nombre="miArrMenu")
	@XmlElement(name="Menu")
	private ArrayList<Menu> miArrMenu = new ArrayList<>();
	
	public ArrayList<Menu> getmiArrMenu()
	{
		return miArrMenu;
	}
	
	public String toString()
	{
		return "Menús [miArrMenu=" + miArrMenu + "]";
	}


}
