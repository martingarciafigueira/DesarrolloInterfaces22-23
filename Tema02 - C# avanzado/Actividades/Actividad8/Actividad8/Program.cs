string nombre;
int edad;

//Pedimos un dato por pantalla
Console.WriteLine("Introduce tu nombre:");
nombre = Console.ReadLine();
Console.WriteLine("El nombre introducido es: " + nombre);

Console.WriteLine("Introduce tu edad:");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Tu edad es: " + edad);

Console.WriteLine("a", edad);

Console.ReadLine();