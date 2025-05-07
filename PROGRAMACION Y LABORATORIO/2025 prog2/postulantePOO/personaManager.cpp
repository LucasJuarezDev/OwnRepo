#include "PersonaManager.h"
#include <iostream>
using namespace std;

void personaManager :: Mostrar(bool contratado, Persona obj){
    cout << "REGISTRO NRO: " << obj.getId() << endl;
    cout << " ---------------------------- " << endl;
    cout << "NOMBRE Y APELLIDO: " << obj.getApellido() << obj.getNombre() << endl;
    cout << "EDAD: " << obj.getEdad() << endl;
    cout << " ---------------------------- " << endl;
    cout << "PUESTO AL QUE APLICA: " << obj.getPuesto() << endl;
    cout << "ANIOS DE EXPERIENCIA LABORAL: " << obj.getExperienciaLaboral() << endl;
    if(!contratado){
        cout << "ESTADO DE RECLUTAMIENTO: " << (obj.getContratado() ? "EN CONSIDERACION" : "NO") << endl;
    }
}

void personaManager :: seleccionarPostulante(Persona individuo){
    int seleccion;

    cout << endl;
    cout << "QUIERE CONTRATAR EN ESTE PUESTO A ESTA PERSONA? (CUALQUIER NUMERO - SI | 0 - NO)" << endl;
    cout << "==================" << endl;
    cout << "NOMBRE: " << individuo.getNombre() << individuo.getApellido() << endl;
    cout << "PUESTO: " << individuo.getPuesto() << endl;
    cout << "==================" << endl;
    cin >> seleccion;
    if(seleccion != 0){
        if(personaArch.guardarAplicado(individuo))
        {
          cout << "POSTULANTE CONTRATADO!" << endl;
          system("pause");
        }else
        {
          cout << "ALGO SALIO MAL..." << endl;
          system("pause");
        }
    system("cls");
    }else
    {
        system("cls");
        return;
    }
}

/////////////////////////////////////////////////////

void personaManager :: mostrarContratado(){
    Persona obj;

    int cantidad = personaArch.contarContratados();

    system("cls");
    if(cantidad > 0)
    {
        for(int x = 0 ; x < cantidad ; x ++)
        {
            obj = personaArch.leerContratado(x);
            cout << "=================================================" << endl;
            Mostrar(true, obj);
            cout << "=================================================" << endl;
        }
    }else
    {
        cout << "NO SE CONTRATARON PERSONAS POR EL MOMENTO." << endl;
        return;
    }
}


void personaManager :: mostrarPostulantes(){
    Persona obj;

    int cantidad = personaArch.contarRegistros();

    system("cls");
    if(cantidad > 0)
    {
        for(int x = 0 ; x < cantidad ; x ++)
        {
            obj = personaArch.leerPersona(x);
            if(obj.getContratado())
            {
                cout << "=================================================" << endl;
                Mostrar(false, obj);
                cout << "=================================================" << endl;
            }
        }
    }else
    {
        cout << "NO HAY POSTULANTES CARGADOS ACTUALMENTE" << endl;
        return;
    }
}


void personaManager :: cargarPersona(){
    Persona obj;
    puestoManager selecPuesto;
    int id, edad, xp;
    string nombre, apellido, puesto;

    cout << "=============================================================="<< endl;
    cout << "                   REGISTRO DE POSTULANTE"<< endl;
    cout << "=============================================================="<< endl;
    id = personaArch.IdPersona();
    obj.setId(id);
    cout << "ID POSTULANTE: " << obj.getId() << endl;
    cout << endl;
    cout << "=============================================================="<< endl;

    cout << "NOMBRE Y APELLIDO: ";
    cin.ignore();
    getline(cin, nombre);
    fflush(stdin);
    cout << endl;
    cin.ignore();
    getline(cin, apellido);
    fflush(stdin);
    obj.setNombre(nombre);
    obj.setApellido(apellido);
    cout << endl;
    cout << "=============================================================="<< endl;
    cout << "INGRESE LA EDAD: ";
    cin >> edad;
    obj.setEdad(edad);
    cout << endl;
    cout << "=============================================================="<< endl;
    cout << "INGRESE AL PUESTO QUE APLICA: ";
    puesto = selecPuesto.elegirPuesto();
    obj.setPuesto(puesto);
    cout << endl;
    cout << "=============================================================="<< endl;
    cout << "ANIOS DE EXPERIENCIA: ";
    cin >> xp;
    obj.setExperienciaLaboral(xp);
    obj.setContratado(true);
    if(personaArch.guardarPersona(obj))
    {
      cout << "POSTULANTE CARGADO CORRECTAMENTE." << endl;
      system("pause");
    }else
    {
      cout << "ALGO SALIO MAL..." << endl;
      system("pause");
    }
    cout << endl;
}

void personaManager :: aplicarPostulantes(){
    string puestoBuscado;
    char Selector[30], copia[30];
    puestoManager selecPuesto;
    Persona individuo;
    int Comparador;
    int cantidadPostulante = personaArch.contarRegistros();
    int cantidadPuestos = puestoArch.contarRegistros();
    bool fueContratado;

    if(cantidadPostulante > 0 && cantidadPuestos > 0){
        puestoBuscado = selecPuesto.elegirPuesto();
        strcpy(Selector, puestoBuscado.c_str());

        for(int x = 0 ; x < cantidadPostulante ; x ++){
            fueContratado = false;
            individuo = personaArch.leerPersona(x);
            fueContratado = personaArch.verificarContratado(individuo.getId());
            strcpy(copia, individuo.getPuesto().c_str());
            Comparador = strcmp(Selector,copia);
            if(Comparador == 0 && individuo.getContratado() && fueContratado){
                cout << "=================================================" << endl;
                Mostrar(false, individuo);
                seleccionarPostulante(individuo);
                cout << "=================================================" << endl;
            }
        }
    }else
    {
        cout << "NO HAY POSTULANTES Y/O PUESTOS GUARDADOS PARA EVALUAR." << endl;
    }

}
