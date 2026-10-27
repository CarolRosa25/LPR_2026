// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área e perímetro.
// Usar a seguinte classe:
// Retangulo
// double Altura
// double Largura
// calcArea()
// calcPerimetro()

using System;
public class Retangulo
{
    public double altura;
    public double largura;

    public double calcularArea()
    {
        return altura * largura;
    }

    public double calcularPerimetro()
    {
        return 2 * (altura + largura);
    }

    public static void Main(string[] args)
    {
        Retangulo retan = new Retangulo();
        Console.Write("Digite a altura do retângulo: ");
        retan.altura = double.Parse(Console.ReadLine()!);
        Console.Write("Digite a largura do retângulo: ");
        retan.largura = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Área: " + retan.calcularArea());
        Console.WriteLine("Perímetro: " + retan.calcularPerimetro());
    }
}