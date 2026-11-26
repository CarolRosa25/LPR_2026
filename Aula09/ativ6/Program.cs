// Construa um dicionário de X pares chave-valor onde as chaves são nomes de pessoas e os valores 
// são suas respectivas  idades.
// Encontre e imprima todos os nomes de pessoas com idade acima da média.
// Encontre e imprima o nome da pessoa mais velha e o nome da pessoa mais nova.
// Remova todas as pessoas com idade igual a um valor Y (fornecido pelo usuário) e imprima o 
// dicionário atualizado.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        Console.Write("Quantas pessoas deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine()!);
            pessoas[nome] = idade;
        }

        double media = 0;
        foreach (var pessoa in pessoas) media += pessoa.Value;
        media /= pessoas.Count;

        Console.WriteLine("\nPessoas com idade acima da media (" + media + "):");
        foreach (var pessoa in pessoas)
            if (pessoa.Value > media)
                Console.WriteLine(pessoa.Key + " - " + pessoa.Value);

        string maisVelha = "";
        string maisNova = "";
        int maiorIdade = int.MinValue;
        int menorIdade = int.MaxValue;

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > maiorIdade)
            {
                maiorIdade = pessoa.Value;
                maisVelha = pessoa.Key;
            }
            if (pessoa.Value < menorIdade)
            {
                menorIdade = pessoa.Value;
                maisNova = pessoa.Key;
            }
        }

        Console.WriteLine("\nPessoa mais velha: " + maisVelha + " (" + maiorIdade + ")");
        Console.WriteLine("Pessoa mais nova: " + maisNova + " (" + menorIdade + ")");

        Console.Write("\nDigite a idade Y para remover: ");
        int y = int.Parse(Console.ReadLine()!);

        List<string> remover = new List<string>();
        foreach (var pessoa in pessoas)
            if (pessoa.Value == y) remover.Add(pessoa.Key);

        foreach (string nome in remover) pessoas.Remove(nome);

        Console.WriteLine("\nDicionario atualizado:");
        foreach (var pessoa in pessoas)
            Console.WriteLine(pessoa.Key + " - " + pessoa.Value);
    }
}
