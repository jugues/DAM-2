package PruebaJaxb;
import java.util.List;
import javax.xml.bind.annotation.*;

@XmlRootElement
public class Departamento {
	
	private List<Empleado> empleados;
	
	public Departamento() {}

	public List<Empleado> getEmpleados() {
		return empleados;
	}

	@XmlElement(name="empleado")
	public void setEmpleados(List<Empleado> empleados) {
		this.empleados = empleados;
	}
	
	

}
