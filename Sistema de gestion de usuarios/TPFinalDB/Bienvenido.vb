Public Class Bienvenido
    Dim contador As Integer
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.CenterToScreen()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
    End Sub


End Class
