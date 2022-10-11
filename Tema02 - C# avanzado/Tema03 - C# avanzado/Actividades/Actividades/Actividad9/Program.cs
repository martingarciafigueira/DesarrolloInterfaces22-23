using System;
using Matematicas;
using Fisica;

namespace Matematicas
{
    public class Calculo { }
    class Estadistica { }
}

namespace Fisica
{
    class Calculo { }
    class Energia { }
    class Informatica { }
}

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematicas.Calculo var1 = new Matematicas.Calculo();
            Fisica.Calculo var2 = new Fisica.Calculo();
        }
    }
}
