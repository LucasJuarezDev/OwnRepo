#include "managerMateria.h"
#include <iostream>
#include <cstring>
using namespace std;

void ManagerMateria :: cargarCadena(char *Palabra, int Tamanio)
{
    int i=0;
    fflush(stdin);
    for (i=0; i<Tamanio; i++){
        Palabra[i]=cin.get();
        if (Palabra[i]=='\n'){
            break;
        }
    }
    Palabra[i]='\0';
    fflush(stdin);
}

void ManagerMateria :: Mostrar(Materia obj)
{
    cout<<"NUMERO DE MATERIA: "<<obj.getNumeroMateria()<<endl;
    cout<<"NOMBRE: "<<obj.getNombreMateria()<<endl;
    cout<<"CANTIDAD DE ALUMNOS: "<<obj.getCantidadAlumnos()<<endl;
    cout<<"CANTIDAD DE DOCENTES: "<<obj.getCantidadDocentes()<<endl<<endl;
}

void ManagerMateria :: ModificacionMateria(Materia &obj)
{
    int cantidadAlumnos, cantidadDocentes, opcion;
    char nombre[50];


    do
    {
        system("cls");
        cout << "ELIJA QUE DATOS QUIERE MODIFICAR" << endl;
        cout << "===========================================" << endl;
        cout << "MATERIA A MODIFICAR: " << obj.getNombreMateria() << endl;
        cout << "---------------------------------------------" << endl;
        cout << "1) MODIFICAR NOMBRE" << endl;
        cout << "2) MODIFICAR SU CANTIDAD DE ALUMNOS" << endl;
        cout << "3) MODIFICAR SU CANTIDAD DE DOCENTES" << endl;
        cout << "---------------------------------------------" << endl;
        cout << "0) SALIR" << endl;
        cin >> opcion;
        switch(opcion)
        {
        case 1:
            {
                cout << "INDIQUE EL NUEVO NOMBRE DE LA MATERIA: ";
                cargarCadena(nombre, 49);
                obj.setNombreMateria(nombre);
                cout << endl;
                break;
            }
        case 2:
            {
                cout << "INDIQUE LA NUEVA CANTIDAD DE ALUMNOS: ";
                cin>>cantidadAlumnos;
                obj.setCantidadAlumnos(cantidadAlumnos);
                cout << endl;
                break;
            }
        case 3:
            {
                cout << "INDIQUE LA NUEVA CANTIDAD DE DOCENTES: ";
                cin>>cantidadDocentes;
                obj.setCantidadDocentes(cantidadDocentes);
                cout << endl;
                break;
            }
        default:
              if(opcion != 0){
                cout << "OPCION INCORRECTA" << endl;
                if(cin.fail())
                {
                cin.clear();
                cin.ignore();
                }
                }
            break;
        }

    system("pause");
    }while(opcion != 0);
}

/////////////////////////////////////////////////////////////////////////////////

void ManagerMateria :: cargarMateria()
{
    Materia obj;
    int numero, cantidadAlumnos, cantidadDocentes;
    char nombre[50];

    cout<<"INGRESE EL NUMERO DE MATERIA: ";
    cin>>numero;
    obj.setNumeroMateria(numero);
    cout<<"INGRESE EL NOMBRE DE LA MATERIA: ";
    cargarCadena(nombre, 49);
    obj.setNombreMateria(nombre);
    cout<<"INGRESE LA CANTIDAD DE ALUMNOS: ";
    cin>>cantidadAlumnos;
    obj.setCantidadAlumnos(cantidadAlumnos);
    cout<<"INGRESE LA CANTIDAD DE DOCENTES: ";
    cin>>cantidadDocentes;
    obj.setCantidadDocentes(cantidadDocentes);
    obj.setEstado(true);
    if(archMateria.guardarMateria(obj))
    {
      cout << "MATERIA CARGADA CORRECTAMENTE." << endl;
      system("pause");
    }else
    {
      cout << "ALGO SALIO MAL..." << endl;
      system("pause");
    }

}

void ManagerMateria :: mostrarMateria()
{
    Materia obj;

    int cantidad = archMateria.contarRegistros();

    system("cls");
    if(cantidad > 0)
    {
        for(int x = 0 ; x < cantidad ; x ++)
        {
            obj = archMateria.leerRegistro(x);
            if(obj.getEstado())
            {
                cout << "=================================================" << endl;
                Mostrar(obj);
                cout << "=================================================" << endl;
            }
        }
    }else
    {
        cout << "NO HAY MATERIAS CARGADAS ACTUALMENTE" << endl;
        return;
    }
}

void ManagerMateria :: modificarMateria()
{
    int seleccion, pos = 0;
    int cantidad = archMateria.contarRegistros();
    Materia _materia;

    if (cantidad > 0)
    {
        system("cls");
        cout << "INGRESE EL NUMERO DE MATERIA A MODIFICAR: " << endl;
        mostrarMateria();
        cout << endl;
        cout << "(INGRESE '0' EN CASO DE QUERER VOLVER AL MENU PRINCIPAL)" << endl;
        cout << endl;
        cout << "OPCION: ";
        cin >> seleccion;
        while (seleccion != 0){
            system("cls");
            pos = archMateria.buscarNumeroMateria(seleccion);
            if (pos != -2){ // Pregunto si se encontró en el archivo

                for (int x = 0; x < cantidad; x++){ // Recorro todo el archivo de prendas
                    _materia = archMateria.leerRegistro(x);

                    if (_materia.getNumeroMateria() == seleccion && _materia.getEstado()){// Una vez encontrada modifico y guardo en el archivo

                        ModificacionMateria(_materia);
                        archMateria.modificarMateria(_materia, pos);
                    }
                }
                break; // Salir del bucle una vez realizada la modificacion
            }else{
                cout << "MATERIA NO ENCONTRADA. POR FAVOR, INGRESE UN CODIGO DE MATERIA VALIDO" << endl;
                if(cin.fail())
                {
                cin.clear();
                cin.ignore();
                }
                system("pause");
                mostrarMateria();
                cout << endl;
                cout << "OPCION: ";
                cin >> seleccion;
            }
        }
    }else{
        cout << "NO EXISTEN REGISTROS DE MATERIAS" << endl;
        system("pause");
    }
}

