char[] caracteres = new char[10];
char caracterLeido;
string cadenaLeida;

for (int i = 0; i < caracteres.Length; i++)
{
    Console.WriteLine("Introduce un caracter: ");
    cadenaLeida = Console.ReadLine();
    caracterLeido = cadenaLeida[0];

    if (char.IsLetter(caracterLeido))
    {
        caracteres[i] = (char)caracterLeido;
    }
}

//Hacemos las operaciones que nos piden
Console.WriteLine("Mostramos los caracteres en mayusculas");
foreach (char caracter in caracteres)
{
    Console.Write(char.ToUpper(caracter) + " ");
}
Console.WriteLine();    

Console.WriteLine("Concatenamos los caracteres en una cadena de texto");

Console.Write(string.Concat(caracteres));

Console.ReadLine();