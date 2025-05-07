#ifndef MENUUTN_H_INCLUDED
#define MENUUTN_H_INCLUDED
#include <iostream>
#include <cstdlib>
using namespace std;
#include "managerMateria.h"

ManagerMateria opcionesMaterias;

void menuAlumnos()
{
    int opcion;
    while(true){
        system("cls");
        cout << "         ALUMNOS" << endl;
        cout << "---------------------------" << endl;
        cout << endl;
        cout << "1)    REGISTRAR ALUMNO" << endl;
        cout << endl;
        cout << "2)   MODIFICAR REGISTRO DE ALUMNO" << endl;
        cout << endl;
        cout << "3)   VER TODOS" << endl;
        cout << endl;
        cout << "4)    BAJA ALUMNO" << endl;
        cout << endl;
        cout << "---------------------------" << endl;
        cout << endl;
        cout << "0)   MENU ANTERIOR" << endl;
        cin >> opcion;

        switch(opcion){
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 0:
            return;
            break;
        default:
            if(cin.fail())
            {
            cin.clear();
            cin.ignore();
            cout << "OPCION INCORRECTA" << endl;
            system("pause");
            }
            break;
        }

    }
}

void menuMaterias()
{
    int opcion;

    while(true){
        system("cls");
        cout << "         MATERIAS" << endl;
        cout << "---------------------------" << endl;
        cout << endl;
        cout << "1)    ALTA MATERIA" << endl;
        cout << endl;
        cout << "2)   MODIFICAR MATERIA" << endl;
        cout << endl;
        cout << "3)   VER MATERIAS" << endl;
        cout << endl;
        cout << "4)    BAJA MATERIA" << endl;
        cout << endl;
        cout << "---------------------------" << endl;
        cout << endl;
        cout << "0)   MENU ANTERIOR" << endl;
        cin >> opcion;

        switch(opcion){
        case 1:
            system("cls");
            opcionesMaterias.cargarMateria();
            break;
        case 2:
            system("cls");
            opcionesMaterias.modificarMateria();
            break;
        case 3:
            opcionesMaterias.mostrarMateria();
            system("pause");
            break;
        case 4:

            break;
        case 0:
            return;
            break;
        default:
            if(cin.fail())
            {
            cin.clear();
            cin.ignore();
            cout << "OPCION INCORRECTA" << endl;
            system("pause");
            }
            break;
        }
    }
}

#endif // MENUUTN_H_INCLUDED
