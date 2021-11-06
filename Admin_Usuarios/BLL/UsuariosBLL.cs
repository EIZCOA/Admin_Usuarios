using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Usuarios.BLL
{
    class UsuariosBLL
    {
        public int id { get; set; }
        public string UserAccount { get; set; }
        public string pnombre { get; set; }
        public string snombre { get; set; }
        public string pape { get; set; }
        public string sape { get; set; }
        public string pass { get; set; }
        public int status { get; set; }
    }
}
