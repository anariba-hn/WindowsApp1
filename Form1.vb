Imports System.Data.SqlClient
Imports WindowsApp1.My.Resources
Public Class Form1
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Dim clase As hola_mundo = New hola_mundo()




    Private Sub CmdHola_Click(sender As Object, e As EventArgs) Handles CmdRegister.Click
        'For index = 1 To 10
        'lblmensaje.Text = index.ToString
        'Next
        ''clase.sumar(3, 4)
        ''lblmensaje.Text = clase.resultado
        ''MsgBox()


    End Sub

    Private Sub RBIvonne_CheckedChanged(sender As Object, e As EventArgs)
        'If RBIvonne.Checked Then
        'lblwelcome.Text = "Welcome back Ivonne!" & ControlChars.NewLine & "Click to register a sale!"
        'lblwelcome.Visible = True
        'CmdRegister.Visible = True
        'CmdExit.Visible = True

        'End If '
    End Sub

    Private Sub RBHenry_CheckedChanged(sender As Object, e As EventArgs)
        'If RBHenry.Checked Then
        'lblwelcome.Text = "Welcome back Ivonne!" & ControlChars.NewLine & "Click to register a sale!"
        'lblwelcome.Visible = True
        'CmdRegister.Visible = True
        'CmdExit.Visible = True
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            myConn = New SqlConnection("Server=IvonneDenisse\SQLExpress;Database=Prueba;Integrated Security=true")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT Nombre, Apellido FROM Empleados"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            Do While myReader.Read()
                results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
            Loop
            'Display results.
            MsgBox(results)
            myReader.Close()
            myConn.Close()
            'lblwelcome.Text = clase.Hola()
            'lblwelcome.Visible = True
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        Me.cargarcmb()
    End Sub


    Private Sub btnCalcu_Click(sender As Object, e As EventArgs) Handles btnCalcu.Click
        Dim form2 As New Form2
        form2.Show()
        Me.Close()

    End Sub
    Private Sub cargarcmb()
        Dim x As Integer = 0
        myConn = New SqlConnection("Server=IvonneDenisse\SQLExpress;Database=Prueba;Integrated Security=true")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Nombre, Apellido FROM Empleados"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            ''results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
            '' & " " & myReader.GetSqlString(1)
            ''cmbEmpleados.Items.Add(myReader.GetString(0) & " " & myReader.GetString(1))

        Loop

    End Sub
    Private Sub saludo()
        lblmensaje.Text = "Welcome back, " & cmbEmpleados.Text

    End Sub

    Private Sub cmbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleados.SelectedIndexChanged
        Me.saludo()
    End Sub
End Class
