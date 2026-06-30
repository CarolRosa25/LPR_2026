#include <iostream>
using namespace std;

int main() {
    int i, j;
    int soma = 0;
    int matriz[3][3];

    for (i = 0; i < 3; i++) {
        for (j = 0; j < 3; j++) {
            cout << "Digite um número inteiro: ";
            cin >> matriz[i][j];
        }
    }
    soma += matriz[i][j];

    cout << "Matriz: " << endl;
    for (i = 0; i < 3; i++) {
        for (j = 0; j < 3; j++) {
            cout << matriz[i][j] << ' ';
        }
        cout << '\n';
    }
    cout << "Soma: " << soma << endl;
}