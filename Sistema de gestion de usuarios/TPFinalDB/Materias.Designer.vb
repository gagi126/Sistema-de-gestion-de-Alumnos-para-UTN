<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescmat = New System.Windows.Forms.TextBox()
        Me.txtdesccarrera = New System.Windows.Forms.TextBox()
        Me.cmbprofesor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion Materia"
        '
        'txtdescmat
        '
        Me.txtdescmat.Location = New System.Drawing.Point(146, 33)
        Me.txtdescmat.Name = "txtdescmat"
        Me.txtdescmat.Size = New System.Drawing.Size(121, 20)
        Me.txtdescmat.TabIndex = 1
        '
        'txtdesccarrera
        '
        Me.txtdesccarrera.Location = New System.Drawing.Point(146, 70)
        Me.txtdesccarrera.Name = "txtdesccarrera"
        Me.txtdesccarrera.Size = New System.Drawing.Size(121, 20)
        Me.txtdesccarrera.TabIndex = 2
        '
        'cmbprofesor
        '
        Me.cmbprofesor.FormattingEnabled = True
        Me.cmbprofesor.Location = New System.Drawing.Point(146, 106)
        Me.cmbprofesor.Name = "cmbprofesor"
        Me.cmbprofesor.Size = New System.Drawing.Size(121, 21)
        Me.cmbprofesor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion Carrera"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Profesor Asignado"
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(100, 151)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 6
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 237)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbprofesor)
        Me.Controls.Add(Me.txtdesccarrera)
        Me.Controls.Add(Me.txtdescmat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Materias"
        Me.Text = "Materias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescmat As TextBox
    Friend WithEvents txtdesccarrera As TextBox
    Friend WithEvents cmbprofesor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnregistrar As Button
End Class
