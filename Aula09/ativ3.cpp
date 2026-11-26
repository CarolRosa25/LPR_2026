// Construa uma lista de 100 números aleatórios 
// Crie um algoritmo que coloque-os em ordem crescente e imprima-os
// A partir dessa lista ordenada, remova todos os números pares e imprima a lista novamente.
// Por fim imprima quais números se repetem, se existe algum número repetido.

#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>
using namespace std;

int main() {
    srand((unsigned)time(nullptr));
    vector<int> numeros;

    for (int i = 0; i < 100; i++)
        numeros.push_back(rand() % 100); // numeros de 0 a 99

    sort(numeros.begin(), numeros.end());

    cout << "Lista em ordem crescente:\n";
    for (int n : numeros) cout << n << " ";
    cout << "\n";

    numeros.erase(remove_if(numeros.begin(), numeros.end(),
        [](int n) { return n % 2 == 0; }), numeros.end());

    cout << "\nLista sem numeros pares:\n";
    for (int n : numeros) cout << n << " ";
    cout << "\n\nNumeros repetidos:\n";

    bool encontrou = false;
    for (int i = 0; i < (int)numeros.size(); i++) {
        if (i > 0 && numeros[i] == numeros[i - 1]) continue;
        int ocorrencias = count(numeros.begin(), numeros.end(), numeros[i]);
        if (ocorrencias > 1) {
            cout << numeros[i] << " aparece " << ocorrencias << " vezes\n";
            encontrou = true;
        }
    }
    if (!encontrou) cout << "Nenhum numero repetido.\n";
    return 0;
}
