#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

class Dado{
private:
    int Valor;
public:
    Dado(){ Lanzar(); };
    void Lanzar();
    int getValor(){return Valor;};
    bool esMaximo();
    bool esMinimo();
    void mostrarValor() {cout<< "EL VALOR ES: "<<getValor()<<endl;}
};

void Dado::Lanzar(){
    Valor = 1 + rand() % 6;
}

bool Dado::esMaximo(){
    if(Valor == 6){
        cout <<  "ES EL VALOR MAXIMO!!" << endl;
        return true;
    }else
    {
        return false;
    }
}

bool Dado::esMinimo(){
    if(Valor == 1){
        cout <<  "ES EL VALOR MINIMO!!" << endl;
        return true;
    }else
    {
        return false;
    }
}

int main()
{
    srand(time(0));
    Dado obj;
    obj.Lanzar();
    obj.mostrarValor();
    obj.esMaximo();
    obj.esMinimo();
    return 0;
}
