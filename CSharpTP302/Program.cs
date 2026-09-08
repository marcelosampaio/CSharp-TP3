public class Program
{
    public static void Main(string[] args)
    {
        // Criação de um objeto da classe Ingresso.
        Ingresso ingresso = new Ingresso();

        // Atribuição de valores aos atributos do objeto.
        ingresso.nomeDoShow = "Festival de Música";
        ingresso.preco = 150.00;
        ingresso.quantidadeDisponivel = 500;

        // Exibição dos dados do ingresso
        Console.WriteLine("Nome do show: " + ingresso.nomeDoShow);
        Console.WriteLine("Preço: R$ " + ingresso.preco);
        Console.WriteLine("Quantidade disponível: " + ingresso.quantidadeDisponivel);
    }
}