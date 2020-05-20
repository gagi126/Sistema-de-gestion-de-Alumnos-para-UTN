<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Opciones
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProfesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeMateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrasOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTitulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.ProfesoresToolStripMenuItem, Me.MateriasToolStripMenuItem, Me.OtrasOpcionesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.CargarDocumentosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeAlumnosToolStripMenuItem})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'ListadoDeAlumnosToolStripMenuItem
        '
        Me.ListadoDeAlumnosToolStripMenuItem.Name = "ListadoDeAlumnosToolStripMenuItem"
        Me.ListadoDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ListadoDeAlumnosToolStripMenuItem.Text = "Listado de alumnos"
        '
        'ProfesoresToolStripMenuItem
        '
        Me.ProfesoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeProfesoresToolStripMenuItem})
        Me.ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem"
        Me.ProfesoresToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ProfesoresToolStripMenuItem.Text = "Profesores"
        '
        'ListadoDeProfesoresToolStripMenuItem
        '
        Me.ListadoDeProfesoresToolStripMenuItem.Name = "ListadoDeProfesoresToolStripMenuItem"
        Me.ListadoDeProfesoresToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ListadoDeProfesoresToolStripMenuItem.Text = "Listado de profesores"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeMateriasToolStripMenuItem})
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'ListadoDeMateriasToolStripMenuItem
        '
        Me.ListadoDeMateriasToolStripMenuItem.Name = "ListadoDeMateriasToolStripMenuItem"
        Me.ListadoDeMateriasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ListadoDeMateriasToolStripMenuItem.Text = "Listado de materias"
        '
        'OtrasOpcionesToolStripMenuItem
        '
        Me.OtrasOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeTitulosToolStripMenuItem})
        Me.OtrasOpcionesToolStripMenuItem.Name = "OtrasOpcionesToolStripMenuItem"
        Me.OtrasOpcionesToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OtrasOpcionesToolStripMenuItem.Text = "Titulos"
        '
        'ListadoDeTitulosToolStripMenuItem
        '
        Me.ListadoDeTitulosToolStripMenuItem.Name = "ListadoDeTitulosToolStripMenuItem"
        Me.ListadoDeTitulosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListadoDeTitulosToolStripMenuItem.Text = "Listado de titulos"
        '
        'CargarDocumentosToolStripMenuItem
        '
        Me.CargarDocumentosToolStripMenuItem.Name = "CargarDocumentosToolStripMenuItem"
        Me.CargarDocumentosToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.CargarDocumentosToolStripMenuItem.Text = "Cargar Documentos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Opciones"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProfesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeMateriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrasOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTitulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarDocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
