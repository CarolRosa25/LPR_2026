// Construa uma lista de X nomes aleatórios
// A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes 
// ordenados por tamanho, começando com o menor. Em cada linha, só pode ser mostrado um nome 
// de determinado tamanho, e os demais nomes com o mesmo tamanho devem ser apresentados 
// nas linhas seguintes. Você deve seguir a ordem de digitação.

#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

int main() {
    int quantidade;
    cout << "Quantidade de nomes: ";
    cin >> quantidade;

    vector<string> nomes(quantidade);
    for (int i = 0; i < quantidade; i++) {
        cout << "Nome " << i + 1 << ": ";
        cin >> nomes[i];
    }

    // Agrupa por tamanho, mantendo a ordem em que os nomes foram digitados.
    vector<vector<string>> grupos;
    for (const string& nome : nomes) {
        int tamanho = nome.size();
        if ((int)grupos.size() < tamanho + 1)
            grupos.resize(tamanho + 1);
        grupos[tamanho].push_back(nome);
    }

    int maiorGrupo = 0;
    for (const auto& grupo : grupos)
        maiorGrupo = max(maiorGrupo, (int)grupo.size());

    // Cada linha apresenta no maximo um nome de cada tamanho.
    for (int linha = 0; linha < maiorGrupo; linha++) {
        bool primeiro = true;
        for (int tamanho = 0; tamanho < (int)grupos.size(); tamanho++) {
            if (linha < (int)grupos[tamanho].size()) {
                if (!primeiro) cout << ", ";
                cout << grupos[tamanho][linha];
                primeiro = false;
            }
        }
        cout << endl;
    }
    return 0;
}
