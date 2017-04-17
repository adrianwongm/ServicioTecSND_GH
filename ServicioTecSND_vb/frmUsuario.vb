Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ConexionServicioTecSND_vb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class frmUsuario
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Dim con As New UsuarioExtend()
        Me.grdUsuarios.DataSource = con.getListadoUsuario().Tables(0)
        cargaComboEmpleados()
    End Sub
    Dim listado As New List(Of Empleado)

    Private Sub cargaComboEmpleados()
        Try
            Dim con As New UsuarioExtend()

            listado = con.getListadoEmpleados()
            Me.cmbEmpleados.Properties.Items.AddRange(listado)
            'Me.cmbEmpleados.
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles grdUsuarios.DoubleClick
        Dim grd As DevExpress.XtraGrid.GridControl = DirectCast(sender, DevExpress.XtraGrid.GridControl)
        Dim view As GridView = DirectCast(grd.Views(0), GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        Dim iEmpleado As Integer = DoRowDoubleClick(view, pt)
        Me.cmbEmpleados.SelectedItem = listado.Where(Function(x) x.ID = iEmpleado).FirstOrDefault()
    End Sub

    Private Shared Function DoRowDoubleClick(view As GridView, pt As Point) As Integer
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        If info.InRow OrElse info.InRowCell Then
            Dim colCaption As String = If(info.Column Is Nothing, "N/A", info.Column.GetCaption())
            Dim val = view.GetRowCellValue(info.RowHandle, info.Column)
            MessageBox.Show(String.Format("DoubleClick on row: {0}, column: {1}, valor: {2}", info.RowHandle, colCaption, val))
        End If
        'view.GetRowCellValue(info.RowHandle, "ID")
        Dim i As Integer = Integer.Parse(view.GetRowCellValue(info.RowHandle, "ID_Empleado").ToString())
        Return i
    End Function

    Private Sub simpleButton2_Click(sender As Object, e As EventArgs) Handles simpleButton2.Click
        Dim grd As DevExpress.XtraGrid.GridControl = DirectCast(Me.grdUsuarios, DevExpress.XtraGrid.GridControl)
        Dim view As GridView = DirectCast(grd.Views(0), GridView)
        view.FocusedRowHandle = -1
        view.OptionsView.ShowIndicator = False
    End Sub
End Class