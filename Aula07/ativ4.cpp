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
    
    for (int i = 0; i < 10; i++) {
        cout << nome[i] << " - ";
        cout << nota[i] << " - ";
        cout << classificarAluno(nota[i]) << endl;
    }
}