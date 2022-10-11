//Crear el array
bool conversionCorrecta = false;
string cadenaAConvertir;
float[] arrayNumeros = new float[10];

//Rellenar el array
for (int i = 0; i < arrayNumeros.Length; i++)
{
    Console.Write("Introduce el " + (i + 1) +" número: ");
    cadenaAConvertir = Console.ReadLine();
    conversionCorrecta = float.TryParse(cadenaAConvertir, out arrayNumeros[i]);

    if (!conversionCorrecta)
    {
        Console.WriteLine("ERROR al convertir: " + cadenaAConvertir);
        break;
    }
}

if (conversionCorrecta)
{
    //Mostramos el array por pantalla
    foreach (float numero in arrayNumeros)
    {
        Console.WriteLine("Tabla del " + numero);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }
        Console.WriteLine();
    } 
}

Console.ReadLine();