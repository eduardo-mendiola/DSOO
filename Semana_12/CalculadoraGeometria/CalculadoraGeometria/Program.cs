namespace CalculadoraGeometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Radio = 4;
            Calculadora.Altura = 2;
            Calculadora.Base = 3;

            Console.WriteLine(Calculadora.AreaRectangulo());
            Console.WriteLine(Calculadora.AreaCirculo());
            Console.WriteLine(Calculadora.PerimetroRectangulo());
            Console.WriteLine(Calculadora.PerimetroCirculo());
        }
    }
}
