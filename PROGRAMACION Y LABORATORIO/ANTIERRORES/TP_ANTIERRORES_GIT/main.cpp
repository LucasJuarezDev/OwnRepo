#include <iostream>
#include <windows.h>
#include <iomanip>
#include "Menus.h"

using namespace std;

void SetColor(int color) {
    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hConsole, color);
}

int main()
{
    SetColor(10);
    int opcion;
    while (true){
    system("cls");
    const int menuWidth = 30;  // Ancho del menú
    const int consoleWidth = 90;  // Ancho de la consola
    int padding = (consoleWidth - menuWidth) / 2;
    string pad(padding, ' ');

    string horizontalLine(menuWidth + 2, '-');  // +2 para las barras verticales

    cout << pad << "+" << horizontalLine << "+" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(25) << "MENU PRINCIPAL" << setw(8) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "1)" << setw(16) << "PRENDA" << setw(12) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "2)" << setw(18) << "INVENTARIO" << setw(10) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "3)" << setw(19) << "ESTATISTICAS" << setw(9) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
    cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "0)" << setw(16) << "SALIR" << setw(12) << " |" << endl;
    cout << pad << "+" << horizontalLine << "+" << endl;

        cin >> opcion;
        system("cls");

        switch(opcion){
            case 1:
                {
                    Menu1();
                }
                break;
            case 2:
                {
                    Menu2();
                }
                break;
            case 3:
                {
                    Menu3();
                }
                break;
            case 0:
                {
                    return 0;
                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
                system("pause");
            break;
        }

    }
}
