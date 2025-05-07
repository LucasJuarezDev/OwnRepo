#include <iostream>
#include "Puntos.h"
using namespace std;

int main()
{
    UserPoint user;
    int opcion;
    while (true){
        system("cls");
        cout << "     MENU PRINCIPAL" << endl;
        cout << "------------------------" << endl;
        cout << endl;
        cout << "1)     CARGAR PUNTOS" << endl;
        cout << endl;
        cout << "2)    MOSTRAR TABLA" << endl;
        cout << endl;
        cout << "3)    REINICIAR CAMPEONATOS" << endl;
        cout << endl;
        cout << "------------------------" << endl;
        cout << endl;
        cout << "0)       SALIR" << endl;

        cin >> opcion;

        switch(opcion){
            case 1:
                {
                    user.CargarPuntos();
                    system("pause");
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
                    return 0;
                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
                system("pause");
            break;
        }

    }
    return 0;
}
