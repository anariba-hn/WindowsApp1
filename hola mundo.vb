Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class hola_mundo
    Private suma As Integer
    Public Sub New()

    End Sub
    'Public Sub holamundo()
    'Return "Hola Mundo"
    'End Sub
    Public ReadOnly Property Hola() As String
        Get
            Return "Hola Mundo"
        End Get
    End Property
    Public ReadOnly Property resultado() As Integer
        Get
            Return suma
        End Get
    End Property
    Public Sub sumar(ByVal x As Integer, ByVal z As Integer)
        suma = x + z
    End Sub
End Class
