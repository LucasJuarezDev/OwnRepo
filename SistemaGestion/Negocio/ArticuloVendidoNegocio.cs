using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloVendidoNegocio
    {

        ////////////////////////////////////////  METODOS VARIOS (AJENOS A LA DB)  ///////////////////////////////////////////

        private AccesoDatos DataRespaldo = new AccesoDatos();
        public List<ArticuloVendido> CopiarArticulos(List<Articulo> Articulos)
        {
            List<ArticuloVendido> ListaVendidos = new List<ArticuloVendido>();
            foreach (Articulo item in Articulos)
            {
                ListaVendidos.Add(new ArticuloVendido
                {
                    CodArt = item.CodigoArticulo,
                    Marca = item.Marcas.Descripcion,
                    Nombre = item.Articulos,
                    Descripcion = item.TipoDeArticulo,
                    Stock = item.CantidadDeArticulos,
                    StockMinimo = item.CantidadMinima,
                    PU = item.PrecioVenta,
                });

            }
            return ListaVendidos;
        }

        public bool SearchArticuloDuplicado(int cod)
        {
            try
            {
                DataRespaldo.SetQuery("select ID_CodigoArt from ArticuloVendido01");
                DataRespaldo.OpenRead();
                while (DataRespaldo.LectorPublico.Read())
                {
                    int CodExistente = (int)DataRespaldo.LectorPublico["ID_CodigoArt"];
                    if (CodExistente == cod)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
        }

        public void RestarStockLocal(int cod, int cant, List<ArticuloVendido> ListaVendidos)
        {
            ArticuloVendido obj = ListaVendidos.FirstOrDefault(x => x.CodArt == cod);
            if (obj != null && obj.Stock >= cant)
            {
                obj.CodArt = cod;
                obj.Stock -= cant;
                ModificarStock(obj);
            }
        }

        public void CasteoDeObjeto(Articulo Seleccionado)
        {
            try
            {
                ArticuloVendido art = new ArticuloVendido
                {
                    CodArt = Seleccionado.CodigoArticulo,
                    Marca = Seleccionado.Marcas.Descripcion,
                    Nombre = Seleccionado.Articulos,
                    Descripcion = Seleccionado.TipoDeArticulo,
                    Stock = Seleccionado.CantidadDeArticulos,
                    PU = Seleccionado.PrecioVenta,
                };
                AddArticuloInBD(art);
            }
            catch (Exception)
            {

                throw;
            }

        }

        ////////////////////////////////////////  INTERACTUAN CON LA DB  ///////////////////////////////////////////

        private void AddArticuloInBD(ArticuloVendido Seleccionado)
        {
            try
            {
                DataRespaldo.SetQuery("insert into ArticuloVendido01 (ID_CodigoArt, Marca, Articulo, Descripcion, Stock, PU) values (@ID_CodigoArt, @Marca, @Articulo, @Descripcion, @Stock, @PU)");
                DataRespaldo.SetParameters("@ID_CodigoAr", Seleccionado.CodArt);
                DataRespaldo.SetParameters("@Marca", Seleccionado.Marca);
                DataRespaldo.SetParameters("@Articulo", Seleccionado.Nombre);
                DataRespaldo.SetParameters("@Descripcion", Seleccionado.Descripcion);
                DataRespaldo.SetParameters("@Stoc", Seleccionado.Stock);
                DataRespaldo.SetParameters("@PU", Seleccionado.PU);
                DataRespaldo.OpenNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
        }

        private void ModificarStock(ArticuloVendido articulo)
        {
            try
            {
                DataRespaldo.SetQuery("UPDATE ArticuloVendido01 SET Stock = @Stock where ID_CodigoArt = @ID_CodigoArt");
                DataRespaldo.SetParameters("@Stock", articulo.Stock);
                DataRespaldo.SetParameters("@ID_CodigoArt", articulo.CodArt);
                DataRespaldo.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
        }

        public int StockDB(int Codigo, int Cantidad)
        {
            int StockActual = 0, StockActualizado;
            try
            {
                StockActual = ReturnStock(Codigo);
                StockActualizado = (StockActual - Cantidad) + 1;
                DataRespaldo.ClearParameters();
                DataRespaldo.SetQuery("update ArticuloVendido01 set Stock = @Stock where ID_CodigoArt = @ID_CodigoArt");
                DataRespaldo.SetParameters("@Stock", StockActualizado);
                DataRespaldo.SetParameters("@ID_CodigoArt", Codigo);
                DataRespaldo.OpenNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
            return StockActualizado;
        }

        private int ReturnStock(int Codigo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            int StockActual = 0;
            try
            {
                accesoDatos.SetQuery("select Stock from ArticuloVendido01 where ID_CodigoArt = @ID_CodigoArt");
                accesoDatos.SetParameters("@ID_CodigoArt", Codigo);
                accesoDatos.OpenRead();
                if (accesoDatos.LectorPublico.Read())
                {
                    StockActual = (int)accesoDatos.LectorPublico["Stock"];
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoDatos.CloseRead(); 
            }
            return StockActual;
        }


        public List<ArticuloVendido> ListarArticulosVendidos()
        {
            List<ArticuloVendido> ListarVendidosDB = new List<ArticuloVendido>();
            try
            {
                DataRespaldo.SetQuery("select ID_CodigoArt, Stock from ArticuloVendido01");
                DataRespaldo.OpenRead();

                while (DataRespaldo.LectorPublico.Read())
                {
                    ArticuloVendido articuloVendido = new ArticuloVendido
                    {
                        CodArt = (int)DataRespaldo.LectorPublico["ID_CodigoArt"],
                        Stock = (int)DataRespaldo.LectorPublico["Stock"],
                    };
                    ListarVendidosDB.Add(articuloVendido);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
            return ListarVendidosDB;
        }

        public void ClearTable()
        {
            try
            {
                DataRespaldo.SetQuery("delete ArticuloVendido01");
                DataRespaldo.OpenNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataRespaldo.CloseRead(); 
            }
        }

        public void ClearTable(int Cod)
        {
            try
            {
                DataRespaldo.ClearParameters();
                DataRespaldo.SetQuery("delete ArticuloVendido01 where ID_CodigoArt = @ID_CodigoArt");
                DataRespaldo.SetParameters("@ID_CodigoArt", Cod);
                DataRespaldo.OpenNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataRespaldo.CloseRead();
            }
        }
    }
}
