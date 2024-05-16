#include <iostream>
#include "Empresa.h"
#include <string.h>
using namespace std;


int Empresa :: getNumeroEmpresa()
{
    return NumeroDeEmpresa;
}

int Empresa :: getCategoria()
{
    return Categoria;
}

int Empresa :: getEmpleados()
{
    return CantidadDeEmpleados;
}

int Empresa :: getNumeroMunicipio()
{
    return NumeroDeMunicipio;
}

bool Empresa :: getEstado()
{
    return Estado;
}

const char * Empresa :: getNombreEmpresa()
{
    return NombreDeEmpresa;
}

void Empresa :: setNumeroEmpresa(int numero_empresa)
{
    NumeroDeEmpresa = numero_empresa;
}

void Empresa :: setNombreEmpresa(const char * nombre_empresa)
{
        strcpy(NombreDeEmpresa, nombre_empresa);
}

void Empresa :: setCategoria(int categoria)
{

    Categoria = categoria;

}

void Empresa :: setEmpleados(int cant_empleados)
{
    CantidadDeEmpleados = cant_empleados;
}

void Empresa :: setNumeroMunicipio(int numero_municipio)
{
    NumeroDeMunicipio = numero_municipio;
}

void Empresa :: setEstado(bool estado)
{
    Estado = estado;
}

Empresa :: Empresa(int numero_empresa, const char * nombre_empresa, long cant_empleados, int categoria, int numero_municipio, bool estado)
{
    setNumeroEmpresa(numero_empresa);
    setNombreEmpresa(nombre_empresa);
    setCategoria(categoria);
    setEmpleados(cant_empleados);
    setNumeroMunicipio(numero_municipio);
    setEstado(estado);
}
