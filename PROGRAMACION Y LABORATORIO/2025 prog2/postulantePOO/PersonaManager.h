#ifndef PERSONAMANAGER_H_INCLUDED
#define PERSONAMANAGER_H_INCLUDED
#include "PersonaArchivo.h"
#include "PuestoArchivo.h"
#include "PuestoManager.h"

#include "Persona.h"
class personaManager{
private:
    puestoArchivo puestoArch;
    personaArchivo personaArch;
    void Mostrar(bool contratado, Persona obj);
    void seleccionarPostulante(Persona obj);
public:
    void cargarPersona();
    void mostrarPostulantes();
    void aplicarPostulantes();
    void mostrarContratado();
};


#endif // PERSONAMANAGER_H_INCLUDED
