using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Usuarios.BLL
{
    class DispositivosBLL
    {
        public int ID_Dispositivo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string MACADDRESS { get; set; }
        public string SO { get; set; }
        public string version { get; set; }
    }
}
