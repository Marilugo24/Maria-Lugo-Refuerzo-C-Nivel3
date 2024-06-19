// See https://aka.ms/new-console-template for more information

Console.WriteLine("Juego de Dados");
Random random = new Random();

int LanzarDado()
{
    return random.Next(1, 6);
}

while (true)
{
    int resultado1 = LanzarDado();
    int resultado2 = LanzarDado();

    Console.WriteLine($"Lanzamiento 1: {resultado1}");
    Console.WriteLine($"Lanzamiento 2: {resultado2}");

    Console.WriteLine("¿Quieres lanzar los dados de nuevo? (s/n): ");
    string respuesta = Console.ReadLine();
    if (respuesta.ToLower() != "s")
        break;
}