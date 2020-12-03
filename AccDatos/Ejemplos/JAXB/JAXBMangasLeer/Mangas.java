package JAXBMangasLeer;

import java.util.ArrayList;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="mangas")
public class Mangas {
	
	private ArrayList<Manga> mangas = new ArrayList<>();
	
	public Mangas()
	{
		
	}

	public ArrayList<Manga> getMangas() {
		return mangas;
	}

	@XmlElement(name="manga")
	public void setMangas(ArrayList<Manga> mangas) {
		this.mangas = mangas;
	}
	
	

}
