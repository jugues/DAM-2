import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ConnectionDatabase {

	public static void main(String[] args) {
		
		try {
			//establecemos la conexion con la BD
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC", "root", "root");
			System.out.println("conecta\n");
			
			//creamos la sentencia SQL y la ejecutamos
			Statement myStatement = conexion.createStatement();
			ResultSet r = myStatement.executeQuery("SELECT * FROM DEPART");
			
			//recorremos el resultset
			while(r.next())
			{
				System.out.println("Dept_no: " + r.getString("dept_no") + " dnombre: " + r.getString("dnombre") + " loc: " + r.getString("loc"));
			}
	
			conexion.close(); // Cerrar conexión
		} catch (SQLException cn) {
			cn.printStackTrace();
		}

	}

}
