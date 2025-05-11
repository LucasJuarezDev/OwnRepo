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
    float promedio = calcularPromedio();
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int cantidad = arch.CantidadRegistros();
    int punto1 = 0;

    for(int x = 0 ; x < cantidad ; x ++){
        obj = arch.Leer(x);
        if(obj.getPuntajeObtenido() > promedio)
        {
            punto1 ++;
        }
    }
    cout << "==============================" << endl;
    cout << "RESULTADO: " << punto1 << endl;
}

void Examen::Punto2(){
    ArchivoServicioMesa arch("restaurant.dat");
    bool flag = false;
    ServicioMesa obj;
    int cantidad = arch.CantidadRegistros();
    float importeMayor = 0;
    int platoMayor = 0;


    for(int x = 0 ; x < cantidad ; x ++){
        obj = arch.Leer(x);
        if(!flag){
            importeMayor = obj.getImporte();
            platoMayor = obj.getIDPlato();
            flag = true;
        }else if (obj.getImporte() >= importeMayor)
        {
            importeMayor = obj.getImporte();
            platoMayor = obj.getIDPlato();
        }
    }
    cout << "***********************************************" << endl;
    cout << "***********************************************" << endl;
    cout << "EL PLATO MAYOR ES N." << platoMayor << endl;
    cout << "***********************************************" << endl;
    cout << "***********************************************" << endl;
}

void Examen::Punto3(){
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int cantidad = arch.CantidadRegistros();
    float mayor = 0;
    int mozoRico = 0;
    bool flag = false;
    float *propinas;
    propinas = new float[cantidad];
    if(propinas == nullptr)
    {
        return;
    }

    for(int x = 0 ; x < cantidad ; x ++){
        obj = arch.Leer(x);
        if(obj.getIDServicioMesa())
        {
            propinas[x] += obj.getPropina();
        }
    }

    for(int x = 0 ; x < cantidad ; x ++){
        obj = arch.Leer(x);
        if(!flag){
            mayor = propinas[x];
            mozoRico = obj.getIDMozo();
        }else if(propinas[x] > mayor && obj.getFecha().getAnio() == 2024){
            mayor = propinas[x];
            mozoRico = obj.getIDMozo();
        }
    }

    cout << "***********************************************" << endl;
    cout << "***********************************************" << endl;
    cout << "EL MOZO CON MAYOR PROPINA ES N." << mozoRico << endl;
    cout << "***********************************************" << endl;
    cout << "***********************************************" << endl;
    delete []propinas;
}

float Examen ::calcularPromedio(){
    ArchivoServicioMesa arch("restaurant.dat");
    ServicioMesa obj;
    int cantidad = arch.CantidadRegistros();
    float acumulador = 0;

    for(int x = 0 ; x < cantidad ; x ++){
        obj = arch.Leer(x);
        if(obj.getIDServicioMesa() != 0){
            acumulador += obj.getPuntajeObtenido();
        }
    }
    float resultado = acumulador / cantidad;
    return resultado;
}

