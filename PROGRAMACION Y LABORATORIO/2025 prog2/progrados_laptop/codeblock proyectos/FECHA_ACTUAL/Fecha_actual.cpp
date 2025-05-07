#include "Fecha_actual.h"
#include <iostream>
#include <ctime>
using namespace std;

Fecha::Fecha(){
    time_t t;
    struct tm *f;
    time(&t);
    f = localtime(&t);
    Dia = f->tm_mday;
    Mes = f->tm_mon+1;
    Anio = f->tm_year+1900;
}

Fecha Fecha::DevuelveFechaActual()
{
    return Fecha();
}

void Fecha ::MostrarFechaActual()
{
    Fecha obj;
    cout << obj.getDia() << "/" << obj.getMes() << "/" << obj.getAnio() << endl;
}


