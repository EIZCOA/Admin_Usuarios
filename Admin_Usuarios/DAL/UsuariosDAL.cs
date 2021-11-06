using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Admin_Usuarios.BLL;


namespace Admin_Usuarios.DAL
{   
    class UsuariosDAL
    {
        conexionDAL conexion;
        public UsuariosDAL()
        {
            conexion = new conexionDAL();
        }

        public bool Agregar(UsuariosBLL oUsuariosBLL)
        {

            SqlCommand SQLComando = new SqlCommand("INSERT INTO TBL_Usuario ([UserAccount],[P_Nombre],[S_Nombre],[P_Apellido],[S_Apellido],[Password],[Status]) VALUES (@User, @PNom, @SNom, @PApe, @SApe, @Pass, @Stat)");
            SQLComando.Parameters.Add("@User", SqlDbType.VarChar).Value = oUsuariosBLL.UserAccount;
            SQLComando.Parameters.Add("@PNom", SqlDbType.VarChar).Value = oUsuariosBLL.pnombre;
            SQLComando.Parameters.Add("@SNom", SqlDbType.VarChar).Value = oUsuariosBLL.snombre;
            SQLComando.Parameters.Add("@PApe", SqlDbType.VarChar).Value = oUsuariosBLL.pape;
            SQLComando.Parameters.Add("@SApe", SqlDbType.VarChar).Value = oUsuariosBLL.sape;
            SQLComando.Parameters.Add("@Pass", SqlDbType.VarChar).Value = oUsuariosBLL.pass;
            SQLComando.Parameters.Add("@Stat", SqlDbType.VarChar).Value = oUsuariosBLL.status;
            //Hago llamado al ejecutar sin reotrno el cual recibe la instriccion de insertar este registros a la tabla de usarios
            return conexion.ejecutarsinretorno(SQLComando);
        }

        public int Modificar(UsuariosBLL oUsuariosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE TBL_Usuario SET UserAccount = @User, P_Nombre = @PNom , S_Nombre = @SNom , P_Apellido = @PApe , S_Apellido = @SApe , Password = @Pass , Status = @Stat  WHERE id_dispositivo = @ID");
            SQLComando.Parameters.Add("@User", SqlDbType.VarChar).Value = oUsuariosBLL.UserAccount;
            SQLComando.Parameters.Add("@PNom", SqlDbType.VarChar).Value = oUsuariosBLL.pnombre;
            SQLComando.Parameters.Add("@SNom", SqlDbType.VarChar).Value = oUsuariosBLL.snombre;
            SQLComando.Parameters.Add("@PApe", SqlDbType.VarChar).Value = oUsuariosBLL.pape;
            SQLComando.Parameters.Add("@SApe", SqlDbType.VarChar).Value = oUsuariosBLL.sape;
            SQLComando.Parameters.Add("@Pass", SqlDbType.VarChar).Value = oUsuariosBLL.pass;
            SQLComando.Parameters.Add("@Stat", SqlDbType.VarChar).Value = oUsuariosBLL.status;
            SQLComando.Parameters.Add("@ID", SqlDbType.VarChar).Value = oUsuariosBLL.id;

            conexion.ejecutarsinretorno(SQLComando);

            return 1;
        }

        //Metodo para eliminar registros de la tabla usuarios
        public int Eliminar(UsuariosBLL oUsuariosBLL)
        {
            conexion.exec_comandos("DELETE FROM TBL_Usuario WHERE ID_Usuario = " + oUsuariosBLL.id);
            return 1;
        }

        public DataSet MostrarUsuarios()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM TBL_Usuario");

            return conexion.EjecutarSentencia(sentencia);

        }

    }
}
