Imports System.ComponentModel

Public Class Materias
    Private Sub Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from profesores", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No se puede cargar ninguna materia porque no hay profesores cargados en los registros, por favor cargue profesores al registro y vuelva a intentarlo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        If consultamodificacion() = True And WHO = "Materia" Then
            ConsultarDatos("Select * from profesores", tabla)
            cmbprofesor.DataSource = tabla
            cmbprofesor.ValueMember = ("nro_legajo_p")
            cmbprofesor.DisplayMember = ("ape_nomb")
            cmbprofesor.DropDownStyle = ComboBoxStyle.DropDownList
            ConsultarDatos("Select * from materias where cod_materia=" & IDPersonaSel, tabla)
            txtdescmat.Text = tabla.Rows(0)("desc_mat").Trim
            txtdesccarrera.Text = tabla.Rows(0)("desc_carrera").Trim
            cmbprofesor.SelectedValue = tabla.Rows(0)("nro_legajo_p")
        ElseIf consultamodificacion() = False Then
            ConsultarDatos("Select * from profesores", tabla)
            cmbprofesor.DataSource = tabla
            cmbprofesor.ValueMember = ("nro_legajo_p")
            cmbprofesor.DisplayMember = ("ape_nomb")
            cmbprofesor.SelectedItem = 0
            cmbprofesor.DropDownStyle = ComboBoxStyle.DropDownList
        End If
        txtdesccarrera.MaxLength = "60"
        txtdescmat.MaxLength = "60"
    End Sub

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If esvalido() = True Then
            If consultamodificacion() = True Then
                'aca ocurre si esta en MODO "MOD" 
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select cod_materia from materias where desc_mat='" & txtdescmat.Text & "' and cod_materia <> " & IDPersonaSel, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("Update materias set desc_mat= '" & txtdescmat.Text & "', desc_carrera = '" & txtdesccarrera.Text & "', nro_legajo_p = " & cmbprofesor.SelectedValue & " where cod_materia=" & IDPersonaSel)
                    MessageBox.Show("Datos actualizados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("La materia ya existe en los registros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'aca ocurre en modo alta
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select cod_materia from materias where desc_mat='" & txtdescmat.Text & "'", tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("insert into materias (desc_mat,desc_carrera,nro_legajo_p) values ('" & txtdescmat.Text & "','" & txtdesccarrera.Text & "'," & cmbprofesor.SelectedValue & ")")
                    MessageBox.Show("Datos grabados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("La materia ya existe en los registros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

    End Sub

    Private Sub Materias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtdesccarrera.Text = ""
        txtdescmat.Text = ""
        cmbprofesor.SelectedValue = 0
        Accion = "ALTA"
    End Sub

    Private Function esvalido() As Boolean
        Dim afirmativo As Boolean = False
        If txtdesccarrera.Text.Trim <> "" Then
            If txtdescmat.Text.Trim <> "" Then
                afirmativo = True
            Else
                MessageBox.Show("El campo descripcion materia no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("El campo descripcion carrera no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return afirmativo
    End Function

End Class