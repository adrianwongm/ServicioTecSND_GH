Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class UsuarioExtend
    Public Function getListadoUsuario() As DataSet
        Dim sqlStatement As String = "SP_SCPV_Obtiene_Usuario"
        Dim connection As New SqlConnection(Utilidades.ObtenerConexion())
        Dim functionReturnValue As System.Data.DataSet = Nothing
        If connection Is Nothing Then
            Throw New ArgumentNullException("connection")
        End If

        Dim cmd As New System.Data.SqlClient.SqlCommand()
        Dim adp As New System.Data.SqlClient.SqlDataAdapter()
        Dim dset As New System.Data.DataSet()

        Try
            '   Connect to the database
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If

            If connection.State <> ConnectionState.Open Then
                Throw New Exception("Connection currently {0} when it should be open.")
            End If

            '   Create a command connection
            cmd = New System.Data.SqlClient.SqlCommand()
            If True Then
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = sqlStatement
            End If
            '.ExecuteReader()        'Forward only Dataset

            '   Create a data adapter to store the inforamtion
            adp = New System.Data.SqlClient.SqlDataAdapter()
            dset = New DataSet()
            If True Then
                adp.SelectCommand = cmd
                adp.Fill(dset, "Results")
            End If

            '   Return the resulting dataset to the calling application

            functionReturnValue = dset
        Catch objSE As System.Data.SqlClient.SqlException
            functionReturnValue = Nothing
            '   Let the calling function known they stuffed up and give them the SQL to help out.
            Throw New Exception(System.[String].Format("SQL :- {0}.", sqlStatement), objSE)
        Finally
            If (cmd IsNot Nothing) Then
                cmd = Nothing
            End If
            If (adp IsNot Nothing) Then
                adp = Nothing
            End If
            If (dset IsNot Nothing) Then
                dset = Nothing
            End If
        End Try
        Return functionReturnValue
    End Function
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
