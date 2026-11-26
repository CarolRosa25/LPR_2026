// Desenvolva o diagrama de classes do seu jogo favorito: pense em personagens, cenários, 
// coisas utilizadas pelos personagens, poderes, habilidades, etc… 
// ○ Dica: utilize um software de desenho. 
// Sugestão: LucidChart
// O diagrama deve conter atributos, métodos, relacionamentos e cardinalidades.
// Implemente 3 classes principais do seu jogo (as que você escolher) e submeta os 
// códigos das classes no questionário.

#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Habilidade {
private:
    string nome;
    int dano;
public:
    Habilidade(string n, int d) : nome(n), dano(d) {}
    void exibir() {
        cout << nome << " (dano: " << dano << ")";
    }
};

class Cenario {
private:
    string nome;
public:
    Cenario(string n) : nome(n) {}
    string getNome() { return nome; }
};

class Personagem {
private:
    string nome;
    int vida;
    Cenario* cenario;
    vector<Habilidade> habilidades;
public:
    Personagem(string n, int v, Cenario* c) : nome(n), vida(v), cenario(c) {}

    void adicionarHabilidade(Habilidade h) {
        habilidades.push_back(h);
    }

    void exibirDados() {
        cout << "\nPersonagem: " << nome << "\nVida: " << vida;
        cout << "\nCenario: " << cenario->getNome();
        cout << "\nHabilidades: ";
        for (Habilidade h : habilidades) {
            h.exibir();
            cout << " ";
        }
        cout << endl;
    }
};

int main() {
    Cenario floresta("Floresta");
    Personagem heroi("Guardiao", 100, &floresta);

    heroi.adicionarHabilidade(Habilidade("Ataque", 20));
    heroi.adicionarHabilidade(Habilidade("Defesa", 0));

    heroi.exibirDados();
    return 0;
}
