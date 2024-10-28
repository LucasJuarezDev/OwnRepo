using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos DataBaseCat = new AccesoDatos();
        public List <Categoria> ListarCategorias()
        {
            List <Categoria> ListaCategorias = new List <Categoria>();  

            try
            {
                DataBaseCat.SetQuery("select Cod_Categoria, Descripcion from Categorias");
                DataBaseCat.OpenRead();

                while (DataBaseCat.LectorPublico.Read())
                {
                    Categoria aux = new Categoria();
                    aux.CodigoCategoria = DataBaseCat.LectorPublico.GetInt32(0);
                    aux.Descripcion = (string)DataBaseCat.LectorPublico["Descripcion"];    
                    ListaCategorias.Add(aux);
                }
                return ListaCategorias;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DataBaseCat.CloseRead();
            }
            
        }

        public void CargarCategoria(Categoria categoria)
        {
            try
            {
                DataBaseCat.SetQuery("insert into Categorias (Descripcion) values (@Descripcion)");
                DataBaseCat.SetParameters("@Descripcion", categoria.Descripcion);
                DataBaseCat.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBaseCat.CloseRead();
            }
        }

        public int LastID()
        {
            int ID = -1;
            try
            {
                DataBaseCat.SetQuery("select ident_current('Categorias')");
                DataBaseCat.OpenRead();

                if (DataBaseCat.LectorPublico.Read())
                {
                    decimal aux = DataBaseCat.LectorPublico.GetDecimal(0);
                    ID = (int)aux;
                }
            }
            catch (Exception EX)
            {

                throw EX;
            }
            finally
            {
                DataBaseCat.CloseRead();
            }
            return ID;
        }

        public bool CompararCategoria(string EscritoPorUser)
        {
            List<Categoria> Comparador;
            try
            {
                Comparador = ListarCategorias();
                foreach (var cat in Comparador)
                {
                    if(string.Equals(cat.Descripcion, EscritoPorUser, StringComparison.OrdinalIgnoreCase))
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
    }
}
