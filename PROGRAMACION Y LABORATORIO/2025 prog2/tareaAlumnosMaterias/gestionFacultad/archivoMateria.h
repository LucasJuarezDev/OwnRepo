#ifndef ARCHIVOMATERIA_H_INCLUDED
#define ARCHIVOMATERIA_H_INCLUDED
#include "materia.h"

class archivoMateria{
private:
    char Archivo[50];
public:
    archivoMateria(const char * arch = "MATERIAS.DAT");
    bool guardarMateria(Materia);
    Materia leerRegistro(int);
    int contarRegistros();
    bool modificarMateria(Materia, int);
    int buscarNumeroMateria(int);
};

#endif // ARCHIVOMATERIA_H_INCLUDED
