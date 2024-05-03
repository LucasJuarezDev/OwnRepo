#include <iostream>
#include <string.h> //AÑADE LA FUNCION STRCPY O STRCMP
using namespace std;


class Articulo{
private:
    char _Codigo[5];
    char _Descripcion[30];
    float _PrecioUnitario;
    int _Stock;
    bool _Estado;

    /*  COMENTARIOS DE CODIGO

        CONST CHAR * EN EL CONSTRUCTOR == EN ''C++ MODERNO'' NO PERMITE LA CONVERSION DE UNA CADENA DE CARACTERES A UN PUNTERO DE CARACTERES

    */

public:
    Articulo(const char *c = "", const char *d = "", float p = 0, int s = 0, bool e = false){
        strcpy(_Codigo, c);
        strcpy(_Descripcion, d);
        _PrecioUnitario = p;
        _Stock = s;
        _Estado = e;
    }
    float getArtPU(){return _PrecioUnitario;}
    int getArtSTK() {return _Stock;}
    bool getArtEST(){return _Estado;}
    const char *getArtCOD(){return _Codigo;}
    const char *getArtDESC(){return _Descripcion;}
    void setArtSTK(int s) {_Stock = s;}
    void setArtPU(float p) {_PrecioUnitario = p;}
    void setArtEST(bool e) {_Estado = e;}
    void setArtCOD(const char *c) {strcpy(_Codigo, c);}
    void setArtDESC(const char *d) {strcpy(_Descripcion, d);}
    void Cargar();
    void Mostrar();
    void CargarVector(Articulo V[], const int Tam);
    void MostrarVector(Articulo V[], const int Tam);
};

void Articulo::CargarVector(Articulo V[], const int Tam){

        for(int x = 0 ; x < Tam ; x ++){
            cout << "Articulo Nro " << Tam + 1 << ": " << endl << endl;
            V[x].Cargar();
            cout << endl << endl;
        }
    system("cls");
}

void Articulo::MostrarVector(Articulo V[], const int Tam){

    for(int x = 0 ; x < Tam ; x ++){
            cout << "Articulo Nro " << Tam + 1 << ": " << endl << endl;
            V[x].Mostrar();
            system("cls");
        }
}



//MOSTRAR Y CARGAR ELEMENTOS DE UN ARTICULO

void Articulo::Cargar(){
    cout << "introduzca el codigo de articulo: " << endl << endl;
    fflush(stdin);
    cin.getline( _Codigo, 5);
    cout << endl;
    cout << "introduzca su descripcion: " << endl << endl;
    fflush(stdin);
    cin.getline(_Descripcion, 30);
    cout << endl;
    cout << "introduzca su precio unitario: " << endl << endl;
    cin >> _PrecioUnitario;
    cout << endl;
    cout << "¿esta disponible este articulo o no? ('1' para SI, '0' para NO): " << endl << endl;
    cin >> _Estado;
    if(_Estado){
        cout << "introduzca la cantidad de "<< _Descripcion << " que hay disponibles: " << endl << endl;
        cin >> _Stock;
    }
    cout << endl << endl;
}

void Articulo::Mostrar(){
    if(getArtEST() == true){
        system("cls");
        cout << "DESCRIPCION: "<< getArtDESC() << endl;
        cout << endl;
        cout << "CODIGO: " << getArtCOD() << endl;
        cout << endl;
        cout << "PRECIO: $"<< getArtPU() << endl;
        cout << endl;
        cout << "UNIDADES DISPONIBLES: "<< getArtSTK()<< endl;

    }else{
        cout << "El articulo " << getArtDESC() << " no se encuentra disponible" << endl;


    }
}


int main(){
    const int tam = 3;
    Articulo obj[tam];
    int opcion;


    /*while (true){
        system("cls");
        cout << "MENU PRODUCTOS" << endl;
        cout << "----------------" << endl;
        cout << "1) NUEVO PRODUCTO" << endl;
        cout << "2) LISTAR PRODUCTOS" << endl;
        cout << "3) LISTAR PRODUCTO x ID" << endl;
        cout << "---------------------------" << endl;
        cout << "0) SALIR" << endl;

        cin >> opcion;

        switch(opcion){
            case 1:
                {
                    for(int x = 0; x < tam ; x ++){
                        obj[x].Cargar();
                        cout << endl;
                        system("cls");
                    }
                }
                break;
            case 2:
                {
                   obj.MostrarVector(obj, tam);
                }
                break;
            case 3:
                {

                }
                break;
            default:
                cout << "OPCION INCORRECTA" << endl;
            break;
        }

        system("pause");

    }*/
      for(int x = 0; x < tam ; x ++){
        obj[x].Cargar();
        cout << endl;
        system("cls");
    }

      for(int x = 0; x < tam ; x ++){
        obj[x].Mostrar();
        cout << endl;
        system("pause");
    }

    return 0;
}
