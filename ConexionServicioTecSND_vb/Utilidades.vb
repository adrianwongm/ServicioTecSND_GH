Public NotInheritable Class Utilidades
    Private Sub New()
    End Sub
    Public Shared Function ObtenerConexion() As String
        Dim cadenaConexion As String = "Data Source = SQL5033.SmarterASP.NET; Initial Catalog = DB_A15AC8_ATENEA; User Id = DB_A15AC8_ATENEA_admin; Password = minions2016; "
        Return cadenaConexion
    End Function

End Class
