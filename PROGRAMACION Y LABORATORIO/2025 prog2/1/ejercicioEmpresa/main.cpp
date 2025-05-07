#include <iostream>

using namespace std;

int main()
{
    int NumeroEmpleado = 0, Mes = 0, Dia = 0, HorasTrabajadas = 0;
    int manual [12][31] = {};
    int vecEmp [29] = {};

    /*
    for(int x = 0 ; x < 12 ; x++)
    {
        cout << "MES " << x + 1 << endl;
        cout << "--------------------------" << endl;
        for(int j = 0 ; j < 31 ; j++)
        {

            cout << "DIA: " << j + 1 << endl;
        }
        cout << "--------------------------" << endl;
    }
    */
    cout << "Ingrese el num de empleado: ";
    cin >> NumeroEmpleado;
    cout << endl;

    while(NumeroEmpleado != 0)
    {
        cout << "Ingrese el Mes actual: ";
        cin >> Mes;
        cout << endl;
        cout << "Ingrese el Dia de hoy: ";
        cin >> Dia;
        cout << endl;
        cout << "Ingrese las Horas trabajadas en esta jornada: ";
        cin >> HorasTrabajadas;
        cout << endl;
        cout << "-------------------------------------" << endl << endl;

        manual[Mes - 1][Dia - 1] += 1;
        vecEmp [NumeroEmpleado - 1] += HorasTrabajadas;

        cout << "Ingrese el num de empleado: ";
        cin >> NumeroEmpleado;
        cout << endl;
    }

    for(int x = 0 ; x < 12 ; x++)
    {
        cout << "MES " << x + 1 << endl;
        cout << "--------------------------" << endl;
        for(int j = 0 ; j < 31 ; j++)
        {
            if(manual[x][j] >= 1)
            {
            cout << "DIA: " << j + 1 << " HUBO LA CANTIDAD DE "<< manual[x][j] << " EMPLEADOS PRESENTES" <<endl; // PUNTO 1
            }else
            {
            cout << "EL DIA: " << j + 1 << " NO TUVO EMPLEADOS PRESENTES" << endl; // PUNTO 2
            }
        }
        cout << "--------------------------" << endl << endl;
    }

    for(int x = 0 ; x < 29 ; x++) // PUNTO 3
    {
        if(vecEmp[x] != 0)
        {
            cout << "EMPLEADO Nro: " << x + 1 << endl;
            cout << "--------------------------" << endl;
            cout << "TRABAJO LA CANTIDAD DE " << vecEmp [x] << "hrs" << endl;
            cout << "--------------------------" << endl;
        }
    }

    return 0;
}
