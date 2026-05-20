namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, string> claves = new Dictionary<int, string>();

    public void AgregarAlumno(int legajo, string alumno)
    {
        claves.Add(legajo, alumno);
    }

    public void BuscarAlumno(int legajo)
    {
        foreach (KeyValuePair<int, string> element in claves)
        {
            
        }
    }

}
