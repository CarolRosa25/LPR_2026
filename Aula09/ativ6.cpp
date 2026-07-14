// Construa um dicionário de X pares chave-valor onde as chaves são nomes de pessoas e 
// os valores são suas respectivas idades.
// Encontre e imprima todos os nomes de pessoas com idade acima da média.
// Encontre e imprima o nome da pessoa mais velha e o nome da pessoa mais nova.
// Remova todas as pessoas com idade igual a um valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.

#include <iostream>
#include <map>
#include <string>
#include <vector>

using namespace std;
int main () {
    map<string, int> pessoas;
    vector<string> nomes;
    string nomePessoa;

    for (int i = 0; i < 3; i++) {
        cout << "\nDigite o nome da pessoa: ";
        getline(cin, nomePessoa);
        nomes.push_back(nomePessoa);

        int idade;
        for (int i = 0; i < nomePessoa.size(); i++) {
        cout << "Digite a idade de " << nomePessoa << ": ";
        cin >> idade;
        pessoas[nomePessoa] = idade;
        }
    }

    int soma;
        for (auto& idade : pessoas) {
            soma += idade.second;
            int mediaIdades = soma / pessoas.size();
            for (auto& pessoa : pessoas) {
                if (pessoa.second > mediaIdades) {
                    cout << "Pessoa com idade acima da média: " << pessoa.first << endl;
                }
            }
        }

        for (auto& pessoa : pessoas) {
            if (pessoa.second == 0) {
                cout << "Pessoa mais nova: " << pessoa.first << endl;
            }
        }
}
