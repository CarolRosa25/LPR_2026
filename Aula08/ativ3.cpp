#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro livros[3];
    float totalPrecos = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "\nCadastro do livro " << i + 1 << endl;

        cout << "Titulo: ";
        getline(cin, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de publicacao: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Numero de paginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preco: ";
        cin >> livros[i].Preco;

        cin.ignore();

        totalPrecos += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    float mediaPaginas = totalPaginas / 3.0;

    cout << "\n===== LIVROS CADASTRADOS =====\n";

    for (int i = 0; i < 3; i++) {
        cout << "\nTitulo: " << livros[i].Titulo << endl;
        cout << "Autor: " << livros[i].Autor << endl;
        cout << "Ano: " << livros[i].AnoPublicacao << endl;
        cout << "Paginas: " << livros[i].NumeroPaginas << endl;
        cout << "Preco: R$ " << livros[i].Preco << endl;
    }

    cout << "\n===== RESULTADOS =====\n";
    cout << "Preco total dos livros: R$ " << totalPrecos << endl;
    cout << "Media de paginas: " << mediaPaginas << endl;

    return 0;
}
