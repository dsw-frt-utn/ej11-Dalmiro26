using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, string> claves = new Dictionary<int, string>();

    public void AgregarAlumno(Alumno alumno)
    {
        claves.Add(alumno.Id, alumno.Nombre);
    }

    public void BuscarAlumno(int legajo)
    {
        if (claves.TryGetValue(legajo, out string alumno))
            Console.WriteLine($"Alumno encontrado: {alumno} con legajo {legajo}");
        else
            Console.WriteLine("No existe.");
    }

    public Dictionary<int, string> ObtenerDiccionario()
    {
        return claves;
    }

    public void EliminarAlumno(int legajo)
    {
        if (claves.Remove(legajo))
            Console.WriteLine($"Legajo de alumno eliminado: {legajo}");
        else
            Console.WriteLine("Alumno no encontrado.");
    }
}
