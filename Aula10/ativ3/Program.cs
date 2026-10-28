// Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
// Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
// 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
// ○ media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2)
// ○ final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final). 
// O aluno vai pra final se sua média for menor que 60.


using System;

public class Alunos
{
    public string matricula;
    public string nome = "";
    double[] notasProva = new double[2];
    double [] notasTrabalho = new double[1];

    public double mediaFinal()
    {
        return (notasProva[0] * 2.5 + notasProva[1] * 2.5 + notasTrabalho[0] * 2) / 7;
    }

    public double notaFinal()
    {
        double media = mediaFinal();

        if (media < 60)
        {
            return 120 - media;
        }
        else
        {
            return 0;
        }
    }

    public static void Main(string[] args)
    {
        Alunos aluno = new Alunos();
        Console.Write("Digite o nome do aluno: ");
        aluno.nome = Console.ReadLine()!;

        Console.Write("Digite a matrícula do aluno: ");
        aluno.matricula = Console.ReadLine()!;
        
        Console.WriteLine();
        Console.Write("Digite a nota da primeira prova: ");
        aluno.notasProva[0] = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a nota da segunda prova: ");
        aluno.notasProva[1] = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a nota do trabalho: ");
        aluno.notasTrabalho[0] = double.Parse(Console.ReadLine()!);

        Console.WriteLine();
        Console.WriteLine($"Média final do aluno: {aluno.mediaFinal():F2}");

        Console.WriteLine($"Nota necessária para a prova final: {aluno.notaFinal():F2}");
    }
}