#include <iostream>
using namespace std;

void mediaPares(int quantidade) {
    int numero;
    int contador = 0;
    int soma = 0;

    for (int i = 0; i < quantidade; i++) {
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }
    }

    if (contador > 0) {
        double media = (double)soma / contador;
        cout << "Media dos pares: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
}


int somaImparesMultiplos3(int inicio, int fim) {
    int soma = 0;

    for (int i = inicio; i <= fim; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    return soma;
}


int somaDigitosQuadrado(int numero) {
    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    return soma;
}


int main() {
    int opcao;

    do {
        cout << "Menu" << endl;
        cout << "1 - Media dos numeros pares" << endl;
        cout << "2 - Soma dos impares multiplos de 3" << endl;
        cout << "3 - Soma dos digitos do quadrado" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int quantidade;
                cout << "Quantos numeros deseja digitar? ";
                cin >> quantidade;
                mediaPares(quantidade);
                break;
            }

            case 2: {
                int inicio, fim;
                cout << "Digite o inicio do intervalo: ";
                cin >> inicio;
                cout << "Digite o fim do intervalo: ";
                cin >> fim;

                int resultado = somaImparesMultiplos3(inicio, fim);
                cout << "Soma: " << resultado << endl;
                break;
            }

            case 3: {
                int numero;
                cout << "Digite um numero: ";
                cin >> numero;

                int resultado = somaDigitosQuadrado(numero);
                cout << "Soma dos digitos: " << resultado << endl;
                break;
            }

            case 0:
                cout << "Encerrando..." << endl;
                break;

            default:
                cout << "Opcao invalida" << endl;
        }

    } while (opcao != 0);

    return 0;
}