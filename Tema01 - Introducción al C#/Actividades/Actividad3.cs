
using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo las variables para guardar los dos operandos
            int numero1 = 0; int numero2 = 0;

            Console.WriteLine("Calculadora en C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Marca un número, y después pulsa Enter");

            #region Guardo los operandos
            //Guardo el primer operando
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marca otro número, y después pulsa Enter");
            //Guardo el segundo operando
            numero2 = Convert.ToInt32(Console.ReadLine()); 
            #endregion

            #region Muestro las opciones
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Qué eliges?"); 
            #endregion

            #region Selecciono una opción y realizo la operación correspondiente

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado: {numero1} + {numero2} = " + (numero1 + numero2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado: {numero1} - {numero2} = " + (numero1 - numero2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {numero1} * {numero2} = " + (numero1 * numero2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {numero1} / {numero2} = " + (numero1 / numero2));
                    break;
            } 
            #endregion

            Console.Write("Pulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}





