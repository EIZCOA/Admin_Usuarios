using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Admin_Usuarios.DAL
{
    class conexionDAL
    {

        private string cadenaConexion = "Server= THINKPAD\\SQLEXPRESS; Database=cacao; Integrated Security = true";

        SqlConnection conexion;

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
            return this.conexion;
        }

        //Metodo para hacer update, insert, delete
        public bool exec_comandos(string strComando)
        {
            try {


                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;
                //Comando.CommandText = "INSERT INTO TBL_Usuario ([ID_Usuario] ,[P_Nombre],[S_Nombre],[P_Apellido],[S_Apellido],[Password],[Status]) VALUES ('fiscoa','Fausto','Emil','Iscoa','Reyes','Developer98**',1)";
                Comando.Connection = this.EstablecerConexion();
                conexion.Open();
                Comando.ExecuteNonQuery();
                conexion.Close();

                return true;

            }

            catch {
                return false;
            }
        }

        //Metodo que me permite pasar paramteros
        public bool ejecutarsinretorno(SqlCommand comando)
        {
            try
            {
                SqlCommand Comando = comando;
                Comando.Connection = this.EstablecerConexion();
                conexion.Open();
                Comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //SELECT retorno datos

        public DataSet EjecutarSentencia(SqlCommand sqlComando) 
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();

            try 
            {
                SqlCommand Comando = new SqlCommand();
                Comando = sqlComando;
                Comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = Comando;
                conexion.Open();
                Adaptador.Fill(DS);
                conexion.Close();
                return DS;

            }
            catch
            {
                return DS;
            }
        }

    }
}
