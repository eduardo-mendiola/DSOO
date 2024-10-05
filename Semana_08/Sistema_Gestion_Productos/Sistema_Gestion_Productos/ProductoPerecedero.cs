namespace Sistema_Gestion_Productos
{
    class ProductoPerecedero : Producto
    {
        public int diasACaducar { get; private set; }

        public ProductoPerecedero(string nombre, double precio, string tipo, int diasACaducar)
                           : base(nombre, precio, tipo)
        {
            this.diasACaducar = diasACaducar;
        }


        // TODO: Método para sobreescribir el método "calcularPrecioTotal: double" de la clase madre.
        /*
         - En Perecedero, aparte de lo que hace producto, el precio se reducirá dependiendo de los días a caducar según las 
           siguientes reglas:

         * Si le queda 1 día para caducar, se reducirá 4 veces el precio final. 
	     * Si le quedan 2 días para caducar, se reducirá 3 veces el precio final. 
	     * Si le quedan 3 días para caducar, se reducirá a la mitad de su precio final. 
        */
        public override double calcularPrecioTotal(int cantidad)
        {
            double precioFinal;

            switch (diasACaducar)
            {
                case 1:
                    precioFinal = (precio * cantidad) / 4;
                    break;
                case 2:
                    precioFinal = (precio * cantidad) / 3;
                    break;
                case 3:
                    precioFinal = (precio * cantidad) / 2;
                    break;
                default:
                    precioFinal = precio * cantidad;
                    break;
            }
            return precioFinal;
        }

        // TODO: Sobreescribir el "metodo mostrarDatos: String" para mostrar también los diasACaducar.
        public override String mostrarDatos() => $"{base.mostrarDatos()}" +
                                                 $"  Días para caducar: {diasACaducar}\n";
    }
}
