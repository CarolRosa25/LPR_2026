#include <iostream>
using namespace std;

int main() {
    int num [5];
    int i;
    int maior, posicao;
    
    for (i = 0; i < 5; i++) {
        cout << "Digite um número inteiro: ";
        cin >> num[i];
    }
    
    maior = num[0];
    posicao = 0;
    
    for (i = 1; i < 5; i++) {
        if (num[i] > maior) {
            maior = num[i];
            posicao = i;
        }
    }
    
    cout << "Maior valor: " << maior;
    cout << "\nPosição: " << posicao << endl;
}