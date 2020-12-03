import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class GeneraTablas {

	public static void main(String[] args) throws SQLException {
		
		String driver = "oracle.jdbc.driver.OracleDriver";
		String cadena = "jdbc:oracle:thin:@localhost:1521:XE", usuario = "system", clave = "root";
		Connection conexion;
		Statement sentencia;
		
		conexion = DriverManager.getConnection(cadena, usuario, clave);
		System.out.println("Conecta\n");

	}

}
