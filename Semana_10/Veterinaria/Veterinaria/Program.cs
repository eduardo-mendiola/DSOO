namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Perro("Toni"));
            animales.Add(new Gato("Michifus"));
            animales.Add(new Leon("Scarface"));
            animales.Add(new Perro("Gaston"));
            animales.Add(new Canario("Cantor"));
            animales.Add(new Perro("Manchita"));

            // Recorremos cada uno de los animales de la veterinaria
            foreach (Animal animal in animales)
            {
                animal.caminar();
                animal.comer();
                animal.hacerSonido();
                if (animal.GetType() == typeof(Perro))
                    ((Perro) animal).darLaPatita(); // Casteo de animal a tipo Perro
            }
        }
    }
}
