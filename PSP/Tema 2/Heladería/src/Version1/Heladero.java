package Version1;

import java.util.ArrayList;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Heladero extends Thread{
	
	ArrayList<String> sabores;
	Random random; //para el nº de helados
	RCNevera miNevera;
	
	public Heladero(int i, RCNevera nevera)
	{
		miNevera = nevera;
		this.setName("Heladero " + i);
		random = new Random();
		sabores = new ArrayList<String>();
		sabores.add("chocolate");
		sabores.add("limón");
		sabores.add("naranja");
		sabores.add("almendra");
		sabores.add("nata");
	}
	
	public Helado crearHelado()
	{
		float precioAl = 0 + (3-0) * random.nextFloat();
		int saborAl = random.nextInt(sabores.size());
		String sabor = sabores.get(saborAl);
		Helado helado = new Helado(sabor, precioAl);
		return helado;
	}
	
	public void run()
	{
		Random r = new Random();
		
		try
		{
			int cantHelados = 10 + r.nextInt(41);
			System.out.println(Thread.currentThread().getName() + " -- Cantidad de helados: " + cantHelados);
			
			for(int i = 0; i<cantHelados; i++)
			{
				Helado h = crearHelado();
				miNevera.meter(h);
				Thread.sleep(r.nextInt(1001));
			}
			
			System.out.println(Thread.currentThread().getName() + " ha creado " + cantHelados);
		}
		
		catch(InterruptedException ex)
		{
			Logger.getLogger(Heladero.class.getName()).log(Level.SEVERE, null, ex);
		}
	}

}
