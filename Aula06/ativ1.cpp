#include <iostream>
using namespace std;

int reverterNumero(int num) {
    int reverso = 0;

    while (num != 0) {
        int digito = num % 10;    
        reverso = reverso * 10 + digito;
        num /= 10;                
    }

    return reverso;
}

int main() {
    int numero;

    cout << "Digite um numero: ";
    cin >> numero;

    cout << "Numero invertido: " << reverterNumero(numero) << endl;

    return 0;
}
