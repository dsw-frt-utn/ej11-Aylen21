using Dsw2026Ej11.Domain;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{

     List<Libro> libros = Libro.CrearLista();



    public  void GetPrimero(List<Libro> libros) {

        var primero = libros.FirstOrDefault();
        Console.WriteLine("Primer Elemento: ");
        Console.WriteLine(primero?.ToString());

    }
    public void GetUltimo(List<Libro> libros)
    {

        var ultimo = libros.LastOrDefault();
        Console.WriteLine("Ultimo Elemento: ");
        Console.WriteLine(ultimo?.ToString());

    }


    public void GetTotalPrecios(List<Libro> libros) { 
    
    decimal suma = libros.Sum(p => p.Precio);
    Console.WriteLine($"La suma de precios es:{suma}");
    
    }
    public static void GetPromedioPrecios(List<Libro> libros, out decimal promedio) { 
    
    promedio =  libros.Average(p => p.Precio);
        Console.WriteLine($"El promedio de los precios es:{promedio:F2}");

    }


    public void GetListById(List<Libro> libros) {

        var libroFiltrado = libros.Where(p => p.Id > 15);
        Console.WriteLine("Libros con ID mayor a 15:\n");
        foreach (var p in libroFiltrado) {

            Console.WriteLine(p.ToString());

        }
    }

        public void GetLibros(List<Libro> libros) {

        var cultura = CultureInfo.GetCultureInfo("es-AR");
        var librosFormateados = libros.Select(p => $"ID:{p.Id} - Titulo:{p.Titulo} - Precio:{p.Precio.ToString("C2",cultura)}").ToList();
        Console.WriteLine("Libros con Formato");
        foreach (var item in librosFormateados)
        {
            Console.WriteLine(item);
        }
    
    }

    public void GetMayorPrecio(List<Libro> libros) {


        decimal precioMayor = libros.Max(p => p.Precio);

        Libro libroMayor = libros.FirstOrDefault(p => p.Precio == precioMayor);

        Console.WriteLine("Libro más caro:");
        Console.WriteLine(libroMayor);

    }

    public void GetMenorPrecio(List<Libro> libros) {


        decimal precioMenor = libros.Min(p => p.Precio);

        Libro libroMenor = libros.FirstOrDefault(p => p.Precio == precioMenor);

        Console.WriteLine("Libro menos caro:");
        Console.WriteLine(libroMenor);


    }
    public void GetMayorPromedio(List<Libro> libros, decimal promedio) {

        Console.WriteLine($"Libro con precio mayor al promedio:{promedio} ");
        foreach (var p in libros) {
            if (p.Precio > promedio) {

                Console.WriteLine(p.ToString());
            
            }
        
        
        
        }
    
    
    }



    public void OrdenadosPorTitulo(List<Libro> libros)
    {

        var librosOrdenados = libros.OrderByDescending(p => p.Titulo).ToList();
        Console.WriteLine("Libros Ordenados descendientemente por titulo");
        foreach (var p in librosOrdenados) {
            Console.WriteLine(p.ToString());
        
        }

    }


}

