// Defina uma struct Livro com os seguintes campos: 
// Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco.
// Crie um programa que permita ao usuário inserir dados de 3 livros e, em seguida, 
// calcule e exiba o preço total dos livros cadastrados e a média de páginas dos livros.

using System;
public struct Livro
    {
        public string titulo;
        public string autor;
        public float numeroPaginas;
        public int preco;
    }
class Ativ
{
	static void Main() 
	{
        Livro[] dados = new Livro[3];
        int mediaPaginas = 0;
        int i;
        
        for (i = 0; i < 3; i++)
        {
            Console.Write("Escreva o título do livro: ");
            dados[i].titulo = Console.ReadLine()!;

            Console.Write("Escreva o autor do livro: ");
            dados[i].autor = Console.ReadLine()!;

            Console.Write("Escreva o número de páginas do livro: ");
            dados[i].numeroPaginas = float.Parse(Console.ReadLine()!);

            Console.Write("Escreva o preço do livro: ");
            dados[i].preco = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
        }
 
    mediaPaginas = (int)((dados[0].numeroPaginas + dados[1].numeroPaginas + dados[2].numeroPaginas) / 3);
    
    Console.WriteLine("A média de páginas é: " + mediaPaginas);
    }                    
}