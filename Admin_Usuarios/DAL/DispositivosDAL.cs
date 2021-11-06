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
    class DispositivosDAL
    {
        conexionDAL conexion;
        public DispositivosDAL() 
        {
            conexion = new conexionDAL();
        }

        //Este metodo recibe como parametro un objeto
        public bool Agregar(DispositivosBLL oDispositivosBLL) 
        {
            SqlCommand SQLComando = new SqlCommand("INSERT INTO TBL_Dispositivos (Marca, Modelo, MAC, SO, [version]) VALUES(@Marca, @Modelo, @Mac, @SO, @Ver) ");
            SQLComando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = oDispositivosBLL.marca;
            SQLComando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = oDispositivosBLL.modelo;
            SQLComando.Parameters.Add("@Mac", SqlDbType.VarChar).Value = oDispositivosBLL.MACADDRESS;
            SQLComando.Parameters.Add("@SO", SqlDbType.VarChar).Value = oDispositivosBLL.SO;
            SQLComando.Parameters.Add("@ver", SqlDbType.VarChar).Value = oDispositivosBLL.version;

            return conexion.ejecutarsinretorno(SQLComando);
            
        }

        public int Eliminar(DispositivosBLL oDispositivos)
        {
            conexion.exec_comandos("DELETE FROM TBL_Dispositivos WHERE id_dispositivo = " + oDispositivos.ID_Dispositivo);
            return 1;
        }

        public int Modificar(DispositivosBLL oDispositivos)
        {

            SqlCommand SQLComando = new SqlCommand("UPDATE TBL_Dispositivos SET Marca = @Marca, Modelo = @Modelo , MAC = @Mac , SO = @so , [version] = @ver WHERE id_dispositivo = @ID");
            SQLComando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = oDispositivos.marca;
            SQLComando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = oDispositivos.modelo;
            SQLComando.Parameters.Add("@Mac", SqlDbType.VarChar).Value = oDispositivos.MACADDRESS;
            SQLComando.Parameters.Add("@SO", SqlDbType.VarChar).Value = oDispositivos.SO;
            SQLComando.Parameters.Add("@ver", SqlDbType.VarChar).Value = oDispositivos.version;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDispositivos.ID_Dispositivo;

            conexion.ejecutarsinretorno(SQLComando);
                       
            
            return 1;
        }

        public DataSet MostrarDispositivos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM TBL_Dispositivos");

            return conexion.EjecutarSentencia(sentencia);

        }
    }
}
