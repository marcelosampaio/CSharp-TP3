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

        Console.WriteLine("Nome do aluno: " + matricula.NomeDoAluno);
        Console.WriteLine("Curso: " + matricula.Curso);
        Console.WriteLine("Número da matrícula: " + matricula.NumeroMatricula);
        Console.WriteLine("Situação: " + matricula.Situacao);
        Console.WriteLine("Data inicial: " + matricula.DataInicial);
    }
}