#include <iostream>
#include <cstring>
using namespace std;
#include "PREPARCIAL2_1.h"

class ParcialLucasJuarez
{
public:
    void Punto1A();
    void VectorACero(int *Veq, int cant)
    {
        for(int x = 0 ; x < cant ; x ++)
        {
            Veq[x] = 0;
        }
    }

};

void ParcialLucasJuarez :: Punto1A()
{
    ArchivoEquipos arch_eq("equipos.dat");
    ArchivoJugadores arch_jug("jugadores.dat");
    Equipo eq, aux, *ListarEquipos;
    int *Vequipos, cant_equipos_de_diez = 0;
    Jugador jug;
    int cantidad_equipos = arch_eq.contarRegistros();
    int cantidad_jugadores = arch_jug.contarRegistros();

    Vequipos = new int[cantidad_equipos]; //PUNTOA
    if(Vequipos == nullptr)
    {
        return;
    }
    VectorACero(Vequipos, cantidad_equipos);

    ListarEquipos = new Equipo[cantidad_equipos]; //PUNTOB
    if(ListarEquipos == nullptr)
    {
        return;
    }

    for(int x = 0 ; x < cantidad_equipos ; x ++)
    {
        eq = arch_eq.leerRegistro(x);
        for(int i = 0 ; i < cantidad_jugadores ; i ++)
        {
            jug = arch_jug.leerRegistro(x);
            if(eq.getIDequipo() == jug.getIDequipo() && jug.getNombre() != "" && jug.getApellido() != "")
            {
                Vequipos[x]++;
            }
        }
    }

    for(int x = 0 ; x < cantidad_equipos ; x ++)
    {
        eq = arch_eq.leerRegistro(x);
        if(Vequipos[x] >= 10)
        {
            aux.setIDEquipo(eq.getIDequipo());
            aux.setNombre(eq.getNombre());
            aux.setNivel(eq.getNivel());
            arch_eq.grabarRegistro(aux);
            ListarEquipos[x] = aux;
            ListarEquipos[x].Mostrar();
            cout << endl;
        }
    }

    delete [] ListarEquipos;
    delete [] Vequipos;

}

int main()
{
    ParcialLucasJuarez lucas;

    lucas.Punto1A();
    return 0;
}
