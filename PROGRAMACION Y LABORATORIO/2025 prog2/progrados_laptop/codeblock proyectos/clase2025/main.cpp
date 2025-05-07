#include <iostream>

using namespace std;

class Contador{
    private:
        int valor;
    public:
        void setValor(int v);
        int getValor();
        void incrementar();
        void incrementar(int v);
        void decrementar();
        void decrementar(int v);
        void reiniciar();
        void mostrar();
};

void Contador::setValor(int v){
    valor = v;
}

int Contador::getValor(){
    return valor;
}

void Contador::incrementar(){
    valor++;
}

void Contador::incrementar(int v){
    valor += v;
}

void Contador::reiniciar(){
    valor=0;
}

void Contador::decrementar(){
    valor--;
}

void Contador::decrementar(int v){
    valor -= v;
}

void Contador::mostrar(){
    cout<<"CONTADOR: "<<valor<<endl;
}

int main()
{
    Contador cont;
    cont.mostrar();
    cont.setValor(10);
    cont.reiniciar();
    cont.mostrar();
    return 0;
}
