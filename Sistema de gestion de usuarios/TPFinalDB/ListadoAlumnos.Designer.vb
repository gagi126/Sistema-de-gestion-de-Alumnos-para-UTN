<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoAlumnos
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
        Me.components = New System.ComponentModel.Container()
        Me.lvalumnos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNAlta = New System.Windows.Forms.Button()
        Me.BD_SISTEMA1Dataset = New TPFinalDB.BD_SISTEMA1DataSet()
        CType(Me.lvalumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.BD_SISTEMA1Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'lvalumnos
        '
        Me.lvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvalumnos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvalumnos.Location = New System.Drawing.Point(24, 63)
        Me.lvalumnos.Name = "lvalumnos"
        Me.lvalumnos.Size = New System.Drawing.Size(778, 197)
        Me.lvalumnos.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 48)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar "
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'BTNAlta
        '
        Me.BTNAlta.Location = New System.Drawing.Point(830, 142)
        Me.BTNAlta.Name = "BTNAlta"
        Me.BTNAlta.Size = New System.Drawing.Size(75, 23)
        Me.BTNAlta.TabIndex = 1
        Me.BTNAlta.Text = "Nuevo Alumno"
        Me.BTNAlta.UseVisualStyleBackColor = True
        '
        'BD_SISTEMA1Dataset
        '
        Me.BD_SISTEMA1Dataset.DataSetName = "BD_SISTEMA1Dataset"
        Me.BD_SISTEMA1Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 302)
        Me.Controls.Add(Me.BTNAlta)
        Me.Controls.Add(Me.lvalumnos)
        Me.Name = "ListadoAlumnos"
        Me.Text = "Listado de Alumnos"
        CType(Me.lvalumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BD_SISTEMA1Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvalumnos As DataGridView
    Friend WithEvents BTNAlta As Button
    Friend WithEvents BD_SISTEMA1Dataset As BD_SISTEMA1DataSet
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
