using System;

namespace Actividad5
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan nuevo = new TimeSpan(1606758024);


            Random generador = new Random();
            string pass = "";

            //Generamos una letra mayúscula
            pass = ((char)generador.Next('A', 'Z' + 1)).ToString();

            //Generamos entre 6 y 8 dígitos aleatorios
            int longitudNumeros = generador.Next(6, 9);
            for (int i = 0; i < longitudNumeros; i++)
            {
                pass = pass + generador.Next(0,10);
            }

            //Generamos un símbolo aleatorio
            pass = pass + (char)generador.Next('!', '?' + 1);

            Console.WriteLine(pass);
            Console.ReadKey();
        }
    }
}
