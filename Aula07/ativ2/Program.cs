using System;
class Ativ
{
	static void Main() 
	{
	    int [] numeros = new int[10];
        int [] pares = new int[10];
        int [] impares = new int[10];
        
        int qntPares = 0;
        int qntImpares = 0;
        
    	for (int i = 0; i < numeros.Length; i++)
	    {
    		Console.Write("Digite um número: ");
    		numeros [i] = int.Parse(Console.ReadLine()!);
    	        if (numeros[i] % 2 == 0) {
                    pares[qntPares] = numeros[i];
                    qntPares++;
    	        }
    	        else {
    	            impares[qntImpares] = numeros[i];
                    qntImpares++;
    	        }
        }
        Console.WriteLine("Pares: ");
        for (int i = 0; i < qntPares; i++) {
            Console.WriteLine(pares[i]);
        }
        Console.WriteLine();
        
        Console.WriteLine("Ímpares: ");
        for (int i = 0; i < qntImpares; i++) {
            Console.WriteLine(impares[i]);
        }
        
    }
}