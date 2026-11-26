//Fazer um programa para ler os valores da largura e altura de um retângulo. 
// Em seguida, mostrar na tela o valor de sua área e perímetro.
// Usar a seguinte classe:
// Retangulo
// double Altura
// double Largura
// calcArea()
// calcPerimetro()

#include <iostream>
using namespace std;

class Retangulo {
private:
    double altura;
    double largura;
public:
    Retangulo(double a, double l) {
        altura = a;
        largura = l;
    }

    double calcArea() {
        return altura * largura;
    }

    double calcPerimetro() {
        return 2 * (altura + largura);
    }
};

int main() {
    double altura, largura;
    cout << "Altura: ";
    cin >> altura;
    cout << "Largura: ";
    cin >> largura;

    Retangulo retangulo(altura, largura);
    cout << "Area: " << retangulo.calcArea() << endl;
    cout << "Perimetro: " << retangulo.calcPerimetro() << endl;
    return 0;
}
