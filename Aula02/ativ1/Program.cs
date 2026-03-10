using System;

class Program
{
    static void Main()
    {
        double raio, area;
        double pi = 3.14159;

        Console.Write("Digite o valor do raio: ");
        raio = double.Parse(Console.ReadLine());

        area = pi * raio * raio;

        Console.WriteLine("Área= " + area.ToString("F4"));
    }
}