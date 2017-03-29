Public Class frmPrincipal
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Orden de Servicio
        'Dim frm As New frmOrdenServicio()
        'frm.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'Mantenedor de usuarios
        Dim frm As New frmUsuario()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class