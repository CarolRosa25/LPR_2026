using System;

class Program
{
    static void Main()
    {
        int A, B, C, D, diferenca;

        Console.Write("Digite A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        B = int.Parse(Console.ReadLine());

        Console.Write("Digite C: ");
        C = int.Parse(Console.ReadLine());

        Console.Write("Digite D: ");
        D = int.Parse(Console.ReadLine());

        diferenca = (A * B) - (C * D);

        Console.WriteLine("Diferença= " + diferenca);
    }
}