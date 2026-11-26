// Crie uma struct chamada Piloto contendo: 
// Nome, Equipe, Pontuação
// O programa deverá utilizar uma lista para armazenar os competidores.
// Implemente as seguintes funções:
// ● CadastrarPiloto()
// ● ExibirRanking()
// ● CalcularPontuacaoMedia()
// ● ExibirMelhorEquipe()
// O programa deve:
// ● Cadastrar 10 pilotos.
// ● Exibir um ranking em ordem decrescente de pontuação.
// ● Calcular a média de pontos do campeonato.
// ● Exibir quantos pilotos ficaram acima da média.
// ● Determinar qual equipe possui a maior soma de pontos.

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

struct Piloto {
    string nome;
    string equipe;
    double pontuacao;
};

void CadastrarPiloto(vector<Piloto>& pilotos) {
    for (int i = 0; i < 10; i++) {
        Piloto p;
        cout << "\nPiloto " << i + 1 << "\nNome: ";
        getline(cin >> ws, p.nome);
        cout << "Equipe: ";
        getline(cin, p.equipe);
        cout << "Pontuacao: ";
        cin >> p.pontuacao;
        pilotos.push_back(p);
    }
}

void ExibirRanking(vector<Piloto> pilotos) {
    sort(pilotos.begin(), pilotos.end(),
        [](const Piloto& a, const Piloto& b) {
            return a.pontuacao > b.pontuacao;
        });
    cout << "\nRANKING\n";
    for (int i = 0; i < (int)pilotos.size(); i++)
        cout << i + 1 << " - " << pilotos[i].nome << " | "
             << pilotos[i].equipe << " | " << pilotos[i].pontuacao << " pontos\n";
}

double CalcularPontuacaoMedia(const vector<Piloto>& pilotos) {
    double soma = 0;
    for (const Piloto& p : pilotos) soma += p.pontuacao;
    return soma / pilotos.size();
}

void ExibirMelhorEquipe(const vector<Piloto>& pilotos) {
    vector<string> equipes;
    vector<double> totais;
    for (const Piloto& p : pilotos) {
        auto it = find(equipes.begin(), equipes.end(), p.equipe);
        if (it == equipes.end()) {
            equipes.push_back(p.equipe);
            totais.push_back(p.pontuacao);
        } else {
            totais[it - equipes.begin()] += p.pontuacao;
        }
    }

    int melhor = 0;
    for (int i = 1; i < (int)totais.size(); i++)
        if (totais[i] > totais[melhor]) melhor = i;

    cout << "Melhor equipe: " << equipes[melhor]
         << " (" << totais[melhor] << " pontos)\n";
}

int main() {
    vector<Piloto> pilotos;
    CadastrarPiloto(pilotos);
    ExibirRanking(pilotos);

    double media = CalcularPontuacaoMedia(pilotos);
    int acima = 0;
    for (const Piloto& p : pilotos)
        if (p.pontuacao > media) acima++;

    cout << "\nMedia do campeonato: " << media;
    cout << "\nPilotos acima da media: " << acima << endl;
    ExibirMelhorEquipe(pilotos);
    return 0;
}
