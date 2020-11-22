package Conexion;

import java.sql.*;

public class EjemploPreparedStatement {

	public static void main(String[] args) {
		
		try 
		{
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo", "root", "root");
			System.out.println("conecta\n");
			
			PreparedStatement sentence = conexion.prepareStatement("select * from depart where dept_no = ?");
			sentence.setString(1, "10");
			ResultSet r = sentence.executeQuery();
			
			while(r.next()) //sacamos las columnas
			{
				System.out.println(r.getString(1) + " " + r.getString(2) + " " + r.getString(3));
			}
		}
		
		catch(Exception ex)
		{
			System.out.println("Excepción encontrada.");
		}
		

	}

}
