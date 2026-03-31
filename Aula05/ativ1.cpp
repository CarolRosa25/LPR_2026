#include <iostream>
using namespace std;

int main() {
    int quantidade, numero;
    int contador = 0;
    int soma = 0;
    int i = 0;

    cout << "Quantos numeros deseja digitar? ";
    cin >> quantidade;

    while (i < quantidade) {
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;   // acumulador
            contador++;       // contador
        }

        i++;
    }

    if (contador > 0) {
        double media = (double)soma / contador;
        cout << "Media dos pares: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }

    return 0;
}