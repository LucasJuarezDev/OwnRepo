/*
///Generar un archivo con los alumnos que participan de equipos de nivel inicial.
///Cada registro del archivo nuevo debe tener el siguiente formato:

DNI, nombre, apellido y fecha de inscripción
*/

#include <iostream>
using namespace std;
#include "auxiliar.h"
#include <cstring>


void ParcialManager :: mostrarJugadores()
{
    ArchivoJugadores arch("jugadores.dat");
    int reg = arch.contarRegistros();
    Jugador obj;

    for(int x = 0 ; x < reg ; x ++){
        obj = arch.leerRegistro(x);
        cout << "++++++++++++++" << endl;
        obj.Mostrar();
        cout << "++++++++++++++" << endl;
    }
}

void ParcialManager :: mostrarEquipos()
{
    ArchivoEquipos arch("equipos.dat");
    int reg = arch.contarRegistros();
    Equipo obj;

    for(int x = 0 ; x < reg ; x ++){
        obj = arch.leerRegistro(x);
        cout << "++++++++++++++" << endl;
        obj.Mostrar();
        cout << "++++++++++++++" << endl;
    }
}



void ParcialManager :: Punto1()
{
    ArchivoJugadores archjug("jugadores.dat");
    ArchivoJugadores archPunto1("jugadores_equipo_uno.dat");
    ArchivoJugadores jugadoresEquipo4("jugadores_equipo_cuatro.dat");
    int regJug = archjug.contarRegistros();
    Jugador jug;

    for(int x = 0 ; x < regJug ; x ++)
    {
        jug = archjug.leerRegistro(x);

        if(jug.getIdEquipo() == 4)
        {
            if(jugadoresEquipo4.grabarRegistro(jug))
            {
                cout << "SE GUARDO EL REGISTRO!" << endl;
            }else
            {
                cout << "ERROR." << endl;
            }
        }
    }
}
