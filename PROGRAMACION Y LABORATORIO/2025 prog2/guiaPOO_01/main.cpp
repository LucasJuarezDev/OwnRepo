#include <iostream>

using namespace std;

class Rectangulo{
private:
    int Base;
    int Altura;
public:
    void setbase(int base);
    void setAltura(int altura);
    int getBase();
    int getAltura();
    void calcularArea();
    void calcularPerimetro();
};

void Rectangulo::setbase(int base){
    Base = base;
}

void Rectangulo::setAltura(int altura){
    Altura = altura;
}

int Rectangulo::getAltura(){
    return Altura;
}

int Rectangulo::getBase(){
    return Base;
}

void Rectangulo::calcularArea(){
    int area;
    cout << "INGRESE LA BASE: ";
    cin >> Base;
    cout << endl;
    cout << "INGRESE LA ALTURA: ";
    cin >> Altura;
    cout << endl;
    area = Base * Altura;
    cout << "EL AREA ES : " << area << endl;
}

int main()
{
    Rectangulo obj;

    obj.calcularArea();
    return 0;
}
