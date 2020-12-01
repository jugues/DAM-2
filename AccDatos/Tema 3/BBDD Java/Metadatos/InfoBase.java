package Metadatos;

import java.sql.*;

public class InfoBase {
	
	static Connection conexion;

	public static void main(String[] args) {
		
		try {
			mostrarInfo();
		} catch (SQLException e) {
			e.printStackTrace();
		}

	}
	
	static void mostrarInfo() throws SQLException
	{
		
		try
		{
			conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC", "root", "root");
			System.out.println("conecta\n");
			DatabaseMetaData d = conexion.getMetaData(); //metadatos de ejemplo
			System.out.println("Nombre de la bbdd: " + d.getDatabaseProductName());
			System.out.println("Versión: " + d.getDatabaseProductVersion());
			System.out.println("Driver: " + d.getDriverName() + " Versión " + d.getDriverVersion());
		}
		
		catch(Exception ex)
		{
			System.out.println("Excepción encontrada.");
		}
		
		finally
		{
			conexion.close();
		}
	}

}
