using OperacionesAritmeticas;

var operaciones = new List<IOperacion>()
{
    new Suma(7, 8),
    new Resta(20, 6),
    new Multiplicacion(10, 12),
    new Division(60, 45)
};

Console.WriteLine("Resultado de las operaciones:\n");

foreach(var operacion in operaciones)
{
    Console.WriteLine($"{operacion}");
    Console.WriteLine($"{operacion.GetOperacion()}");
}
