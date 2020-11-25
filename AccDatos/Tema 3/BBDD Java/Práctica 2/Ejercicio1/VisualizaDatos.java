package Ejercicio1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class VisualizaDatos {

	public static void main(String[] args) {
		
		try {
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo", "root", "root");
			System.out.println("conecta\n");
			
			Statement myStatement = conexion.createStatement();
			ResultSet r = myStatement.executeQuery("SELECT * FROM PRODUCTOS");
			
			while(r.next()) 
			{
				System.out.println("Tabla Ventas: " + r.getString(1) + " " + r.getString(2) + " " + r.getString(3) + " " + r.getString(4) + " " + r.getString(5));
			}
				
			r = myStatement.executeQuery("SELECT * FROM CLIENTES");
			
			while(r.next()) 
			{
				System.out.println("Tabla Clientes: " + r.getString(1) + " " + r.getString(2) + " " + r.getString(3) + " " + r.getString(4) + " " + r.getString(5) + " " + r.getString(6));
			}
			
		}
		
		catch (SQLException e) {
			e.printStackTrace();
		}	

	}

}
