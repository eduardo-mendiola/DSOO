using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    internal class Sistema
    {
        public string RazonSocial { get; private set; }
        public List<Producto> Productos { get; private set; }
        public Carrito Carrito { get; private set; }
        public int IdUltimoCarrito { get; private set; }
        public int IdUltimoProducto { get; private set; }

        public Sistema(string razonSocial)
        {
            this.RazonSocial = razonSocial;
            this.Productos = new List<Producto>();
            this.IdUltimoCarrito = 0;
            this.IdUltimoProducto = 0;
        }
    }
}
