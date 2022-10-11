int codigoCaracterLeido;
char caracterLeido;

//Pedimos un carácter por pantalla
Console.WriteLine("Introduce un carácter");

//Guardamos ese carácter en una variable
codigoCaracterLeido = Console.Read();
caracterLeido = (char)codigoCaracterLeido;

//Mostrar el carácter leído por pantalla
Console.WriteLine("He leído el carácter: " + caracterLeido);

Console.ReadKey();