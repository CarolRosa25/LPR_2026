#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

struct Livro
{
    string titulo;
    string autor;
    int anoPublicacao;
    int numeroPaginas;
    float preco;
};

int main() 
{
    Livro dados[3];
    int somaPaginas = 0;
    float precoTotal = 0;
    
    for (int i = 0; i < 3; i++)
    {
        cout << "Cadastro do livro " << (i + 1) << endl;
        
        cout << "Escreva o título do livro: ";
        getline(cin, dados[i].titulo);

        cout << "Escreva o autor do livro: ";
        getline(cin, dados[i].autor);

        cout << "Escreva o ano de publicação: ";
        cin >> dados[i].anoPublicacao;

        cout << "Escreva o número de páginas do livro: ";
        cin >> dados[i].numeroPaginas;

        cout << "Escreva o preço do livro: R$ ";
        cin >> dados[i].preco;

        cout << endl;
    }

    for (int i = 0; i < 3; i++)
    {
        somaPaginas += dados[i].numeroPaginas;
        precoTotal += dados[i].preco;
    }

    int mediaPaginas = somaPaginas / 3;
    
    cout << "Resumo dos Livros" << endl;
    cout << "Preço total dos livros: R$ " << fixed << setprecision(2) << precoTotal << endl;
    cout << "Média de páginas dos livros: " << mediaPaginas << " páginas" << endl;

    return 0;
}