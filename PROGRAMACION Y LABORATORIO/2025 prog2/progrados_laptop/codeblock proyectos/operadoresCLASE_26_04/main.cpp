#include <iostream>
#include <cstring>

using namespace std;

class Cadena{
    private:
        char *texto;
        int tam;
    public:
        Cadena(const char *);
        void setTexto(const char *);
        bool operator==(const char *);
        bool operator!=(Cadena &obj);
        void operator+=(const char *);
        void Mostrar();
        ~Cadena();
};

Cadena::Cadena(const char *t){
    tam = strlen(t);
    texto = new char[tam+1];
    if(texto == nullptr){
        return;
    }
    strcpy(texto, t);
}

Cadena::~Cadena(){
    delete[] texto;
}

void Cadena::Mostrar(){
    cout<<texto<<endl;
}

bool Cadena::operator==(const char *t){
    if(strcmp(texto, t) == 0){
        return true;
    }
    return false;
}

bool Cadena::operator!=(Cadena &obj){
    if(strcmp(texto, obj.texto) != 0){
        return true;
    }
    return false;
}

void Cadena::setTexto(const char *t){
    delete[] texto;
    tam = strlen(t);
    texto = new char[tam+1];
    if(texto == nullptr){
        return;
    }
    strcpy(texto, t);
}

void Cadena ::operator+=(const char *t){
    strcat(texto, t);
}

/**
AGREGARLE A LA CLASE CADENA UNA SOBRECARGA DE OPERADOR QUE
COMPARE DOS OBJETOS DE TIPO CADENA Y DEVUELVA TRUE SI LAS
CADENAS QUE CONTIENEN SON DISTINTAS, FALSE EN OTRO CASO.

AGREGAR OTRA SOBRECARGA PARA EL OPERADOR +=, QUE RECIBA
UNA CADENA DE CARACTERES (const char *) Y LE "SUME" AL TEXTO
LA CADENA RECIBIDA.
*/

int main(){
    Cadena txt("Hola");
    Cadena txt2("Hola");
    txt.Mostrar();
    if(txt == "Hola mundo!"){
        cout<<"LAS DOS CADENAS SON IGUALES"<<endl;
    }
    else{
        cout<<"LAS DOS CADENAS SON DISTINTAS"<<endl;
    }
    txt.Mostrar();
    if(txt == "tecnico universitario en programacion"){
        cout<<"LAS DOS CADENAS SON IGUALES"<<endl;
    }
    else{
        cout<<"LAS DOS CADENAS SON DISTINTAS"<<endl;
    }

    txt.Mostrar();

    if(txt != txt2){
        cout<<"LAS DOS CADENAS SON DISTINTAS PAPA"<<endl;
    }else
    {
        cout<<"LAS DOS CADENAS SON IGUALES XD"<<endl;
    }

    txt += " PACHI HHJSDKSD QWEQSA  QWQDQW  DDDDD"; // CONCATENO UNA CADENA CON UNA SOBRECARGA DE OPERADOR.
    txt.Mostrar();
    return 0;
    }


