using System;

class Program
{
    public struct Heroi
    {
        public string Nome;
        public string Poder;
        public int Pontuacao;
    }

    public struct Equipe
    {
        public Heroi[] Herois;
        public int Quantidade;
    }

    static Heroi cadastrarHeroi()
    {
        Heroi h;

        Console.Write("\nNome do heroi: ");
        h.Nome = Console.ReadLine()!;

        Console.Write("Poder: ");
        h.Poder = Console.ReadLine()!;

        Console.Write("Pontuacao: ");
        h.Pontuacao = int.Parse(Console.ReadLine()!);

        return h;
    }

    static void selecionarEquipe(Heroi[] herois, int quantidade, ref Equipe equipe)
    {
        if (quantidade < 3)
        {
            Console.WriteLine("\nCadastre pelo menos 3 herois primeiro!");
            return;
        }

        equipe.Quantidade = 0;

        Console.WriteLine("\n===== HEROIS CADASTRADOS =====");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine((i + 1) + " - " + herois[i].Nome +
                " | Poder: " + herois[i].Poder +
                " | Pontuacao: " + herois[i].Pontuacao);
        }

        while (equipe.Quantidade < 3)
        {
            Console.Write("\nEscolha o numero do heroi: ");
            int escolha = int.Parse(Console.ReadLine()!);

            if (escolha < 1 || escolha > quantidade)
            {
                Console.WriteLine("Opcao invalida!");
            }
            else
            {
                bool repetido = false;

                for (int i = 0; i < equipe.Quantidade; i++)
                {
                    if (equipe.Herois[i].Nome == herois[escolha - 1].Nome)
                    {
                        repetido = true;
                    }
                }

                if (repetido)
                {
                    Console.WriteLine("Esse heroi ja foi selecionado!");
                }
                else
                {
                    equipe.Herois[equipe.Quantidade] = herois[escolha - 1];
                    equipe.Quantidade++;
                    Console.WriteLine("Heroi selecionado!");
                }
            }
        }

        Console.WriteLine("\nEquipe selecionada com sucesso!");
    }

    static int calcularPontuacaoTotal(Equipe equipe)
    {
        int total = 0;

        for (int i = 0; i < equipe.Quantidade; i++)
        {
            total += equipe.Herois[i].Pontuacao;
        }

        return total;
    }

    static void exibirEquipe(Equipe equipe)
    {
        if (equipe.Quantidade != 3)
        {
            Console.WriteLine("\nSelecione uma equipe primeiro!");
            return;
        }

        Console.WriteLine("\n===== EQUIPE MARVEL =====");

        for (int i = 0; i < equipe.Quantidade; i++)
        {
            Console.WriteLine("\nHeroi: " + equipe.Herois[i].Nome);
            Console.WriteLine("Poder: " + equipe.Herois[i].Poder);
            Console.WriteLine("Pontuacao: " + equipe.Herois[i].Pontuacao);
        }

        Console.WriteLine("\nPontuacao total da equipe: " + calcularPontuacaoTotal(equipe));
    }

    static int menuPrincipal()
    {
        Console.WriteLine("\n===== MENU PRINCIPAL =====");
        Console.WriteLine("1 - Cadastrar herois");
        Console.WriteLine("2 - Selecionar equipe");
        Console.WriteLine("3 - Exibir equipe");
        Console.WriteLine("4 - Sair");
        Console.Write("Escolha uma opcao: ");

        return int.Parse(Console.ReadLine()!);
    }

    static void Main()
    {
        Heroi[] herois = new Heroi[5];

        Equipe equipe = new Equipe();
        equipe.Herois = new Heroi[3];
        equipe.Quantidade = 0;

        int quantidade = 0;
        int opcao = 0;

        while (opcao != 4)
        {
            opcao = menuPrincipal();

            switch (opcao)
            {
                case 1:
                    if (quantidade < 5)
                    {
                        herois[quantidade] = cadastrarHeroi();
                        quantidade++;
                        equipe.Quantidade = 0;
                        Console.WriteLine("\nHeroi cadastrado!");
                    }
                    else
                    {
                        Console.WriteLine("\nLimite de 5 herois atingido!");
                    }
                    break;

                case 2:
                    selecionarEquipe(herois, quantidade, ref equipe);
                    break;

                case 3:
                    exibirEquipe(equipe);
                    break;

                case 4:
                    Console.WriteLine("\nPrograma encerrado!");
                    break;

                default:
                    Console.WriteLine("\nOpcao invalida!");
                    break;
            }
        }
    }
}
