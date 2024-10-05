using Sistema_Gestion_Productos;

namespace Sistema_Gestion_Productos
{
    internal class Test
    {
        static void Main(string[] args)
        {

            List<Producto> listaDeProductos = new List<Producto>();

            listaDeProductos.Add(new ProductoNoPerecedero("Fideos", 15.0, "No perecedero", "Pastas"));
            listaDeProductos.Add(new ProductoNoPerecedero("Arroz", 20.0, "No perecedero", "Cereal"));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.0, "Perecedero", 4));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.0, "Perecedero", 3));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.0, "Perecedero", 2));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.0, "Perecedero", 1));

            //listaDeProductos.ForEach(item => Console.WriteLine($"El precio final es: {item.calcularPrecioTotal(5)}"));

            int cantVenta = 5;

            foreach (var item in listaDeProductos)
            {
                double precioRound = Math.Round(item.calcularPrecioTotal(cantVenta));
                Console.WriteLine($"{item.mostrarDatos()} El precio final es: ${precioRound}\n");

            }
        }
    }
}
