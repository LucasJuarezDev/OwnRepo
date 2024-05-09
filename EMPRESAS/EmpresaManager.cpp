#include <iostream>
#include <string.h>
#include "EmpresaManager.h"
using namespace std;

Empresa EmpresaManager :: CrearEmpresa()
{
    int NumEmp;
    int Cant_E;
    int Cat;
    int NumMun;

     cout << "NUMERO DE EMPRESA: ";
     cin >> NumEmp;
     cout << "CANTIDAD DE EMPLEADOS: ";
     cin >> Cant_E;
     cout << endl;
     cout << "CATEGORIA DE EMPRESA: ";
     cin >> Cat;
     cout << endl;
     cout << "NUMERO DE MUNICIPIO DE LA EMPRESA: ";
     cin >> NumMun;

     return Empresa(NumEmp, "COCACOLA", Cant_E, Cat, NumMun, true); //DEVUELVO EL OBJETO ''ANONIMO '' CON LOS VALORES ASIGNADOS
}                                                                   //UTILIZO EL CONSTRUCTOR COMO CREADOR DE OBJETO

void EmpresaManager :: AgregarEmpresa()
{
    Empresa emp(100, "FORD", 150, 43, 17, 1);

    _Archivo.Guardar(CrearEmpresa());
    if(_Archivo.Guardar(CrearEmpresa())){
        cout << "EMPRESA ARCHIVADA CORRECTAMENTE" << endl;
    }
}

void EmpresaManager :: ListarEmpresa()
{
     int cantidad = _Archivo.getCantidadRegistros();

    for(int x = 0 ; x < cantidad ; x ++)
        {
            Empresa emp = _Archivo.Leer(x);

            cout << "NUMERO DE EMPRESA: " << emp.getNumeroEmpresa() << endl;
            cout << "NOMBRE DE EMPRESA: " << emp.getNombreEmpresa() << endl;
            cout << "CANTIDAD DE EMPLEADOS: " << emp.getEmpleados() << endl;
            cout << "CATEGORIA DE EMPRESA: " << emp.getCategoria() << endl;
            cout << "NUMERO DE MUNICIPIO DE LA EMPRESA: " << emp.getNumeroMunicipio() << endl;
            cout << "ESTADO FISCAL: " << emp.getEstado() << endl;
            cout << "=================================================" << endl;
        }
}

void EmpresaManager :: Menu()
{
     int opcion;
    do{
        system("cls");
        cout << "SISTEMA EMPRESA" << endl;
        cout << "----------------" << endl;
        cout << "1) NUEVA EMPRESA" << endl;
        cout << "2) LISTAR EMPRESA" << endl;
        cout << "---------------------------" << endl;
        cout << "0) SALIR" << endl;

        cin >> opcion;

        switch(opcion){
            case 1:
                {
                    AgregarEmpresa();
                }
                break;
            case 2:
                {
                    ListarEmpresa();
                }
                break;
            default:
                if(opcion != 0){
                cout << "OPCION INCORRECTA" << endl;
                }
            break;
        }

        system("pause");

    }while(opcion != 0);
}
