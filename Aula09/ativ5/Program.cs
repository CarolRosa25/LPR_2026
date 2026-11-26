// Crie um programa que utilize um dicionário para armazenar jogos e seus respectivos gêneros.
// Cadastre pelo menos 5 jogos informados pelo usuário.
// Depois, solicite o nome de um jogo e exiba seu gênero.
// Caso o jogo não esteja cadastrado, exiba uma mensagem informando isso.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> jogos = new Dictionary<string, string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nome do jogo: ");
            string nome = Console.ReadLine()!;
            Console.Write("Genero: ");
            string genero = Console.ReadLine()!;
            jogos[nome] = genero;
        }

        Console.Write("\nDigite o nome de um jogo para buscar: ");
        string busca = Console.ReadLine()!;

        if (jogos.ContainsKey(busca))
            Console.WriteLine("Genero: " + jogos[busca]);
        else
            Console.WriteLine("Jogo nao cadastrado.");
    }
}
