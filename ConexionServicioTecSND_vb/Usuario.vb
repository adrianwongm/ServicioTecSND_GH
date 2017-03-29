Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class Usuario
    Public Property Login() As String
        Get
            Return m_Login
        End Get
        Set
            m_Login = Value
        End Set
    End Property
    Private m_Login As String

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set
            m_Password = Value
        End Set
    End Property
    Private m_Password As String

    Public Property Estado() As String
        Get
            Return m_Estado
        End Get
        Set
            m_Estado = Value
        End Set
    End Property
    Private m_Estado As String

    Public Property ID_Empleado() As Integer
        Get
            Return m_ID_Empleado
        End Get
        Set
            m_ID_Empleado = Value
        End Set
    End Property
    Private m_ID_Empleado As Integer
End Class
