// Uma empresa deseja controlar os chamados abertos pelos funcionários.
// Crie uma struct chamada Chamado contendo:
// Numero, Solicitante, Setor, Prioridade (1 a 3), Status e Descricao
// O programa deve possuir as seguintes funções:
// ● cadastrarChamado(): Permite cadastrar até 10 chamados. Ao cadastrar, o status inicial deve ser: Aberto
// ● listarChamados(): Exibe todos os chamados cadastrados.
// ● atualizarStatus(): Solicita o número do chamado e permite alterar o status para: Em andamento, Resolvido, Cancelado
// ● classificarPrioridade() Recebe a prioridade e retorna: 1 = Baixa, 2 = Média, 3 = Alta
// ● estatisticas() Exibe Quantos chamados estão abertos; Quantos estão em andamento; Quantos foram resolvidos; Quantos foram cancelados.

#include <iostream>
#include <string>
using namespace std;

struct Chamado {
    int numero;
    string solicitante;
    string setor;
    int prioridade;
    string status;
    string descricao;
};

void cadastrarChamado(Chamado chamados[], int &total) {
    if (total >= 10) {
        cout << "\nLimite maximo de 10 chamados atingido!" << endl;
        return;
    }

    cout << "\nCadastrar Chamado" << endl;
    cout << "Numero do chamado: ";
    cin >> chamados[total].numero;

    cout << "Solicitante: ";
    getline(cin, chamados[total].solicitante);

    cout << "Setor: ";
    getline(cin, chamados[total].setor);

    cout << "Prioridade (1 = Baixa, 2 = Media, 3 = Alta): ";
    cin >> chamados[total].prioridade;

    cout << "Descricao: ";
    getline(cin, chamados[total].descricao);

    chamados[total].status = "Aberto";
    total++;

    cout << "Chamado cadastrado com sucesso!" << endl;
}

string classificarPrioridade(int prioridade) {
    if (prioridade == 1) return "Baixa";
    if (prioridade == 2) return "Media";
    if (prioridade == 3) return "Alta";
    return "Desconhecida";
}

void listarChamados(Chamado chamados[], int total) {
    if (total == 0) {
        cout << "\nNenhum chamado cadastrado ate o momento." << endl;
        return;
    }

    cout << "\nLista de Chamados" << endl;
    for (int i = 0; i < total; i++) {
        cout << "Chamado #" << chamados[i].numero << endl;
        cout << "  Solicitante: " << chamados[i].solicitante << " | Setor: " << chamados[i].setor << endl;
        cout << "  Prioridade: " << classificarPrioridade(chamados[i].prioridade) << endl;
        cout << "  Status: " << chamados[i].status << endl;
        cout << "  Descricao: " << chamados[i].descricao << endl;
    }
}

void atualizarStatus(Chamado chamados[], int total) {
    if (total == 0) {
        cout << "\nNenhum chamado cadastrado para atualizar." << endl;
        return;
    }

    int numProcurado;
    cout << "\nDigite o numero do chamado que deseja atualizar: ";
    cin >> numProcurado;

    int indiceEncontrado = -1;
    for (int i = 0; i < total; i++) {
        if (chamados[i].numero == numProcurado) {
            indiceEncontrado = i;
            break;
        }
    }

    if (indiceEncontrado == -1) {
        cout << "Chamado nao encontrado!" << endl;
        return;
    }

    int opcaoStatus;
    cout << "\nSelecione o novo status:" << endl;
    cout << "1 - Em andamento" << endl;
    cout << "2 - Resolvido" << endl;
    cout << "3 - Cancelado" << endl;
    cout << "Escolha uma opcao: ";
    cin >> opcaoStatus;

    if (opcaoStatus == 1) chamados[indiceEncontrado].status = "Em andamento";
    else if (opcaoStatus == 2) chamados[indiceEncontrado].status = "Resolvido";
    else if (opcaoStatus == 3) chamados[indiceEncontrado].status = "Cancelado";
    else cout << "Opcao invalida! O status nao foi alterado." << endl;

    if (opcaoStatus >= 1 && opcaoStatus <= 3) {
        cout << "Status atualizado com sucesso!" << endl;
    }
}

void estatisticas(Chamado chamados[], int total) {
    int abertos = 0, emAndamento = 0, resolvidos = 0, cancelados = 0;

    for (int i = 0; i < total; i++) {
        if (chamados[i].status == "Aberto") abertos++;
        else if (chamados[i].status == "Em andamento") emAndamento++;
        else if (chamados[i].status == "Resolvido") resolvidos++;
        else if (chamados[i].status == "Cancelado") cancelados++;
    }

    cout << "\nEstatisticas dos Chamados" << endl;
    cout << "Abertos: " << abertos << endl;
    cout << "Em andamento: " << emAndamento << endl;
    cout << "Resolvidos: " << resolvidos << endl;
    cout << "Cancelados: " << cancelados << endl;
}

int main() {
    Chamado lista[10];
    int totalChamados = 0;
    int opcao;

    do {
        cout << "\nSistema de Chamados" << endl;
        cout << "1 - Cadastrar Chamado" << endl;
        cout << "2 - Listar Chamados" << endl;
        cout << "3 - Atualizar Status" << endl;
        cout << "4 - Exibir Estatisticas" << endl;
        cout << "5 - Sair" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1: cadastrarChamado(lista, totalChamados); break;
            case 2: listarChamados(lista, totalChamados); break;
            case 3: atualizarStatus(lista, totalChamados); break;
            case 4: estatisticas(lista, totalChamados); break;
            case 5: cout << "Encerrando o programa..." << endl; break;
            default: cout << "Opcao invalida!" << endl;
        }
    } while (opcao != 5);

    return 0;
}