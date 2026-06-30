using System;
class Ativ
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        Console.WriteLine("Digite os elementos da Matriz A (3x3):");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"A[{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine("\nDigite os elementos da Matriz B (3x3):");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                C[i, j] = 0; 
                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nMatriz Resultante C (A * B):");
        for (int i = 0; i < C.GetLength(0); i++)
        {
            for (int j = 0; j < C.GetLength(1); j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}