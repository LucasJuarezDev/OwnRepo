#include <iostream>

using namespace std;

class Contador{
    private:
        int valor;
        int valorInicial;
    public:
        void setValor(int v);
        void setValorInicial(int v);
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

void Contador::setValorInicial(int v){
    valorInicial = v;
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
    valor=valorInicial;
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

int main(){
    return 0;
}
