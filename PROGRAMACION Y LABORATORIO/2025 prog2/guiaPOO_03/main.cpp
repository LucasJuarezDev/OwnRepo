#include <iostream>

using namespace std;

class CuentaBancaria{
private:
    int NumberAccout;
    float MoneyAccount;
public:
    CuentaBancaria(int _number, float _money);
    void setNumberAccount(int _number) {NumberAccout = _number;};
    bool setMoneyAccount(int _money);
    float getMoneyAccount(){return MoneyAccount;};
    void Depositar(float monto = 0);
    void Retirar(float monto);
    void getSaldo();
};

void CuentaBancaria::Retirar(float monto){
    float aux = 0, total = 0;
    cout << "ELIJA EL MONTO A RETIRAR: " << endl;
    cin >> monto;
    aux = getMoneyAccount();
    total = aux - monto;
    setMoneyAccount(total);
}

void CuentaBancaria::getSaldo(){
    cout << endl;
    cout << "-----------------------------------------------" << endl;
    cout << "BIENVENIDO USUARIO -- " << NumberAccout << " --" << endl;
    cout << "SU SALDO BANCARIO ES: " << MoneyAccount << endl;
    cout << "-----------------------------------------------" << endl;
}

bool CuentaBancaria::setMoneyAccount(int _money){
    if(_money >= 1){
        MoneyAccount += _money;
        return true;
    }else
    {
        cout << "ERROR"<<endl;
        return false;
    }
}

CuentaBancaria::CuentaBancaria(int _number, float _money){
    setNumberAccount(_number);
    setMoneyAccount(_money);
}

void CuentaBancaria::Depositar(float monto){
    cout << "INGRESE EL DINERO QUE QUIERE DEPOSITAR: ";
    cin>> monto;
    if(!setMoneyAccount(monto)){
        return;
    }
    cout << endl;
}



int main()
{
    CuentaBancaria banc(12, 0);

    banc.Depositar();
    banc.getSaldo();
    banc.Depositar();
    banc.Depositar();
    banc.getSaldo();
    return 0;
}
