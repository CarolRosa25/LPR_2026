#include <iostream>
#include <string>
using namespace std;

string VerificarAssento(int sala[6][8], int linha, int coluna) {
    if (sala[linha][coluna] == 0) {
        return "Livre";
    } else {
        return "Ocupado";
    }
}

int main() {
    int sala[6][8];
    for (int i = 0; i < 6; i++) {
        for (int j = 0; j < 8; j++) {
            sala[i][j] = 0;
        }
    }

    int opcao;
    int linha, coluna;

    do {
        cout << "Menu Cinema:" << endl;
        cout << "1 - Reservar assento" << endl;
        cout << "2 - Cancelar reserva" << endl;
        cout << "3 - Consultar assento" << endl;
        cout << "4 - Mostrar mapa da sala" << endl;
        cout << "5 - Encerrar" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                cout << "\nDigite a linha (0 a 5): ";
                cin >> linha;
                cout << "Digite a coluna (0 a 7): ";
                cin >> coluna;

                if (linha >= 0 && linha < 6 && coluna >= 0 && coluna < 8) {
                    if (VerificarAssento(sala, linha, coluna) == "Livre") {
                        sala[linha][coluna] = 1; 
                        cout << "Assento reservado com sucesso!" << endl;
                    } else {
                        cout << "Erro: Esse assento ja esta ocupado!" << endl;
                    }
                } else {
                    cout << "Posicao invalida!" << endl;
                }
                break;

            case 2:
                cout << "\nDigite a linha (0 a 5): ";
                cin >> linha;
                cout << "Digite a coluna (0 a 7): ";
                cin >> coluna;

                if (linha >= 0 && linha < 6 && coluna >= 0 && coluna < 8) {
                    if (VerificarAssento(sala, linha, coluna) == "Ocupado") {
                        sala[linha][coluna] = 0; 
                        cout << "Reserva cancelada com sucesso!" << endl;
                    } else {
                        cout << "Esse assento ja estava livre!" << endl;
                    }
                } else {
                    cout << "Posicao invalida!" << endl;
                }
                break;

            case 3:
                cout << "\nDigite a linha (0 a 5): ";
                cin >> linha;
                cout << "Digite a coluna (0 a 7): ";
                cin >> coluna;

                if (linha >= 0 && linha < 6 && coluna >= 0 && coluna < 8) {
                    cout << "Status do assento [" << linha << "][" << coluna << "]: " << VerificarAssento(sala, linha, coluna) << endl;
                } else {
                    cout << "Posicao invalida!" << endl;
                }
                break;

            case 4:
                cout << "Mapa da Sala:" << endl;
                cout << "\tC0 C1 C2 C3 C4 C5 C6 C7" << endl; 
                for (int i = 0; i < 6; i++) {
                    cout << "L" << i << "\t"; 
                    for (int j = 0; j < 8; j++) {
                        cout << sala[i][j] << "  ";
                    }
                    cout << endl;
                }
                break;

            case 5:
                cout << "Programa encerrado!" << endl;
                break;

            default:
                cout << "Opcao invalida!" << endl;
                break;
        }

    } while (opcao != 5);

    return 0;
}