// Implemente um sistema onde uma Reserva está associada a um Cliente, e um Cliente pode ter várias Reservas.
// a) Crie as classes Cliente e Reserva. 
// b) Um Cliente pode ter várias Reservas, mas cada Reserva pertence a apenas um Cliente.
// c) Em Cliente, implemente um método para adicionar uma Reserva à lista de reservas do cliente. 
// d) Em Reserva, adicione um atributo para referenciar o cliente que fez a reserva. 
// e) Crie um método em Cliente que liste todas as reservas existentes para um determinado cliente.

using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public List<Reserva> Reservas { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
        Reservas = new List<Reserva>();
    }

    public void AdicionarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
    }

    public void ListarReservas()
    {
        Console.WriteLine("Reservas de " + Nome + ":");
        foreach (Reserva reserva in Reservas)
            Console.WriteLine("Reserva " + reserva.Codigo + " - " + reserva.Data);
    }
}

class Reserva
{
    public int Codigo { get; set; }
    public string Data { get; set; }
    public Cliente Cliente { get; set; }

    public Reserva(int codigo, string data, Cliente cliente)
    {
        Codigo = codigo;
        Data = data;
        Cliente = cliente;
    }
}

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Mariana");

        Reserva r1 = new Reserva(1, "10/12/2026", cliente);
        Reserva r2 = new Reserva(2, "15/12/2026", cliente);

        cliente.AdicionarReserva(r1);
        cliente.AdicionarReserva(r2);

        cliente.ListarReservas();
    }
}
