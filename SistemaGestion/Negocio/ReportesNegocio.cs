using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class ReportesNegocio
    {
		private AccesoDatos ReportesDB = new AccesoDatos();

        public void AscdDescDGV(List<Venta> Lista, DataGridView DGV, ComboBox CB, bool Flag = false)
        {
            string OrdenSeleccionado = CB.SelectedItem.ToString();
            try
            {
                if(Flag)
                {
                    if (OrdenSeleccionado == "Ascendente")
                    {
                        var ListaOrdenada = Lista.Select(v => new
                        {
                            IDVentaGlobal = v.IDGlobalVentas,
                            IDArticulo = v.VentaArticulo.CodigoArticulo,
                            Articulo = v.VentaArticulo.Articulos,
                            Descripcion = v.VentaArticulo.TipoDeArticulo,
                            Marca = v.VentaArticulo.Marcas.Descripcion,
                            CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                            VentaTotal = v.VentaArticulo.PrecioCompra,
                            Pago = v.DescripcionDePago,
                            Fecha = v.FechaReporte
                        }).OrderBy(v => v.IDVentaGlobal).ToList();

                        DGV.DataSource = ListaOrdenada;

                    }
                    else if (OrdenSeleccionado == "Descendente")
                    {
                        var ListaOrdenada = Lista.Select(v => new
                        {
                            IDVentaGlobal = v.IDGlobalVentas,
                            IDArticulo = v.VentaArticulo.CodigoArticulo,
                            Articulo = v.VentaArticulo.Articulos,
                            Descripcion = v.VentaArticulo.TipoDeArticulo,
                            Marca = v.VentaArticulo.Marcas.Descripcion,
                            CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                            VentaTotal = v.VentaArticulo.PrecioCompra,
                            Pago = v.DescripcionDePago,
                            Fecha = v.FechaReporte
                        }).OrderByDescending(v => v.IDVentaGlobal).ToList();

                        DGV.DataSource = ListaOrdenada;
                    }

                    else
                    {
                        CB.Enabled = false;
                    }

                }
                else
                {
                    if (OrdenSeleccionado == "Ascendente")
                    {
                        var ListaOrdenada = Lista.Select(v => new
                        {
                            IDVentaGlobal = v.IDGlobalVentas,
                            IDArticulo = v.VentaArticulo.CodigoArticulo,
                            Articulo = v.VentaArticulo.Articulos,
                            Descripcion = v.VentaArticulo.TipoDeArticulo,
                            Marca = v.VentaArticulo.Marcas.Descripcion,
                            CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                            VentaTotal = v.VentaArticulo.PrecioCompra,
                            Pago = v.DescripcionDePago
                        }).OrderBy(v => v.IDVentaGlobal).ToList();

                        DGV.DataSource = ListaOrdenada;

                    }
                    else if (OrdenSeleccionado == "Descendente")
                    {
                        var ListaOrdenada = Lista.Select(v => new
                        {
                            IDVentaGlobal = v.IDGlobalVentas,
                            IDArticulo = v.VentaArticulo.CodigoArticulo,
                            Articulo = v.VentaArticulo.Articulos,
                            Descripcion = v.VentaArticulo.TipoDeArticulo,
                            Marca = v.VentaArticulo.Marcas.Descripcion,
                            CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                            VentaTotal = v.VentaArticulo.PrecioCompra,
                            Pago = v.DescripcionDePago
                        }).OrderByDescending(v => v.IDVentaGlobal).ToList();

                        DGV.DataSource = ListaOrdenada;
                    }

                    else
                    {
                        CB.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void OrdenarPorPagos(List<Venta> Lista, DataGridView DGV, ComboBox CB, bool Flag = false)
        {
            string OpcionSeleccionada = CB.SelectedItem.ToString();
            try
            {
                if(Flag)
                {
                    var ListaPorPago = Lista;

                    if (OpcionSeleccionada == "Efectivo")
                    {
                        ListaPorPago = ListaPorPago.Where(v => v.DescripcionDePago == "EFECTIVO").ToList();
                    }
                    else if (OpcionSeleccionada == "Transferencia")
                    {
                        ListaPorPago = ListaPorPago.Where(v => v.DescripcionDePago == "TRANSFERENCIA").ToList();
                    }

                    var datosParaMostrar = ListaPorPago.Select(v => new
                    {
                        IDVentaGlobal = v.IDGlobalVentas,
                        IDArticulo = v.VentaArticulo.CodigoArticulo,
                        Articulo = v.VentaArticulo.Articulos,
                        Descripcion = v.VentaArticulo.TipoDeArticulo,
                        Marca = v.VentaArticulo.Marcas.Descripcion,
                        CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                        VentaTotal = v.VentaArticulo.PrecioCompra,
                        Pago = v.DescripcionDePago,
                        Fecha = v.FechaReporte
                    }).OrderByDescending(v => v.IDVentaGlobal).ToList();

                    DGV.DataSource = datosParaMostrar;
                }
                else
                {
                    var ListaPorPago = Lista;

                    if (OpcionSeleccionada == "Efectivo")
                    {
                        ListaPorPago = ListaPorPago.Where(v => v.DescripcionDePago == "EFECTIVO").ToList();
                    }
                    else if (OpcionSeleccionada == "Transferencia")
                    {
                        ListaPorPago = ListaPorPago.Where(v => v.DescripcionDePago == "TRANSFERENCIA").ToList();
                    }

                    var datosParaMostrar = ListaPorPago.Select(v => new
                    {
                        IDVentaGlobal = v.IDGlobalVentas,
                        IDArticulo = v.VentaArticulo.CodigoArticulo,
                        Articulo = v.VentaArticulo.Articulos,
                        Descripcion = v.VentaArticulo.TipoDeArticulo,
                        Marca = v.VentaArticulo.Marcas.Descripcion,
                        CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                        VentaTotal = v.VentaArticulo.PrecioCompra,
                        Pago = v.DescripcionDePago
                    }).OrderByDescending(v => v.IDVentaGlobal).ToList();

                    DGV.DataSource = datosParaMostrar;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Venta> ListarVentasDelDia()
        {
			List<Venta> ListaVentasDia = new List<Venta>();
			try
			{
                ReportesDB.SetQuery("select VEN.IDVentaGlobal, MET.Descripcion AS [Forma De Pago], VEN.IDArticulo, ART.Articulo, ART.Tipo, MAR.Descripcion as Marca, VEN.CantidadVendida as [Art.Vendidos], VEN.VentaTotal as [En esta Venta] \r\nfrom Ventas VEN, Articulos ART, Marcas MAR, MetodoDePago MET\r\nwhere CAST(FechaVenta AS date) = CAST(GETDATE() AS date) and ART.Cod_Articulo = VEN.IDArticulo and ART.Cod_Marca = MAR.ID_Marca and MET.IDMetodoPago = VEN.FormaDePago");
                ReportesDB.OpenRead();
				while(ReportesDB.LectorPublico.Read())
				{
					Venta aux = new Venta();
					aux.IDGlobalVentas = (int)ReportesDB.LectorPublico["IDVentaGlobal"];
					aux.DescripcionDePago = (string)ReportesDB.LectorPublico["Forma De Pago"];
					aux.VentaArticulo = new Articulo();
					aux.VentaArticulo.CodigoArticulo = (int)ReportesDB.LectorPublico["IDArticulo"];
					aux.VentaArticulo.Articulos = (string)ReportesDB.LectorPublico["Articulo"];
					aux.VentaArticulo.TipoDeArticulo = (string)ReportesDB.LectorPublico["Tipo"];
					aux.VentaArticulo.Marcas = new Marca();
					aux.VentaArticulo.Marcas.Descripcion = (string)ReportesDB.LectorPublico["Marca"];
					aux.VentaArticulo.CantidadDeArticulos = (int)ReportesDB.LectorPublico["Art.Vendidos"];
					aux.VentaArticulo.PrecioCompra = (float)ReportesDB.LectorPublico.GetDouble(7);
					
					ListaVentasDia.Add(aux);
                }
				return ListaVentasDia;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				ReportesDB.CloseRead();
			}
        }

		public List<Venta> ListarVentasMes(DateTime DTP1, DateTime DTP2)
		{
			List<Venta>ListaVentasMes = new List<Venta>();
			try
			{
				ReportesDB.ClearParameters();
				ReportesDB.SetQuery("select VEN.IDVentaGlobal, MET.Descripcion AS [Forma De Pago], VEN.IDArticulo, ART.Articulo, ART.Tipo, MAR.Descripcion as Marca, VEN.CantidadVendida as [Art.Vendidos], VEN.VentaTotal as [En esta Venta], VEN.FechaVenta AS [Fecha de Venta] FROM Ventas VEN JOIN Articulos ART ON ART.Cod_Articulo = VEN.IDArticulo JOIN Marcas MAR ON ART.Cod_Marca = MAR.ID_Marca JOIN MetodoDePago MET ON MET.IDMetodoPago = VEN.FormaDePago WHERE CAST(FechaVenta AS date) BETWEEN @FechaInicio AND @FechaFin");
				ReportesDB.SetParameters("@FechaInicio", DTP1);
                ReportesDB.SetParameters("@FechaFin", DTP2);
				ReportesDB.OpenRead();

				while(ReportesDB.LectorPublico.Read())
				{
                    Venta aux = new Venta();
                    aux.IDGlobalVentas = (int)ReportesDB.LectorPublico["IDVentaGlobal"];
                    aux.DescripcionDePago = (string)ReportesDB.LectorPublico["Forma De Pago"];
                    aux.VentaArticulo = new Articulo();
                    aux.VentaArticulo.CodigoArticulo = (int)ReportesDB.LectorPublico["IDArticulo"];
                    aux.VentaArticulo.Articulos = (string)ReportesDB.LectorPublico["Articulo"];
                    aux.VentaArticulo.TipoDeArticulo = (string)ReportesDB.LectorPublico["Tipo"];
                    aux.VentaArticulo.Marcas = new Marca();
                    aux.VentaArticulo.Marcas.Descripcion = (string)ReportesDB.LectorPublico["Marca"];
                    aux.VentaArticulo.CantidadDeArticulos = (int)ReportesDB.LectorPublico["Art.Vendidos"];
                    aux.VentaArticulo.PrecioCompra = (float)ReportesDB.LectorPublico.GetDouble(7);
					aux.FechaReporte = (DateTime)ReportesDB.LectorPublico["Fecha de Venta"];

					ListaVentasMes.Add(aux);
                }
                return ListaVentasMes;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				ReportesDB.CloseRead();
			}
		}
    }
}
