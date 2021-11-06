using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_Usuarios.BLL;
//Hago uso de mi capa de acceso de datos
using Admin_Usuarios.DAL;

namespace Admin_Usuarios.PL
{
    public partial class frmDispositivos : DevExpress.XtraEditors.XtraForm
    {

        DispositivosDAL oDispositivosDAL;
        //Mi constructor
        public frmDispositivos()
        {

            oDispositivosDAL = new DispositivosDAL();
            InitializeComponent();
            dgvDispositivos.DataSource = oDispositivosDAL.MostrarDispositivos().Tables[0];
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Evento click del boton agregar
           
            ///MessageBox.Show("Conectado..");
            oDispositivosDAL.Agregar(recuperarInfo());
            dgvDispositivos.DataSource = oDispositivosDAL.MostrarDispositivos().Tables[0];
            //grdDispositivos.DataSource = oDispositivosDAL.MostrarDispositivos().Tables[0];

        }

        private DispositivosBLL recuperarInfo()
        {

            DispositivosBLL oDispositivo = new DispositivosBLL();

            //Cargo los valores de mis input text a mi BLL
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDispositivo.ID_Dispositivo = ID;
            oDispositivo.marca = txtMarca.Text.Trim().ToUpper();
            oDispositivo.modelo = txtModelo.Text.Trim().ToUpper();
            oDispositivo.SO = txtSO.Text.Trim().ToUpper();
            oDispositivo.MACADDRESS = txtMAC.Text.Trim().ToUpper();
            oDispositivo.version = txtVersion.Text.Trim().ToUpper();

            return oDispositivo;

        }

        private void txtMarca_Resize(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            txtID.Text = dgvDispositivos.Rows[indice].Cells[0].Value.ToString();
            txtMarca.Text = dgvDispositivos.Rows[indice].Cells[1].Value.ToString();
            txtModelo.Text = dgvDispositivos.Rows[indice].Cells[2].Value.ToString();
            txtMAC.Text = dgvDispositivos.Rows[indice].Cells[3].Value.ToString();
            txtVersion.Text = dgvDispositivos.Rows[indice].Cells[4].Value.ToString();
            txtSO.Text = dgvDispositivos.Rows[indice].Cells[5].Value.ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oDispositivosDAL.Eliminar(recuperarInfo());
            //Para actualizar info de mi data grid view
            LlenarGrid();

        }

        //Metdodo para modificar datos del dispositivo
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Llamo mi metodo para modificar la informacion de mi formulario
            oDispositivosDAL.Modificar(recuperarInfo());
            //Para actualizar info de mi data grid view
            LlenarGrid();
        }

        //Nuevo metodo 
        public void LlenarGrid()
        {
            dgvDispositivos.DataSource = oDispositivosDAL.MostrarDispositivos().Tables[0];
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDispositivos_Load(object sender, EventArgs e)
        {

        }

        private void grd_dispositivos_Click(object sender, EventArgs e)
        {

        }

        private void row_selected(object sender, EventArgs e)
        {

        }

        private void GridView_Click(object sender, EventArgs e)
        {

        }

        private void close(object sender, EventArgs e)
        {
           
        }
    }
}
