using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class PruebaExcepciones
    {
        class Program
        {
            static void Main(string[] args)
            {
                A obj1 = new A();
                obj1.F();
            }
        }
        class A
        {
            public void F()
            {
                int c = 0, d = 0;
                try
                {
                    c = Int32.Parse(Console.ReadLine());
                    d = 2 / c;
                }
                catch (DivideByZeroException ex)
                {
                    d = 0;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }
                Console.WriteLine(d);
            }
        }
    }
}





