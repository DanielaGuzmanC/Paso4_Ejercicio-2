//Nombre del estudiante:Daniela Guzman+
//Grupo: 213022_386
//Numero y texto del progrma:El colegio SUAREZ requiere un programa que permita hallar la calificación promedio de sus estudiantes así: Por teclado se debe solicitar la cantidad de usuarios a valorar. Se requiere captura por teclado de nombre y calificación (siendo la calificación un número entero de 1 a 10). Se debe calcular e imprimir en consola el valor de la calificación
//promedio, máxima y mínima de los estudiantes. Se debe implementar una función que reciba como parámetro las calificaciones de los estudiantes, calcule y retorne la calificación maxima.
//Codigo de fuente:
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de estudiantes a valorar:");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        int sumaCalificaciones = 0;
        int calificacionMaxima = int.MinValue;
        int calificacionMinima = int.MaxValue;

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del estudiante (1-10):");
            int calificacion = int.Parse(Console.ReadLine());

            sumaCalificaciones += calificacion;
            calificacionMaxima = Math.Max(calificacionMaxima, calificacion);
            calificacionMinima = Math.Min(calificacionMinima, calificacion);
        }

        double promedio = (double)sumaCalificaciones / cantidadEstudiantes;

        Console.WriteLine("Calificación promedio: " + promedio);
        Console.WriteLine("Calificación máxima: " + calificacionMaxima);
        Console.WriteLine("Calificación mínima: " + calificacionMinima);
    }
}