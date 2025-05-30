#include "Venta.h"
#include <cstring>

// Constructor
Venta::Venta(){
    CodigoPrenda =0;
    strcpy(NombrePrenda,"");
    strcpy(Modelo,"");
    strcpy(Talle,"");
    strcpy(Color,"");
    Cantidad=0;
    FechaDeVenta=Fecha();
}

Venta::Venta(int _CodigoPrenda, string _NombrePrenda, string _Modelo, string _Talle, string _Color, int _Cantidad, Fecha _FechaDeVenta)
{
    setCodigoPrenda(_CodigoPrenda);
    setNombrePrenda(_NombrePrenda);
    setModelo(_Modelo);
    setTalle(_Talle);
    setColor(_Color);
    setCantidad(_Cantidad);
    setVentaFecha(_FechaDeVenta);
}

//getters
int Venta::getCodigo() {
    return CodigoPrenda;
}

string Venta::getNombrePrenda() {
    return NombrePrenda;
}

string Venta::getModelo() {
    return Modelo;
}

string Venta::getTalle() {
    return Talle;
}

string Venta::getColor() {
    return Color;
}


int Venta::getCantidad() {
    return Cantidad;
}

Fecha Venta::getVentaFecha() {
    return FechaDeVenta;
}

//setters
void Venta::setCodigoPrenda(int _CodigoPrenda) {
    CodigoPrenda = _CodigoPrenda;
}

void Venta::setNombrePrenda(string _NombrePrenda) {
    strcpy(NombrePrenda,_NombrePrenda.c_str());
}

void Venta::setModelo(string _Modelo) {
    strcpy(Modelo,_Modelo.c_str());
}

void Venta::setTalle(string _Talle) {
     strcpy(Talle,_Talle.c_str());
}

void Venta::setColor(string _Color) {
    strcpy(Color,_Color.c_str());
}


void Venta::setCantidad(int _Cantidad) {
    Cantidad = _Cantidad;
}

void Venta::setVentaFecha(Fecha _FechaDeVenta) {
    FechaDeVenta = _FechaDeVenta;
}
