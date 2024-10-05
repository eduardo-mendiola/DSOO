namespace Sistema_Gestion_Productos
{
    class ProductoNoPerecedero : Producto
    {
        public string categoria{ get; private set; }

        public ProductoNoPerecedero(string nombre, double precio, string tipo, string categoria) 
                             : base(nombre, precio, tipo)
        {
            this.categoria = categoria;
        }

        // TODO: Sobreescribir el "metodo mostrarDatos: String" para mostrar también la categoria.
        public override String mostrarDatos() => $"{base.mostrarDatos()}" +
                                                 $"          Categoría: {categoria}\n";

    }
}
