//Definimos las variables
char tipoOperacion;
double valor1, valor2, resultadoFinal;


Console.WriteLine("Introduce el valor 1: ");
double.TryParse(Console.ReadLine(), out valor1);

Console.WriteLine("Introduce el valor 2: ");
double.TryParse(Console.ReadLine(), out valor2);

Console.WriteLine("Introduce el tipo de operación: ");
tipoOperacion = (char)Console.Read();

resultadoFinal = calcular(tipoOperacion, valor1, valor2);

Console.WriteLine("El resultado final sería: " + resultadoFinal);

Console.ReadKey();

double calcular(char c, double op1, double op2)
{
    if (c == '+')
    {
        return op1 + op2;
    }
    else if (c == '-')
    {
        return op1 - op2;
    }
    else
    {
        return Double.MaxValue;
    }

    return -1;
}

m[0];