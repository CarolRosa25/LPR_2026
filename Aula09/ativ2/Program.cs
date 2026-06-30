// Construa uma lista de X nomes aleatórios:
// A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes ordenados por tamanho, 
// começando com o menor. Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais 
// nomes com o mesmo tamanho devem ser apresentados nas linhas seguintes. Você deve seguir a ordem de digitação.

using System;
using System.Collections.Generic;
class Ativ
{
	static void Main() 
	{
        List<string> nomes = new();
        Console.Write("Digite os nomes que deseja inserir: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            string nomeAtual = nome[i];
            Console.Write($"Digite o {i + 1}º nome: ");
            nomes.Add(Console.ReadLine());
        }

        nomes.Sort((a, b) => a.Length.CompareTo(b.Length));
        int tamanhoAtual = 0;
        Console.WriteLine("Nomes ordenados por tamanho:");
        foreach (string nome in nomes)
        {
            if (nome.Length != tamanhoAtual)
            {
                tamanhoAtual = nome.Length;
                Console.WriteLine();
            }
            Console.WriteLine(nome);
        }
    }                    
}