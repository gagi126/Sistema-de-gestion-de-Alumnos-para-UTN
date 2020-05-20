Public Class ListadoProfesores

    Private Sub ListadoProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select nro_legajo_p as 'Nro Legajo', nro_legajo_p  , ape_nomb as 'Apellido y Nombre', nro_doc as 'Nro.Doc', direccion as 'Direccion',email as 'Email', sexo as 'Sexo', fec_nac as 'Fecha de Nacimiento',est_civil as 'Estado Civil', RTRIM(titulos.desc_titulo) as 'Titulo' from profesores,titulos where titulos.cod_titulo = profesores.cod_titulo", tabla)
        lvprofesores.DataSource = tabla
        lvprofesores.ReadOnly = True
        lvprofesores.AllowUserToAddRows = False
        lvprofesores.AllowUserToDeleteRows = False
        lvprofesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        lvprofesores.RowHeadersVisible = False
        lvprofesores.Columns("nro_legajo_p").Visible = False
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from tipo_doc", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se pueden cargar profesores debido a que no estan cargados los tipos de documento, por favor vuelva al menu principal y haga click sobre 'Cargar Documentos' y vuelva a intentarlo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        numero1 = tabla.Rows.Count
        ConsultarDatos("Select * from titulos", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("Para cargar un profesor debe contar con al menos un titulo cargado en el sistema, por favor realice la carga a traves del menu de 'Titulos'", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Else
        End If
        numero2 = tabla.Rows.Count
        If numero1 >= 1 And numero2 >= 1 Then
            Accion = "ALTA"
            WHO = "Profesor"
            Alumnos.ShowDialog()
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If lvprofesores.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un profesor para modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "MOD"
            WHO = "Profesor"
            IDPersonaSel = lvprofesores.CurrentRow.Cells("nro_legajo_p").Value
            Alumnos.ShowDialog()

        End If
    End Sub

    Private Sub lvprofesores_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select nro_legajo_p as 'Nro Legajo', nro_legajo_p  , ape_nomb as 'Apellido y Nombre', nro_doc as 'Nro.Doc', direccion as 'Direccion',email as 'Email', sexo as 'Sexo', fec_nac as 'Fecha de Nacimiento',est_civil as 'Estado Civil', RTRIM(titulos.desc_titulo) as 'Titulo' from profesores,titulos where titulos.cod_titulo = profesores.cod_titulo", tabla)
        lvprofesores.DataSource = tabla
        lvprofesores.Columns("nro_legajo_p").Visible = False

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If lvprofesores.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un profesor para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Accion = "BAJA"
            WHO = "Profesor"
            IDPersonaSel = lvprofesores.CurrentRow.Cells("nro_legajo_P").Value
            BorrarSiNo.ShowDialog()

        End If
    End Sub
    Private Sub lvprofesores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvprofesores.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
            If lvprofesores.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un profesor para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Accion = "BAJA"
                WHO = "Profesor"
                IDPersonaSel = lvprofesores.CurrentRow.Cells("nro_legajo_p").Value
                BorrarSiNo.ShowDialog()
            End If

        End If
    End Sub
End Class