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
    int _tam;

    Pemp = fopen("EMPRESA.DAT", "rb");
    if(Pemp == nullptr){
        return -1;
    }
    fseek(Pemp, 0, SEEK_END);
    //ME MUEVO 0 BYTES DESDE EL PRINCIPIO, Y ME POSICIONO AL FINAL (SEEK_END), RECORRO DE ATRAS PARA ADELANTE CONTANDO
    //EL TAMAÑO DEL ARCHIVO
    _tam = ftell(Pemp) / sizeof(Empresa);
    //EN _TAM GUARDO EL TAMAÑO DEL ARCHIVO EN BYTES
    // FTELL(PFILE) (TAMAÑO TOTAL DEL ARCHIVO) / SIZEEOF(OBJ) (TAMAÑO DE UN REGISTRO INDIVIDUAL)
    //ESO ME DARA LA CANTIDAD DE REGISTROS QUE TIENE NUESTRO ARCHIVO
    return _tam;
    //RETORNO LA CANTIDAD DE REGISTROS

}

int EmpresaArchivo :: BuscarRegistro(int NE)
{
    FILE *Pemp;
    int p = 0;
    Empresa obj;

    Pemp = fopen("EMPRESA.DAT", "rb");
    if(Pemp == nullptr)
        {
            std::cout << "ERROR DE ARCHIVO" << std::endl;
            return -1;
        }
    while(fread(&obj, sizeof(Empresa), 1, Pemp) == 1)
        {
            if(obj.getNumeroEmpresa() == NE)
                {
                    fclose(Pemp);
                    return p;
                }
                p ++;
        }
        fclose(Pemp);
        return -1;
}

bool EmpresaArchivo :: SobreEscribir(int indice, Empresa obj)
{
    bool R;
    FILE *Pemp;
    Pemp = fopen("EMPRESA.DAT", "rb+");
    if(Pemp == nullptr)
        {
            return -1;
        }
    fseek(Pemp, sizeof(Empresa) * indice, SEEK_SET);
    R = fwrite(&obj, sizeof(Empresa), 1, Pemp);
    fclose(Pemp);
    return R;
}

int EmpresaArchivo :: NuevoNE()
{
    int cantidad = getCantidadRegistros();

    if(cantidad > 0)
        {
            return Leer(cantidad - 1).getNumeroEmpresa() + 1;
        }else
        {
            return 1;
        }
}
