public class Program
{
    public static void Main(string[] args)
    {
        Matricula matricula = new Matricula();

        matricula.NomeDoAluno = "Marcelo Sampaio";
        matricula.Curso = "Análise e Desenvolvimento de Sistemas";
        matricula.NumeroMatricula = 12345;
        matricula.Situacao = "Ativa";
        matricula.DataInicial = "01/08/2026";

        Console.WriteLine("=== Matrícula inicial ===");
        matricula.ExibirInformacoes();

        Console.WriteLine("\n=== Após trancar ===");
        matricula.Trancar();
        matricula.ExibirInformacoes();

        Console.WriteLine("\n=== Após reativar ===");
        matricula.Reativar();
        matricula.ExibirInformacoes();
    }
}