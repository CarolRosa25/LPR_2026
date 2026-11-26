#include <iostream>
#include <string>
using namespace std;

struct Filme {
    string Titulo;
    string Diretor;
    int AnoLancamento;
    int DuracaoMinutos;
};

int main() {
    Filme filmes[3];

    for (int i = 0; i < 3; i++) {
        cout << "\nCadastro do filme " << i + 1 << endl;

        cout << "Titulo: ";
        getline(cin, filmes[i].Titulo);

        cout << "Diretor: ";
        getline(cin, filmes[i].Diretor);

        cout << "Ano de lancamento: ";
        cin >> filmes[i].AnoLancamento;

        cout << "Duracao em minutos: ";
        cin >> filmes[i].DuracaoMinutos;

        cin.ignore();
    }

    int maisAntigo = 0;

    for (int i = 1; i < 3; i++) {
        if (filmes[i].AnoLancamento < filmes[maisAntigo].AnoLancamento) {
            maisAntigo = i;
        }
    }

    cout << "\n===== FILMES CADASTRADOS =====\n";

    for (int i = 0; i < 3; i++) {
        cout << "\nTitulo: " << filmes[i].Titulo << endl;
        cout << "Diretor: " << filmes[i].Diretor << endl;
        cout << "Ano: " << filmes[i].AnoLancamento << endl;
        cout << "Duracao: " << filmes[i].DuracaoMinutos << " minutos" << endl;
    }

    cout << "\n===== FILME MAIS ANTIGO =====\n";
    cout << "Titulo: " << filmes[maisAntigo].Titulo << endl;
    cout << "Ano: " << filmes[maisAntigo].AnoLancamento << endl;

    return 0;
}
