package LecturaSAX;

import java.util.ArrayList;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class MangasHandler extends DefaultHandler {
	
	private ArrayList<Manga> arr = new ArrayList();
	private Manga mAux;
	private StringBuilder buffer = new StringBuilder();

	@Override
	public void characters(char[] ch, int start, int length) throws SAXException { //manejo del contenido textual
		
		super.characters(ch, start, length);
		buffer.append(ch, start, length);
	}

	@Override
	public void endElement(String uri, String localName, String qName) throws SAXException {
		
		super.endElement(uri, localName, qName);
		
		switch(qName)
		{
			case "mangas":
				break;
				
			case "manga":
				break;
				
			case "titulo":
				mAux.setTitulo(buffer.toString()); //le paso 
				break;
				
			case "autor":
				mAux.setAutor(buffer.toString());
				break;
				
			case "demografia":
				mAux.setDemografia(buffer.toString());
				break;
		}
	}

	public ArrayList<Manga> getArr() {
		return arr;
	}

	@Override
	public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
		
		super.startElement(uri, localName, qName, attributes);
		
		switch(qName)
		{
			case "mangas":
				break;
				
			case "manga":
				mAux = new Manga();
				arr.add(mAux);
				mAux.setId(Integer.parseInt(attributes.getValue("id")));
				break;
				
			case "titulo":
				buffer.delete(0, buffer.length());
				break;
				
			case "autor":
				buffer.delete(0, buffer.length());
				break;
				
			case "demografia":
				buffer.delete(0, buffer.length());
				break;
		}
	}
	
	

}
