Public Class ListadoAlumnos
    Private Sub ListadoAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select nro_legajo_a as 'Nro Legajo', nro_legajo_a  , ape_nomb as 'Apellido y Nombre', nro_doc as 'Nro.Doc', direccion as 'Direccion',email as 'Email', sexo as 'Sexo', fec_nac as 'Fecha de Nacimiento',est_civil as 'Estado Civil' from Alumnos", tabla)
        lvalumnos.DataSource = tabla
        lvalumnos.ReadOnly = True
        lvalumnos.AllowUserToAddRows = False
        lvalumnos.AllowUserToDeleteRows = False
        lvalumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        lvalumnos.RowHeadersVisible = False
        lvalumnos.Columns("nro_legajo_a").Visible = False
    End Sub

    Private Sub BTNAlta_Click(sender As Object, e As EventArgs) Handles BTNAlta.Click
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from tipo_doc", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se pueden cargar alumnos debido a que no estan cargados los tipos de documento, por favor vuelva al menu principal y haga click sobre 'Cargar Documentos' y vuelva a intentarlo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
            WHO = "Alumno"
            Alumnos.ShowDialog()
        End If
    End Sub

    Private Sub lvalumnos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select nro_legajo_a as 'Nro Legajo' ,nro_legajo_a , ape_nomb as 'Apellido y Nombre', nro_doc as 'Nro.Doc', direccion as 'Direccion',email as 'Email', sexo as 'Sexo', fec_nac as 'Fecha de Nacimiento',est_civil as 'Estado Civil' from Alumnos", tabla)
        lvalumnos.DataSource = tabla
        lvalumnos.Columns("nro_legajo_a").Visible = False

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If lvalumnos.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un alumno para modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "MOD"
            WHO = "Alumno"
            IDPersonaSel = lvalumnos.CurrentRow.Cells("nro_legajo_a").Value
            Alumnos.ShowDialog()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If lvalumnos.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un alumno para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "BAJA"
            WHO = "Alumno"
            IDPersonaSel = lvalumnos.CurrentRow.Cells("nro_legajo_a").Value
            BorrarSiNo.ShowDialog()

        End If
    End Sub
    Private Sub lvalumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvalumnos.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
            If lvalumnos.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un alumno para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Accion = "BAJA"
                WHO = "Alumno"
                IDPersonaSel = lvalumnos.CurrentRow.Cells("nro_legajo_a").Value
                BorrarSiNo.ShowDialog()
            End If

        End If
    End Sub

End Class