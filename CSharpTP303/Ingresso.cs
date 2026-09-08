public class Ingresso
{
    public string nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;

    public void AlterarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome do show: " + nomeDoShow);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Quantidade disponível: " + quantidadeDisponivel);
    }
}