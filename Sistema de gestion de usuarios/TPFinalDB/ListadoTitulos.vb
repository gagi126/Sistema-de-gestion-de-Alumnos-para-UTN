Imports System.ComponentModel

Public Class ListadoTitulos
    Private Sub ListadoTitulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select cod_titulo as 'Codigo Titulo', cod_titulo , RTRIM(desc_titulo) as 'Descripcion' from titulos", tabla)
        If tabla.Rows.Count = 0 Then
            lbnohay.Visible = True
        Else
            lbnohay.Visible = False
        End If
        lvtitulos.DataSource = tabla
        lvtitulos.ReadOnly = True
        lvtitulos.AllowUserToAddRows = False
        lvtitulos.AllowUserToDeleteRows = False
        lvtitulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        lvtitulos.RowHeadersVisible = False
        lvtitulos.Columns("cod_titulo").Visible = False
        txtdesctitulo.Visible = False
        lbtitulo.Visible = False
        txtdesctitulo.MaxLength = "100"
    End Sub
    Private Sub lvtitulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvtitulos.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
            If lvtitulos.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar un titulo para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Accion = "BAJA"
                WHO = "Titulo"
                IDPersonaSel = lvtitulos.CurrentRow.Cells("cod_titulo").Value
                BorrarSiNo.ShowDialog()
            End If
        End If
    End Sub
    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Accion = "Alta"
        txtdesctitulo.Visible = True
        lbtitulo.Visible = True
        btnnuevo.Text = "Registrar Titulo"
        If txtdesctitulo.Text.Trim <> "" Then
            If consultamodificacion() = True Then
                'aca ocurre si esta en MODO "MOD" 
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select cod_titulo from titulos where desc_titulo='" & txtdesctitulo.Text & "' and cod_titulo <> " & IDPersonaSel, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("Update titulos set desc_titulo= '" & txtdesctitulo.Text & "'where cod_titulo=" & IDPersonaSel)
                    MessageBox.Show("Datos actualizados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnnuevo.Text = "Cargar Nuevo Titulo"
                    txtdesctitulo.Text = ""
                Else
                    MessageBox.Show("La materia ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'aca ocurre en modo alta
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select cod_titulo from titulos where desc_titulo='" & txtdesctitulo.Text & "'", tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("insert into titulos (desc_titulo) values('" & txtdesctitulo.Text & "')")
                    MessageBox.Show("Datos grabados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnnuevo.Text = "Cargar Nuevo Titulo"
                    txtdesctitulo.Text = ""
                Else
                    MessageBox.Show("La materia ya existe ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            txtdesctitulo.Focus()
        End If

    End Sub

    Private Sub ListadoTitulos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Accion = "Alta"
        txtdesctitulo.Text = ""
        btnnuevo.Text = "Cargar Nuevo Titulo"
    End Sub
    Private Sub lvalumnos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select cod_titulo as 'Codigo Titulo', cod_titulo , RTRIM(desc_titulo) as 'Descripcion' from titulos", tabla)
        lvtitulos.DataSource = tabla
        lvtitulos.Columns("cod_titulo").Visible = False
        If tabla.Rows.Count = 0 Then
            lbnohay.Visible = True
        Else
            lbnohay.Visible = False
        End If
    End Sub
End Class