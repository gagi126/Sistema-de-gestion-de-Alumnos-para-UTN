<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrarSiNo
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
        Me.btnsi = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsi
        '
        Me.btnsi.Location = New System.Drawing.Point(23, 60)
        Me.btnsi.Name = "btnsi"
        Me.btnsi.Size = New System.Drawing.Size(42, 23)
        Me.btnsi.TabIndex = 0
        Me.btnsi.Text = "Si"
        Me.btnsi.UseVisualStyleBackColor = True
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(115, 60)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(42, 23)
        Me.btnno.TabIndex = 1
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Desea el registro?"
        '
        'BorrarSiNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 109)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrarSiNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atencion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsi As Button
    Friend WithEvents btnno As Button
    Friend WithEvents Label1 As Label
End Class
