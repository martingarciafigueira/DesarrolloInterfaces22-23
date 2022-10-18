using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            bool flag = true;

            //Llenamos el array
            for (int i = 0; i < 10; i++)
            {
                int numeroPantalla;

                flag = int.TryParse(Console.ReadLine(), out numeroPantalla);

                if (flag)
                {
                    numeros[i] = numeroPantalla;
                }
                else
                {
                    Console.WriteLine("Ha introducido texto!");
                    break;
                }
            }

            if (flag)
            {
                //
                foreach (int numero in numeros)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado;
                        resultado = numero * i;

                        Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
                    }
                } 
            }
            Console.ReadKey();
        }
    }
}
