package HibDemo;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.ServiceRegistry;

public class App {

	public static void main(String[] args) {
		
		System.out.println("Main de App. Crearemos un alien...");
		
		Alien juli = new Alien();
		juli.setAid(1);
		juli.setAname("Juli");
		juli.setAcolor("Azul");
		
		Configuration con = new Configuration().configure().addAnnotatedClass(Alien.class);
		//ServiceRegistry reg = new ServiceRegistryBuilder().applySettings(con.getProperties()).buildServiceRegistry();
		SessionFactory sf = con.buildSessionFactory(); //reg en paréntesis
		Session sesion = sf.openSession();
		Transaction tx = sesion.beginTransaction();
		sesion.save(juli);
		tx.commit();

	}

}
