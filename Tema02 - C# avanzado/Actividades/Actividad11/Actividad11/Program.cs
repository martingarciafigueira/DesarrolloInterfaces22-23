//Defino las variables
double numeroRecibido, resultadoFinal;

Console.WriteLine("Vamos a calcular el cuadrado de un número");
Console.Write("Introduce un número: ");

double.TryParse(Console.ReadLine(), out numeroRecibido);

resultadoFinal = Math.Pow(numeroRecibido, 2);

Console.WriteLine("El cuadrado de ese número es: " + resultadoFinal);

Console.ReadLine();
