// Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
// A classe funcionário deve conter os seguintes métodos:
// ○ Mostrar os dados do funcionário (nome e salário líquido).
// ○ Aumentar o salário do funcionário com base em uma porcentagem dada
// ● OBS: Tabela de Imposto
// ○ 10% para salários de até 2000
// ○ 15% para salários de até 3000
// ○ 20% para salários superiores a 3000

using System;
public class Funcionario
{
    public string nome;
    public double salarioBruto;
    public double imposto;

    public double calcularSalarioLiquido()
    {
        if (salarioBruto <= 2000)
        {
            imposto = salarioBruto * 0.10;
        }
        else if (salarioBruto <= 3000)
        {
            imposto = salarioBruto * 0.15;
        }
        else
        {
            imposto = salarioBruto * 0.20;
        }
        return salarioBruto - imposto;
    }

    public void aumentarSalario(double porcentagem)
    {
        salarioBruto += salarioBruto * (porcentagem / 100);
    }
    public static void Main(string[] args)
    {
        Funcionario func = new Funcionario();
        Console.Write("Digite o nome do funcionário: ");
        func.nome = Console.ReadLine()!;
        Console.Write("Digite o salário bruto do funcionário: ");
        func.salarioBruto = double.Parse(Console.ReadLine()!);

        Console.WriteLine();
        Console.Write("Você deseja aumentar o salário do funcionário? (s/n): ");
        string resposta = Console.ReadLine()!;
        if (resposta.ToLower() == "s")
        {
            Console.Write("Digite a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine()!);
            func.aumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Salário bruto atualizado: " + func.salarioBruto);
        }
    
    Console.WriteLine("Nome: " + func.nome);
    Console.WriteLine("Salário líquido: " + func.calcularSalarioLiquido());
    }
}
