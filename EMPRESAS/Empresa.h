#pragma once

class Empresa{
private:
    int NumeroDeEmpresa;
    char NombreDeEmpresa[30];
    int CantidadDeEmpleados;
    int Categoria;
    int NumeroDeMunicipio;
    bool Estado;
public:
    //CONSTRUCTOR
    Empresa(int numero_empresa = 0, const char * nombre_empresa = "", int cant_empleados = 0 ,int cat = 0, int numero_municipio = 0, bool est = false);
    //METODOS VARIOS
    void CargarEmpresa();
    void MostrarEmpresa();
    //GETTERS
    int getNumeroEmpresa();
    const char * getNombreEmpresa();
    int getCategoria();
    int getEmpleados();
    int getNumeroMunicipio();
    bool getEstado();
    //SETTERS
    void setNumeroEmpresa(int numero_empresa);
    void setNombreEmpresa(const char *nombre_empresa);
    void setCategoria(int categoria);
    void setEmpleados(int cant_empleadcs);
    void setNumeroMunicipio(int numero_municipio);
    void setEstado(bool estado);
};

