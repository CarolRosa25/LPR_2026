using System;
class Ativ
{
	static void Main() 
	{
	    int [] numeros = new int[10];
        
    	for (int i = 0; i < numeros.Length; i++)
	    {
    		Console.Write("Digite um número: ");
    		numeros [i] = int.Parse(Console.ReadLine()!);
	    }
	    
	    Console.WriteLine("Digite um número que deseja pesquisar: ");
	    int pesquisa = int.Parse(Console.ReadLine()!);
	    
	    int ocorrencias = 0;
	    
	    for (int i = 0; i < numeros.Length; i++)
	    {
	        if (numeros[i] == pesquisa) {
	            Console.WriteLine("Encontrado na posição: " + i);
	            ocorrencias++;
	        }
	    }
	    if (ocorrencias == 0) {
	        Console.WriteLine("Não encontrado.");
	    }
	    
	    Console.WriteLine("Total de ocorrencias: " + ocorrencias);
    }
}