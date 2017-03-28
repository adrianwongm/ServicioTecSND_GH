using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexionServicioTecSND;
namespace ServicioTecSND
{
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuario()
        {
            InitializeComponent();

            UsuarioExtend con = new UsuarioExtend();
            this.grdUsuarios.DataSource =  con.getListadoUsuario().Tables[0];

        }

        private void grdUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
