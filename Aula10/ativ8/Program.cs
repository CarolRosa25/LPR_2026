// Crie um sistema onde Aluno e Turma possuem uma relação N-N
// a) Cada aluno pode estar matriculado em várias turmas, e cada turma pode ter vários alunos.
// b) Crie as classes Aluno, Turma, e uma classe intermediária Matricula 
// c) Em Aluno e Turma, crie listas de Matricula para associar um aluno a uma turma.
// d) Implemente métodos em Aluno e Turma para adicionar uma nova Matricula.
// e) Em Matricula, inclua um atributo para registrar a data da matrícula.
// f) Adicione uma lógica para verificar se um Aluno já está matriculado em uma Turma antes de 
// permitir uma nova Matricula.
// g) Implemente um método em Turma para retornar a lista de todos os alunos matriculados.

using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Aluno(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public bool AdicionarMatricula(Turma turma, string data)
    {
        foreach (Matricula m in Matriculas)
            if (m.Turma == turma) return false;

        Matricula nova = new Matricula(this, turma, data);
        Matriculas.Add(nova);
        turma.Matriculas.Add(nova);
        return true;
    }
}

class Turma
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; }

    public Turma(string nome)
    {
        Nome = nome;
        Matriculas = new List<Matricula>();
    }

    public List<Aluno> ListarAlunos()
    {
        List<Aluno> alunos = new List<Aluno>();
        foreach (Matricula m in Matriculas)
            alunos.Add(m.Aluno);
        return alunos;
    }
}

class Matricula
{
    public Aluno Aluno { get; set; }
    public Turma Turma { get; set; }
    public string Data { get; set; }

    public Matricula(Aluno aluno, Turma turma, string data)
    {
        Aluno = aluno;
        Turma = turma;
        Data = data;
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno1 = new Aluno("Ana");
        Aluno aluno2 = new Aluno("Pedro");
        Turma turma1 = new Turma("Programacao");
        Turma turma2 = new Turma("Matematica");

        Console.WriteLine(aluno1.AdicionarMatricula(turma1, "20/02/2026")
            ? "Matricula realizada." : "Aluno ja matriculado.");
        Console.WriteLine(aluno1.AdicionarMatricula(turma1, "21/02/2026")
            ? "Matricula realizada." : "Aluno ja matriculado.");

        aluno1.AdicionarMatricula(turma2, "20/02/2026");
        aluno2.AdicionarMatricula(turma1, "20/02/2026");

        Console.WriteLine("\nAlunos da turma " + turma1.Nome + ":");
        foreach (Aluno aluno in turma1.ListarAlunos())
            Console.WriteLine(aluno.Nome);
    }
}

