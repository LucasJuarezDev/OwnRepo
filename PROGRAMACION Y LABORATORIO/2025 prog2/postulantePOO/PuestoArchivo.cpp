#include "PuestoArchivo.h"

bool puestoArchivo :: guardarPuesto(Puesto obj){
    FILE *p;
    bool escritura;

    p = fopen("PUESTOS.DAT", "ab");
    if(p == nullptr){
        cout << "ERROR DE GUARDADO." << endl;
        return false;
    }
    escritura = fwrite(&obj, sizeof(Puesto), 1, p);
    fclose(p);
    return escritura;
}

int puestoArchivo :: contarRegistros(){
    FILE *p;
    int tam;

    p = fopen("PUESTOS.DAT", "rb");
    if(p == nullptr){
        return -1;
    }
    fseek(p, 0, SEEK_END);
    tam = ftell(p) / sizeof(Puesto);
    fclose(p);
    return tam;
}

Puesto puestoArchivo :: leerPuestos(int indice){
    FILE *p;

    p = fopen("PUESTOS.DAT", "rb");
    if(p == nullptr)
    {
        cout << "NO PUDO ABRIR LEER PUESTO" << endl;
        return puesto;
    }

    fseek(p, sizeof(Puesto) * indice, SEEK_SET);
    fread(&puesto, sizeof(Puesto), 1, p);
    fclose(p);
    return puesto;
}

int puestoArchivo :: BuscarCodigoPuesto(int cod){
    FILE *p;
    int pos = 0;
    p = fopen("PUESTOS.DAT", "rb");

    if(p == nullptr){
        cout << "ERROR DE ARCHIVO" << endl;
        return -1;
    }

    while(fread(&puesto, sizeof(Puesto), 1, p) == 1) //el ciclo itera hasta encontrar el objeto
    {
        if(puesto.getIdPuesto() == cod)
        {
            fclose(p);
            return pos; //una vez encontrado retorna la posicion
        }
        pos ++;
    }
    fclose(p);
    return -2;// retorna -2 en caso de no encontrarlo en el archivo

}

int puestoArchivo :: IdTrabajo(){
    int cantidad = contarRegistros();

    if(cantidad > 0)
    {
        return leerPuestos(cantidad - 1).getIdPuesto() + 1;
    }else
    {
        return 1;
    }
}
