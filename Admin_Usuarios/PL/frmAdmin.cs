using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_Usuarios.PL;

namespace Admin_Usuarios.PL
{
    public partial class frmAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void barButtonDevices_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDispositivos frm_hijo = new frmDispositivos();
            frm_hijo.TopLevel = false;
            panelAdmin.Controls.Add(frm_hijo);
            
            frm_hijo.Show();

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuarios frm_hijo = new frmUsuarios();
            frm_hijo.TopLevel = false;
            panelAdmin.Controls.Add(frm_hijo);
            frm_hijo.Show();
        }
    }
}