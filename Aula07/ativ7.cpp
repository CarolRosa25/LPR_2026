#include <iostream>
using namespace std;

int main() {
    int matriz[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4; j++) {
            cout << matriz[i][j] << ' ';
        }
        cout << '\n';
    }

    return 0;
}