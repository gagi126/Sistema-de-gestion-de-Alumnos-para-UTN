Imports System.ComponentModel

Public Class Opciones
    Private Sub ListadoDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeAlumnosToolStripMenuItem.Click
        ListadoAlumnos.ShowDialog()
    End Sub

    Private Sub ListadoDeProfesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProfesoresToolStripMenuItem.Click
        ListadoProfesores.ShowDialog()
    End Sub

    Private Sub ListadoDeMateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeMateriasToolStripMenuItem.Click
        ListadoMaterias.ShowDialog()
    End Sub


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from tipo_doc", tabla)
        If tabla.Rows.Count = 0 Then
        Else
            CargarDocumentosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub ListadoDeTitulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTitulosToolStripMenuItem.Click
        ListadoTitulos.ShowDialog()
    End Sub



    Private Sub OtrasOpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrasOpcionesToolStripMenuItem.Click

    End Sub

    Private Sub CargarDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarDocumentosToolStripMenuItem.Click
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from tipo_doc", tabla)
        If tabla.Rows.Count = 0 Then
            ABM("Insert into tipo_doc (desc_doc) values ('DNI')")
            ABM("Insert into tipo_doc (desc_doc) values ('PASAPORTE')")
            ABM("Insert into tipo_doc (desc_doc) values ('OTRO')")
            MessageBox.Show("Carga exitosa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDocumentosToolStripMenuItem.Visible = False
        Else
            CargarDocumentosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click

    End Sub

    Private Sub Menu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()
        Dim tabla As DataTable
        tabla = New DataTable
        ConsultarDatos("Select * from tipo_doc", tabla)
        If tabla.Rows.Count = 0 Then
            CargarDocumentosToolStripMenuItem.Visible = True
        Else
            CargarDocumentosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub Opciones_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Clave.Close()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Reportes.ShowDialog()
    End Sub
End Class
