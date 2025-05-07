#include <iostream>
#include "PuestoManager.h"
#include "PersonaManager.h"

using namespace std;

puestoManager managerPuesto;
personaManager managerPersona;

int main()
{
    int opcion;
    while (true){
        system("cls");
        cout << "===============================" << endl;
        cout << "    SISTEMA POSTULANTES" << endl;
        cout << "-------------------------------" << endl;
        cout << " 1) CARGAR POSTULANTE" << endl;
        cout << " 2) LISTAR POSTULANTES" << endl;
        cout << " 3) APLICAR POSTULACION" << endl;
        cout << " 4) PERSONAS CONTRATADAS" << endl;
        cout << "-------------------------------" << endl;
        cout << " 5) NUEVO PUESTO" << endl;
        cout << " 6) MOSTRAR PUESTOS" << endl;
        cout << "===============================" << endl;
        cout << " 0) SALIR" << endl;

        cin >> opcion;

        switch(opcion){
            case 1:
                {
                    managerPersona.cargarPersona();
                }
                break;
            case 2:
                {
                    managerPersona.mostrarPostulantes();
                    system("pause");
                }
                break;
            case 3:
                {
                    managerPersona.aplicarPostulantes();
                    system("pause");
                }
                break;
            case 4:
                {
                    managerPersona.mostrarContratado();
                    system("pause");
                }
                break;
            case 5:
                {
                    managerPuesto.CargarPuesto();
                }
                break;
            case 6:
                {
                    managerPuesto.MostrarPuestos();
                    system("pause");
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
