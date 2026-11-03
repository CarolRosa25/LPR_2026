// Crie uma struct chamada Piloto contendo: Nome, Equipe, Pontuação
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
#include <list>
using namespace std;

struct Piloto {
    string nome;
    string equipe;
    int pontuacao;
};

list<Piloto> pilotos;

void CadastrarPiloto() {
    Piloto piloto;
    cout << "Digite o nome do piloto: ";
    cin >> piloto.nome;
    cout << "Digite a equipe do piloto: ";
    cin >> piloto.equipe;
    cout << "Digite a pontuação do piloto: ";
    cin >> piloto.pontuacao;
    pilotos.push_back(piloto);
}

void ExibirRanking() {
    pilotos.sort([](const Piloto& a, const Piloto& b) {
        return a.pontuacao > b.pontuacao;
    });
    cout << "Ranking dos pilotos:\n";
    for (const auto& piloto : pilotos) {
        cout << piloto.nome << " - " << piloto.equipe << " - " << piloto.pontuacao << " pontos\n";
    }
}

void CalcularPontuacaoMedia() {
    int soma = 0;
    for (const auto& piloto : pilotos) {
        soma += piloto.pontuacao;
    }
    double media = static_cast<double>(soma) / pilotos.size();
    cout << "Pontuação média do campeonato: " << media << endl;

    int acimaDaMedia = 0;
    for (const auto& piloto : pilotos) {
        if (piloto.pontuacao > media) {
            acimaDaMedia++;
        }
    }
    cout << "Número de pilotos acima da média: " << acimaDaMedia << endl;
}

void ExibirMelhorEquipe() {
    list<string> equipes;
    list<int> pontuacoes;

    for (const auto& piloto : pilotos) {
        auto it = find(equipes.begin(), equipes.end(), piloto.equipe);
        if (it == equipes.end()) {
            equipes.push_back(piloto.equipe);
            pontuacoes.push_back(piloto.pontuacao);
        } else {
            int index = distance(equipes.begin(), it);
            pontuacoes[index] += piloto.pontuacao;
        }
    }

    int maxPontuacao = 0;
    string melhorEquipe;
    for (size_t i = 0; i < equipes.size(); ++i) {
        if (pontuacoes[i] > maxPontuacao) {
            maxPontuacao = pontuacoes[i];
            melhorEquipe = equipes[i];
        }
    }
    cout << "Melhor equipe: " << melhorEquipe << " com " << maxPontuacao << " pontos\n";
}
