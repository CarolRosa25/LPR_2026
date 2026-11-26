// Crie as classes “Livro” (atributos: Título, Autor e Ano de publicação) e “Biblioteca” 
//(atributo: lista de objetos da classe Livro). 
// Use métodos construtores, getters e setters quando necessário.
// Na classe Biblioteca:
// ○ Crie os métodos “AdicionarLivro”
// ○ Crie um método “ListarLivros”
// Teste seu sistema no “Main”.

using System;
using System.Collections.Generic;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }
}

class Biblioteca
{
    private List<Livro> livros;

    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ListarLivros()
    {
        Console.WriteLine("Livros da biblioteca:");
        foreach (Livro livro in livros)
            Console.WriteLine(livro.Titulo + " | " + livro.Autor + " | " + livro.Ano);
    }
}

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.AdicionarLivro(new Livro("Dom Casmurro", "Machado de Assis", 1899));
        biblioteca.AdicionarLivro(new Livro("O Cortico", "Aluisio Azevedo", 1890));

        biblioteca.ListarLivros();
    }
}

