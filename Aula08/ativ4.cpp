#include <iostream>
# include <array>
using namespace std;

struct Heroi {
    string nome;
    string poder;
    int pontuacao;
};

struct Equipe {
    Heroi membros[3];
    int pontuacaoTotal;
};

Heroi cadastrarHeroi() {
    Heroi h;
    for (int i = 0; i < 5; i++) {
        cout << "Digite o nome do heroi: ";
        cin >> h.nome;
        cout << "Digite o poder do heroi: ";
        cin >> h.poder;
        cout << "Digite a pontuacao do heroi: ";
        cin >> h.pontuacao; 

    }
    return h;
}

Equipe selecionarEquipe() {
    Equipe e;
    cout << "Selecione os membros da equipe (3 herois):" << endl;
    for (int i = 0; i < 3; i++) {
        e.membros[i] = cadastrarHeroi();
    }
    return e;
}

int main() {
    Equipe equipe = selecionarEquipe();
    Heroi heroi = cadastrarHeroi();

    return 0;
}


