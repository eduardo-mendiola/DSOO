namespace S12_Interfaces_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAreaCalculable> areaCalculables = new List<IAreaCalculable>();

            areaCalculables.Add(new Cuadrado(10));
            areaCalculables.Add(new CuadradoInformacion(10));
            areaCalculables.Add(new Cuadrado(5));
            areaCalculables.Add(new CuadradoInformacion(5));

            foreach (IAreaCalculable i in areaCalculables) 
            {
                Console.WriteLine($"Clase {i.GetType().Name}, valor de area = {i.CalcularArea()}"); 
            }

            CuadradoInformacion cuadrado1 = new CuadradoInformacion(20);
            CirculoInformacion circulo1 = new CirculoInformacion(25);

            ImprimirInformacion(cuadrado1);
            ImprimirInformacion(circulo1);
        }

        static void ImprimirInformacion(IInformacionFigura objeto)
        {
            objeto.ObtenerInformacion();
        }
    }
}
