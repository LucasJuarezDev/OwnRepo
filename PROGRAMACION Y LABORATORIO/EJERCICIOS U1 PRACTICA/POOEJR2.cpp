#include <iostream>
using namespace std;

class Articulo{
private:
    int _Vcod [10];
    int _cod;
    char _Descripcion[10];
     char _des;
    double _VPU[10];
    double _pu;
    int _VStock[10];
    int _stock;

public:
    Articulo();
    void Cargar();
    void Mostrar();
};

Articulo :: Articulo (){
    _Vcod[10] = {};
    _cod = 0;
    _Descripcion[10] = {};
    _des = ' ';
    _VPU[10] = {};
    _pu = 0;
    _VStock[10] = {};
    _stock = 0;
}

void Articulo::Cargar(){
    for(int x = 0 ; x < 10 ; x ++){
        int i;

        cout <<  "ARTICULO #" << x + 1 << endl << endl;

        cout << "ingrese el codigo: ";
        cin >> _cod;
        _Vcod[x] = _cod;
        cout << "ingrese el nombre: ";
        while(_des != 10 || i < 10){
        cin >> _des;
        _Descripcion[i] = _des;
        i ++;
        }
        cout << "ingrese el precio unitario del articulo: ";
        cin >> _pu;
        _VPU[x] = _pu;
        cout << "ingrese su stock: ";
        cin >> _stock;
        _VStock[x] = _stock;
        cout << endl;

    }
}

 void Articulo :: Mostrar(){
        for(int x = 0 ; x < 10 ; x ++){
                cout << endl;
                cout << _Vcod[x] << endl;
                cout << endl;
                cout << _Descripcion[x] << endl;
                cout << endl;
                cout << _VPU[x] << endl;
                cout << endl;
                cout << _VStock[x] << endl;

        }
    }

int main(){
    Articulo Art1;

    Art1.Cargar();
    Art1.Mostrar();
    return 0;
}
