#include "Persona.h"
#include <cstring>

//constructores

Persona :: Persona(){
    Id = 0;
    strcpy(Nombre, "");
    strcpy(Apellido, "");
    Edad = 0;
    ExperienciaLaboral = 0;
    Contratado = false;
    strcpy(PuestoLaboral, "");
}

Persona::Persona(int _id, string _nombre, string _apellido, int _edad, string _puesto, int _xp, bool _contratado)
{
    setId(_id);
    setNombre(_nombre);
    setApellido(_apellido);
    setEdad(_edad);
    setPuesto(_puesto);
    setExperienciaLaboral(_xp);
    setContratado(_contratado);
}

//setters

void Persona :: setId(int _id)
{
    Id = _id;
}

void Persona :: setNombre(string _nombre)
{
    strcpy(Nombre, _nombre.c_str());
}

void Persona :: setApellido(string _apellido)
{
    strcpy(Apellido, _apellido.c_str());
}

void Persona :: setEdad(int _edad)
{
    Edad = _edad;
}

void Persona :: setPuesto(string _puesto){
    strcpy(PuestoLaboral, _puesto.c_str());
}

void Persona :: setExperienciaLaboral(int _xp){
    ExperienciaLaboral = _xp;
}

void Persona :: setContratado(bool _contratado){
    Contratado = _contratado;
}

//getters

int Persona :: getId(){
    return Id;
}

string Persona :: getNombre(){
    return Nombre;
}

string Persona :: getApellido(){
    return Apellido;
}

int Persona :: getEdad(){
    return Edad;
}

string Persona :: getPuesto(){
    return PuestoLaboral;
}

int Persona :: getExperienciaLaboral(){
    return ExperienciaLaboral;
}

bool Persona :: getContratado(){
    return Contratado;
}
