// A classe representa um modelo que define as características
// e os comportamentos que os objetos desse tipo terão.
public class Carro
{
    // Campos (atributos) representam as características do carro.
    public string marca;
    public string modelo;
    public int ano;

    // Métodos representam os comportamentos que um objeto Carro pode realizar.
    public void Acelerar()
    {
        Console.WriteLine($"O carro {marca} {modelo} está acelerando.");
    }

    public void Frear()
    {
        Console.WriteLine($"O carro {marca} {modelo} está freando.");
    }
}