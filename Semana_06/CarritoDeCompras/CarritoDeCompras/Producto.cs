using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    internal class Producto
    {
        public int Id { get; private set; }
        public String Nombre { get; private set; }
        public double PrecioUnitario { get; private set; }
        public int Cantidad { get; private set; }

        public Producto(int id, String nombre, double precioUnitario, int cantidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.PrecioUnitario = precioUnitario;
            this.Cantidad = cantidad;
        }
    }
}
