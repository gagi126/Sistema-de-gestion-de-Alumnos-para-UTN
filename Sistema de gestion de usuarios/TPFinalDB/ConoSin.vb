Public Class ConoSin
    Private Sub btntodo_Click(sender As Object, e As EventArgs) Handles btntodo.Click
        Todo = "SI"
        Me.Close()
    End Sub

    Private Sub Btnsolos_Click(sender As Object, e As EventArgs) Handles btnsolos.Click
        Todo = "NO"
        Me.Close()
    End Sub

    Private Sub ConoSin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class