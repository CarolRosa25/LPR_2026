// Crie um programa que utilize um dicionário para armazenar jogos e seus respectivos gêneros.
// Cadastre pelo menos 5 jogos informados pelo usuário.
// Depois, solicite o nome de um jogo e exiba seu gênero.
// Caso o jogo não esteja cadastrado, exiba uma mensagem informando isso.

#include <iostream>
#include <map>
#include <string>
#include <vector>

using namespace std;
int main () {
    map<string, string> jogos;

    jogos["The Witcher 3"] = "RPG";
    jogos["Red Dead Redemption 2"] = "Ação";
    jogos["The Legend of Zelda: Breath of the Wild"] = "Aventura";
    jogos["God of War"] = "Ação";
    jogos["Assassin's Creed Valhalla"] = "Aventura";

    vector<string> nomes;
    string nomeJogo;

    for (int i = 0; i < 5; i++) {
        cout << "\nDigite o nome do jogo: ";
        getline(cin, nomeJogo);
        nomes.push_back(nomeJogo);

        if (jogos.find(nomeJogo) != jogos.end()) {
            cout << "O gênero do jogo " << nomeJogo << " é: " << jogos[nomeJogo] << endl;
        } else {
            cout << "O jogo " << nomeJogo << " não está cadastrado." << endl;
        }
    }

    return 0; 
}

