import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

class Persona {
    String nombre;
    LocalDate fechaNacimiento;

    public Persona(String nombre, String fechaNacimiento) {
        this.nombre = nombre;
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        this.fechaNacimiento = LocalDate.parse(fechaNacimiento, formatter);
    }

    public int calcularEdad() {
        LocalDate ahora = LocalDate.now();
        return ahora.getYear() - this.fechaNacimiento.getYear();
    }
}