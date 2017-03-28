using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionServicioTecSND
{
    public class UsuarioExtend
    {
        public DataSet getListadoUsuario()
        {
            string sqlStatement = "SP_SCPV_Obtiene_Usuario";
            SqlConnection connection = new SqlConnection(Utilidades.ObtenerConexion());
            System.Data.DataSet functionReturnValue = default(System.Data.DataSet);
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter();
            System.Data.DataSet dset = new System.Data.DataSet();

            try
            {
                //   Connect to the database
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                if (connection.State != ConnectionState.Open)
                {
                    throw new Exception("Connection currently {0} when it should be open.");
                }

                //   Create a command connection
                cmd = new System.Data.SqlClient.SqlCommand();
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sqlStatement;
                }
                //.ExecuteReader()        'Forward only Dataset

                //   Create a data adapter to store the inforamtion
                adp = new System.Data.SqlClient.SqlDataAdapter();
                dset = new DataSet();
                {
                    adp.SelectCommand = cmd;
                    adp.Fill(dset, "Results");
                }

                //   Return the resulting dataset to the calling application

                functionReturnValue = dset;
            }
            catch (System.Data.SqlClient.SqlException objSE)
            {
                functionReturnValue = null;
                //   Let the calling function known they stuffed up and give them the SQL to help out.
                throw new Exception(System.String.Format("SQL :- {0}.", sqlStatement), objSE);
            }
            finally
            {
                if ((cmd != null)) cmd = null;
                if ((adp != null)) adp = null;
                if ((dset != null)) dset = null;
            }
            return functionReturnValue;
        }
    }
}
