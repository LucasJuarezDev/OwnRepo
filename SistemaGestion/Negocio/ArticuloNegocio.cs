using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Data;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos DataBase = new AccesoDatos();

        /////////////////////       LISTADOS Y DEMAS     ///////////////////
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> ListaArticulo = new List<Articulo>();

            try
            {
                DataBase.SetQuery("select Art.Cod_Articulo, Art.Articulo, Art.Tipo, Art.Cantidad, Art.PU_Venta as PU, M.Descripcion, cat.Descripcion as [Clasf. Alimentos], Art.Categoria, Art.Cod_Marca, Art.StockMinimo from Articulos Art, Marcas M, Categorias cat where Art.Cod_Marca = M.ID_Marca and Art.Categoria = cat.Cod_Categoria and Art.Estado = 1");
                DataBase.OpenRead();

                while (DataBase.LectorPublico.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = DataBase.LectorPublico.GetInt32(0);
                    aux.Articulos = (string)DataBase.LectorPublico["Articulo"];
                    aux.TipoDeArticulo = (string)DataBase.LectorPublico["Tipo"];
                    aux.CantidadDeArticulos = DataBase.LectorPublico.GetInt32(3);
                    aux.PrecioVenta = (float)DataBase.LectorPublico.GetDouble(4);
                    aux.Marcas = new Marca();
                    aux.Marcas.CodigoMarca = (int)DataBase.LectorPublico["Cod_Marca"];
                    aux.Marcas.Descripcion = (string)DataBase.LectorPublico["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.CodigoCategoria = (int)DataBase.LectorPublico["Categoria"];
                    aux.Categoria.Descripcion = (string)DataBase.LectorPublico["Clasf. Alimentos"];
                    aux.CantidadMinima = (int)DataBase.LectorPublico["StockMinimo"];

                    ListaArticulo.Add(aux);
                }
                return ListaArticulo;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                DataBase.CloseRead();
            }

        }

        public List<Articulo> VisualizarStock()
        {
            List<Articulo> ListarStock = new List<Articulo>();
            try
            {
                DataBase.SetQuery("select Cod_Articulo, m.Descripcion as Marca, Articulo,Tipo as Descripcion, Cantidad as Stock, StockMinimo  from Articulos, Marcas m where Cod_Marca = m.ID_Marca");
                DataBase.OpenRead();

                while (DataBase.LectorPublico.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Marcas = new Marca();
                    articulo.CodigoArticulo = (int)DataBase.LectorPublico["Cod_Articulo"];
                    articulo.Marcas.Descripcion = (string)DataBase.LectorPublico["Marca"];
                    articulo.Articulos = (string)DataBase.LectorPublico["Articulo"];
                    articulo.TipoDeArticulo = (string)DataBase.LectorPublico["Descripcion"];
                    articulo.CantidadDeArticulos = (int)DataBase.LectorPublico["Stock"];
                    articulo.CantidadMinima = (int)DataBase.LectorPublico["StockMinimo"];

                    ListarStock.Add(articulo);
                }
                return ListarStock;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        private int ReturnID(int codigo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            int CodigoRetorno = 0;
            try
            {
                accesoDatos.SetQuery("select Cod_Articulo from Articulos where Cod_Articulo = @Cod_Articulo");
                accesoDatos.SetParameters("@Cod_Articulo", codigo);
                accesoDatos.OpenRead();
                if (accesoDatos.LectorPublico.Read())
                {
                    CodigoRetorno = (int)accesoDatos.LectorPublico["Cod_Articulo"];
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
            return CodigoRetorno;
        }

        public List<Articulo> ListarNombres()
        {
            List<Articulo> Articulos = new List<Articulo>();
            try
            {
                DataBase.SetQuery("SELECT Cod_Articulo, Articulo FROM Articulos WHERE Cod_Articulo IN (SELECT MIN(Cod_Articulo) FROM Articulos GROUP BY Articulo);");
                DataBase.OpenRead();

                while(DataBase.LectorPublico.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (int)DataBase.LectorPublico["Cod_Articulo"];
                    aux.Articulos = (string)DataBase.LectorPublico["Articulo"];

                    Articulos.Add(aux);
                }
                return Articulos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
               DataBase.CloseRead();
            }
        }

        public bool CompararNombres(string EscritoPorUser)
        {
            List<Articulo> Lista;
            try
            {
                Lista = ListarArticulos();
                foreach (var item in Lista)
                {
                    if(string.Equals(item.Articulos, EscritoPorUser, StringComparison.OrdinalIgnoreCase))
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
        }

        /////////////////////   ACCIONES LOGICAS CONTRA UN ARTICULO ///////////////////

        public void CargarArticulo(Articulo art)
        {
            try
            {

                DataBase.SetQuery("insert into Articulos (Articulo, Tipo, Cantidad, StockMinimo, PU_Venta, Cod_Marca, Categoria) values (@Articulo, @Tipo, @Cantidad, @StockMinimo, @PU_Venta, @Cod_Marca, @Categoria)");
                DataBase.SetParameters("@Articulo", art.Articulos);
                DataBase.SetParameters("@Tipo", art.TipoDeArticulo);
                DataBase.SetParameters("@Cantidad", art.CantidadDeArticulos);
                DataBase.SetParameters("@StockMinimo", art.CantidadMinima);
                DataBase.SetParameters("@PU_Venta", art.PrecioVenta);
                if (art.IDMarca != 0)
                {
                    DataBase.SetParameters("@Cod_Marca", art.IDMarca);
                }
                else
                {
                    DataBase.SetParameters("@Cod_Marca", art.Marcas.CodigoMarca);
                }
                if (art.IDCategoria != 0)
                {
                    DataBase.SetParameters("@Categoria", art.IDCategoria);
                }
                else
                {
                    DataBase.SetParameters("@Categoria", art.Categoria.CodigoCategoria);
                }
                DataBase.OpenNonQuery();

            }
            catch (Exception exp)
            {

                throw exp;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public void ModificarArticulo(Articulo obj)
        {
            try
            {
                DataBase.SetQuery("update Articulos set  Articulo = @Articulo, Tipo = @Tipo, PU_Venta = @PU_Venta, Cod_Marca = @Cod_Marca, Categoria = @Categoria where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Articulo", obj.Articulos);
                DataBase.SetParameters("@Tipo", obj.TipoDeArticulo);
                DataBase.SetParameters("@PU_Venta", obj.PrecioVenta);
                DataBase.SetParameters("@Cod_Marca", obj.Marcas.CodigoMarca);
                DataBase.SetParameters("@Categoria", obj.Categoria.CodigoCategoria);
                DataBase.SetParameters("@Cod_Articulo", obj.CodigoArticulo);

                DataBase.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public void ModificarStock(Articulo articulo)
        {
            try
            {
                DataBase.SetQuery("update Articulos set Cantidad = @Cantidad, StockMinimo = @StockMinimo where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Cantidad", articulo.CantidadDeArticulos);
                DataBase.SetParameters("@StockMinimo", articulo.CantidadMinima);
                DataBase.SetParameters("@Cod_Articulo", articulo.CodigoArticulo);
                DataBase.OpenNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public void EliminarArticuloFisico(int ID) //ELIMINO EL REGISTRO POR COMPLETO EN LA DB
        {
            try
            {
                DataBase.SetQuery("delete from Articulos where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Cod_Articulo", ID);
                DataBase.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public void EliminarArticuloLogico(int ID) //JUEGO CON ACTUALIZAR EL VALOR BOOLEANO A 0 DE "ESTADO" EN LA DB 
        {
            try
            {
                DataBase.SetQuery("update Articulos set Estado = 0 where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Cod_Articulo", ID);
                DataBase.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public void ActualizarDatosDB(int ID, int StockActual)
        {
            try
            {
                int codigo = ReturnID(ID);
                DataBase.ClearParameters();
                DataBase.SetQuery("update Articulos set Cantidad = @Cantidad where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Cantidad", StockActual);
                DataBase.SetParameters("@Cod_Articulo", codigo);
                DataBase.OpenNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DataBase.CloseRead();
            }
        }

        public bool SituacionDeStock(int Cod, int Stock)
        {
            int Codigo = 0;
            try
            {
                Codigo = ReturnID(Cod);
                DataBase.ClearParameters();
                DataBase.SetQuery("select Cantidad from Articulos where Cod_Articulo = @Cod_Articulo");
                DataBase.SetParameters("@Cod_Articulo", Cod);
                DataBase.OpenRead();
                if(DataBase.LectorPublico.Read())
                {
                    int StockAcomparar = (int)DataBase.LectorPublico["Cantidad"];
                    if(StockAcomparar < Stock)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DataBase.CloseRead();
            }
            return true;    
        }
    }
}
