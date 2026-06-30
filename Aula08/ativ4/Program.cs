// Desenvolva um programa em C# que simule um sistema de seleção de heróis da  Marvel para uma equipe. 
// O programa deve ter as seguintes funcionalidades:

// Cadastro de Heróis: Crie uma função chamada cadastrarHeroi que permita ao usuário inserir 
// o nome, poder e pontuação de um herói da Marvel. A função deve solicitar essas informações ao usuário 
// e armazená-las em UM STRUCT. O programa deve permitir o cadastro de até 5 heróis. 

// Seleção de Equipe: Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis 
// para formar sua equipe. A função deve exibir os heróis cadastrados e permitir que o usuário selecione 
// quais heróis deseja incluir em sua equipe. O usuário deve ser capaz de selecionar três heróis para sua equipe.

// Pontuação Total da Equipe: Crie uma função chamada calcularPontuacaoTotal que calcule a pontuação total da equipe 
// com base nos heróis selecionados. A pontuação total da equipe deve ser a soma das pontuações individuais de cada 
//herói selecionado.

// Exibição da Equipe: Crie uma função chamada exibirEquipe que exiba os heróis selecionados para a equipe, seu poder 
// e a pontuação total da equipe.

// Menu: Crie uma função chamada menuPrincipal que exiba um menu com as opções disponíveis para o usuário (cadastro de heróis, 
// seleção de equipe, exibição da equipe e sair do programa). O usuário deve poder escolher uma das opções do menu e o programa 
// deve executar a funcionalidade correspondente.

// ● O programa deve continuar em execução até que o usuário escolha a opção de sair.
// ● Utilize STRUCTS para armazenar as informações dos heróis e da equipe.
// ● Não utilize classes ou listas! Pode (ou será que deve) utilizar vetores.

using System;
class Ativ
{
    struct Heroi
    {
        public string nome;
        public string poder;
        public int pontuacao;
    }

    struct Equipe
    {
        public Heroi[] membros;
        public int pontuacaoTotal;
    }

    static void cadastrarHeroi(Heroi[] listaHerois, ref int totalCadastrados)
    {
        if (totalCadastrados >= 5)
        {
            Console.WriteLine("\n[Erro] Limite máximo de 5 heróis cadastrados atingido!");
            return;
        }

        Console.WriteLine($"\nCadastro do Herói {totalCadastrados + 1}");
        Console.Write("Digite o nome do herói: ");
        listaHerois[totalCadastrados].nome = Console.ReadLine()!;

        Console.Write("Digite o poder do herói: ");
        listaHerois[totalCadastrados].poder = Console.ReadLine()!;

        Console.Write("Digite a pontuação do herói: ");
        listaHerois[totalCadastrados].pontuacao = int.Parse(Console.ReadLine()!);

        totalCadastrados++;
        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe(Heroi[] listaHerois, int totalCadastrados, ref Equipe minhaEquipe)
    {
        if (totalCadastrados < 3)
        {
            Console.WriteLine("\n[Erro] É necessário cadastrar pelo menos 3 heróis antes de montar a equipe!");
            return;
        }

        Console.WriteLine("\nSeleção de Equipe (Escolha 3 heróis)");
        int selecionados = 0;

        while (selecionados < 3)
        {
            Console.WriteLine("\nHeróis Disponíveis:");
            for (int i = 0; i < totalCadastrados; i++)
            {
                Console.WriteLine($"{i} - {listaHerois[i].nome} (Poder: {listaHerois[i].poder} | Pontos: {listaHerois[i].pontuacao})");
            }

            Console.Write($"Escolha o integrante {selecionados + 1} (Digite o índice de 0 a {totalCadastrados - 1}): ");
            int escolha = int.Parse(Console.ReadLine()!);

            if (escolha >= 0 && escolha < totalCadastrados)
            {
                minhaEquipe.membros[selecionados] = listaHerois[escolha];
                selecionados++;
                Console.WriteLine("Herói adicionado à equipe!");
            }
            else
            {
                Console.WriteLine("Índice inválido! Tente novamente.");
            }
        }

        minhaEquipe.pontuacaoTotal = calcularPontuacaoTotal(minhaEquipe);
        Console.WriteLine("\nEquipe escalada com sucesso!");
    }

    static int calcularPontuacaoTotal(Equipe minhaEquipe)
    {
        int soma = 0;
        for (int i = 0; i < 3; i++)
        {
            soma += minhaEquipe.membros[i].pontuacao;
        }
        return soma;
    }

    static void exibirEquipe(Equipe minhaEquipe)
    {
        if (minhaEquipe.membros[0].nome == null)
        {
            Console.WriteLine("\nA equipe ainda não foi formada. Selecione os membros na opção 2!");
            return;
        }

        Console.WriteLine("\nIntegrantes da Equipe:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"- Nome: {minhaEquipe.membros[i].nome} | Poder: {minhaEquipe.membros[i].poder} | Pontos: {minhaEquipe.membros[i].pontuacao}");
        }
        Console.WriteLine($"Pontuação Total: {minhaEquipe.pontuacaoTotal} pontos.");
    }

    static void menuPrincipal()
    {
        Heroi[] catalogoHerois = new Heroi[5];
        int totalCadastrados = 0;

        Equipe minhaEquipe = new Equipe();
        minhaEquipe.membros = new Heroi[3]; 
        minhaEquipe.pontuacaoTotal = 0;

        int opcao;

        do
        {
            Console.WriteLine("\nSistema de Seleção de Heróis da Marvel");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe (3 Heróis)");
            Console.WriteLine("3 - Exibir Equipe e Pontuação");
            Console.WriteLine("4 - Sair do Programa");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi(catalogoHerois, ref totalCadastrados);
                    break;
                case 2:
                    selecionarEquipe(catalogoHerois, totalCadastrados, ref minhaEquipe);
                    break;
                case 3:
                    exibirEquipe(minhaEquipe);
                    break;
                case 4:
                    Console.WriteLine("\nEncerrando o sistema. Até logo!");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Escolha um número de 1 a 4.");
                    break;
            }

        } while (opcao != 4); 
    }

    static void Main()
    {
        menuPrincipal();
    }
}