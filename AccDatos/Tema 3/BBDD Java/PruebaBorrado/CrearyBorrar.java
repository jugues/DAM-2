package PruebaBorrado;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.Statement;

public class CrearyBorrar {

	public static void main(String[] args) {
		
		try
		{
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC", "root", "root");
			System.out.println("conecta\n");
			
			Statement smt = conexion.createStatement();
			System.out.println("Antes del borrado");
			smt.executeUpdate("truncate table borrar;");
			System.out.println("Contenido de la tabla borrado."); 
			PreparedStatement preparado = null;
			preparado = conexion.prepareStatement("drop table borrar;");
			preparado.execute();
			System.out.println("Ejecutado delete from borrar");
			System.out.println("FIN");
		}
		
		catch(Exception ex)
		{
			ex.getMessage();
		}
	}

}
