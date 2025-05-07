#ifndef FECHA_ACTUAL_H_INCLUDED
#define FECHA_ACTUAL_H_INCLUDED

class Fecha
{
private:
    int Dia, Mes, Anio;
public:
    Fecha();
    Fecha DevuelveFechaActual();
    void MostrarFechaActual();
    int getDia(){return Dia;}
    int getMes(){return Mes;}
    int getAnio(){return Anio;}
};

#endif // FECHA_ACTUAL_H_INCLUDED
