﻿using Sistema_Gestion_Productos;

namespace Sistema_Gestion_Productos
{
    internal class Test
    {
        static void Main(string[] args)
        {

            List<Producto> listaDeProductos = new List<Producto>();

            listaDeProductos.Add(new ProductoNoPerecedero("Fideos", 15.50, "No perecedero", "Pastas"));
            listaDeProductos.Add(new ProductoNoPerecedero("Arroz", 20.75, "No perecedero", "Cereal"));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.25, "Perecedero", 4));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.25, "Perecedero", 3));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.25, "Perecedero", 2));
            listaDeProductos.Add(new ProductoPerecedero("Leche", 5.25, "Perecedero", 1));


            int cantVenta = 5;

            //listaDeProductos.ForEach(item => Console.WriteLine($"El precio final es: {item.calcularPrecioTotal(cantVenta)}"));

            foreach (var item in listaDeProductos)
            {
                double precioRound = Math.Round(item.calcularPrecioTotal(cantVenta),2);
                Console.WriteLine($"{item.mostrarDatos()} El precio final es: ${precioRound}\n");
            }
        }
    }
}
