using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Negocio
{
    public class AccesoDatos
    {
        ///////////////////////////////////   PROPIEDADES /////////////////////////////////////
        
        private string IPConexion = "server = DESKTOP-N8976U7\\SQLEXPRESS ; database = Dietetica ; integrated security = true";
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;
        public SqlDataReader LectorPublico //  propiedad para leer el lector desde afuera en caso que lo necesitara
        { 
            get { return Lector; } 
      
        } 
        public AccesoDatos () // constructor vacio con acceso a la DB
        {
            Conexion = new SqlConnection(IPConexion);
            Comando = new SqlCommand();
        }

        public void SetQuery (string Consulta) // metodo generico para traer la consulta
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }

        ///////////////////////////////////   METODOS  /////////////////////////////////////
        public void OpenRead () 
        {
            Comando.Connection = Conexion;
            try
            {
                if(Conexion.State  == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();
                }
                Lector = Comando.ExecuteReader();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        public void OpenNonQuery()
        {
            Comando.Connection = Conexion;  
            try
            {
                if(Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();
                }
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SetParameters(string Nombre, object value)
        {
            Comando.Parameters.AddWithValue(Nombre, value);
        }

        public void CloseRead ()
        {
            if(Lector != null)
            {
                Lector.Close();
            }
            if(Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public void OpenTransaction(Action<SqlCommand> ComandoDeTransaccion)
        {
            OpenConnection();

            using (SqlTransaction Transaccion = Conexion.BeginTransaction())
            {
                try
                {
                    Comando.Transaction = Transaccion;
                    ComandoDeTransaccion(Comando);
                    Transaccion.Commit();
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    throw ex;
                }
                finally
                {
                    CloseRead();
                }
            }
        }

        private void OpenConnection()
        {
            if(Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Open();
            }
        }

        public void ClearParameters() 
        {
            Comando.Parameters.Clear();
        }
    }
}
