// See https://aka.ms/new-console-template for more information

Console.WriteLine("Gestor de Inventario.");
Dictionary<string, int> Inventario = new Dictionary<string, int>
{
    { "azucar", 15 },
    { "arroz", 20 },
    { "pasta", 34 },
    { "salsa", 23 },
    { "mayonesa", 12 }
};

while (true)
{
    Console.WriteLine("Menú de opciones. Por favor elije una opcion:");
    Console.WriteLine("1. Agregar producto.");
    Console.WriteLine("2. Eliminar producto.");
    Console.WriteLine("3. Actualizar cantidad.");
    Console.WriteLine("4. Mostrar inventario.");
    Console.WriteLine("5. Salir.");

    int opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Introduzca el nombre del producto:");
            string producto = Console.ReadLine();
            Console.WriteLine("Introduce la cantidad del producto:");
            int cantidad = int.Parse(Console.ReadLine());
            Inventario.Add(producto, cantidad);
            Console.WriteLine($"Producto '{producto}' agregado al inventario con cantidad {cantidad}.");
            break;

        case 2:
            Console.WriteLine("Introduzca el nombre del producto a eliminar:");
            string productoEliminar = Console.ReadLine();

            if (Inventario.ContainsKey(productoEliminar))
            {
                Inventario.Remove(productoEliminar);
                Console.WriteLine($"Producto '{productoEliminar}' eliminado del inventario.");
            }
            else
            {
                Console.WriteLine($"El producto '{productoEliminar}' no existe en el inventario.");
            }
            break;

        case 3:
            Console.WriteLine("Introduzca el nombre del producto a actualizar:");
            string productoActualizar = Console.ReadLine();

            if (Inventario.ContainsKey(productoActualizar))
            {
                Console.WriteLine("Introduzca la nueva cantidad del producto:");
                int nuevaCantidad = int.Parse(Console.ReadLine());
                Inventario[productoActualizar] = nuevaCantidad;
                Console.WriteLine($"Cantidad actualizada de '{productoActualizar}' es '{nuevaCantidad}'.");
                break;
            }
            else
            {
                Console.WriteLine($"El producto '{productoActualizar}' no existe en el inventario.");
            }
            break;

        case 4:
            Console.WriteLine("Inventario:");
            foreach (var kvp in Inventario)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            break;

        case 5:
            Console.WriteLine("¡Hasta luego!");
            return;

        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
}
