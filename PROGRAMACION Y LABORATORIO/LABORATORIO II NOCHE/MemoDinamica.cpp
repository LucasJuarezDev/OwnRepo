#include <iostream>
using namespace std;
#include <cstdlib>

int main(){
    int TAM = 0;
    int *v;

    cout << "ingrese el un numero para determinar el tamaño de memoria: " << endl;
    cin >> TAM;

    v = new int[TAM];
    if(v == nullptr){
        cout << "no hay memoria disponible" << endl;
        system("pause");
    }else{
        for(int x = 0 ; x < TAM ; x ++){

        }

    }

    return 0;
}
