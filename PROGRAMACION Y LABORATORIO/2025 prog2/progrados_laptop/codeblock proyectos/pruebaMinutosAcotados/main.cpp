#include <iostream>

using namespace std;

int main()
{
    int Minutos;

    cout << "INGRESE LOS MINUTOS" << endl;
    cin >> Minutos;

    int horas = Minutos / 60;

    // Calcular minutos restantes
    int minutosRestantes = Minutos % 60;

    // Calcular segundos restantes (si se desea)
    int segundos = minutosRestantes % 1 * 60;

    // Imprimir el resultado

    cout << horas << " : " << minutosRestantes << " : " << segundos << endl;
    return 0;
}
