#pragma once
#include "Empresa.h"
#include "EmpresaArchivo.h" //PARA EL OBJETO _ARCHIVO

class EmpresaManager{
private:
    void AgregarEmpresa();  //METODOS PRIVADOS PARA QUE SOLO PUEDA ACCEDER EL METODO MENU
    void ListarEmpresa();
    Empresa CrearEmpresa();

    EmpresaArchivo _Archivo; //DATO ENCAPSULADO DE TIPO EMPRESAaRCHIVO PARA PODER UTILIZARLO EN EL CPP DE ESTE LUGAR
public:
    void Menu();

};
