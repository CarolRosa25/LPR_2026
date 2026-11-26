//  Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
// A classe funcionário deve conter os seguintes métodos:
// ○ Mostrar os dados do funcionário (nome e salário líquido). 
// ○ Aumentar o salário do funcionário com base em uma porcentagem dada 
// ● OBS: Tabela de Imposto
// ○ 10% para salários de até 2000
// ○ 15% para salários de até 3000
// ○ 20% para salários superiores a 3000

#include <iostream>
#include <string>
using namespace std;

class Funcionario {
private:
    string nome;
    double salarioBruto;
    double imposto;

public:
    Funcionario(string n, double salario, double imp) {
        nome = n;
        salarioBruto = salario;
        imposto = imp;
    }

    double salarioLiquido() {
        double percentual;
        if (salarioBruto <= 2000) percentual = 0.10;
        else if (salarioBruto <= 3000) percentual = 0.15;
        else percentual = 0.20;

        // O imposto informado no cadastro e somado ao imposto da tabela.
        return salarioBruto - imposto - (salarioBruto * percentual);
    }

    void mostrarDados() {
        cout << "Funcionario: " << nome << endl;
        cout << "Salario liquido: " << salarioLiquido() << endl;
    }

    void aumentarSalario(double porcentagem) {
        salarioBruto += salarioBruto * porcentagem / 100.0;
    }
};

int main() {
    string nome;
    double salario, imposto, porcentagem;

    cout << "Nome: ";
    getline(cin, nome);
    cout << "Salario bruto: ";
    cin >> salario;
    cout << "Imposto informado: ";
    cin >> imposto;

    Funcionario funcionario(nome, salario, imposto);
    funcionario.mostrarDados();

    cout << "\nPorcentagem de aumento: ";
    cin >> porcentagem;
    funcionario.aumentarSalario(porcentagem);

    cout << "\nDados apos o aumento:\n";
    funcionario.mostrarDados();
    return 0;
}
