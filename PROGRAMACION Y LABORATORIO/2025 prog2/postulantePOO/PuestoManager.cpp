#include "PuestoManager.h"
#include <iostream>
using namespace std;

void puestoManager :: CargarPuesto()
{
    Puesto obj;
    int id;
    string nombre;

    cout << "=============================================================="<< endl;
    cout << "                   NUEVO PUESTO DE TRABAJO"<< endl;
    cout << "=============================================================="<< endl;
    id = objArch.IdTrabajo();
    obj.setIdPuesto(id);
    cout << "IDENTIFICADOR: " << obj.getIdPuesto() << endl;
    cout << endl;
    cout << "=============================================================="<< endl;

    cout << "PUESTO A INGRESAR: ";
    cin.ignore();
    getline(cin, nombre);
    fflush(stdin);
    obj.setPuesto(nombre);
    cout << endl;
    cout << "=============================================================="<< endl;

    obj.setEstado(true);
    if(objArch.guardarPuesto(obj))
    {
      cout << "PUESTO DE TRABAJO CARGADO CORRECTAMENTE." << endl;
      system("pause");
    }else
    {
      cout << "ALGO SALIO MAL..." << endl;
      system("pause");
    }

}

void puestoManager :: Mostrar(Puesto obj){
    cout << "CODIGO DE TRABAJO: " << obj.getIdPuesto() << endl;
    cout << "NOMBRE DE PUESTO: " << obj.getPuesto() << endl;
    cout << "DISPONIBLE: " << (obj.getEstado() ? "SI" : "NO")<< endl;
}

void puestoManager :: MostrarPuestos()
{
    Puesto obj;

    int cantidad = objArch.contarRegistros();

    system("cls");
    if(cantidad > 0)
    {
        for(int x = 0 ; x < cantidad ; x ++)
        {
            obj = objArch.leerPuestos(x);
            if(obj.getEstado())
            {
                cout << "=================================================" << endl;
                Mostrar(obj);
                cout << "=================================================" << endl;
            }
        }
    }else
    {
        cout << "NO HAY PUESTOS DE TRABAJO CARGADOS ACTUALMENTE" << endl;
        return;
    }
}

string puestoManager :: elegirPuesto(){
    Puesto obj;
    int seleccionado = 0;
    int pos = 0;
    int cantidad = objArch.contarRegistros();
    string puestoSeleccionado;

    cout << "===================================================" << endl;
    cout << "SELECCIONE EL PUESTO QUE COINCIDE CON EL POSTULANTE" << endl;
    MostrarPuestos();
    cout << endl;
    cout << "OPCION: ";
    cin >> seleccionado;
    while (seleccionado != 0){
        system("cls");
        pos = objArch.BuscarCodigoPuesto(seleccionado);
        if (pos != -2){ // Pregunto si se encontró en el archivo

            obj = objArch.leerPuestos(pos);
            puestoSeleccionado = obj.getPuesto();
            return puestoSeleccionado;
        }else{
            cout << "PUESTO NO ENCONTRADO. POR FAVOR, INGRESE UN CODIGO VALIDO: " << endl;
            if(cin.fail())
            {
            cin.clear();
            cin.ignore();
            }
            system("pause");
            MostrarPuestos();
            cout << endl;
            cout << "OPCION: ";
            cin >> seleccionado;
        }
    }
}
