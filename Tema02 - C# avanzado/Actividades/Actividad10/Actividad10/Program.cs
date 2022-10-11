//Creamos las variables
string nombre, apellidos, fechaNacimiento;
int edad;

//Pedimos las variables
Console.Write("Introduce tu nombre: ");
nombre = Console.ReadLine();

Console.Write("Introduce tus apellidos: ");
apellidos = Console.ReadLine();

Console.Write("Introduce tu fecha de nacimiento: ");
fechaNacimiento = Console.ReadLine();

Console.Write("Introduce tu edad: ");
int.TryParse(Console.ReadLine(), out edad);

//Mostramos las variables por pantalla
Console.WriteLine("Tu nombre es: " + nombre);
Console.WriteLine("Tus apellidos son: " + apellidos);
Console.WriteLine("Tu fecha de nacimiento es: " + fechaNacimiento);
Console.WriteLine("Tu edad es: " + edad);

Console.ReadKey();