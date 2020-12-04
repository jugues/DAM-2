package EntregaTestigo05;

public class Main {

	public static void main(String[] args) {
		
		Testigo a = new Testigo();
		Corredor1 c1 = new Corredor1(a);
		Corredor2 c2 = new Corredor2(a);
		c1.start();
		c2.start();
	}

}
