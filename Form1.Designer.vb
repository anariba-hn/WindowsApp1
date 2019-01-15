<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdRegister = New System.Windows.Forms.Button()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.btnCalcu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdRegister
        '
        Me.CmdRegister.Location = New System.Drawing.Point(129, 168)
        Me.CmdRegister.Name = "CmdRegister"
        Me.CmdRegister.Size = New System.Drawing.Size(75, 23)
        Me.CmdRegister.TabIndex = 0
        Me.CmdRegister.Text = "Register"
        Me.CmdRegister.UseVisualStyleBackColor = True
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.BackColor = System.Drawing.SystemColors.Control
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblmensaje.Location = New System.Drawing.Point(155, 33)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(120, 16)
        Me.lblmensaje.TabIndex = 1
        Me.lblmensaje.Text = "Select Your Name:"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Location = New System.Drawing.Point(155, 124)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(118, 13)
        Me.lblwelcome.TabIndex = 5
        Me.lblwelcome.Text = "Welcome back Ivonne!"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(217, 168)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 6
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(158, 63)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleados.TabIndex = 7
        '
        'btnCalcu
        '
        Me.btnCalcu.Location = New System.Drawing.Point(179, 212)
        Me.btnCalcu.Name = "btnCalcu"
        Me.btnCalcu.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcu.TabIndex = 8
        Me.btnCalcu.Text = "Calcu"
        Me.btnCalcu.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 322)
        Me.Controls.Add(Me.btnCalcu)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.CmdRegister)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdRegister As Button
    Friend WithEvents lblmensaje As Label
    Friend WithEvents lblwelcome As Label
    Friend WithEvents CmdExit As Button
    Friend WithEvents cmbEmpleados As ComboBox
    Friend WithEvents btnCalcu As Button
End Class
