namespace ServicioTecSND
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grdUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsuarios.Location = new System.Drawing.Point(0, 208);
            this.grdUsuarios.MainView = this.gridView1;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.Size = new System.Drawing.Size(726, 224);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdUsuarios_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Codigo,
            this.Estado,
            this.ID_Empleado});
            this.gridView1.GridControl = this.grdUsuarios;
            this.gridView1.Name = "gridView1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 285;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Login";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 129;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 2;
            this.Estado.Width = 88;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.Caption = "Empleado";
            this.ID_Empleado.FieldName = "ID_Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Visible = true;
            this.ID_Empleado.VisibleIndex = 3;
            this.ID_Empleado.Width = 179;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(88, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(155, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(127, 91);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 460);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.grdUsuarios);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "frmUsuario";
            this.Text = "Mantenedor de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn ID_Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}