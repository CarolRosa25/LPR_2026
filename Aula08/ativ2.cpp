#include <iostream>
#include <string>
using namespace std;

struct Produto {
    string Nome;
    int Codigo;
    float Preco;
    int Quantidade;
};

int main() {
    Produto produtos[3];
    float totalEstoque = 0;

    for (int i = 0; i < 3; i++) {
        cout << "\nCadastro do produto " << i + 1 << endl;

        cout << "Nome: ";
        getline(cin, produtos[i].Nome);

        cout << "Codigo: ";
        cin >> produtos[i].Codigo;

        cout << "Preco: ";
        cin >> produtos[i].Preco;

        cout << "Quantidade: ";
        cin >> produtos[i].Quantidade;

        cin.ignore();

        totalEstoque += produtos[i].Preco * produtos[i].Quantidade;
    }

    cout << "\n===== PRODUTOS CADASTRADOS =====\n";

    for (int i = 0; i < 3; i++) {
        cout << "\nNome: " << produtos[i].Nome << endl;
        cout << "Codigo: " << produtos[i].Codigo << endl;
        cout << "Preco: R$ " << produtos[i].Preco << endl;
        cout << "Quantidade: " << produtos[i].Quantidade << endl;
    }

    cout << "\nValor total do estoque: R$ " << totalEstoque << endl;

    return 0;
}
