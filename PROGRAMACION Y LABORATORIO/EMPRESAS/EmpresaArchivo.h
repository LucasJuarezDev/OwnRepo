#pragma once
#include "Empresa.h" //PARA MANIPULAR LOS OBJETOS DE TIPO EMPRESA EN ESTE ARCHIVO

class EmpresaArchivo{

public:
    bool Guardar(Empresa emp); //EL METODO ES BOOLEANO PARA SABER SI EL OBJETO FUE GUARDADO (SI DEVUELVE TRUE FUE GUARDADO!!!)
    Empresa Leer(int Indice); //AGARRO UN INDICE PARA POSICIONARME DENTRO DEL ARCHIVO, Y DEVUELVO UN OBJETO CON SUS PROPIEDADES PARA MOSTRAR
    int getCantidadRegistros();
    int BuscarRegistro(int NE);
    bool SobreEscribir(int indice, Empresa obj);
    int NuevoNE();
};
