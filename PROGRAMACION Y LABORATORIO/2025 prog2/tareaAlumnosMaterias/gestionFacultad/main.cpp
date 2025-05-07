#include <iostream>
#include "menuUTN.h"
using namespace std;

int main()
{
    int opcion;

    while(true)
    {
        system("cls");
        cout << "     GESTION DE UTN" << endl;
        cout << "------------------------" << endl;
        cout << endl;
        cout << "1)     MATERIAS" << endl;
        cout << endl;
        cout << "2)    ALUMNOS" << endl;
        cout << endl;
        cout << "------------------------" << endl;
        cout << endl;
        cout << "0)       SALIR" << endl;

        cin >> opcion;

        switch(opcion)
        {
        case 1:
            menuMaterias();
            break;
        case 2:
            menuAlumnos();
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


/**

LA UTN DE PACHECO QUIERE ALMACENAR LA INFORMACIÓN DE LAS 18
MATERIAS DE LA CARRERA DE TUP, PARA LO CUAL PRECISA CARGAR
LOS SIGUIENTES DATOS:

-NUMERO DE MATERIA
-NOMBRE DE LA MATERIA
-CANTIDAD DE ALUMNOS
-CANTIDAD DE DOCENTES

ARMAR LA CLASE QUE PERMITA GUARDAR DICHA INFORMACIÓN Y,
A SU VEZ, CARGARLA Y MOSTRARLA

*/
/**
AGREGAR UNA CLASE ALUMNO QUE TENGA LA SIGUIENTE INFORMACION:
-LEGAJO (int)
-NOMBRE (char[])
-APELLIDO (char[])
-DIA NACIMIENTO (int)
-MES NACIMIENTO (int)
-AÑO NACIMIENTO (int)
-EMAIL (char[])
-ESTADO (bool)

HACER UNA CLASE ARCHIVO PARA EL MANEJO DEL ARCHIVO.
AGREGAR UN SUBMENU PARA EL ABML DEL ARCHIVO DE
ALUMNOS
*/
/**
AGREGAR UNA OPCION AL MENU QUE PIDA AL USUARIO
UN NUMERO DE MATERIA Y MUESTRE LA MATERIA CON ESE
NUMERO

AGREGAR UNA OPCION AL MENU QUE PIDA AL USUARIO
UN NUMERO DE MATERIA Y MUESTRE LA POSICION QUE
OCUPA LA MATERIA CON ESE NUMERO EN EL ARCHIVO
DEBE USARSE UNA FUNCION QUE DEVUELVA LA POSICION
*/

/**
MODIFICAR EL PROGRAMA PARA TENER UN MENU PRINCIPAL
QUE LLAME A DOS SUBMENUES, UNO DE MATERIAS Y OTRO
DE ALUMNOS

LOS ALUMNOS ALMACENAN LA SIGUIENTE INFORMACION:
-LEGAJO (int)
-NOMBRE Y APELLIDO (char[])
-CARRERA (int)
-MAIL (char[])
-DNI (int)
-TELEFONO (char[])

CADA SUBMENU DEBE TENER UNA OPCION PARA AGREGAR UN
REGISTRO, LISTAR TODOS LOS REGISTROS, LISTAR EL
REGISTRO QUE TENGA EL VALOR DEL CAMPO CLAVE INGRESADO
POR EL USUARIO.
*/
