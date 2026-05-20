using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

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
        CasoList lista = new CasoList();
        lista.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        lista.AgregarAlumno(new Alumno(2, "Marta", 9.0));
        lista.AgregarAlumno(new Alumno(3, "Miguel", 4.5));

        var listaAlumnos = lista.ObtenerLista();

        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine($"Legajo: {alumno.Id} - Nombre: {alumno.Nombre} - Promedio: {alumno.Promedio}");
        }

        lista.BuscarAlumno("Marta");

        lista.EliminarAlumno(new Alumno(0, "Miguel", 0.0));

        lista.EleiminarEliminarAlumnoIndice(0);

        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine($"Legajo: {alumno.Id} - Nombre: {alumno.Nombre} - Promedio: {alumno.Promedio}");
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
