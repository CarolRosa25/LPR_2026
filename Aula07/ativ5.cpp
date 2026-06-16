#include <iostream>
using namespace std;

string classificarAluno(int nota) {
        if (nota < 60) {
            return "Reprovado.";
        }
        else if (nota <= 79){
            return "Recuperação.";
        }
        else {
            return "Aprovado.";
        }
}

int main() {
    int i;
    string nome [10];
    int nota [10];
    
    for (int i = 0; i < 10; i++) {
        cout << "Nome: ";
        cin >> nome[i];

        cout << "Nota: ";
        cin >> nota[i];
    }
        
    cout << "\n";
    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;
    int soma = 0;
    for (int i = 0; i < 10; i++) {
        cout << nome[i] << " - ";
        cout << nota[i] << " - ";
        cout << classificarAluno(nota[i]) << endl;
        
        soma += nota[i];
        if (nota[i] < 60) {
            reprovados++;
        }
        else if (nota[i] <= 79){
            recuperacao++;
        }
        else {
            aprovados++;
        }
    }
    double media = soma/10.0;
    
    cout << "\nAprovados: " << aprovados << endl;
    cout << "Recuperacao: " << recuperacao << endl;
    cout << "Reprovados: " << reprovados << endl;
    cout << "Media da turma: " << media << endl;
}