#include "PersonaArchivo.h"

int personaArchivo :: IdPersona(){

    int cantidad = contarRegistros();

    if(cantidad > 0)
    {
        return leerPersona(cantidad - 1).getId() + 1;
    }else
    {
        return 1;
    }
}

/////////// PERSONAS.DAT ///////////////

bool personaArchivo :: guardarPersona(Persona obj){
    FILE *p;
    bool escritura;
    p = fopen("PERSONAS.DAT", "ab");
    if(p == nullptr){
        return false;
    }
    escritura = fwrite(&obj, sizeof(Persona), 1, p);
    fclose(p);
    return escritura;
}

Persona personaArchivo :: leerPersona(int i){
    FILE *p;
    p = fopen("PERSONAS.DAT", "rb");
    if(p == nullptr){
        return obj;
    }
    fseek(p, sizeof(Persona) * i, SEEK_SET);
    fread(&obj, sizeof(Persona), 1, p);
    fclose(p);
    return obj;
}

int personaArchivo :: contarRegistros(){
    FILE *p;
    int tam;

    p = fopen("PERSONAS.DAT", "rb");
    if(p == nullptr){
        return -2;
    }

    fseek(p, 0, SEEK_END);
    tam = ftell(p) / sizeof(Persona);
    fclose(p);
    return tam;
}

bool personaArchivo :: verificarContratado(int Id)
{
    FILE *p;
    int pos = 0;

    p = fopen("CONTRATADOS.DAT", "rb");
    if(p == nullptr)
    {
        cout << "ERROR DE ARCHIVO" << endl;
        return false; //retorna false en caso de error
    }
    while(fread(&obj, sizeof(Persona), 1, p) == 1) //el ciclo itera hasta encontrar el objeto
    {
        if(obj.getId() == Id)
        {
            fclose(p);
            return false; //si coincide retorna falso indicando que esta persona ya fue contratada
        }
        pos ++;
    }
    fclose(p);
    return true;// retorna true si es una persona con status postulante
}

/////////// CONTRATADOS.DAT ///////////////

bool personaArchivo :: guardarAplicado(Persona obj){
    FILE *p;
    bool escritura;
    p = fopen("CONTRATADOS.DAT", "ab");
    if(p == nullptr){
        return false;
    }
    escritura = fwrite(&obj, sizeof(Persona), 1, p);
    fclose(p);
    return escritura;
}

int personaArchivo :: contarContratados(){
    FILE *p;
    int tam;

    p = fopen("CONTRATADOS.DAT", "rb");
    if(p == nullptr){
        return -2;
    }

    fseek(p, 0, SEEK_END);
    tam = ftell(p) / sizeof(Persona);
    fclose(p);
    return tam;
}

Persona personaArchivo :: leerContratado(int i){
    FILE *p;
    p = fopen("CONTRATADOS.DAT", "rb");
    if(p == nullptr){
        return obj;
    }
    fseek(p, sizeof(Persona) * i, SEEK_SET);
    fread(&obj, sizeof(Persona), 1, p);
    fclose(p);
    return obj;
}
