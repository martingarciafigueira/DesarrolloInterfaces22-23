string fecha;
DateTime dtFechaEscogida;
TimeSpan diferencia;

Console.Write("Introduce una fecha: ");
fecha = Console.ReadLine();

dtFechaEscogida = DateTime.Parse(fecha);

diferencia = dtFechaEscogida - DateTime.Today;

if (diferencia < TimeSpan.Zero)
{
    Console.WriteLine("Entre la fecha escogida y hoy pasaron {0} días", Math.Abs(diferencia.Days));
}
else if (diferencia > TimeSpan.Zero)
{
    Console.WriteLine("Para la fecha escogida faltan {0} días", diferencia.Days);
}
else
{
    Console.WriteLine("Es el mismo día");
}