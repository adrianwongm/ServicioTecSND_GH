

Public Class formLogin
    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit1.EditValueChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try

            Dim form As New frmPrincipal()
            form.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class