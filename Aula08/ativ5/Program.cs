using System;

class Program
{
    public struct Chamado
    {
        public int Numero;
        public string Solicitante;
        public string Setor;
        public int Prioridade;
        public string Status;
        public string Descricao;
    }

    static int cadastrarChamado(Chamado[] chamados, int quantidade)
    {
        if (quantidade >= 10)
        {
            Console.WriteLine("\nLimite de chamados atingido!");
            return quantidade;
        }

        Console.WriteLine("\n===== CADASTRO DE CHAMADO =====");

        Console.Write("Numero: ");
        chamados[quantidade].Numero = int.Parse(Console.ReadLine()!);

        Console.Write("Solicitante: ");
        chamados[quantidade].Solicitante = Console.ReadLine()!;

        Console.Write("Setor: ");
        chamados[quantidade].Setor = Console.ReadLine()!;

        Console.Write("Prioridade (1 a 3): ");
        chamados[quantidade].Prioridade = int.Parse(Console.ReadLine()!);

        while (chamados[quantidade].Prioridade < 1 ||
               chamados[quantidade].Prioridade > 3)
        {
            Console.WriteLine("Prioridade invalida!");
            Console.Write("Digite novamente (1 a 3): ");
            chamados[quantidade].Prioridade = int.Parse(Console.ReadLine()!);
        }

        Console.Write("Descricao: ");
        chamados[quantidade].Descricao = Console.ReadLine()!;

        chamados[quantidade].Status = "Aberto";

        quantidade++;

        Console.WriteLine("\nChamado cadastrado!");

        return quantidade;
    }

    static string classificarPrioridade(int prioridade)
    {
        if (prioridade == 1)
        {
            return "Baixa";
        }
        else if (prioridade == 2)
        {
            return "Media";
        }
        else
        {
            return "Alta";
        }
    }

    static void listarChamados(Chamado[] chamados, int quantidade)
    {
        if (quantidade == 0)
        {
            Console.WriteLine("\nNenhum chamado cadastrado!");
            return;
        }

        Console.WriteLine("\n===== LISTA DE CHAMADOS =====");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("\nNumero: " + chamados[i].Numero);
            Console.WriteLine("Solicitante: " + chamados[i].Solicitante);
            Console.WriteLine("Setor: " + chamados[i].Setor);
            Console.WriteLine("Prioridade: " + classificarPrioridade(chamados[i].Prioridade));
            Console.WriteLine("Status: " + chamados[i].Status);
            Console.WriteLine("Descricao: " + chamados[i].Descricao);
        }
    }

    static void atualizarStatus(Chamado[] chamados, int quantidade)
    {
        Console.Write("\nDigite o numero do chamado: ");
        int numero = int.Parse(Console.ReadLine()!);

        int posicao = -1;

        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Numero == numero)
            {
                posicao = i;
            }
        }

        if (posicao == -1)
        {
            Console.WriteLine("\nChamado nao encontrado!");
            return;
        }

        Console.WriteLine("\nEscolha o novo status:");
        Console.WriteLine("1 - Em andamento");
        Console.WriteLine("2 - Resolvido");
        Console.WriteLine("3 - Cancelado");
        Console.Write("Opcao: ");

        int opcao = int.Parse(Console.ReadLine()!);

        if (opcao == 1)
        {
            chamados[posicao].Status = "Em andamento";
        }
        else if (opcao == 2)
        {
            chamados[posicao].Status = "Resolvido";
        }
        else if (opcao == 3)
        {
            chamados[posicao].Status = "Cancelado";
        }
        else
        {
            Console.WriteLine("\nOpcao invalida!");
            return;
        }

        Console.WriteLine("\nStatus atualizado!");
    }

    static void estatisticas(Chamado[] chamados, int quantidade)
    {
        int abertos = 0;
        int andamento = 0;
        int resolvidos = 0;
        int cancelados = 0;

        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Status == "Aberto")
            {
                abertos++;
            }
            else if (chamados[i].Status == "Em andamento")
            {
                andamento++;
            }
            else if (chamados[i].Status == "Resolvido")
            {
                resolvidos++;
            }
            else if (chamados[i].Status == "Cancelado")
            {
                cancelados++;
            }
        }

        Console.WriteLine("\n===== ESTATISTICAS =====");
        Console.WriteLine("Chamados abertos: " + abertos);
        Console.WriteLine("Chamados em andamento: " + andamento);
        Console.WriteLine("Chamados resolvidos: " + resolvidos);
        Console.WriteLine("Chamados cancelados: " + cancelados);
    }

    static int menuPrincipal()
    {
        Console.WriteLine("\n===== MENU DE CHAMADOS =====");
        Console.WriteLine("1 - Cadastrar chamado");
        Console.WriteLine("2 - Listar chamados");
        Console.WriteLine("3 - Atualizar status");
        Console.WriteLine("4 - Estatisticas");
        Console.WriteLine("5 - Sair");
        Console.Write("Escolha uma opcao: ");

        return int.Parse(Console.ReadLine()!);
    }

    static void Main()
    {
        Chamado[] chamados = new Chamado[10];

        int quantidade = 0;
        int opcao = 0;

        while (opcao != 5)
        {
            opcao = menuPrincipal();

            switch (opcao)
            {
                case 1:
                    quantidade = cadastrarChamado(chamados, quantidade);
                    break;

                case 2:
                    listarChamados(chamados, quantidade);
                    break;

                case 3:
                    atualizarStatus(chamados, quantidade);
                    break;

                case 4:
                    estatisticas(chamados, quantidade);
                    break;

                case 5:
                    Console.WriteLine("\nPrograma encerrado!");
                    break;

                default:
                    Console.WriteLine("\nOpcao invalida!");
                    break;
            }
        }
    }
}

