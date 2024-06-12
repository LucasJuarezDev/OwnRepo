#ifndef MENUS_H_INCLUDED
#define MENUS_H_INCLUDED
#include <windows.h>
#include <iostream>
using namespace std;
#include "PrendaManager.h"
#include "VentaManager.h"

void SetColorSubMenu(int color) {
    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hConsole, color);
}

//      MENU DE PRENDA

PrendaManager obj_de_submenu_prenda;
VentaManager obj_de_submenu_venta;

void Menu1()

{
    SetColorSubMenu(5);
     int opcion;
    while (true){
        system("cls");
        const int menuWidth = 30;  // Ancho del menú
        const int consoleWidth = 90;  // Ancho de la consola
        int padding = (consoleWidth - menuWidth) / 2;
        string pad(padding, ' ');

        string horizontalLine(menuWidth + 2, '-');  // +2 para las barras verticales

        cout << pad << "+" << horizontalLine << "+" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(21) << "PRENDAS" << setw(12) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "1)" << setw(19) << "CARGAR PRENDA" << setw(9) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "2)" << setw(21) << "MODIFICAR PRENDA" << setw(7) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "3)" << setw(20) << "ELIMINAR PRENDA" << setw(8) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "4)" << setw(19) << "CARGAR VENTA" << setw(9) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "0)" << setw(16) << "SALIR" << setw(12) << " |" << endl;
        cout << pad << "+" << horizontalLine << "+" << endl;

        cin >> opcion;
        system("cls");

        switch(opcion){
            case 1:
                {
                    obj_de_submenu_prenda.SubmenuCargarPrenda();
                }
                break;
            case 2:
                {
                    system("cls");
                    obj_de_submenu_prenda.SubmenuModificarPrenda();
                }
                break;
            case 3:
                {
                    obj_de_submenu_prenda.SubmenuEliminarPrenda();
                }
                break;
            case 4:
                {
                    obj_de_submenu_venta.SubMenuCargarVenta();
                }
                break;
            case 0:
                {
                    SetColorSubMenu(10);
                    return;
                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
                system("pause");
            break;
        }

    }
}

//          MENU DE INVENTARIO

void Menu2()
{
    SetColorSubMenu(12);
    int opcion;
    while (true){
        system("cls");
        const int menuWidth = 30;  // Ancho del menú
        const int consoleWidth = 90;  // Ancho de la consola
        int padding = (consoleWidth - menuWidth) / 2;
        string pad(padding, ' ');

        string horizontalLine(menuWidth + 2, '-');  // +2 para las barras verticales

        cout << pad << "+" << horizontalLine << "+" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(23) << "INVENTARIO" << setw(10) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "1)" << setw(19) << "VER INVENTARIO" << setw(9) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "2)" << setw(21) << "DETALLES DE PRENDA" << setw(7) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(5) << "0)" << setw(15) << "SALIR" << setw(13) << " |" << endl;
        cout << pad << "+" << horizontalLine << "+" << endl;

        cin >> opcion;
        system("cls");

        switch(opcion){
            case 1:
                {
                   obj_de_submenu_prenda.SubmenuInventario();
                   system("pause");
                }
                break;
            case 2:
                {
                    //DETALLES DE PRENDA
                }
                break;
            case 0:
                {
                    SetColorSubMenu(10);
                    return;
                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
                system("pause");
            break;
        }

    }
}

//              MENU DE ESTADISTICAS

void Menu3()
{
    SetColorSubMenu(9);
    int opcion;
    while (true){
        system("cls");
        const int menuWidth = 30;  // Ancho del menú
        const int consoleWidth = 90;  // Ancho de la consola
        int padding = (consoleWidth - menuWidth) / 2;
        string pad(padding, ' ');

        string horizontalLine(menuWidth + 2, '-');  // +2 para las barras verticales

        cout << pad << "+" << horizontalLine << "+" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(21) << "ESTADISTICAS" << setw(12) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(2) << "1)" << setw(28) << "ESTADISTICAS DEL PRODUCTO" << setw(3) << "|" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(2) << "2)" << setw(24) << "HISTORIAL DE VENTAS" << setw(7) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(2) << "3)" << setw(23) << "PORC. DE GANANCIAS" << setw(8) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(32) << "(C/ RESPECTO AL ANIO ANTERIOR)" << "|" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(33) << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << "--------------------------" << " |" << endl;
        cout << pad << "|" << setw(menuWidth + 1) << right << setw(2) << "0)" << setw(19) << "SALIR" << setw(12) << " |" << endl;
        cout << pad << "+" << horizontalLine << "+" << endl;


        cin >> opcion;
        system("cls");

        switch(opcion){
            case 1:
                {

                }
                break;
            case 2:
                {

                }
                break;
            case 3:
                {

                }
                break;
            case 0:
                {
                    SetColorSubMenu(10);
                    return;
                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
                system("pause");
            break;
        }

    }
}

#endif // TALLER_H_INCLUDED
