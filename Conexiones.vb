Imports System.Data.SqlClient
Imports WindowsApp1.My.Resources
Public Class Conexiones
    Private Conn As SqlConnection
    Private query As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private conexionstrg As String = "Server=IvonneDenisse\SQLExpress;Database=Prueba;Integrated Security=true"
    Private resultados(3) As String

    Public Sub New()
        Conn = New SqlConnection(conexionstrg)
    End Sub

    Public Sub Registrar(ByVal Id As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Sueldo As String)
        Try
            query = Conn.CreateCommand
            'query.CommandText = "INSERT INTO Empleados (Id,Nombre,Apellido,Sueldo) values(" & 1010 & "," & var1 & "," & var2 & "," & var3 & ");"
            query.CommandText = "insert into Empleados(Id,Nombre,Apellido,Sueldo) values (" & Id & ",'" & Nombre & "','" & Apellido & "'," & Sueldo & ");"

            Conn.Open()
            query.ExecuteNonQuery()
            Conn.Close()
            MsgBox(Convert.ToString("Usuario " & Id & " Registrado Exitosamente!"))
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Public Sub Actualizar(ByVal Id As Integer, ByVal Nombre As String, Apellido As String, ByVal Sueldo As String)
        Try
            query = Conn.CreateCommand
            query.CommandText = "UPDATE Empleados SET Nombre = '" & Nombre & "',Apellido= '" & Apellido & "', Sueldo= " & Sueldo & " WHERE Id=" & Id & ";"
            Conn.Open()
            query.ExecuteNonQuery()
            Conn.Close()
            MsgBox(Convert.ToString("Usuario " & Id & " Actualizado Exitosamente!"))
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub
    Public ReadOnly Property Busqueda(ByVal Id As Integer) As String()


        Get

            Try
                Conn = New SqlConnection("Server=IvonneDenisse\SQLExpress;Database=Prueba;Integrated Security=true")
                query = Conn.CreateCommand
                query.CommandText = "select Nombre, Apellido, Sueldo from Empleados where Id = " & Id & ";"
                Conn.Open()
                myReader = query.ExecuteReader()
                Do While myReader.Read()
                    For index As Integer = 0 To 2
                        resultados(index) = Convert.ToString(myReader.GetValue(index))
                    Next
                Loop
                myReader.Close()
                Conn.Close()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
            Return resultados
        End Get
    End Property

    Public Sub Eliminar(ByVal Id As Integer)
        Try
            query = Conn.CreateCommand
            query.CommandText = "Delete from Empleados where id = " & Id & ";"
            Conn.Open()
            query.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Empleado Eliminado Exitosamenta")
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub
End Class
