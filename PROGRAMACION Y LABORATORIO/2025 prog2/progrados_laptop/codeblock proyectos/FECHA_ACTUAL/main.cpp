#include <iostream>
#include "Fecha_actual.h"
using namespace std;

class Persona
{
private:
    int edad;
    Fecha fecha_de_nacimiento;
public:
    Persona(int e, Fecha fec)
    {
        setEdad(e);
        setFechaNac(fec);
    }
    void setFechaNac(Fecha fec){fecha_de_nacimiento = fec;}
    void setEdad(int e){edad = e;}
    int getEdad(){return edad;}
    Fecha getFechaNac(){return fecha_de_nacimiento;}
};

int main()
{
    Fecha obj;
    Persona name(0,Fecha());

    name.setEdad(20);
    //name.setFechaNac(obj.DevuelveFechaActual());
    cout << name.getEdad() << endl;
    name.getFechaNac().MostrarFechaActual();

    //obj.MostrarFechaActual();
    return 0;
}
