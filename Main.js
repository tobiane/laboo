import java.util.Scanner;
import java.util.ArrayList;


public class Main {
   static Persona p1;
   static ArrayList<Persona> personas = new ArrayList<>();


   static void promedio(){
       float promedio = 0;
       int contador = 0;
       for (int i=0;i<personas.size();i++){
           p1=personas.get(i);
           contador +=p1.Edad();
       }
       promedio = contador/personas.size();
       System.out.println("el promedio es " + promedio);
   }


   static void mayor(){
       int mayor = personas.get(0).Edad();
       for (int i=1;i<personas.size();i++){
           if (mayor < personas.get(i).Edad()) {
               mayor = personas.get(i).Edad();
           }


       }
       System.out.println("el mayor tiene " + mayor + " años");
   }


   static void menor(){
       int menor = personas.get(0).Edad();
       for (int i=1;i<personas.size();i++){
           if (menor > personas.get(i).Edad()) {
               menor = personas.get(i).Edad();
           }


       }
       System.out.println("el menor tiene " + menor + " años");
   }




   public static void main(String[] args) {
       Scanner escribir = new Scanner(System.in);
       for (int i = 0; i < 3; i++) {
           System.out.println("Ingrese los datos de la " +(i + 1)+  " persona:");
           System.out.print("Nombre: ");
           String nombre = escribir.nextLine();
           System.out.print("Fecha de nacimiento (dd/mm/yyyy): ");
           String fechaNacimiento = escribir.nextLine();
           p1 = new Persona(nombre, fechaNacimiento);
           personas.add(p1);
       }
       System.out.println("Datos de las personas:");
       for (int i = 0; i < personas.size(); i++) {
           p1 = personas.get(i);
           System.out.println(p1.nombre + " nació el " + p1.fechadenac + " y tiene " + p1.Edad() + " años");
       }


       mayor();
       promedio();
       menor();
   }
}
