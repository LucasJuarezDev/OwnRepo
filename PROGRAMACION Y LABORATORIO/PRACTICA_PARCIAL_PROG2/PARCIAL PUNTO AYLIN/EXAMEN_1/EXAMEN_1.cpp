/*
///Generar un archivo con los alumnos que participan de equipos de nivel inicial.
///Cada registro del archivo nuevo debe tener el siguiente formato:

DNI, nombre, apellido y fecha de inscripción
*/

#include <iostream>
using namespace std;
#include "auxiliar.h"
#include <cstring>


void ParcialManager :: Resolver1()
{
    ArchivoEquipos arch_eq("equipos.dat");
    ArchivoJugadores arch_jug("jugadores.dat");
    Jugador jug;
    Equipo equipo;
    int cant_alumnos;
    int cantidad = arch_jug.contarRegistros();

    if(cantidad > 0)
    {
        for(int x = 0 ; x < cantidad ; x ++)
        {
            jug = arch_jug.leerRegistro(x);
            if(jug.getClaustro() == 2)
            {
                cant_alumnos ++;
            }
        }

        for(int x = 0 ; x < cant_alumnos ; x ++)
        {
            equipo = arch_eq.leerRegistro(x);
            jug = arch_jug.leerRegistro(x);

            if(jug.getIdEquipo() == equipo.getIdEquipo() && equipo.getNivel() == 1)
            {
                cout << "DNI: " << jug.getDNI() << endl;
                cout << "NOMBRE: " << jug.getNombre() << endl;
                cout << "APELLIDO: " << jug.getApellido() << endl;
                jug.getFechaInscirpcion().Mostrar();
            }
        }
    }
}
