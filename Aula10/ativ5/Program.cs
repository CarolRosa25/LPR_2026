// Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um 
// produto comprado.
// Crie a classe Produto, com os atributos nome e preco.
// Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo 
// chamado quantidade.
// No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e 
// o preço total da compra.

using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

class Pedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public Pedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public double CalcularTotal()
    {
        return Produto.Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Teclado", 120.00);
        Pedido pedido = new Pedido(produto, 2);

        Console.WriteLine("Produto: " + pedido.Produto.Nome);
        Console.WriteLine("Quantidade: " + pedido.Quantidade);
        Console.WriteLine("Preco total: " + pedido.CalcularTotal());
    }
}
