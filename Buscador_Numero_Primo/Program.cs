// See https://aka.ms/new-console-template for more information

Console.WriteLine("Buscador de Números Primos.");
bool EsPrimo(int numero)
{
    if (numero < 1)
        return false;

   for (int i = 2; i * i <= numero; i++)
    {
        if (numero % i == 0)
            return false;
    }

    return true;
}

Console.WriteLine("Por favor ingresa el número inicial del rango:");
int inicio = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor ingresa el número final del rango:");
int fin = int.Parse(Console.ReadLine());

List<int> PrimosEncontrados = new List<int>();

for (int numero = inicio; numero <= fin; numero++)
{
    if (EsPrimo(numero))
        PrimosEncontrados.Add(numero);
}

Console.WriteLine("Números primos encontrados:");
foreach (int primo in PrimosEncontrados)
{
    Console.WriteLine(primo + " ");
}

