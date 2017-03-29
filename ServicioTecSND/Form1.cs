using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecSND
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            InitializeComponent();
            this.Lbl_Titulo.Parent = this.pictureEdit1;
            this.Lbl_Titulo.BackColor = Color.Transparent;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmPrincipal form = new frmPrincipal();
            form.Show();
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
