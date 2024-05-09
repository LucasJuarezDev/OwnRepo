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
    if(NumeroDeEmpresa > 0)
        {
            NumeroDeEmpresa = numero_empresa;
        }else
        {
            NumeroDeEmpresa = 0;
        }
}

void Empresa :: setNombreEmpresa(const char * nombre_empresa)
{
        strcpy(NombreDeEmpresa, nombre_empresa);
}

void Empresa :: setCategoria(int categoria)
{
    if(Categoria > 0 && Categoria <= 44)
        {
            Categoria = categoria;
        }else
        {
           Categoria = 0;
        }
}

void Empresa :: setEmpleados(int cant_empleados)
{
    if(CantidadDeEmpleados > 0)
        {
            CantidadDeEmpleados = cant_empleados;
        }else
        {
           CantidadDeEmpleados = 0;
        }
}

void Empresa :: setNumeroMunicipio(int numero_municipio)
{
    if(NumeroDeMunicipio > 0 && NumeroDeMunicipio <= 55)
        {
            NumeroDeMunicipio = numero_municipio;
        }else
        {
           NumeroDeMunicipio = 0;
        }
}

void Empresa :: setEstado(bool estado)
{
            Estado = estado;
}

Empresa :: Empresa(int numero_empresa, const char * nombre_empresa, int cant_empleados, int categoria, int numero_municipio, bool estado)
{
    setNumeroEmpresa(numero_empresa);
    setNombreEmpresa(nombre_empresa);
    setCategoria(categoria);
    setEmpleados(cant_empleados);
    setNumeroMunicipio(numero_municipio);
    setEstado(estado);
}

void Empresa :: CargarEmpresa()
{

    cout << "NUMERO DE EMPRESA: ";
    cin >> NumeroDeEmpresa;
    cout << endl;
    cout << "NOMBRE DE EMPRESA: ";
    cin >> NombreDeEmpresa;
    cout << endl;
    cout << "CANTIDAD DE EMPLEADOS: ";
    cin >> CantidadDeEmpleados;
    cout << endl;
    cout << "CATEGORIA DE EMPRESA: ";
    cin >> Categoria;
    cout << endl;
    cout << "NUMERO DE MUNICIPIO DE LA EMPRESA: ";
    cin >> NumeroDeMunicipio;
    cout << endl;
    cout << "ESTADO FISCAL: ";
    cin >> Estado;
    cout << endl;
}

void Empresa :: MostrarEmpresa()
{
    cout << "NUMERO DE EMPRESA: " << getNumeroEmpresa() << endl;
    cout << "NOMBRE DE EMPRESA: " << getNombreEmpresa() << endl;
    cout << "CANTIDAD DE EMPLEADOS: " << getEmpleados() << endl;
    cout << "CATEGORIA DE EMPRESA: " << getCategoria() << endl;
    cout << "NUMERO DE MUNICIPIO DE LA EMPRESA: " << getNumeroMunicipio() << endl;
    cout << "ESTADO FISCAL: " << getEstado() << endl;
}
