
using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEquipo = "Montecastelo FC";
            bool isJugadorExpulsado = true;
            DateTime fechaNacimiento = Convert.ToDateTime("12/02/1991 23:13:22");
            long numeroSeguridadSocial = 1234567878552;

            string cadenaNumero = "123";
            //int numero;
            bool todoBien = false;

            todoBien = int.TryParse(cadenaNumero, out int numero);

            if (todoBien == true)
            {
                Console.WriteLine("")
            }
        }
    }
}





