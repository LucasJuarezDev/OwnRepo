#include "Puesto.h"
#include <cstring>

Puesto :: Puesto(int _id, string _nombre, bool _estado){
    setIdPuesto(_id);
    setPuesto(_nombre);
    setEstado(_estado);
}

Puesto :: Puesto(){
    IdPuesto = 0;
    strcpy(NombrePuesto, "");
    EstadoPuesto = false;
}

//setters

void Puesto :: setIdPuesto(int _id){
    IdPuesto = _id;
}

void Puesto :: setPuesto(string _nombre){
    strcpy(NombrePuesto, _nombre.c_str());
}

void Puesto :: setEstado(bool _estado){
    EstadoPuesto = _estado;
}

//getters

int Puesto :: getIdPuesto(){
    return IdPuesto;
}

string Puesto :: getPuesto(){
    return NombrePuesto;
}

bool Puesto :: getEstado(){
    return EstadoPuesto;
}

