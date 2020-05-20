Public Class Clave

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtclave.TextChanged
        Dim c90 As Integer
        c90 = "456123"
        If Len(txtclave.Text) = 6 Then
            If txtclave.Text = c90 Then
                MessageBox.Show("Clave Ingresada con exito, ingresando al sistema...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Opciones.ShowDialog()
            Else
                txtclave.SelectAll()
                txtclave.Focus()

                lbincorrecta.Visible = True
            End If

        Else

        End If
        If Len(txtclave.Text) = 0 Then
            lbincorrecta.Visible = False
        End If
    End Sub

    Private Sub Clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtclave.MaxLength = 6
        lbincorrecta.Visible = False

    End Sub

    Private Sub txtclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclave.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class