#include <iostream>
using namespace std;

#include "Examen.h"
#include "ServicioMesa.h"
#include "ArchivoServicioMesa.h"

void Examen::EjemploDeListado(){
   ArchivoServicioMesa archivo("restaurant.dat");
   ServicioMesa registro;

   int i, cantidadRegistros = archivo.CantidadRegistros();
   for(i = 0; i < cantidadRegistros; i++){
      registro = archivo.Leer(i);
      cout << registro.toCSV() << endl;
   }
}

void Examen::Punto1(){
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int registros = arch.CantidadRegistros();
    float promedio = 0, resultado;
    int serviciosMayores = 0;

    for(int x = 0 ; x < registros ; x ++){
        obj = arch.Leer(x);
        promedio += obj.getPuntajeObtenido();
    }
    resultado = promedio / registros;

    for(int x = 0 ; x < registros ; x ++){
        obj = arch.Leer(x);

        if(obj.getPuntajeObtenido() > resultado){
            serviciosMayores ++;
        }
    }
    cout << "================================" << endl;
    cout << "PUNTO 1: " << serviciosMayores << endl;
    cout << "================================" << endl;
    cout << endl;
}

void Examen::Punto2(){
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int registros = arch.CantidadRegistros();
    float importeXplato[70] = {};
    float importeMayor = 0;
    int platoMayor = 0;
    bool flag = false;

    for(int x = 0 ; x < registros ; x ++){
    obj = arch.Leer(x);
    importeXplato[obj.getIDPlato() - 1] += obj.getImporte();
    }

   for(int x = 0 ; x < 70 ; x ++){
        if(!flag){
            importeMayor = importeXplato[x];
            platoMayor = x + 1;
            flag = true;
        }

        if(importeXplato[x] >= importeMayor){
            importeMayor = importeXplato[x];
            platoMayor = x + 1;
        }
    }

    cout << "================================" << endl;
    cout << "PUNTO 2: " << platoMayor << endl;
    cout << "================================" << endl;
    cout << endl;

}

void Examen::inicializarVector(float *v, int tam){
    for(int x = 0 ; x < tam ; x ++){
        v[x] = 0;
    }
}

void Examen::Punto3(){
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int registros = arch.CantidadRegistros();
    float propinaXmozo[20] = {};
    inicializarVector(propinaXmozo, 20);
    bool flag = false;
    int mozoRico = 0;
    float propinaMayor = 0;

    for(int x = 0 ; x < registros ; x ++){
        obj = arch.Leer(x);
        if(obj.getFecha().getAnio() == 2024)
        propinaXmozo[obj.getIDMozo() - 1] += obj.getPropina();
    }

    for(int x = 0 ; x < 20 ; x ++){
        if(!flag){
            propinaMayor = propinaXmozo[x];
            mozoRico = x + 1;
            flag = true;
        }
        else if(propinaXmozo[x] >= propinaMayor){
            propinaMayor = propinaXmozo[x];
            mozoRico = x + 1;
        }
    }

    cout << "================================" << endl;
    cout << "PUNTO 3: " << mozoRico << endl;
    cout << "================================" << endl;
    cout << endl;
}


