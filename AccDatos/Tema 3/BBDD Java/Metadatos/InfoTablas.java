package Metadatos;

import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class InfoTablas {

	static Connection conexion = null;

	public static void main(String[] args) {
		
		try {
			mostrarInfo();
			mostrarInfoTablas();
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
	
	static void mostrarInfoTablas() throws SQLException
	{
		try
		{
			conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC", "root", "root");
			System.out.println("conecta\n");
			
			//sacar lista de tablas de ejemplo
			DatabaseMetaData dTablas = conexion.getMetaData();
			System.out.println("Lista de tablas:");
			ResultSet rs = dTablas.getTables(null, null, "d%", null);
			
			while(rs.next())
			{
				System.out.println(rs.getString("TABLE_NAME"));
			}
			
			//sacar campos
			System.out.println("");
			System.out.println("Campos de Depart");
			rs = dTablas.getColumns(null, null, "depart", null);
			
			while(rs.next())
			{
				System.out.println(rs.getString("COLUMN_NAME"));
			}
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
