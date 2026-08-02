#include <iostream>
#include <string>

using namespace std;

struct Heroi
{
    string nome;
    string poder;
    int pontuacao;
};

struct Equipe
{
    Heroi membros[3];
    int pontuacaoTotal;
};

void cadastrarHeroi(Heroi listaHerois[], int &totalCadastrados)
{
    if (totalCadastrados >= 5)
    {
        cout << "\n[Erro] Limite máximo de 5 heróis cadastrados atingido!" << endl;
        return;
    }

    cout << "\nCadastro do Herói " << totalCadastrados + 1 << endl;

    cout << "Digite o nome do herói: ";
    cin.ignore();
    getline(cin, listaHerois[totalCadastrados].nome);

    cout << "Digite o poder do herói: ";
    getline(cin, listaHerois[totalCadastrados].poder);

    cout << "Digite a pontuação do herói: ";
    cin >> listaHerois[totalCadastrados].pontuacao;

    totalCadastrados++;

    cout << "Herói cadastrado com sucesso!" << endl;
}

int calcularPontuacaoTotal(Equipe minhaEquipe)
{
    int soma = 0;

    for (int i = 0; i < 3; i++)
    {
        soma += minhaEquipe.membros[i].pontuacao;
    }

    return soma;
}

void selecionarEquipe(Heroi listaHerois[], int totalCadastrados, Equipe &minhaEquipe)
{
    if (totalCadastrados < 3)
    {
        cout << "\n[Erro] É necessário cadastrar pelo menos 3 heróis antes de montar a equipe!" << endl;
        return;
    }

    cout << "\nSeleção de Equipe (Escolha 3 heróis)" << endl;

    int selecionados = 0;

    while (selecionados < 3)
    {
        cout << "\nHeróis Disponíveis:" << endl;

        for (int i = 0; i < totalCadastrados; i++)
        {
            cout << i << " - " << listaHerois[i].nome
                 << " (Poder: " << listaHerois[i].poder
                 << " | Pontos: " << listaHerois[i].pontuacao << ")" << endl;
        }

        int escolha;

        cout << "Escolha o integrante " << selecionados + 1
             << " (Digite o índice de 0 a " << totalCadastrados - 1 << "): ";
        cin >> escolha;

        if (escolha >= 0 && escolha < totalCadastrados)
        {
            minhaEquipe.membros[selecionados] = listaHerois[escolha];
            selecionados++;

            cout << "Herói adicionado à equipe!" << endl;
        }
        else
        {
            cout << "Índice inválido! Tente novamente." << endl;
        }
    }

    minhaEquipe.pontuacaoTotal = calcularPontuacaoTotal(minhaEquipe);

    cout << "\nEquipe escalada com sucesso!" << endl;
}

void exibirEquipe(Equipe minhaEquipe)
{
    if (minhaEquipe.membros[0].nome == "")
    {
        cout << "\nA equipe ainda não foi formada. Selecione os membros na opção 2!" << endl;
        return;
    }

    cout << "\nIntegrantes da Equipe:" << endl;

    for (int i = 0; i < 3; i++)
    {
        cout << "- Nome: " << minhaEquipe.membros[i].nome
             << " | Poder: " << minhaEquipe.membros[i].poder
             << " | Pontos: " << minhaEquipe.membros[i].pontuacao << endl;
    }

    cout << "Pontuação Total: " << minhaEquipe.pontuacaoTotal << " pontos." << endl;
}

void menuPrincipal()
{
    Heroi catalogoHerois[5];
    int totalCadastrados = 0;

    Equipe minhaEquipe;
    minhaEquipe.pontuacaoTotal = 0;

    int opcao;

    do
    {
        cout << "\nSistema de Seleção de Heróis da Marvel" << endl;
        cout << "1 - Cadastrar Herói" << endl;
        cout << "2 - Selecionar Equipe (3 Heróis)" << endl;
        cout << "3 - Exibir Equipe e Pontuação" << endl;
        cout << "4 - Sair do Programa" << endl;
        cout << "Escolha uma opção: ";
        cin >> opcao;

        switch (opcao)
        {
        case 1:
            cadastrarHeroi(catalogoHerois, totalCadastrados);
            break;

        case 2:
            selecionarEquipe(catalogoHerois, totalCadastrados, minhaEquipe);
            break;

        case 3:
            exibirEquipe(minhaEquipe);
            break;

        case 4:
            cout << "\nEncerrando o sistema. Até logo!" << endl;
            break;

        default:
            cout << "\nOpção inválida! Escolha um número de 1 a 4." << endl;
            break;
        }

    } while (opcao != 4);
}

int main()
{
    menuPrincipal();
    return 0;
}