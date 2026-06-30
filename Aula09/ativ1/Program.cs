// Crie um programa que permita ao usuário cadastrar notas de alunos em uma lista. O programa deve:
// ● Solicitar ao usuário 5 notas.
// ● Armazenar as notas em uma lista.
// ● Exibir:
// ○ Todas as notas cadastradas;
// ○ A maior nota;
// ○ A menor nota;
// ○ A média das notas.

using System;
using System.Collections.Generic;
class Ativ
{
	static void Main() 
	{
        List<int> numeros = new(5);
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite a nota do aluno: ");
            int nota = Convert.ToInt32(Console.ReadLine());
            numeros.Add(nota);

        }
        Console.WriteLine();
        Console.WriteLine("Notas cadastradas: ");
        foreach (int nota in numeros)
        {
            Console.WriteLine(nota);
        }
        Console.WriteLine();
        Console.WriteLine("Maior nota: {0}", numeros.Max());
        Console.WriteLine("Menor nota: {0}", numeros.Min());
        Console.WriteLine("Média das notas: {0}", numeros.Average());
    }                    
}