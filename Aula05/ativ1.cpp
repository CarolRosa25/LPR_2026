#include <iostream>
using namespace std;

int main() {
 int quantidade;
 int numero;
 double contador;
 double acumulador;

 cout << "Digite uma quantidade de números pares (em seguida você digitará): " << endl;
 cin >> quantidade;
 cout << "Digite os números positivos: " << endl;
 cin >> numero;
   while (numero%2 == 0) {
     acumulador += numero;
     quantidade++;
     cin >> numero;
   }
 double media = acumulador/contador;
 cout << "Média: " << media << endl;
}