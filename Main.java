import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    static ArrayList<Persona> personas = new ArrayList<>();

    static void Mayor() {
        Persona mayor = personas.get(0);
        for (int i = 1; i < personas.size(); i++) {
            Persona personaActual = personas.get(i);
            if (personaActual.calcularEdad() > mayor.calcularEdad()) {
                mayor = personaActual;
            }
        }
        System.out.println(mayor.nombre + " es el mayor con " + mayor.calcularEdad() + " años.");
    }

    static void Menor() {
        Persona menor1 = personas.get(0);
        Persona menor2 = personas.get(1);

        if (menor2.calcularEdad() < menor1.calcularEdad()) {
            Persona temp = menor1;
            menor1 = menor2;
            menor2 = temp;
        }

        for (int i = 2; i < personas.size(); i++) {
            Persona personaActual = personas.get(i);

            if (personaActual.calcularEdad() < menor1.calcularEdad()) {
                menor2 = menor1;
                menor1 = personaActual;
            } else if (personaActual.calcularEdad() < menor2.calcularEdad()) {
                menor2 = personaActual;
            }
        }
        System.out.println(menor1.nombre + " es el menor con " + menor1.calcularEdad() + " años.");
        System.out.println(menor2.nombre + " es el segundo menor con " + menor2.calcularEdad() + " años.");
    }


    static void Promedio() {
        float promedio = 0;
        int contador = 0;
        for (int i = 0; i < personas.size(); i++) {
            Persona p1 = personas.get(i);
            contador += p1.calcularEdad();
        }
        promedio = (float) contador / personas.size();
        System.out.println("El promedio de edad es " + promedio);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < 3; i++) {
            System.out.print("Ingrese el nombre: ");
            String nombre = scanner.nextLine();

            System.out.print("Ingrese su fecha de nacimiento (DD/MM/AAAA): ");
            String fechaNacimiento = scanner.nextLine();

            Persona persona = new Persona(nombre, fechaNacimiento);
            personas.add(persona);

            System.out.println(nombre + " nacio " + fechaNacimiento + ".");
        }

        scanner.close();

        Mayor();
        Menor();
        Promedio();
    }
}