using System;
using CapaEntidad;
using System.Configuration;
//using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace CapaDatos
{
    public class D_Usuario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        public DataTable D_listado()
        {
            SqlCommand cmd = new SqlCommand("sp_listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
