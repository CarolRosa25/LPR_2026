#include <iostream> 
#include <iomanip>
using namespace std;

int main() {
int codigo1, codigo2, pecas1, pecas2;
double valorUnitario1, valorUnitario2, valor;

cout << "Digite o código de uma peça 1: ";
cin >> codigo1;

cout << "Digite o número de peças 1: ";
cin >> pecas1;

cout << "Digite o valor unitário de cada peça 1: ";
cin >> valorUnitario1;

cout << "Digite o código de uma peça 2: ";
cin >> codigo2;

cout << "Digite o número de peças 2: ";
cin >> pecas2;

cout << "Digite o valor unitário de cada peça 2: ";
cin >> valorUnitario2;

valor = (pecas1*valorUnitario1)+(pecas2*valorUnitario2);

cout << "Valor a pagar = R$ " << valor << endl;


}