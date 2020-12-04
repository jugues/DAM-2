package EntregaTestigo05;

import java.util.Random;

public class Testigo {

	private boolean boolTestigo;
	private int iTestigo;
	private final Random r;
	
	public Testigo()
	{
		boolTestigo = false;
		r = new Random();
		iTestigo = r.nextInt(100);
	}
	
	public boolean isBoolTestigo()
	{
		return boolTestigo;
	}

	public int getiTestigo() {
		return iTestigo;
	}

	public void setBoolTestigo(boolean boolTestigo) {
		this.boolTestigo = boolTestigo;
	}
	
}
