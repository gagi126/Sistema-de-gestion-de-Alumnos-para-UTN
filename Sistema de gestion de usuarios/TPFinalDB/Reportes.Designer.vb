<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.btalumnos = New System.Windows.Forms.Button()
        Me.btnmaterias = New System.Windows.Forms.Button()
        Me.btnprofesores = New System.Windows.Forms.Button()
        Me.btntitulos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbprogre = New System.Windows.Forms.ProgressBar()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btalumnos
        '
        Me.btalumnos.Location = New System.Drawing.Point(29, 21)
        Me.btalumnos.Name = "btalumnos"
        Me.btalumnos.Size = New System.Drawing.Size(148, 23)
        Me.btalumnos.TabIndex = 0
        Me.btalumnos.Text = "Reporte de alumnos"
        Me.btalumnos.UseVisualStyleBackColor = True
        '
        'btnmaterias
        '
        Me.btnmaterias.Location = New System.Drawing.Point(29, 50)
        Me.btnmaterias.Name = "btnmaterias"
        Me.btnmaterias.Size = New System.Drawing.Size(148, 23)
        Me.btnmaterias.TabIndex = 1
        Me.btnmaterias.Text = "Reporte de materias"
        Me.btnmaterias.UseVisualStyleBackColor = True
        '
        'btnprofesores
        '
        Me.btnprofesores.Location = New System.Drawing.Point(29, 79)
        Me.btnprofesores.Name = "btnprofesores"
        Me.btnprofesores.Size = New System.Drawing.Size(148, 23)
        Me.btnprofesores.TabIndex = 2
        Me.btnprofesores.Text = "Reporte de Profesores"
        Me.btnprofesores.UseVisualStyleBackColor = True
        '
        'btntitulos
        '
        Me.btntitulos.Location = New System.Drawing.Point(29, 108)
        Me.btntitulos.Name = "btntitulos"
        Me.btntitulos.Size = New System.Drawing.Size(148, 23)
        Me.btntitulos.TabIndex = 3
        Me.btntitulos.Text = "Reporte de titulos"
        Me.btntitulos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btntitulos)
        Me.GroupBox1.Controls.Add(Me.btnmaterias)
        Me.GroupBox1.Controls.Add(Me.btnprofesores)
        Me.GroupBox1.Controls.Add(Me.btalumnos)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 147)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'pbprogre
        '
        Me.pbprogre.Location = New System.Drawing.Point(76, 19)
        Me.pbprogre.Name = "pbprogre"
        Me.pbprogre.Size = New System.Drawing.Size(369, 20)
        Me.pbprogre.TabIndex = 5
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.pbprogre)
        Me.gb1.Controls.Add(Me.lblporcentaje)
        Me.gb1.Location = New System.Drawing.Point(12, 165)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(497, 72)
        Me.gb1.TabIndex = 6
        Me.gb1.TabStop = False
        '
        'lblporcentaje
        '
        Me.lblporcentaje.AutoSize = True
        Me.lblporcentaje.Location = New System.Drawing.Point(319, 42)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(18, 13)
        Me.lblporcentaje.TabIndex = 6
        Me.lblporcentaje.Text = "eti"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btalumnos As Button
    Friend WithEvents btnmaterias As Button
    Friend WithEvents btnprofesores As Button
    Friend WithEvents btntitulos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbprogre As ProgressBar
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents lblporcentaje As Label
End Class
