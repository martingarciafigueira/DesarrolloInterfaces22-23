﻿using System;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int calificacion1 = 39, calificacion2 = 62;
            double notapromedio;

            notapromedio = (double) (calificacion1 + calificacion2) / 2;

            Console.WriteLine("La nota final es: " + notapromedio); //La nota final es 50
        }
    }
}
