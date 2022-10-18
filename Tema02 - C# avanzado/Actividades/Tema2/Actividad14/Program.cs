using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres = new char[10];
            string cadenaTextoFinal = "";

            //Llenamos el array
            for (int i = 0; i < 10; i++)
            {
                caracteres[i] = (char)Console.Read();
            }

            foreach (char caracter in caracteres)
            {
                char caracterMayus;
                caracterMayus = char.ToUpper(caracter);

                cadenaTextoFinal += caracterMayus + " ";
            }

            Console.WriteLine("La cadena final es: " + cadenaTextoFinal);
            Console.ReadKey();
        }
    }
}
