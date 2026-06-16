#include <iostream>
using namespace std;

int main() {
    int i, j;
    int soma = 0;
    int matriz[3][3];

    for (i = 0; i < 3; i++) {
        for (j = 0; j < 3; j++) {
            cout << "Digite um número inteiro: ";
            std::cout << matriz[i][j] << std::endl;
        }
    }
    soma += matriz[i][j];

    cout << "Matriz: " << matriz << endl;
    cout << "Soma: " << soma << endl;
}