<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clave
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.lbincorrecta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor ingrese la clave del sistema"
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(57, 109)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(203, 20)
        Me.txtclave.TabIndex = 1
        '
        'lbincorrecta
        '
        Me.lbincorrecta.AutoSize = True
        Me.lbincorrecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbincorrecta.ForeColor = System.Drawing.Color.Red
        Me.lbincorrecta.Location = New System.Drawing.Point(57, 136)
        Me.lbincorrecta.Name = "lbincorrecta"
        Me.lbincorrecta.Size = New System.Drawing.Size(193, 13)
        Me.lbincorrecta.TabIndex = 2
        Me.lbincorrecta.Text = "La clave ingresada es incorrecta"
        '
        'Clave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 187)
        Me.Controls.Add(Me.lbincorrecta)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clave"
        Me.Text = "Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtclave As TextBox
    Friend WithEvents lbincorrecta As Label
End Class
