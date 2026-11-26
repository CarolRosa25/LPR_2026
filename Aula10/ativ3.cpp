// Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
// Cada objeto dessa classe deve guardar os seguintes dados do aluno: 
// matrícula, nome, 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
// ○ media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2)
// ○ final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for para a final).
// O aluno vai pra final se sua média for menor que 60.

#include <iostream>
#include <string>
using namespace std;

class Aluno {
private:
    int matricula;
    string nome;
    double prova1;
    double prova2;
    double trabalho;

public:
    Aluno(int m, string n, double p1, double p2, double t) {
        matricula = m;
        nome = n;
        prova1 = p1;
        prova2 = p2;
        trabalho = t;
    }

    double media() {
        // Cada prova tem peso 2,5 e o trabalho tem peso 2.
        return (prova1 * 2.5 + prova2 * 2.5 + trabalho * 2.0) / 7.0;
    }

    double final() {
        double m = media();
        if (m >= 60) return 0;
        // Nota necessaria na prova final para atingir media 60,
        // considerando a media atual e uma prova final de peso 1.
        double necessaria = 60 - m;
        return necessaria > 0 ? necessaria : 0;
    }

    void mostrarDados() {
        cout << "\nMatricula: " << matricula;
        cout << "\nNome: " << nome;
        cout << "\nMedia: " << media();
        if (media() < 60)
            cout << "\nPrecisa de " << final() << " pontos na prova final.\n";
        else
            cout << "\nAprovado sem prova final.\n";
    }
};

int main() {
    int matricula;
    string nome;
    double p1, p2, trabalho;

    cout << "Matricula: ";
    cin >> matricula;
    cin.ignore();
    cout << "Nome: ";
    getline(cin, nome);
    cout << "Nota da prova 1: ";
    cin >> p1;
    cout << "Nota da prova 2: ";
    cin >> p2;
    cout << "Nota do trabalho: ";
    cin >> trabalho;

    Aluno aluno(matricula, nome, p1, p2, trabalho);
    aluno.mostrarDados();
    return 0;
}
