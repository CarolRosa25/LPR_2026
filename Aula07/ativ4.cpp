#include <iostream>
using namespace std;

string ClassificarAluno(int nota) {
    if (nota < 60) {
        return "Reprovado";
    }
    else if (nota <= 79) {
        return "Recuperação";
    }
    else {
        return "Aprovado";
    }
}

int main() {
    const int tam = 10;

    string nome[tam];
    int nota[tam];

    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;
    int soma = 0;

    // Leitura dos dados
    for (int i = 0; i < tam; i++) {
        cout << "Nome do aluno: ";
        cin >> nome[i];

        cout << "Nota do aluno (0 a 100): ";
        cin >> nota[i];
        if (nota[i] < 0 || nota[i] > 100) {
            cout << "Nota inválida. Digite novamente." << endl;
            i--; 
        }
    }

    cout << "\nAlunos:\n";

    // Processamento e relatório
    for (int i = 0; i < tam; i++) {
        string situacao = ClassificarAluno(nota[i]);

        cout << nome[i] << " - " << nota[i] << " - " << situacao << endl;

        soma += nota[i];

        if (nota[i] < 60) {
            reprovados++;
        }
        else if (nota[i] <= 79) {
            recuperacao++;
        }
        else {
            aprovados++;
        }
    }

    double media = soma / (double)tam;

    cout << "\nRelatório da turma:\n";
    cout << "Aprovados: " << aprovados << endl;
    cout << "Recuperação: " << recuperacao << endl;
    cout << "Reprovados: " << reprovados << endl;
    cout << "Média da turma: " << media << endl;

    return 0;
}