using System;
using System.Text;

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres = new char[10];
            StringBuilder sb = new StringBuilder();

            //Llenamos el array
            for (int i = 0; i < 10; i++)
            {
                caracteres[i] = (char)Console.Read();
            }

            foreach (char caracter in caracteres)
            {
                char caracterMayus;
                caracterMayus = char.ToUpper(caracter);

                sb.Append(caracterMayus);
            }

            Console.WriteLine("La cadena final es: " + sb);
            Console.ReadKey();
        }
    }
}
