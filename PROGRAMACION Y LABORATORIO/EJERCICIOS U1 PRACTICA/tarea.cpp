#include <iostream>
using namespace std;

void cargar(int *vec, const int tam);
void ceros(int *vec, const int tam);
void mostrar(int *vec, const int tam);



int main(){
    const int tam = 5;
    int vec[tam];

    ceros(vec, tam);
    cargar(vec, tam);
    mostrar(vec, tam);
}

void ceros(int *vec, const int tam){

    for(int x = 0 ; x < tam ; x ++){
        vec[x] += 0;
    }
}

void cargar(int *vec, const int tam){

    for(int x = 0 ; x < tam ; x ++){
        cin >> vec[x];
    }
}

void mostrar(int *vec, const int tam){

    for(int x = 0 ; x < tam ; x ++){
        cout << vec[x] << endl;
    }
}
