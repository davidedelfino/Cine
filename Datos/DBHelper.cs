using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cine.Datos
{
    internal class DBHelper
    {

        private SqlConnection conn;
        private string CadenaConexion = @"Data Source=PC;Initial Catalog=Cine;Integrated Security=True";
        private static DBHelper instancia;

        public DBHelper()
        {
            conn = new SqlConnection(CadenaConexion);
        }

        public static DBHelper ObtenerInstancia()
        {
            if(instancia==null)
                instancia = new DBHelper();
            return instancia;
        }

        public DataTable ConsultarDB(string NomProc, DateTime parametro)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = NomProc;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "fecha";
            param.Value = parametro;
            param.Direction = ParameterDirection.Input;
            param.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(param);
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;


        }

        public DataTable ConsultarClientes()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "PA_CONSULTAR_CLIENTES";
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;
        }
        public DataTable ConsultarLocalidades(int codProvincia)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "PA_CONSULTAR_LOCALS";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "fecha";
            param.Value = codProvincia;
            param.Direction = ParameterDirection.Input;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(codProvincia);
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;
        }
        public DataTable ConsultarBarrios(int codLocalidad)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "PA_CONSULTAR_BARRIOS";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "fecha";
            param.Value = codLocalidad;
            param.Direction = ParameterDirection.Input;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(codLocalidad);
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;
        }
        public DataTable ConsultarCalles(int codBarrio)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "PA_CONSULTAR_CALLES";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "fecha";
            param.Value = codBarrio;
            param.Direction = ParameterDirection.Input;
            param.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(codBarrio);
            tabla.Load(cmd.ExecuteReader());
            conn.Close();

            return tabla;
        }
    }
}
