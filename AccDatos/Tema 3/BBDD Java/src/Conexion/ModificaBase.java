package Conexion;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

public class ModificaBase {

	public static void main(String[] args) {
		
		try {
			
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/ejemplo", "root", "root");
			System.out.println("conecta\n");
			
			Statement myStatement = conexion.createStatement();
			String instruction = "INSERT INTO DEPART(dept_no, dnombre, loc) VALUES (14, 'RRHH', 'Velilla')";
			myStatement.executeUpdate(instruction);
			System.out.println("Datos insertados correctamente.");
			instruction = "UPDATE DEPART SET DEPT_NO = 11 WHERE DEPT_NO = 20";
			myStatement.executeUpdate(instruction);
			System.out.println("DEPARTAMENTO ACTUALIZADO");
			instruction = "UPDATE DEPART SET DEPT_NO = 20 WHERE DEPT_NO = 11";
			myStatement.executeUpdate(instruction);
			System.out.println("DEPARTAMENTO RESTABLECIDO A ESTADO ANTERIOR");
			instruction = "DELETE FROM DEPART WHERE DEPT_NO = 14";
			myStatement.executeUpdate(instruction);
			System.out.println("Recursos Humanos borrado.");
			
			conexion.close(); 
		} catch (SQLException cn) {
			cn.printStackTrace();
		}

	}

}
