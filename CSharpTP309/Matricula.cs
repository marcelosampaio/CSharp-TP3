public class Matricula
{
    public string NomeDoAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;
    public string DataInicial;

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome do aluno: " + NomeDoAluno);
        Console.WriteLine("Curso: " + Curso);
        Console.WriteLine("Número da matrícula: " + NumeroMatricula);
        Console.WriteLine("Situação: " + Situacao);
        Console.WriteLine("Data inicial: " + DataInicial);
    }
}