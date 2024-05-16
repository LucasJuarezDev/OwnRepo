#include <iostream>
#include <string.h>
#include "EmpresaManager.h"
using namespace std;


//          METODOS ABML

Empresa EmpresaManager :: NuevaEmpresa()
{
    Empresa obj;
    int Numero_De_Empresa, Cantidad_De_Empleados, _Categoria, Numero_De_Municipio;
    const char * Nombre_De_Empresa;

    cout << "NUMERO DE EMPRESA: ";
    Numero_De_Empresa =  _Archivo.NuevoNE();
    obj.setNumeroEmpresa(Numero_De_Empresa);
    cout << Numero_De_Empresa;
    cout << endl << endl;
    cout << "INGRESE EL NOMBRE DE EMPRESA: ";
    char t[30];
    cin >> t;
    Nombre_De_Empresa = t;
    obj.setNombreEmpresa(Nombre_De_Empresa);
    cout << endl;
    cout << "INGRESE CANTIDAD DE EMPLEADOS: ";
    cin >> Cantidad_De_Empleados;
    obj.setEmpleados(Cantidad_De_Empleados);
    cout << endl;
    cout << "INGRESE CATEGORIA DE EMPRESA: ";
    cin >> _Categoria;
    obj.setCategoria(_Categoria);
    cout << endl;
    cout << "INGRESE NUMERO DE MUNICIPIO DE LA EMPRESA: ";
    cin >> Numero_De_Municipio;
    obj.setNumeroMunicipio(Numero_De_Municipio);
    cout << endl;
    obj.setEstado(true);
    return obj;
}

void EmpresaManager :: SobrescribirEmpresa(Empresa &emp)
{
    int opcion, CANT_EMPLEADOS, CATEGORIA, NUM_MUNICIPIO;
    const char *NOMBRE_EMPRESA;
    system("cls");

    do
        {
        cout << "ELIJA QUE DATOS QUIERE MODIFICAR: ";
        cout << "EMPRESA " << emp.getNombreEmpresa() << endl;
        cout << "----------------" << endl;
        cout << "1) MODIFICAR NOMBRE DE EMPRESA" << endl;
        cout << "2) MODIFICAR CANTIDAD DE EMPLEADOS" << endl;
        cout << "3) MODIFICAR CATEGORIA" << endl;
        cout << "4) MODIFICAR NUMERO DE MUNICIPIO" << endl;
        cout << "---------------------------" << endl;
        cout << "0) SALIR" << endl;
        cin >> opcion;
        switch(opcion)
        {
        case 1:
            {
                cout << "INGRESE EL NUEVO NOMBRE DE LA EMPRESA: ";
                char t[30];
                cin >> t;
                cout << endl;
                NOMBRE_EMPRESA = t;
                emp.setNombreEmpresa(NOMBRE_EMPRESA);
                break;
            }
        case 2:
            {
                cout << "INGRESE LA NUEVA CANTIDAD DE EMPLEADOS: ";
                cin >> CANT_EMPLEADOS;
                cout << endl;
                emp.setEmpleados(CANT_EMPLEADOS);
                break;
            }
        case 3:
            {
                cout << "INGRESE LA CATEGORIA NUEVA: ";
                cin >> CATEGORIA;
                cout << endl;
                emp.setCategoria(CATEGORIA);
                break;
            }
        case 4:
            {
                cout << "INGRESE EL NUEVO NUMERO DE MUNICIPIO: ";
                cin >> NUM_MUNICIPIO;
                cout << endl;
                emp.setNumeroMunicipio(NUM_MUNICIPIO);
                break;
            }
        default:
              if(opcion != 0){
                cout << "OPCION INCORRECTA" << endl;
                }
            break;
        }
        system("pause");
        }while(opcion != 0);
}

void EmpresaManager :: MostrarEmpresa(Empresa obj)
{
    cout << "NUMERO DE EMPRESA: " << obj.getNumeroEmpresa() << endl;
    cout << "NOMBRE DE EMPRESA: " << obj.getNombreEmpresa() << endl;
    cout << "CANTIDAD DE EMPLEADOS: " << obj.getEmpleados() << endl;
    cout << "CATEGORIA DE EMPRESA: " << obj.getCategoria() << endl;
    cout << "NUMERO DE MUNICIPIO DE LA EMPRESA: " << obj.getNumeroMunicipio() << endl;
    cout << "ESTADO FISCAL: " << (obj.getEstado() ? "ALTA" : "BAJA")<< endl;
}

void EmpresaManager :: AgregarEmpresa()
{
    if(_Archivo.Guardar(NuevaEmpresa())){ //EN ESTA PREGUNTA ADEMAS DE PREGUNTAR SI LA EMPRESA FUE GUARDADA CORRECTAMENTE. LA ESTOY ALMACENANDO TAMBIEN
        cout << "EMPRESA ARCHIVADA CORRECTAMENTE" << endl;
    }
}

void EmpresaManager :: ListarEmpresa()
{
    Empresa obj;
     int cantidad = _Archivo.getCantidadRegistros();
    for(int x = 0 ; x < cantidad ; x ++)
        {
            obj = _Archivo.Leer(x);
            if(obj.getEstado())
            {
            cout << "=================================================" << endl;
            MostrarEmpresa(obj);
            cout << "=================================================" << endl;
            }
        }
}

void EmpresaManager :: ModificarEmpresa()
{
    Empresa obj;
    int Numero_Empresa;
    int pos = 0;

    cout << "INGRESE EL NUMERO DE EMPRESA A MODIFICAR: ";
    cin >> Numero_Empresa;//SELECCIONO LA EMPRESA
    cout << endl;
    pos = _Archivo.BuscarRegistro(Numero_Empresa); //ENCUENTRO EL REGISTRO PERTENECIENTE A LA EMPRESA QUE SELECCCIONE
    if(pos != -1)//SI LA POSICION ES DISTINTO DE -1, SIGNIFICA QUE ENCONTRO UNA POSICION
        {
            obj = _Archivo.Leer(pos); //LEO EL REGISTRO Y LO GUARDO EN UN OBJETO, PARA ABAJO MOSTRARLO
            MostrarEmpresa(obj);
            SobrescribirEmpresa(obj); //VOY AL METODO QUE ME PERMITE SELECCIONAR QUE DATO QUIERO MODIFICAR
            if(_Archivo.SobreEscribir(pos, obj))
                {
                    cout << "EL ARCHIVO SE MODIFICO EXITOSAMENTE" << endl;
                }else
                {
                    cout << "ERROR DE MODIFICACION" << endl;
                }
        }else
        {
            cout << "EMPRESA NO EXISTENTE" << endl;
        }
}

void EmpresaManager :: BajaEmpresa()
{
    int Numero_Empresa, pos = 0;
    Empresa obj;
    bool Eliminar;

    cout << "INGRESE LA EMPRESA QUE DESEA DAR DE BAJA: ";
    cin >> Numero_Empresa; //SELECCIONO LA EMPRESA
    pos = _Archivo.BuscarRegistro(Numero_Empresa); //ENCUENTRO EL REGISTRO PERTENECIENTE A LA EMPRESA QUE SELECCCIONE
    if(pos != -1) //SI LA POSICION ES DISTINTO DE -1, SIGNIFICA QUE ENCONTRO UNA POSICION
    {
        obj = _Archivo.Leer(pos); //LEO EL REGISTRO Y LO GUARDO EN UN OBJETO, PARA ABAJO MOSTRARLO
        MostrarEmpresa(obj);
        cout << endl;
        cout << "DESEA DAR DE BAJA ESTA EMPRESA? (1 - SI || 0 - NO)" << endl;
        cin >> Eliminar;
        if(Eliminar)
        {
            obj.setEstado(false); //SE CAMBIA EL ESTADO DE TRUE (HABILITADO) A FALSE (DESHABILITADO)
            if(_Archivo.SobreEscribir(pos, obj)) //SOBREESCRIBO LOS DATOS EN EL REGISTRO
            {
                cout << "EMPRESA ELIMINADA CORRECTAMENTE" << endl;
            }else
            {
                cout << "ERROR DE SISTEMA" << endl;
            }
        }else
        {
            cout << "NO SE DARA DE BAJA ESTA EMPRESA" << endl;
        }
    }else
    {
        cout << "EMPRESA NO EXISTENTE" << endl;
    }
}

void EmpresaManager :: AltaEmpresa()
{

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
        cout << "3) MODIFICAR EMPRESA" << endl;
        cout << "4) BAJA EMPRESA" << endl;
        cout << "5) ALTA EMPRESA" << endl;
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
            case 3:
                {
                    ModificarEmpresa();
                }
                break;
            case 4:
                {
                  BajaEmpresa();
                }
                break;
            case 5:
                {
                  //AltaEmpresa();
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
