#ifndef PUESTOMANAGER_H_INCLUDED
#define PUESTOMANAGER_H_INCLUDED
#include "PuestoArchivo.h"
#include "Puesto.h"

class puestoManager{
private:
    puestoArchivo objArch;
    void Mostrar(Puesto obj);
public:
    void CargarPuesto();
    string elegirPuesto();
    void MostrarPuestos();

};

#endif // PUESTOMANAGER_H_INCLUDED
