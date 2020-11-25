package Ejercicio1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class InsertaDatos {

	public static void main(String[] args) {
		
		try
		{
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo", "root", "root");
			System.out.println("conecta\n");
			
			Statement myStatement = conexion.createStatement();
			String instruction = "INSERT INTO PRODUCTOS(id, descripcion, stockactual, stockminimo, pvp) VALUES (1, 'Tijeras', 20, 5, 10)";
			myStatement.executeUpdate(instruction);
			
			Statement myStatement2 = conexion.createStatement();		
			String instruction2 = "INSERT INTO PRODUCTOS(id, descripcion, stockactual, stockminimo, pvp) VALUES (2, 'Podadora', 50, 1, 25)";
			myStatement2.executeUpdate(instruction2);
			
			Statement myStatement3 = conexion.createStatement();
			String instruction3 = "INSERT INTO PRODUCTOS(id, descripcion, stockactual, stockminimo, pvp) VALUES (3, 'Guantes', 40, 3, 5)";
			myStatement3.executeUpdate(instruction3);
			
			Statement myStatement4 = conexion.createStatement();
			String instruction4 = "INSERT INTO PRODUCTOS(id, descripcion, stockactual, stockminimo, pvp) VALUES (4, 'Sombrero', 25, 2, 5)";
			myStatement4.executeUpdate(instruction4);
			
			System.out.println("Valores insertados en Productos correctamente"); 
			
			String inst = "INSERT INTO CLIENTES(id, nombre, direccion, poblacion, telef, nif) VALUES (1, 'Juli', 'Rue del Percebe 80', 'Población Inventada', '111111111', '1234')";
			myStatement.executeUpdate(inst);
			
			inst = "INSERT INTO CLIENTES(id, nombre, direccion, poblacion, telef, nif) VALUES (2, 'Paca', 'Rue del Percebe 10', 'Población Inventada', '222222', '4321')";
			myStatement.executeUpdate(inst);
			
			inst = "INSERT INTO CLIENTES(id, nombre, direccion, poblacion, telef, nif) VALUES (3, 'Cristina', 'Parque del Oeste', 'Madrid', 'No', '1234')";
			myStatement.executeUpdate(inst);
			
			inst = "INSERT INTO CLIENTES(id, nombre, direccion, poblacion, telef, nif) VALUES (4, 'Jori', 'Desconocida', 'Muy lejos', '65555555', '4444')";
			myStatement.executeUpdate(inst);
			
			System.out.println("Datos insertados en Clientes correctamente.");
		}
		
		catch(SQLException ex)
		{
			ex.printStackTrace();
		}

	}

}
