// Defina uma struct Produto que contenha os seguintes campos: 
// Nome, Codigo, Preco e Quantidade. 
// Crie um programa que permita ao usuário inserir dados de 3 produtos e, em seguida, 
// exiba o valor total em estoque (considerando o preço e a quantidade de cada produto).

using System;
public struct Produto
    {
        public string nome;
        public string codigo;
        public float preco;
        public int quantidade;
    }
class Ativ
{
	static void Main() 
	{
        Produto[] dados = new Produto[3];
        float valorTotal = 0;
        int i;
        
        for (i = 0; i < 3; i++)
        {
            Console.Write("Escreva o nome do produto: ");
            dados[i].nome = Console.ReadLine()!;

            Console.Write("Escreva o código do produto: ");
            dados[i].codigo = Console.ReadLine()!;

            Console.Write("Escreva o preço do produto: ");
            dados[i].preco = float.Parse(Console.ReadLine()!);

            Console.Write("Escreva a quantidade em estoque: ");
            dados[i].quantidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
        }
 
    valorTotal = dados[0].preco * dados[0].quantidade + dados[1].preco * dados[1].quantidade + dados[2].preco * dados[2].quantidade;
    
    Console.WriteLine("O valor total é: " + valorTotal);
    }                    
}