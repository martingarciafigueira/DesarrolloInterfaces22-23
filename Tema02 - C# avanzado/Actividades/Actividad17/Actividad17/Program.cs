//Ejemplo de clave: A4723%

string passSeguro = "";

//Creamos el objeto que nos permita generar valores aleatorios
Random random = new Random();

//Generamos 1 letra mayúscula
passSeguro += (char)random.Next('A', 'Z' + 1);

//Generamos entre 6 y 8 digitos aleatorios
int numeroDeDigitosAleatorios = random.Next(6,9);

for (int i = 0; i < numeroDeDigitosAleatorios; i++)
{
    passSeguro += random.Next(0, 10);
}

//Generamos 1 símbolo
passSeguro += (char)random.Next(33, 48);

//Generamos 2 letras minúsculas
passSeguro += (char)random.Next('a', 'z' + 1);
passSeguro += (char)random.Next('a', 'z' + 1);

Console.WriteLine("Nuestro pass seguro es: " + passSeguro);
Console.ReadLine();