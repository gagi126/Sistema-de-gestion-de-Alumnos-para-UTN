Public Class ListadoMaterias
    Private Sub ListadoMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select cod_materia,desc_mat as 'Descripcion Materia',desc_carrera as 'Descripcion Carrera', profesores.ape_nomb as 'Profesor Asignado'from materias,profesores where materias.nro_legajo_p = profesores.nro_legajo_p", tabla)
        lvmaterias.DataSource = tabla
        lvmaterias.ReadOnly = True
        lvmaterias.AllowUserToAddRows = False
        lvmaterias.AllowUserToDeleteRows = False
        lvmaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        lvmaterias.RowHeadersVisible = False
        lvmaterias.Columns("cod_materia").Visible = False

    End Sub

    Private Sub Bntregistrar_Click(sender As Object, e As EventArgs) Handles bntregistrar.Click
        Materias.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If lvmaterias.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una materia para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "BAJA"
            WHO = "Materia"
            IDPersonaSel = lvmaterias.CurrentRow.Cells("cod_materia").Value
            BorrarSiNo.ShowDialog()
        End If

    End Sub

    Private Sub lvalumnos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select cod_materia,desc_mat as 'Descripcion Materia',desc_carrera as 'Descripcion Carrera', profesores.ape_nomb as 'Profesor Asignado'from materias,profesores where materias.nro_legajo_p = profesores.nro_legajo_p", tabla)
        lvmaterias.DataSource = tabla
        lvmaterias.Columns("cod_materia").Visible = False

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If lvmaterias.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una materia para modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "MOD"
            WHO = "Materia"
            IDPersonaSel = lvmaterias.CurrentRow.Cells("cod_materia").Value
            Materias.ShowDialog()
        End If

    End Sub
    Private Sub lvmaterias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvmaterias.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
            If lvmaterias.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar una materia para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Accion = "BAJA"
                WHO = "Materia"
                IDPersonaSel = lvmaterias.CurrentRow.Cells("cod_materia").Value
                BorrarSiNo.ShowDialog()
            End If
        End If

    End Sub



    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Lvmaterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvmaterias.CellContentClick

    End Sub
End Class
