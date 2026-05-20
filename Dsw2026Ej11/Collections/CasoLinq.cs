using Dsw2026Ej11.Domain;
using System;
using System.Linq;

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
    public void GetPrimero()
    {
        string primerLibro = Libro.CrearLista().Select(lib => lib.Titulo).First();
        Console.WriteLine($"El primer libro es: {primerLibro}");
    }

    public void GetUltimo()
    {
        string ultimoLibro = Libro.CrearLista().Select(lib => lib.Titulo).Last();
        Console.WriteLine($"El primer libro es: {ultimoLibro}");
    }

    public void GetTotalPrecios()
    {
        decimal totalPrecios = Libro.CrearLista().Sum(lib => lib.Precio);
        Console.WriteLine($"La suma de los precios es: {totalPrecios.ToString("C")}");
    }

    public void GetPromedioPrecios()
    {
        decimal promedioPrecios = Libro.CrearLista().Average(lib => lib.Precio);
        Console.WriteLine($"El promedio de los precios es: {promedioPrecios.ToString("C")}");
    }

    public void GetLISTById()
    {
        var librosMayor15 = Libro.CrearLista().Where(lib => lib.Id > 15).ToList();
        Console.WriteLine("Libros con Id mayor a 15:");
        foreach (var libro in librosMayor15)
        {
            Console.WriteLine($"Id: {libro.Id} - Titulo: {libro.Titulo} - Precio: {libro.Precio.ToString("C")}");
        }
    }

    public void GetLibros()
    {
        var librosFormateados = Libro.CrearLista().Select(lib => $"{lib.Titulo} - {lib.Precio.ToString("C")}").ToList();
        Console.WriteLine("Libros con título y precio formateado:");
        foreach (var libro in librosFormateados)
        {
            Console.WriteLine(libro);
        }
    }

    public void GetMayorPrecio()
    {
        var libroMayorPrecio = Libro.CrearLista().OrderByDescending(lib => lib.Precio).First();
        Console.WriteLine($"El libro con el precio más alto es: {libroMayorPrecio.Titulo}");
    }

    public void GetMenorPrecio()
    {
        var libroMenorPrecio = Libro.CrearLista().OrderBy(lib => lib.Precio).First();
        Console.WriteLine($"El libro con el precio más bajo es: {libroMenorPrecio.Titulo}");
    }

    public void GetMayorPromedio()
    {
        decimal promedioPrecios = Libro.CrearLista().Average(lib => lib.Precio);
        var librosMayorPromedio = Libro.CrearLista().Where(lib => lib.Precio > promedioPrecios).ToList();
        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (var libro in librosMayorPromedio)
        {
            Console.WriteLine($"Titulo: {libro.Titulo}");
        }
    }

    public void GetLibrosOrdenadosDescendnente()
    {
        var librosOrdenados = Libro.CrearLista().OrderByDescending(lib => lib.Titulo).ToList();
        Console.WriteLine("Libros ordenados por título de forma descendente:");
        foreach (var libro in librosOrdenados)
        {
            Console.WriteLine($"Id: {libro.Id} - Titulo: {libro.Titulo} - Precio: {libro.Precio.ToString("C")}");
        }
    }
}
