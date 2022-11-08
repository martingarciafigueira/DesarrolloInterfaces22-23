

using System;

class NombreNoValidoException : ApplicationException
{
	public NombreNoValidoException() : base("Debe teclear algo...")
	{ }
}

class Persona
{
	private string nombre;
	public Persona(string nom)
	{
		if (nom == "") // Si el constructor recibe
			throw new NombreNoValidoException(); // una cadena vacía se lanza
		else // la excepción definida
			this.nombre = nom; // si no, se asigna la cadena
	}
	public void EscribirNombre()
	{
		Console.WriteLine(nombre);
	}
}

class PruebaMisExcepciones
{
	static void Main(string[] args)
	{
		Persona p = null;
		Console.WriteLine("Teclee un nombre");
		string n = Console.ReadLine();
		try
		{
			p = new Persona(n); //Llamada al constructor de Persona
			p.EscribirNombre();
		}
		catch (NombreNoValidoException e) // Si se lanzara una excepción de esta
		{ // clase, este bloque la capturará y
			Console.WriteLine(e.Message); // escribirá: “Debe teclear algo...”
		}
		catch (Exception e) // Si se lanzara una excepción de
		{ // otro tipo, se capturará y aparecerá
			Console.WriteLine(e.Message); // el mensaje predefinido.
		}
		Console.ReadLine();
	}
}





















