Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Class1

    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub New()

    End Sub

    Public Sub holamundo()
        Return "Hola Mundo"
    End Sub

End Class
