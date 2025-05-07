#ifndef PUESTO_H_INCLUDED
#define PUESTO_H_INCLUDED
#include <iostream>
using namespace std;
#include <string>
#include <cstring>

class Puesto{
private:
    int IdPuesto;
    char NombrePuesto[100];
    bool EstadoPuesto;
public:
    Puesto(int _id, string _nombre, bool _estado);
    Puesto();
    //
    int getIdPuesto();
    string getPuesto();
    bool getEstado();
    //
    void setIdPuesto(int _id);
    void setPuesto(string _nombre);
    void setEstado(bool _estado);
};

#endif // PUESTO_H_INCLUDED
