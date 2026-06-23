// Defina uma struct chamada Filme contendo os seguintes campos:
// Titulo, Diretor, AnoLancamento,DuracaoMinutos
// Crie um programa que:
// ● Solicite os dados de 3 filmes.
// ● Armazene-os em um vetor de structs.
// ● Exiba todos os filmes cadastrados.
// ● Informe qual é o filme mais antigo.

// romance[0] = new Filme {titulo = "10 coisas que eu odeio em você", diretor = "Gil Junger", anoLancamento = 1999, duracaoMinutos = 97};
// romance[1] = new Filme {titulo = "Como perder um homem em 10 dias", diretor = "Donald Petrie", anoLancamento = 2003, duracaoMinutos = 116};
// romance[2] = new Filme {titulo = "Diário de uma paixão", diretor = "Nick Cassavetes", anoLancamento = 2004, duracaoMinutos = 123};
// romance[3] = new Filme {titulo = "Uma Linda Mulher", diretor = "Garry Marshall", anoLancamento = 1990, duracaoMinutos = 119};


using System;
public struct Filme
    {
        public string titulo;
        public string diretor;
        public int anoLancamento;
        public int duracaoMinutos;
    }
class Ativ
{
	static void Main() 
	{
        Filme[] romance = new Filme[3];
        int i;

        for (i = 0; i < 3; i++)
        {
            Console.Write("Escreva o titulo do filme: ");
            romance[i].titulo = Console.ReadLine()!;

            Console.Write("Escreva o diretor do filme: ");
            romance[i].diretor = Console.ReadLine()!;

            Console.Write("Escreva o ano de lançamento do filme: ");
            romance[i].anoLancamento = int.Parse(Console.ReadLine()!);

            Console.Write("Escreva a duração de minutos do filme: ");
            romance[i].duracaoMinutos = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
        }
    
    Console.WriteLine("\nFilmes cadastrados: " + romance[0].titulo + ", " + romance[1].titulo + ", " + romance[2].titulo);
    
        if (romance[0].anoLancamento < romance[1].anoLancamento && romance[0].anoLancamento < romance[2].anoLancamento) {
            Console.WriteLine("O filme mais antigo é: " + romance[0].titulo);
        }
        else if (romance[1].anoLancamento < romance[0].anoLancamento && romance[1].anoLancamento < romance[2].anoLancamento) {
            Console.WriteLine("O filme mais antigo é: " + romance[1].titulo);
        }
        else {
            Console.WriteLine("O filme mais antigo é: " + romance[2].titulo);
        }
    }                     
}