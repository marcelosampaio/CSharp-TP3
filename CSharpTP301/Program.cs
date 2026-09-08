// O método Main é o ponto de entrada da aplicação.
public class Program
{
    public static void Main(string[] args)
    {
        // Criação de um objeto da classe Carro.
        // O objeto representa um carro específico.
        Carro carro = new Carro();

        // Atribuição de valores aos campos do objeto.
        carro.marca = "Toyota";
        carro.modelo = "Corolla";
        carro.ano = 2026;

        // Chamada dos métodos do objeto para demonstrar seus comportamentos.
        carro.Acelerar();
        carro.Frear();
    }
}