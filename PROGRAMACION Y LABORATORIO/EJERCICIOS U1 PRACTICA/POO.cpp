#include <iostream>
#include <string.h> //AÑADE LA FUNCION STRCPY O STRCMP
using namespace std;


class Articulo{
private:
    string _Codigo;
    string _Descripcion;
    float _PrecioUnitario;
    int _Stock;
    bool _Estado;
    const int Tam = 3;

    /*  COMENTARIOS DE CODIGO

        CONST CHAR * EN EL CONSTRUCTOR == EN ''C++ MODERNO'' NO PERMITE LA CONVERSION DE UNA CADENA DE CARACTERES A UN PUNTERO DE CARACTERES

    */

public:
    Articulo(string c = "", string d = "", float p = 0, int s = 0, bool e = false){
        _Codigo = c;
        _Descripcion = d;
        _PrecioUnitario = p;
        _Stock = s;
        _Estado = e;
    }
    float getArtPU(){return _PrecioUnitario;}
    int getArtSTK() {return _Stock;}
    bool getArtEST(){return _Estado;}
    string getArtCOD(){return _Codigo;}
    string getArtDESC(){return _Descripcion;}
    void setArtSTK(int s) {_Stock = s;}
    void setArtPU(float p) {_PrecioUnitario = p;}
    void setArtEST(bool e) {_Estado = e;}
    void setArtCOD(string c) {_Codigo = c;}
    void setArtDESC(string d) {_Descripcion = d;}
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
    cin >> _Codigo;
    cout << endl;
    cout << "introduzca su descripcion: " << endl << endl;
    cin >> _Descripcion;
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
        system("cls"); //LIMPIA LA ACCION ANTERIOR
        cout << "DESCRIPCION: "<< getArtDESC() << endl;
        cout << endl;
        cout << "CODIGO: " << getArtCOD() << endl;
        cout << endl;
        cout << "PRECIO: $"<< getArtPU() << endl;
        cout << endl;
        cout << "UNIDADES DISPONIBLES: "<< getArtSTK()<< endl;
        system("pause"); //GUARDA LA ULTIMA ACCION Y PAUSA EN ESE MOMENTO
    }else{
        cout << "El articulo " << getArtDESC() << " no se encuentra disponible" << endl;
        system("pause");

    }
}


int main(){
    Articulo obj, v[3];
    const int T = 3;

    obj.CargarVector(v, T);
    obj.Mostrar();
    return 0;
}
