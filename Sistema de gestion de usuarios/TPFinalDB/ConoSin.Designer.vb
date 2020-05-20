<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConoSin
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
        Me.btntodo = New System.Windows.Forms.Button()
        Me.btnsolos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(590, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Se emitira el listado de titulos cargados en el sistema, ¿Desea emitir todos los " &
    "titulos o solo aquellos con  personal asignado?"
        '
        'btntodo
        '
        Me.btntodo.Location = New System.Drawing.Point(150, 53)
        Me.btntodo.Name = "btntodo"
        Me.btntodo.Size = New System.Drawing.Size(144, 23)
        Me.btntodo.TabIndex = 1
        Me.btntodo.Text = "Emitir todos los titulos"
        Me.btntodo.UseVisualStyleBackColor = True
        '
        'btnsolos
        '
        Me.btnsolos.Location = New System.Drawing.Point(300, 53)
        Me.btnsolos.Name = "btnsolos"
        Me.btnsolos.Size = New System.Drawing.Size(199, 23)
        Me.btnsolos.TabIndex = 2
        Me.btnsolos.Text = "Solo aquellos con personal asignado"
        Me.btnsolos.UseVisualStyleBackColor = True
        '
        'ConoSin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 105)
        Me.Controls.Add(Me.btnsolos)
        Me.Controls.Add(Me.btntodo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConoSin"
        Me.Text = "ConoSin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btntodo As Button
    Friend WithEvents btnsolos As Button
End Class
