// Construa um dicionário de x pares chave-valor onde as chaves são nomes de cidades e os valores 
// são suas respectivas populações.
// Encontre e imprima todas as cidades com população acima da média.
// Encontre e imprima o nome da cidade mais populosa e o nome da cidade menos populosa.
// Remova todas as cidades com população igual a um valor Y (fornecido pelo usuário) e imprima 
// o dicionário atualizado.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, long> cidades = new Dictionary<string, long>();

        Console.Write("Quantas cidades deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Cidade: ");
            string nome = Console.ReadLine()!;
            Console.Write("Populacao: ");
            long populacao = long.Parse(Console.ReadLine()!);
            cidades[nome] = populacao;
        }

        double media = 0;
        foreach (var cidade in cidades) media += cidade.Value;
        media /= cidades.Count;

        Console.WriteLine("\nCidades com populacao acima da media (" + media + "):");
        foreach (var cidade in cidades)
            if (cidade.Value > media)
                Console.WriteLine(cidade.Key + " - " + cidade.Value);

        string maisPopulosa = "";
        string menosPopulosa = "";
        long maior = long.MinValue;
        long menor = long.MaxValue;

        foreach (var cidade in cidades)
        {
            if (cidade.Value > maior)
            {
                maior = cidade.Value;
                maisPopulosa = cidade.Key;
            }
            if (cidade.Value < menor)
            {
                menor = cidade.Value;
                menosPopulosa = cidade.Key;
            }
        }

        Console.WriteLine("\nMais populosa: " + maisPopulosa + " (" + maior + ")");
        Console.WriteLine("Menos populosa: " + menosPopulosa + " (" + menor + ")");

        Console.Write("\nDigite a populacao Y para remover: ");
        long y = long.Parse(Console.ReadLine()!);

        List<string> remover = new List<string>();
        foreach (var cidade in cidades)
            if (cidade.Value == y) remover.Add(cidade.Key);

        foreach (string nome in remover) cidades.Remove(nome);

        Console.WriteLine("\nDicionario atualizado:");
        foreach (var cidade in cidades)
            Console.WriteLine(cidade.Key + " - " + cidade.Value);
    }
}
