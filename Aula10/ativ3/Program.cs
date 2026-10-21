using System;

public class Alunos
{
    public int matricula;
    public string nome;
    public double notaProva;
    public double notaTrabalho;

    public double calcularMedia()
    {
        notaProva = notaProva * 2.5;
        notaTrabalho = notaTrabalho * 2;
        return notaProva + notaTrabalho;
    }

    public double 
    public static void Main(string[] args)
    {
        Alunos aluno = new Alunos();
        Console.Write("Digite a matrícula do aluno: ");
        aluno.matricula = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o nome do aluno: ");
        aluno.nome = Console.ReadLine()!;
        Console.Write("Digite a nota da prova: ");
        aluno.notaProva = double.Parse(Console.ReadLine()!);
        Console.Write("Digite a nota do trabalho: ");
        aluno.notaTrabalho = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Matrícula: " + aluno.matricula);
        Console.WriteLine("Nome: " + aluno.nome);
        Console.WriteLine("Média Final: " + aluno.calcularMedia());
    }
}