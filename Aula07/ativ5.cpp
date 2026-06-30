#include <iostream>
using namespace std;

int main() {
    int matriz[3][3];
    int soma = 0;

    cout << "Digite os elementos da matriz 3x3:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << "Elemento [" << i << "][" << j << "]: ";
            cin >> matriz[i][j];
        }
    }

    cout << "\nMatriz digitada:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matriz[i][j] << "\t";
            soma += matriz[i][j]; 
        }
        cout << endl;
    }

    cout << "\nSoma = " << soma << endl;

    return 0;
}