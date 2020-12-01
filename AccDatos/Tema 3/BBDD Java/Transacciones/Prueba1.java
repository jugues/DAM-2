package Transacciones;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.*;

public class Prueba1 {
	
	private Connection conexion = null; 
	
	public Prueba1() throws SQLException
	{
		
		try
		{
			conectar();
			operaciones();
		}
		
		catch(Exception ex)
		{
			ex.printStackTrace();
		}
		
		finally
		{
			cerrar();
		}
	}
	
	public void conectar() throws SQLException 
	{
		String jdbc = "jdbc:mysql://localhost/ejemplo?useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
		conexion = DriverManager.getConnection(jdbc, "root", "root");
		conexion.setAutoCommit(false);
		System.out.println("conecta\n");
	}
	
	public void operaciones() throws SQLException
	{
		final String INSERTAR1 = "insert into depart(dept_no, dnombre, loc) values(?, ?, ?);";
		final String BORRAR = "truncate table depart;";
		PreparedStatement insertar = null;
		PreparedStatement borrar = null;
		
		try
		{
			insertar = conexion.prepareStatement(INSERTAR1);
			insertar.setInt(1, 50);
			insertar.setString(2, "Inventado1");
			insertar.setString(3, "Nunca Jamás");
			insertar.executeUpdate();
			
			conexion.commit();
			System.out.println("Inserciones hechas con éxito.");
			borrar = conexion.prepareStatement(BORRAR);
			borrar.executeUpdate();
			System.out.println("Contenido de la tabla borrado.");
			
			
		}
		
		catch(Exception exc)
		{
			conexion.rollback();
			exc.getMessage();
		}
		
		finally
		{
			if(insertar != null)
			{
				insertar.close();
			}
			
			if(borrar != null)
			{
				borrar.close();
			}
		}
	}
	
	public void cerrar()throws SQLException 
	{
		
	}

	public static void main(String[] args) {
		
		try {
			Prueba1 p = new Prueba1();
		} catch (SQLException e) {
			e.printStackTrace();
		}

	}

}
