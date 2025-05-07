#include "materia.h"
#include <cstring>

Materia :: Materia()
{
    numeroMateria = 0;
    strcpy(nombreMateria, "");
    cantidadAlumnos = 0;
    cantidadDocentes = 0;
    Estado = false;
}

Materia :: Materia(int num_mat, const char *nom_mat, int cant_alumno, int cant_docente, bool estado)
{
    setCantidadAlumnos(num_mat);
    setNombreMateria(nom_mat);
    setCantidadAlumnos(cant_alumno);
    setCantidadDocentes(cant_docente);
    setEstado(estado);
}

//

void Materia :: setNumeroMateria(int num_mat)
{
    numeroMateria = num_mat;
}

void Materia :: setNombreMateria(const char *nom_mat)
{
    strcpy(nombreMateria, nom_mat);
}

void Materia :: setCantidadAlumnos(int cant_alumno)
{
    cantidadAlumnos = cant_alumno;
}

void Materia :: setCantidadDocentes(int cant_docente)
{
    cantidadDocentes = cant_docente;
}

void Materia :: setEstado(bool estado)
{
    Estado = estado;
}

//

int Materia :: getNumeroMateria()
{
    return numeroMateria;
}

const char * Materia :: getNombreMateria()
{
    return nombreMateria;
}

int Materia :: getCantidadAlumnos()
{
    return cantidadAlumnos;
}

int Materia :: getCantidadDocentes()
{
    return cantidadDocentes;
}

bool Materia :: getEstado()
{
    return Estado;
}
