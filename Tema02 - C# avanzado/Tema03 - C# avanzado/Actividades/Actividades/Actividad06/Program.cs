using System;

namespace Actividad06
{
    class Program
    {
        static void Main(string[] args)
        {
            string terminos;
            int numTerminos, elemento1 = 0, auxiliar, elemento2 = 1;
            Console.WriteLine("Introduce cuántos términos quieres de la sucesión de Fibonacci:");
            terminos = Console.ReadLine();
            int.TryParse(terminos, out numTerminos);

            for (int i = 0; i < numTerminos; i++)
            {
                auxiliar = elemento1;
                elemento1 = elemento2;
                elemento2 = auxiliar + elemento1;
                Console.WriteLine("Termino: {0}", elemento1);
            }
            Console.ReadKey();
        }
    }
}
