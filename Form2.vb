Imports System.Data.SqlClient
Imports WindowsApp1.My.Resources
Public Class Form2
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    ''Private Conn As SqlConnection
    ''Private query As SqlCommand
    ''Private reader As SqlDataReader
    ''Private results As String

    'Dim Id As Integer
    Dim Id As String
    Dim Nombre As String
    Dim Apellido As String
    Dim Sueldo As String
    Dim Conect As Conexiones = New Conexiones()
    Dim resultados(3) As String

    Private Sub CleanAlltxt()
        txtId.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtSueldo.Text = ""
    End Sub

    Private Sub DisableAlltxt()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtSueldo.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Id = txtId.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Sueldo = txtSueldo.Text
        ''Funcion actualiza los datos en tabla empleados
        Conect.Actualizar(Id, Nombre, Apellido, Sueldo)

        CleanAlltxt()
        DisableAlltxt()
        btnBuscar.Enabled = True
        btnEliminar.Visible = False
        btnGuardar.Visible = False
        txtId.Enabled = True

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.PruebaDataSet.Empleados)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Id = txtId.Text
        Dim msg, style, ctxt, resp


        If Id IsNot "" Then
            resultados = Conect.Busqueda(Convert.ToInt64(Id))
            If resultados(0) = "" Then

                msg = "No se Encontro ningun Empleado, Desea Continuar ?"
                style = vbYesNo + vbCritical + vbDefaultButton2
                ctxt = "Mensaje de error"
                resp = MsgBox(msg, style, ctxt)

                If resp = vbYes Then

                    Me.ActiveControl = txtNombre
                    btnNuevo.Enabled = True
                    btnNuevo.Visible = True
                    btnBuscar.Enabled = False
                    CleanAlltxt()
                    txtNombre.Enabled = True
                    txtApellido.Enabled = True
                    txtSueldo.Enabled = True

                Else
                    txtId.Text = ""
                    Me.ActiveControl = txtId
                    CleanAlltxt()
                    DisableAlltxt()
                End If
            Else
                Me.ActiveControl = txtId
                txtNombre.Text = resultados(0)
                txtApellido.Text = resultados(1)
                txtSueldo.Text = resultados(2)
                btnActualizar.Enabled = True
                btnEliminar.Enabled = True
            End If
        Else
            System.Windows.Forms.MessageBox.Show("Debe ingresar un ID para continuar")
            resultados(0) = ""
            Me.ActiveControl = txtId
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        btnBuscar.Enabled = False
        btnGuardar.Visible = True
        btnEliminar.Enabled = False
        txtId.Enabled = False
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtSueldo.Enabled = True
        btnActualizar.Enabled = False

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Id = txtId.Text
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Sueldo = txtSueldo.Text

        ''Funcion registra los datos en tabla empleados
        Conect.Registrar(Id, Nombre, Apellido, Sueldo)
        CleanAlltxt()
        DisableAlltxt()
        btnBuscar.Enabled = True
        txtId.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Id = txtId.Text
        Dim msg, style, ctxt, resp
        msg = "Seguro que Desea Eliminar al usuario " & txtId.Text & " ?"
        style = vbYesNo + vbCritical + vbDefaultButton2
        ctxt = "Mensaje de error"
        resp = MsgBox(msg, style, ctxt)

        If resp = vbYes Then
            Me.ActiveControl = txtId
            btnBuscar.Enabled = True
            DisableAlltxt()
            Conect.Eliminar(Id)
            CleanAlltxt()

        Else
            CleanAlltxt()
            Me.ActiveControl = txtId
            DisableAlltxt()
        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EmpleadosTableAdapter.FillBy(Me.PruebaDataSet.Empleados)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class