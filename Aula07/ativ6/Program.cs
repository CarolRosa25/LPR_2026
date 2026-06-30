using System;
class Ativ
{
    static void Main()
    {
        int[,] matriz = new int[4, 4] {
            { 0,   524, 521, 882 }, // Vitória
            { 524, 0,   434, 586 }, // Belo Horizonte
            { 521, 434, 0,   429 }, // Rio de Janeiro
            { 882, 586, 429, 0   }  // São Paulo
        };

        int origem, destino;

        Console.WriteLine("Distâncias entre cidades (em km):");
        Console.WriteLine("Cidades disponíveis:");
        Console.WriteLine("0 - Vitória");
        Console.WriteLine("1 - Belo Horizonte");
        Console.WriteLine("2 - Rio de Janeiro");
        Console.WriteLine("3 - São Paulo");

        do
        {
            Console.Write("\nInforme a cidade de origem (0 a 3): ");
            origem = int.Parse(Console.ReadLine()!);

            Console.Write("Informe a cidade de destino (0 a 3): ");
            destino = int.Parse(Console.ReadLine()!);

            if (origem == destino)
            {
                Console.WriteLine("Origem e destino são iguais. Programa encerrado!");
            }
            else if (origem >= 0 && origem < 4 && destino >= 0 && destino < 4)
            {
                Console.WriteLine($"A distância é de: {matriz[origem, destino]} km");
            }
            else
            {
                Console.WriteLine("Cidade inválida! Escolha números de 0 a 3.");
            }

        } while (origem != destino); 
    }
}