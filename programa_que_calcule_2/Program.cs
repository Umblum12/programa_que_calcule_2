using System;

namespace programa_que_calcule_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            int Cal1, Cal2, Cal3, promedio;
            //ingresar los valores de variables
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Ingresa la primer calificacion: ");
            Cal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda calificacion: ");
            Cal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la tercer calificacion: ");
            Cal3 = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            //Colocar el procedimiento
            promedio = (Cal1 + Cal2 + Cal3) / 3;
            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("El promedio de las tres calificaciones la calificacion 1 es: " + Cal1 + " + " + " la calificacion 2 es: " + Cal2 + " + " + "la calificacion 3 es: " + Cal3 + " entre 3 es: " + promedio);
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
