#include "EmpresaArchivo.h"
#include <iostream>

bool EmpresaArchivo :: Guardar(Empresa emp)
{
    FILE *Pemp;
    bool Escritura;
    Pemp = fopen("EMPRESA.DAT", "ab");
    if(Pemp == nullptr){
        std::cout << "ERROR DE APERTURA" << std::endl;
        return false;
    }else{
        Escritura = fwrite(&emp, sizeof(Empresa), 1, Pemp);
        fclose(Pemp); //cerrar el archivo para evitar errores de apertura posteriores
        return Escritura;
    }
}

Empresa EmpresaArchivo :: Leer(int Indice)
{
    FILE *Pemp;
    Empresa emp;

    Pemp = fopen("EMPRESA.DAT", "rb");
    if(Pemp == nullptr){
        return emp;
        // SI NO PUEDE ABRIRLO, DEVUELVO UN OBJETO VACIO
    }

    fseek(Pemp, Indice * sizeof(Empresa), SEEK_SET);
    //EN FSEEK, ME POSICIONO EN EL INDICE DEL FOR (0), Y LO MULTIPLICO POR EL TAMAÑO DEL OBJETO. CON SEEK_SET ME POSICIONO AL PRINCIPIO.
    // 0 * 2O = 0 (ME POSICIONO AL PRINCIPIO Y MUESTRO HASTA 20 BYTES) || 1 * 20 = 20(ME MUEVO AL BYTE 20, Y MUESTRO DE AHI PARA ADELANTE
    fread(&emp, sizeof(Empresa), 1, Pemp);
    fclose(Pemp);
    return emp;
}

int EmpresaArchivo :: getCantidadRegistros()
{
    FILE *Pemp;
    int _cantidad = 0, _tam = 0;

    Pemp = fopen("EMPRESA.DAT", "rb");
    if(Pemp == nullptr){
        return -1;
    }
    fseek(Pemp, 0, SEEK_END);
    //ME MUEVO 0 BYTES DESDE EL PRINCIPIO, Y ME POSICIONO AL FINAL (SEEK_END), RECORRO DE ATRAS PARA ADELANTE CONTANDO
    //EL TAMAÑO DEL ARCHIVO
    _tam = ftell(Pemp);
    //EN _TAM GUARDO EL TAMAÑO DEL ARCHIVO EN BYTES
    _cantidad = _tam / sizeof(Empresa);
    // _TAM (TAMAÑO TOTAL DEL ARCHIVO) / SIZEEOF(EMPRESA) (TAMAÑO DE UN REGISTRO INDIVIDUAL)
    //ESO ME DARA LA CANTIDAD DE REGISTROS QUE TIENE NUESTRO ARCHIVO
    return _cantidad;
    //RETORNO LA CANTIDAD DE REGISTROS

}
