// Construa uma lista de X nomes aleatórios:
// A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes ordenados por tamanho, 
// começando com o menor. Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais 
// nomes com o mesmo tamanho devem ser apresentados nas linhas seguintes. Você deve seguir a ordem de digitação.

using System;
using System.Collections.Generic;
using System.Linq;

class Ativ
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        Console.Write("Quantos nomes você deseja digitar? ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < x; i++) {
            Console.Write($"Digite o {i + 1}º nome: ");
            nomes.Add(Console.ReadLine());
        }
        nomes = nomes.OrderBy(n => n.Length).ToList();

        int maiorQuantidade = 0;

        foreach (string nome in nomes) {
            int quantidade = 0;

            foreach (string outro in nomes) {
                if (nome.Length == outro.Length) {
                    quantidade++;
                }
            }

            if (quantidade > maiorQuantidade) {
                maiorQuantidade = quantidade;
            }
        }

        for (int linha = 0; linha < maiorQuantidade; linha++) {
            int tamanhoAtual = -1;
            int contador = 0;

            foreach (string nome in nomes) {
                if (nome.Length != tamanhoAtual) {
                    tamanhoAtual = nome.Length;
                    contador = 0;
                }

                if (contador == linha) {
                    Console.Write(nome + " ");
                }
                contador++;
            }
            Console.WriteLine();
        }
    }
}