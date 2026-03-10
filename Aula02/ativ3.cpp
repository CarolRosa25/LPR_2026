#include <iostream> 
#include <iomanip>
using namespace std;

int main() {
int numero;
double horas, valorHora, salario;

cout << "Digite o número do funcionário: ";
cin >> numero;

cout << "Digite o número de horas trabalhadas: ";
cin >> horas;

cout << "Digite o valor recebido por hora: ";
cin >> valorHora;

salario = horas * valorHora;

cout << "Número = " << numero << endl;
cout << fixed << setprecision(2);
cout << "Salário = " << salario << endl;

return 0;
}