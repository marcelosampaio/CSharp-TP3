public class Program
{
    public static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();

        ingresso.SetNomeDoShow("Festival de Música");
        ingresso.SetPreco(180.00);
        ingresso.SetQuantidadeDisponivel(450);

        Console.WriteLine("Nome do show: " + ingresso.GetNomeDoShow());
        Console.WriteLine("Preço: R$ " + ingresso.GetPreco());
        Console.WriteLine("Quantidade disponível: " + ingresso.GetQuantidadeDisponivel());
    }
}