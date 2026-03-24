#include <iostream>
using namespace std;

int main() {
 int A, B;

cout << "Digite um número inteiro: ";
cin >> A;
cout << "Digite um número inteiro: ";
cin >> B;

    if (A % B == 0 || B % A == 0) {
        cout << "São Multiplos";
    } else {
        cout << "Nao são Multiplos";
    }

    return 0;
}