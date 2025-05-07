#ifndef PUESTOARCHIVO_H_INCLUDED
#define PUESTOARCHIVO_H_INCLUDED
#include "Puesto.h"

class puestoArchivo{
private:
    Puesto puesto;
public:
    int IdTrabajo();
    bool guardarPuesto(Puesto puesto);
    int BuscarCodigoPuesto(int Cod);
    int contarRegistros();
    Puesto leerPuestos(int indice);
};

#endif // PUESTOARCHIVO_H_INCLUDED
