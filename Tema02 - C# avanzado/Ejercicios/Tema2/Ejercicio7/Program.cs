using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorhr, hrstrab, antiguedad;
            string nombre;

            Console.Write("Nombre:");
            nombre = Console.ReadLine();

            Console.Write("Valor hora:");
            valorhr = float.Parse(Console.ReadLine());

            Console.Write("Antiguedad:");
            antiguedad = float.Parse(Console.ReadLine());

            Console.Write("Horas trabajadas:");
            hrstrab = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Antiguedad: {0}", antiguedad);
            Console.WriteLine("Valor hora: {0}", valorhr);
            Console.WriteLine("Total a cobrar: {0}", valorhr * hrstrab + antiguedad);
            Console.Read();
        }
    }
}
