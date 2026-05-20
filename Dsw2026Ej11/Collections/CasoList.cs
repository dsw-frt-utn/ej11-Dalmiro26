using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }

    public void BuscarAlumno(string alumno)
    {
        Alumno coincidencia = alumnos.Find(alu => alu.Nombre == alumno);

        if (coincidencia != null)
            Console.WriteLine($"Alumno encontrado: {coincidencia.Id} - {coincidencia.Nombre}");

        else
            Console.WriteLine("Alumno no encontrado.");
    }

    public void EliminarAlumno(Alumno alumno)
    {
        Alumno coincidencia = alumnos.Find(alu => alu.Nombre == alumno.Nombre);

        if (coincidencia != null)
        {
            alumnos.Remove(coincidencia);
            Console.WriteLine($"Alumno eliminado: {alumno}");
        }

        else
            Console.WriteLine("Alumno no encontrado.");
    }

    public void EleiminarEliminarAlumnoIndice(int indice)
    {
        if (indice >= 0 && indice < alumnos.Count)
        {
            Alumno alumno = alumnos[indice];
            alumnos.RemoveAt(indice);
            Console.WriteLine($"Alumno eliminado: {alumno.Nombre}");
        }

        else
            Console.WriteLine("Alumno no encontrado.");
    }
}
