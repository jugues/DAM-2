package PruebaJaxb;
import java.io.File;
import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.*;

public class Main {

	public static void main(String[] args) {
		
		crearXml();
		leerXml();

	}
	
	public static void crearXml()
	{
		try
		{
			List<Empleado> empleados = new ArrayList<>();
			Empleado emp = new Empleado(); 
			emp.setIdEmpleado(100);
			emp.setNombre("Juanito");
			emp.setPaterno("García");
			emp.setMaterno("Pachecho");
			empleados.add(emp);
			
			emp = new Empleado();
			emp.setIdEmpleado(200);
			emp.setNombre("Manolito");
			emp.setPaterno("Gafotas");
			emp.setMaterno("Arroyo");
			empleados.add(emp);
			
			Departamento depart = new Departamento(); 
			depart.setEmpleados(empleados);
			
			//JAXB context 
			JAXBContext ctx = JAXBContext.newInstance(Departamento.class);
			Marshaller ms = ctx.createMarshaller();
			ms.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
			ms.marshal(depart, new File("C:\\Users\\Juli\\Desktop\\Programas\\Eclipse Workspace\\AccesoDatos\\src\\PruebaJaxb\\escritura.xml"));
		}
		
		catch(JAXBException e)
		{
			e.getMessage();
		}
	}
	
	public static void leerXml()
	{
		try
		{
			JAXBContext ctx = JAXBContext.newInstance(Departamento.class);
			Unmarshaller um = ctx.createUnmarshaller();
			Departamento depart = (Departamento)um.unmarshal(new File("C:\\Users\\Juli\\Desktop\\Programas\\Eclipse Workspace\\AccesoDatos\\src\\PruebaJaxb\\lectura.xml"));
			
			for(Empleado emp: depart.getEmpleados())
			{
				System.out.println("Id: " + emp.getIdEmpleado() + " --Nombre: " + emp.getNombre() + " --1er apellido: " + emp.getPaterno() + "--2º apellido:" + emp.getMaterno());
			}
		}
		catch(Exception ex)
		{
			ex.getMessage();
			//Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
		}
	}

}
