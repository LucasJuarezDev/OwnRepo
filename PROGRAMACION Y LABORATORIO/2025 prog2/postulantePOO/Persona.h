#ifndef PERSONA_H_INCLUDED
#define PERSONA_H_INCLUDED
#include <iostream>
using namespace std;
#include <string>
#include <cstring>
#include "Puesto.h"

class Persona{
private:
    int Id;
    char Nombre[50];
    char Apellido[50];
    int Edad;
    char PuestoLaboral[50];
    int ExperienciaLaboral;
    bool Contratado;
public:
    Persona(int _id, string _nombre, string _apellido, int _edad, string _puesto, int _xp, bool _contratado);
    Persona();
    //
    int getId();
    string getNombre();
    string getApellido();
    int getEdad();
    string getPuesto();
    int getExperienciaLaboral();
    bool getContratado();
    //
    void setId(int _id);
    void setNombre(string _nombre);
    void setApellido(string _apellido);
    void setEdad(int _edad);
    void setPuesto (string _puesto);
    void setExperienciaLaboral(int _xp);
    void setContratado(bool _contratado);
};

#endif // PERSONA_H_INCLUDED
