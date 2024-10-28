using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VentaNegocio
    {
        private AccesoDatos VentaDatos = new AccesoDatos();

        public void CargarVenta(Venta venta)
        {
            try
            {
                VentaDatos.OpenTransaction
                (ComandoDeTransaccion => 
                {
                    VentaDatos.SetQuery("INSERT INTO Ventas (IDArticulo, CantidadVendida, VentaTotal, FechaVenta, IDVentaGlobal, FormaDePago) VALUES (@IDArticulo, @CantidadVendida, @VentaTotal, @FechaVenta, @IDVentaGlobal, @FormaDePago)");
                    foreach (var articulo in venta.ArticulosVendidos)
                    {
                        VentaDatos.ClearParameters();
                        VentaDatos.SetParameters("@IDArticulo", articulo.CodigoArticulo);
                        VentaDatos.SetParameters("@CantidadVendida", articulo.CantidadDeArticulos);
                        VentaDatos.SetParameters("@VentaTotal", articulo.PrecioCompra);
                        VentaDatos.SetParameters("@FechaVenta", venta.FechaVenta);
                        VentaDatos.SetParameters("@IDVentaGlobal", venta.IDGlobalVentas);
                        VentaDatos.SetParameters("@FormaDePago", venta.MetodoDePago ? 1 : 2);
                        VentaDatos.OpenNonQuery();
                    }
                });
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                VentaDatos.CloseRead();
            }
        }

        public int LastID()
        {
            int ID = -1;

            try
            {
                VentaDatos.SetQuery("SELECT ISNULL (MAX(IDVentaGlobal),0) FROM Ventas");
                VentaDatos.OpenRead();

                if(VentaDatos.LectorPublico.Read())
                {
                    ID = VentaDatos.LectorPublico.GetInt32(0) + 1;
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                VentaDatos.CloseRead();
            }
            return ID;
        }
    }
}
