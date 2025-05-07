#ifndef MATERIA_H_INCLUDED
#define MATERIA_H_INCLUDED

class Materia{
private:
    int numeroMateria;
    char nombreMateria[50];
    int cantidadAlumnos;
    int cantidadDocentes;
    bool Estado;
public:
    //
    Materia();
    Materia(int num_mat, const char *nom_mat, int cant_alumno, int cant_docente, bool estado);
    //
    int getNumeroMateria();
    const char *getNombreMateria();
    int getCantidadAlumnos();
    int getCantidadDocentes();
    bool getEstado();
    //
    void setNumeroMateria(int num_mat);
    void setNombreMateria(const char *nom_mat);
    void setCantidadAlumnos(int cant_alumno);
    void setCantidadDocentes(int cant_docente);
    void setEstado(bool estado);
};

#endif // MATERIA_H_INCLUDED
