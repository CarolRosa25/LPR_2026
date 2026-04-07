using System;

class Program
{
    static string? nome1, nome2, nome3, nome4, nome5;
    static string? poder1, poder2, poder3, poder4, poder5;
    static int ponto1, ponto2, ponto3, ponto4, ponto5;

    static int total = 0;

    static string? en1, en2, en3;
    static string? ep1, ep2, ep3;
    static int pt1, pt2, pt3;

    static void cadastrarHeroi()
    {
        if (total >= 5)
        {
            Console.WriteLine("Limite atingido");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Poder: ");
        string poder = Console.ReadLine()!;

        Console.Write("Pontos: ");
        int pontos = int.Parse(Console.ReadLine()!);

        total++;

        if (total == 1) { nome1 = nome; poder1 = poder; ponto1 = pontos; }
        if (total == 2) { nome2 = nome; poder2 = poder; ponto2 = pontos; }
        if (total == 3) { nome3 = nome; poder3 = poder; ponto3 = pontos; }
        if (total == 4) { nome4 = nome; poder4 = poder; ponto4 = pontos; }
        if (total == 5) { nome5 = nome; poder5 = poder; ponto5 = pontos; }
    }

    static void selecionarEquipe()
    {
        if (total < 3)
        {
            Console.WriteLine("Cadastre 3 herois");
            return;
        }

        Console.WriteLine("Escolha 3 herois:");

        if (total >= 1) Console.WriteLine("1 - " + nome1);
        if (total >= 2) Console.WriteLine("2 - " + nome2);
        if (total >= 3) Console.WriteLine("3 - " + nome3);
        if (total >= 4) Console.WriteLine("4 - " + nome4);
        if (total >= 5) Console.WriteLine("5 - " + nome5);

        Console.Write("1: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("2: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.Write("3: ");
        int c = int.Parse(Console.ReadLine()!);

        escolher(a, 1);
        escolher(b, 2);
        escolher(c, 3);
    }

    static void escolher(int op, int pos)
    {
        string? n = "";
        string? p = "";
        int pt = 0;

        if (op == 1) { n = nome1; p = poder1; pt = ponto1; }
        if (op == 2) { n = nome2; p = poder2; pt = ponto2; }
        if (op == 3) { n = nome3; p = poder3; pt = ponto3; }
        if (op == 4) { n = nome4; p = poder4; pt = ponto4; }
        if (op == 5) { n = nome5; p = poder5; pt = ponto5; }

        if (pos == 1) { en1 = n; ep1 = p; pt1 = pt; }
        if (pos == 2) { en2 = n; ep2 = p; pt2 = pt; }
        if (pos == 3) { en3 = n; ep3 = p; pt3 = pt; }
    }

    static int calcularPontuacao()
    {
        return pt1 + pt2 + pt3;
    }

    static void exibirEquipe()
    {
        Console.WriteLine("Equipe:");
        Console.WriteLine(en1 + " - " + ep1);
        Console.WriteLine(en2 + " - " + ep2);
        Console.WriteLine(en3 + " - " + ep3);
        Console.WriteLine("Total: " + calcularPontuacao());
    }

    static void menuPrincipal()
    {
        int op;

        do
        {
            Console.WriteLine("1 Cadastrar");
            Console.WriteLine("2 Selecionar");
            Console.WriteLine("3 Exibir");
            Console.WriteLine("0 Sair");
            Console.Write("Opcao: ");

            op = int.Parse(Console.ReadLine()!);

            if (op == 1) cadastrarHeroi();
            if (op == 2) selecionarEquipe();
            if (op == 3) exibirEquipe();

        } while (op != 0);
    }

    static void Main()
    {
        menuPrincipal();
    }
}