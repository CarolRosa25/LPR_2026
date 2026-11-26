// Crie um programa que permita  ao usuário cadastrar notas de alunos em  uma lista. O programa deve:
// ● Solicitar ao usuário 5 notas.
// ● Armazenar as notas em uma lista.
// ● Exibir:
// ○ Todas as notas cadastradas;
// ○ A maior nota;
// ○ A menor nota;
// ○ A média das notas.

#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
using namespace std;

int main() {
    vector<double> notas;
    double nota;

    for (int i = 0; i < 5; i++) {
        cout << "Digite a nota " << i + 1 << ": ";
        cin >> nota;
        notas.push_back(nota);
    }

    cout << "\nNotas cadastradas: ";
    for (double n : notas) cout << n << " ";

    double maior = *max_element(notas.begin(), notas.end());
    double menor = *min_element(notas.begin(), notas.end());
    double media = accumulate(notas.begin(), notas.end(), 0.0) / notas.size();

    cout << "\nMaior nota: " << maior;
    cout << "\nMenor nota: " << menor;
    cout << "\nMedia: " << media << endl;
    return 0;
}
