package LecturaSAX;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;

import javax.xml.parsers.ParserConfigurationException;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import org.xml.sax.SAXException;

public class Lectura {

	public static void main(String[] args) throws ParserConfigurationException, SAXException, IOException {
		
		SAXParserFactory factoria = SAXParserFactory.newInstance();
		SAXParser parseador = factoria.newSAXParser();
		File archivo = new File("mangas.xml");
		MangasHandler handler = new MangasHandler();
		parseador.parse(archivo, handler);
		ArrayList<Manga> m = handler.getArr();
		
		for(Manga manga : m)
		{
			System.out.println(manga);
		}

	}

}
