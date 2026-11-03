// Construa uma lista de 100 números aleatórios
// Crie um algoritmo que coloque-os em ordem crescente e imprima-os
// A partir dessa lista ordenada, remova todos os números pares e imprima a lista novamente.
// Por fim imprima quais números se repetem, se existe algum número repetido.

#include <iostream>
#include <list>
#include <algorithm>
using namespace std;

int main() {
    list<int> numeros;
    for (int i = 0; i < 100; i++) {
        numeros.push_back(rand() % 100 + 1);
    }
    numeros.sort();

    cout << "Números ordenados:" << endl;
    for (const auto& n : numeros) {
        cout << n << " ";
    }
    cout << endl;

    numeros.remove_if([](int n) {
        return n % 2 == 0;
    });
    
    cout << "Números após remover os pares:" << endl;
    for (const auto& n : numeros) {
        cout << n << " ";
    }
    cout << endl;

    cout << "Números que se repetem:" << endl;
    list<int> impressos;

    for (const auto& n : numeros) {
        if (count(numeros.begin(), numeros.end(), n) > 1 &&
            count(impressos.begin(), impressos.end(), n) == 0)
        {
            cout << n << " ";
            impressos.push_back(n);
        }
    }
    return 0;
}