using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos DataBaseMarca = new AccesoDatos();
        public List<Marca> ListarMarcas()
        {
            List<Marca> ListaMarca = new List<Marca>();

            try
            {
                DataBaseMarca.SetQuery("select ID_Marca, Descripcion from Marcas");
                DataBaseMarca.OpenRead();

                while (DataBaseMarca.LectorPublico.Read())
                {
                    Marca aux = new Marca();
                    aux.CodigoMarca = DataBaseMarca.LectorPublico.GetInt32(0);
                    aux.Descripcion = (string)DataBaseMarca.LectorPublico["Descripcion"];

                    ListaMarca.Add(aux);
                }
                return ListaMarca;
            }
            catch (Exception exp)
            {

                throw exp;
            }
            finally
            {
                DataBaseMarca.CloseRead();
            }

        }

        public void CargarMarca(Marca marca)
        {
            try
            {
                DataBaseMarca.SetQuery("insert into Marcas (Descripcion) values (@Descripcion)");
                DataBaseMarca.SetParameters("@Descripcion", marca.Descripcion);
                DataBaseMarca.OpenNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBaseMarca.CloseRead();
            }
        }

        public int LastID()
        {
            int ID = -1;

            try
            {
                DataBaseMarca.SetQuery("select ident_current('Marcas')");
                DataBaseMarca.OpenRead();

                if (DataBaseMarca.LectorPublico.Read())
                {
                    decimal aux = DataBaseMarca.LectorPublico.GetDecimal(0);
                    ID = (int)aux;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DataBaseMarca.CloseRead();
            }
            return ID;
        }

        public bool CompararMarca(string EscritoPorUsuario)
        {
            List<Marca> ListaComparadora;
            try
            {
                ListaComparadora = ListarMarcas();
                foreach (var marca in ListaComparadora)
                {
                    if(string.Equals(marca.Descripcion, EscritoPorUsuario, StringComparison.OrdinalIgnoreCase)) //comparo los string ignorando las mayusculas o minusculas
                    {
                        return false; // marca repetida
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
