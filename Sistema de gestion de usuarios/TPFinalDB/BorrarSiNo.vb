Public Class BorrarSiNo
    Private Sub BorrarSiNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Me.Close()
    End Sub

    Private Sub Btnsi_Click(sender As Object, e As EventArgs) Handles btnsi.Click
        If WHO = "Alumno" And Accion = "BAJA" Then
            If ABM("Delete from alumnos where nro_legajo_a =" & IDPersonaSel) = True Then
                MessageBox.Show("Registro eliminado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            Else
                MessageBox.Show("Ocurrio un error al eliminar el registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf WHO = "Profesor" And Accion = "BAJA" Then
            If ABM("Delete from profesores where nro_legajo_p =" & IDPersonaSel) = True Then
                MessageBox.Show("Registro eliminado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            Else
                MessageBox.Show("Ocurrio un error al eliminar el registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf WHO = "Materia" And Accion = "BAJA" Then

                If ABM("Delete from materias where cod_materia =" & IDPersonaSel) = True Then
                    MessageBox.Show("Registro eliminado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                Else
                    MessageBox.Show("Ocurrio un error al eliminar el registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            ElseIf WHO = "Titulo" And Accion = "BAJA" Then
                If ABM("Delete from titulos where cod_titulo =" & IDPersonaSel) = True Then
                MessageBox.Show("Registro eliminado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            Else
                MessageBox.Show("Ocurrio un error al eliminar el registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        End If

    End Sub
    Private Sub BorrarSiNo_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        Accion = "ALTA"
        WHO = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class