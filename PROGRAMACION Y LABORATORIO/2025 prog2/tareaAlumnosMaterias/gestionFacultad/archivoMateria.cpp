#include "archivoMateria.h"
#include <cstring>
#include <iostream>

archivoMateria :: archivoMateria(const char * arch)
{
    strcpy(Archivo, arch);
}

bool archivoMateria :: guardarMateria(Materia obj)
{
    FILE *p;
    bool escritura;
    p = fopen(Archivo, "ab");
    if(p == nullptr)
    {
        return false;
    }
    escritura = fwrite(&obj, sizeof(Materia), 1, p);
    fclose(p);
    return escritura;
}

Materia archivoMateria :: leerRegistro(int pos)
{
    FILE *p = fopen(Archivo, "rb");
    Materia obj;
    if(p == nullptr)
    {
        return obj;
    }
    fseek(p, pos * sizeof(Materia), 0);
    fread(&obj, sizeof(Materia), 1, p);
    fclose(p);
    return obj;
}

int archivoMateria :: contarRegistros()
{
    FILE *p=fopen(Archivo, "rb");
    if(p == nullptr){
        return -1;
    }
    fseek(p, 0, 2);
    int tam = ftell(p);
    fclose(p);
    return tam/sizeof(Materia);
}

bool archivoMateria :: modificarMateria(Materia obj, int pos)
{
    FILE *p;
    bool escritura;
    p = fopen(Archivo, "rb+");
    if(p == nullptr)
    {
        return false;
    }
    fseek(p, pos * sizeof obj, 0);
    escritura = fwrite(&obj, sizeof obj, 1, p);
    fclose(p);
    return escritura;
}

int archivoMateria :: buscarNumeroMateria(int Cod)
{
    int pos = 0;
    Materia obj;
    FILE *p = fopen(Archivo, "rb");
    if(p == nullptr)
    {
        return -1;
    }

    while(fread(&obj, sizeof(Materia), 1, p) == 1)
    {
        if(obj.getNumeroMateria() == Cod)
        {
            fclose(p);
            return pos;
        }
        pos ++;
    }
    fclose(p);
    return -2;
}
