package Version1;

import java.util.ArrayList;

public class RCNevera {
	
	int m = 5;
	boolean llena;
	ArrayList<Helado> misHelados;
	
	public RCNevera()
	{
		llena = false;
		misHelados = new ArrayList<>(m);
	}
	
	public synchronized void meter(Helado h) throws InterruptedException
	{
		while(llena)
		{
			wait();
		}
		
		misHelados.add(h);
		System.out.println(Thread.currentThread().getName() + " mete un helado de " + h.getSabor() + " que vale " + h.getPrecio() + " .");
		
		if(misHelados.size() >= m)
		{
			llena = true; 
		}
		
		notifyAll();
	}
	
	public synchronized Helado sacar() throws InterruptedException
	{
		while(!llena)
		{
			wait();
		}
		
		Helado aux = misHelados.get(0);
		misHelados.remove(aux);
		
		System.out.println(Thread.currentThread().getName() + " saca un helado de " + aux.getSabor() + " que vale " + aux.getPrecio() + " .");
		
		if(misHelados.isEmpty())
		{
			llena = false;
		}
		
		notifyAll();
		return aux;
	}

}
