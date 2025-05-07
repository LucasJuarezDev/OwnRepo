#ifndef MANAGERMATERIA_H_INCLUDED
#define MANAGERMATERIA_H_INCLUDED
#include "archivoMateria.h"

class ManagerMateria{
private:
    archivoMateria archMateria;
    void cargarCadena(char *Palabra, int Tamanio);
    void Mostrar(Materia obj);
    void ModificacionMateria(Materia &obj);
public:
    void cargarMateria();
    void mostrarMateria();
    void modificarMateria();
};

#endif // MANAGERMATERIA_H_INCLUDED
