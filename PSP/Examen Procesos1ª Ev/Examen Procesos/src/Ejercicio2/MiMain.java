package Ejercicio2;

import java.util.Random;

public class MiMain {

	public static void main(String[] args) {
		
		int numCoches;
		Random r = new Random();
		numCoches = 5 + r.nextInt(10);
		Coche[] misCoches = new Coche[numCoches]; 
		Semaforo sf = new Semaforo();
		
		//creaci�n de los coches
		for(int i = 0; i<numCoches; i++)
		{
			Coche aux = new Coche("Coche " + i, sf);
			aux.setIdCoche(i);
			misCoches[i] = aux;
		}
		
		//inicializaci�n
		for(int a = 0; a<misCoches.length; a++)
		{
			misCoches[a].start();
		}

		System.out.println("FIN del Main");
	}

}
