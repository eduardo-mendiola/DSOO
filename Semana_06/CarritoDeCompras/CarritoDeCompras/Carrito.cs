using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    internal class Carrito
    {
        public int id { get; private set; }
        public String dni { get; private set; }
        public List<Producto> items { get; private set; }

        public Carrito(String dni, int it)
        {
            setId(id);
            setDni(dni);
            items = new List<Producto>();
        }
    }
}
