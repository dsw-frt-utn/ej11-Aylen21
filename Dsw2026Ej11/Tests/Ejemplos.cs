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
        CasoList casoList = new CasoList();

        casoList.AgregarAlumno(new Alumno(0, "Sofia", 8.5));
        casoList.AgregarAlumno(new Alumno(1, "Lara", 7.8));
        casoList.AgregarAlumno(new Alumno(2, "Aylen", 9.1));
        Console.WriteLine("================LISTA DE ALUMNOS==============");

        foreach (var alu in casoList.RetornarLista())
        {
            Console.WriteLine(alu);
        }
        Console.WriteLine("================Buscando alumno con nombre Lara==============");

        if (casoList.BuscarAlumnoPorNombre("Lara") != null)
        {

            Console.WriteLine(casoList.BuscarAlumnoPorNombre("Lara"));

        }
        else {

            Console.WriteLine("El alumno no existe");


        }
        Console.WriteLine("================Buscando alumno con nombre Jorge (Inexistente).............");

        if (casoList.BuscarAlumnoPorNombre("Jorge") != null)
        {

            Console.WriteLine(casoList.BuscarAlumnoPorNombre("Jorge"));

        }
        else
        {

            Console.WriteLine("El alumno no existe");


        }
        Console.WriteLine("Eliminando alumno con nombre Lara.................");



        Alumno? eliminado = casoList.BuscarAlumnoPorNombre("Lara");
        if (eliminado != null)
        {
            casoList.EliminarAlumno(eliminado);
            Console.WriteLine("Alumno eliminado");
        }
        else {

            Console.WriteLine("El alumno no existe");
        }
        Console.WriteLine("===========Lista luego de eliminar a Lara:===============");
        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        casoList.EliminarPorPosicion(0);
        Console.WriteLine("===========Lista luego de eliminar el primer elemento ===============");
        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }



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

        CasoLinq casoLinq = new CasoLinq();
        List<Libro> libros = Libro.CrearLista();
        casoLinq.GetPrimero(libros);
        Console.WriteLine();


        casoLinq.GetUltimo(libros);
        Console.WriteLine();


        casoLinq.GetTotalPrecios(libros);
        Console.WriteLine();

        decimal promedio;
        CasoLinq.GetPromedioPrecios(libros, out promedio);
        Console.WriteLine();

        casoLinq.GetListById(libros);
        Console.WriteLine();

        casoLinq.GetLibros(libros);
        Console.WriteLine();

        casoLinq.GetMayorPrecio(libros);
        Console.WriteLine();


        casoLinq.GetMenorPrecio(libros);
        Console.WriteLine();

        casoLinq.GetMayorPromedio(libros, promedio);
        Console.WriteLine();

        casoLinq.OrdenadosPorTitulo(libros);
    }
}
