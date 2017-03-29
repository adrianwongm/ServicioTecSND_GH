<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Usuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Estado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ID_Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdUsuarios
        '
        Me.grdUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUsuarios.Location = New System.Drawing.Point(3, 231)
        Me.grdUsuarios.MainView = Me.GridView1
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.Size = New System.Drawing.Size(714, 224)
        Me.grdUsuarios.TabIndex = 0
        Me.grdUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.Usuario, Me.Estado, Me.ID_Empleado})
        Me.GridView1.GridControl = Me.grdUsuarios
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = True
        Me.ID.VisibleIndex = 0
        Me.ID.Width = 80
        '
        'Usuario
        '
        Me.Usuario.Caption = "Codigo"
        Me.Usuario.FieldName = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Visible = True
        Me.Usuario.VisibleIndex = 1
        Me.Usuario.Width = 160
        '
        'Estado
        '
        Me.Estado.Caption = "Estado"
        Me.Estado.FieldName = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = True
        Me.Estado.VisibleIndex = 2
        Me.Estado.Width = 84
        '
        'ID_Empleado
        '
        Me.ID_Empleado.Caption = "Empleado"
        Me.ID_Empleado.FieldName = "ID_Empleado"
        Me.ID_Empleado.Name = "ID_Empleado"
        Me.ID_Empleado.Visible = True
        Me.ID_Empleado.VisibleIndex = 3
        Me.ID_Empleado.Width = 358
        '
        'labelControl5
        '
        Me.labelControl5.Location = New System.Drawing.Point(311, 78)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(33, 13)
        Me.labelControl5.TabIndex = 26
        Me.labelControl5.Text = "Estado"
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(311, 34)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(46, 13)
        Me.labelControl4.TabIndex = 25
        Me.labelControl4.Text = "Empleado"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(8, 124)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(84, 13)
        Me.labelControl3.TabIndex = 24
        Me.labelControl3.Text = "Repetir Password"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(8, 78)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(46, 13)
        Me.labelControl2.TabIndex = 23
        Me.labelControl2.Text = "Password"
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(8, 34)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(36, 13)
        Me.labelControl1.TabIndex = 22
        Me.labelControl1.Text = "Usuario"
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.simpleButton1)
        Me.groupControl1.Controls.Add(Me.simpleButton3)
        Me.groupControl1.Controls.Add(Me.simpleButton2)
        Me.groupControl1.Location = New System.Drawing.Point(311, 120)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Size = New System.Drawing.Size(398, 78)
        Me.groupControl1.TabIndex = 21
        Me.groupControl1.Text = "Acciones"
        '
        'simpleButton1
        '
        Me.simpleButton1.Location = New System.Drawing.Point(147, 39)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(91, 23)
        Me.simpleButton1.TabIndex = 7
        Me.simpleButton1.Text = "&Grabar"
        '
        'simpleButton3
        '
        Me.simpleButton3.Location = New System.Drawing.Point(279, 39)
        Me.simpleButton3.Name = "simpleButton3"
        Me.simpleButton3.Size = New System.Drawing.Size(91, 23)
        Me.simpleButton3.TabIndex = 9
        Me.simpleButton3.Text = "&Cancelar"
        '
        'simpleButton2
        '
        Me.simpleButton2.Location = New System.Drawing.Point(20, 39)
        Me.simpleButton2.Name = "simpleButton2"
        Me.simpleButton2.Size = New System.Drawing.Size(91, 23)
        Me.simpleButton2.TabIndex = 8
        Me.simpleButton2.Text = "&Nuevo"
        '
        'checkEdit1
        '
        Me.checkEdit1.Location = New System.Drawing.Point(399, 76)
        Me.checkEdit1.Name = "checkEdit1"
        Me.checkEdit1.Properties.Caption = "Activo"
        Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
        Me.checkEdit1.TabIndex = 20
        '
        'comboBoxEdit1
        '
        Me.comboBoxEdit1.Location = New System.Drawing.Point(399, 31)
        Me.comboBoxEdit1.Name = "comboBoxEdit1"
        Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboBoxEdit1.Size = New System.Drawing.Size(182, 20)
        Me.comboBoxEdit1.TabIndex = 19
        '
        'textEdit3
        '
        Me.textEdit3.Location = New System.Drawing.Point(108, 121)
        Me.textEdit3.Name = "textEdit3"
        Me.textEdit3.Size = New System.Drawing.Size(155, 20)
        Me.textEdit3.TabIndex = 18
        '
        'textEdit2
        '
        Me.textEdit2.Location = New System.Drawing.Point(108, 75)
        Me.textEdit2.Name = "textEdit2"
        Me.textEdit2.Size = New System.Drawing.Size(155, 20)
        Me.textEdit2.TabIndex = 17
        '
        'textEdit1
        '
        Me.textEdit1.Location = New System.Drawing.Point(108, 31)
        Me.textEdit1.Name = "textEdit1"
        Me.textEdit1.Size = New System.Drawing.Size(155, 20)
        Me.textEdit1.TabIndex = 16
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 467)
        Me.Controls.Add(Me.labelControl5)
        Me.Controls.Add(Me.labelControl4)
        Me.Controls.Add(Me.labelControl3)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.groupControl1)
        Me.Controls.Add(Me.checkEdit1)
        Me.Controls.Add(Me.comboBoxEdit1)
        Me.Controls.Add(Me.textEdit3)
        Me.Controls.Add(Me.textEdit2)
        Me.Controls.Add(Me.textEdit1)
        Me.Controls.Add(Me.grdUsuarios)
        Me.Name = "frmUsuario"
        Me.Text = "Usuario"
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Usuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ID_Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
    Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents textEdit3 As DevExpress.XtraEditors.TextEdit
    Private WithEvents textEdit2 As DevExpress.XtraEditors.TextEdit
    Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
End Class
