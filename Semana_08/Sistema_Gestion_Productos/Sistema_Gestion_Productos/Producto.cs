namespace Sistema_Gestion_Productos
{
    abstract class Producto
    {
        public string nombre { get; private set; }
        public double precio { get; private set; }
        public string tipo { get; private set; }

        protected Producto(string nombre, double precio, string tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;
        }

        // TODO: Crear un metodo para calcular el precio de compra llamado "calcularPrecioTotal: double".

        public virtual double calcularPrecioTotal(int cantidad) => precio * cantidad;

        // TODO: Crear un método para mostrar los datos llamado "mostrarDatos: String".

        public virtual String mostrarDatos() => $"Nombre del producto: {nombre}" +
                                              $"\n    Precio unitario: {precio}" +
                                              $"\n               Tipo: {tipo}\n";
    }

}
