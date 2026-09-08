public class Program
{
    public static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();

        ingresso.nomeDoShow = "Festival de Música";
        ingresso.preco = 150.00;
        ingresso.quantidadeDisponivel = 500;

        ingresso.AlterarPreco(180.00);
        ingresso.AlterarQuantidade(450);

        ingresso.ExibirInformacoes();
    }
}