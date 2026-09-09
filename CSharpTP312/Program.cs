public class Program
{
    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        circulo.Raio = 3;
        Console.WriteLine("Área do círculo: " + circulo.CalcularArea());

        Esfera esfera = new Esfera();
        esfera.Raio = 5;
        Console.WriteLine("Volume da esfera: " + esfera.CalcularVolume());
    }
}