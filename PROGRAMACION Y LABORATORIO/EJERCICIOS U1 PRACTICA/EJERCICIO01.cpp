#include <iostream>
using namespace std;

//PUNTO 1
//Hacer una función que reciba como parámetros un vector de enteros y un
//número entero que indica la cantidad de componentes del vector, y que devuelva
//el valor mínimo contenido en ese vector.

    void FUNCION_P1(int VINT[], int Contador_enteros);

int main(){
//    int VINT[10]{};
//    int Contador_enteros;

    int entera, *apunto; // declaración de una variable entera, y un puntero a entero
    entera=2; // se asigna 2 a la variable entera
    apunto=&entera; //se asigna la dirección de entera a apunto
    cout<<*apunto << endl;// se imprime el contenido de la dirección a la que apunta el puntero
    cout<<apunto << endl;// se imprime lo que contiene apunto
    cout<<&entera << endl;// se imprime la dirección de entera

    return 0;
}
