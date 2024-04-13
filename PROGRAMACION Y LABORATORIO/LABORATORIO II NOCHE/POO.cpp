#include <iostream>
using namespace std;

class Temporizador{
private:
    int _hora;
    int _minutos;
    int _segundos;

public:
    Temporizador(int hora, int minutos, int segundos);
    Temporizador();
    int getHora(){return _hora;}
    int getMinuto(){return _minutos;}
    int getSegundo(){return _segundos;}
    void Tic();
    void Tac();
    void mostrar();
    void Comparar();
};
    Temporizador :: Temporizador(){ ///constructor sin parametros
        _hora = 0;
        _minutos = 0;
        _segundos = 0;
    }

    Temporizador::Temporizador(int hora, int minutos, int segundos){   ///constructor
        _hora = hora;
        _minutos = minutos;
        _segundos = segundos;
    }

    void Temporizador :: Tac(){
         _segundos ++;
        if (_segundos == 60){
            _segundos = 0;
            _minutos ++;
            if(_minutos == 60){
                _minutos = 0;
                _hora ++;
            }
        }
    }

    void Temporizador::Tic(){
        _segundos ++;
        if (_segundos == 60){
            _segundos = 0;
            _minutos ++;
            if(_minutos == 60){
                _minutos = 0;
                _hora ++;
            }
        }

    }

    void Temporizador :: Comparar(){

    }

    void Temporizador::mostrar(){
        cout << (_hora <= 9 ? "0" : "") << _hora << ": ";
        cout << (_minutos <= 9 ? "0" : "") << _minutos << ": ";
        cout << (_segundos <= 9 ? "0" : "") << _segundos << endl;
        //cout << "Hora: " << _hora << "     "  << "Minuto: " << _minutos  << "     "  << "Segundo: " << _segundos << endl;

    }



int main(){
    Temporizador temp1(0,0,0);
    Temporizador temp2 ;

    for(int x = 0 ; x < 7500 ; x ++){

    temp1.mostrar();
    temp1.Tic();

    }

    /*for(int x = 0 ; x < 9709 ; x ++){
    temp2.mostrar();
        temp2.Tac();
    }*/

    cout << endl;

    return 0;
}
