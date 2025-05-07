#ifndef PERSONAARCHIVO_H_INCLUDED
#define PERSONAARCHIVO_H_INCLUDED
#include "Persona.h"

class personaArchivo{
private:
    Persona obj;
public:
    int IdPersona();
    //POSTULANTES
    bool guardarPersona(Persona obj);
    int contarRegistros();
    Persona leerPersona(int indice);
    bool verificarContratado(int id);
    // CONTRATADOS
    bool guardarAplicado(Persona obj);
    Persona leerContratado(int indice);
    int contarContratados();
};


#endif // PERSONAARCHIVO_H_INCLUDED
