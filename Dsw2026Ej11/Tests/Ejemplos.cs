using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Xml.Linq;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

    }

    
   

    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();

        //Agregar 3 alumnos al diccionario
        caso.AgregarAlumno(58200, new Alumno(1, "Ana", 8.5));
        caso.AgregarAlumno(58274, new Alumno(2, "Juan", 7.8));
        caso.AgregarAlumno(57021, new Alumno(3, "Pedro", 9.1));
        //Listar por consola los alumnos

        Console.WriteLine("================LISTA DE ALUMNOS==============");

        foreach (var alu in caso.RetonarDiccionario()) {

            Console.WriteLine($"Legajo: {alu.Key} - Nombre: {alu.Value}");

        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("================Buscando alumno con legajo 58200==============");
        if (caso.BuscarAlumno(58200) != null)
        {

            Alumno encontrado = caso.BuscarAlumno(58200);
            Console.WriteLine($"El alumno encontrado es: {encontrado.Nombre} ");


        }
        else {
            Console.WriteLine("El alumno no existe");

        
        }

        Console.WriteLine("================Buscando alumno con legajo 58208 (Inexistente).............");
        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"

        if (caso.BuscarAlumno(58208) != null)
        {

            Alumno encontrado = caso.BuscarAlumno(58200);
            Console.WriteLine($"El alumno encontrado es: {encontrado.Nombre} ");


        }
        else
        {
            Console.WriteLine("El alumno no existe");


        }

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("Eliminando alumno con legajo 58200.................");
        
        if (caso.EliminarAlumno(58200) == true)
        {


            Console.WriteLine("Alumno eliminado");


        }
        else {

            Console.WriteLine("No se pudo eliminar alumno ");
        }
        Console.WriteLine("================Lista de Alumnos Actualizada ==============");

        foreach (var alu in caso.RetonarDiccionario())
        {

            Console.WriteLine($"Legajo: {alu.Key} - Nombre: {alu.Value}");

        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
