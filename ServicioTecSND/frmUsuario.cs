using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConexionServicioTecSND;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

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
            DevExpress.XtraGrid.GridControl grd = (DevExpress.XtraGrid.GridControl)sender;
            GridView view = (GridView)grd.Views[0];
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }
        private static void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                var val = view.GetRowCellValue(info.RowHandle, info.Column);
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}, valor: {2}", info.RowHandle, colCaption, val));
            }
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}
