using System;

class Program
{
    static void Main()
    {
        Console.Write("Horas de treinamento por dia: ");
        double horasPorDia = double.Parse(Console.ReadLine());

        double totalHoras = 0;
        int dias = 0;

        while (totalHoras < 1000)
        {
            totalHoras += horasPorDia;
            dias++;

            if (dias % 7 == 6 || dias % 7 == 0)
            {
                totalHoras -= horasPorDia; 
            }
        }

        double semanas = dias / 7.0;
        double meses = semanas / 4.5;

        Console.WriteLine("Total de dias: " + dias);
        Console.WriteLine("Total de semanas: " + semanas);
        Console.WriteLine("Total de meses: " + meses);
    }
}