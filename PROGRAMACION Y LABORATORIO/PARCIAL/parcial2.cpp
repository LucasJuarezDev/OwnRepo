/*
1- Generar un archivo con el código de material, el tipo y el importe total de las compras para ese material, para el año actual.
Es decir, por cada material se debe registrar el código de material, el tipo, y el importe total de las
compras de ese material en el año actual.

2- La cantidad de obras de cada provincia.

3- Generar un vector dinámico con todos los materiales y listar luego los materiales del vector
que pertenezcan a un tipo que se ingresa por teclado.
*/
#include <iostream>
#include <cstring>
using namespace std;
#include "parcial2.h"

class ParcialManager
{
public:
    void Punto1();
};

void ParcialManager :: Punto1()
{
    ArchivoMateriales arch_mat("materiales.dat");
    ArchivoCompras arch_comp("compras.dat");
    Material mat;

    int cantidad_mat = arch_mat.contarRegistros();

    for(int x = 0 ; x < cantidad_mat ; x ++)
    {
        mat = arch_mat.leerRegistro(x);


    }
}

int main()
{
    ParcialManager obj;

    obj.Punto1();
    return 0;
}
