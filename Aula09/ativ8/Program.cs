// Crie uma struct chamada Livro contendo:
// ● Título
// ● Autor
// ● Ano de publicação
// ● Quantidade disponível
// Utilize um dicionário onde Chave: Código do livro, Valor: Struct Livro
// Implemente as funções:
// 1. CadastrarLivro()
// 2. BuscarLivro()
// 3. EmprestarLivro()
// 4. ExibirRelatorio()
// O programa deverá:
// ● Cadastrar 10 livros.
// ● Permitir buscar um livro pelo código.
// ● Realizar empréstimos reduzindo a quantidade disponível.
// ● Impedir empréstimos quando não houver exemplares.
// ● Exibir um relatório contendo:
// ○ Total de livros cadastrados;
// ○ Livro mais antigo;
// ○ Livro com maior quantidade disponível.
// ● Exibir quantos livros existem por autor.

using System;
using System.Collections.Generic;

struct Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public int Quantidade;

    public Livro(string titulo, string autor, int ano, int quantidade)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Quantidade = quantidade;
    }
}

class Program
{
    static void CadastrarLivro(Dictionary<string, Livro> livros)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nLivro " + (i + 1));
            Console.Write("Codigo: ");
            string codigo = Console.ReadLine()!;
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine()!;
            Console.Write("Autor: ");
            string autor = Console.ReadLine()!;
            Console.Write("Ano de publicacao: ");
            int ano = int.Parse(Console.ReadLine()!);
            Console.Write("Quantidade disponivel: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            livros[codigo] = new Livro(titulo, autor, ano, quantidade);
        }
    }

    static void BuscarLivro(Dictionary<string, Livro> livros)
    {
        Console.Write("\nCodigo do livro para buscar: ");
        string codigo = Console.ReadLine()!;

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];
            Console.WriteLine(l.Titulo + " | " + l.Autor + " | " + l.Ano +
                              " | Disponiveis: " + l.Quantidade);
        }
        else Console.WriteLine("Livro nao encontrado.");
    }

    static void EmprestarLivro(Dictionary<string, Livro> livros)
    {
        Console.Write("\nCodigo do livro para emprestar: ");
        string codigo = Console.ReadLine()!;

        if (!livros.ContainsKey(codigo))
        {
            Console.WriteLine("Livro nao encontrado.");
            return;
        }

        Livro l = livros[codigo];
        if (l.Quantidade <= 0)
        {
            Console.WriteLine("Nao ha exemplares disponiveis.");
            return;
        }

        l.Quantidade--;
        livros[codigo] = l;
        Console.WriteLine("Emprestimo realizado.");
    }

    static void ExibirRelatorio(Dictionary<string, Livro> livros)
    {
        Console.WriteLine("\nTotal de livros cadastrados: " + livros.Count);
        if (livros.Count == 0) return;

        Livro antigo = new Livro();
        Livro maiorEstoque = new Livro();
        bool primeiro = true;

        foreach (var item in livros)
        {
            Livro l = item.Value;
            if (primeiro || l.Ano < antigo.Ano) antigo = l;
            if (primeiro || l.Quantidade > maiorEstoque.Quantidade) maiorEstoque = l;
            primeiro = false;
        }

        Console.WriteLine("Livro mais antigo: " + antigo.Titulo + " (" + antigo.Ano + ")");
        Console.WriteLine("Maior quantidade disponivel: " + maiorEstoque.Titulo +
                          " (" + maiorEstoque.Quantidade + ")");

        Dictionary<string, int> porAutor = new Dictionary<string, int>();
        foreach (var item in livros)
        {
            string autor = item.Value.Autor;
            if (!porAutor.ContainsKey(autor)) porAutor[autor] = 0;
            porAutor[autor]++;
        }

        Console.WriteLine("\nQuantidade de livros por autor:");
        foreach (var autor in porAutor)
            Console.WriteLine(autor.Key + ": " + autor.Value);
    }

    static void Main()
    {
        Dictionary<string, Livro> livros = new Dictionary<string, Livro>();
        CadastrarLivro(livros);
        BuscarLivro(livros);
        EmprestarLivro(livros);
        ExibirRelatorio(livros);
    }
}
