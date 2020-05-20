Imports System.IO
Imports ExcelApp = Microsoft.Office.Interop.Excel
Public Class Reportes


    Private Sub Btalumnos_Click(sender As Object, e As EventArgs) Handles btalumnos.Click
        Dim tabla As DataTable
        tabla = New DataTable
        Dim variable As String
        ConsultarDatos("Select nro_legajo_a, ape_nomb ,tipo_doc.desc_doc, nro_doc, direccion,email, sexo , fec_nac,est_civil,telefono from Alumnos,tipo_doc where alumnos.cod_doc = tipo_doc.cod_doc", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay registros en el sistema.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            gb1.Visible = True
            pbprogre.Value = 0
            pbprogre.Minimum = 0
            pbprogre.Visible = True
            lblporcentaje.Visible = True
            pbprogre.Maximum = tabla.Rows.Count - 1
            Dim excel As ExcelApp.Application
            Dim libro As ExcelApp.Workbook
            Dim hoja As ExcelApp.Worksheet
            Dim guardar As New SaveFileDialog
            guardar.Title = "Reporte de Alumnos"
            guardar.Filter = "Listados (*.xlsx)|*.xlsx"
            guardar.InitialDirectory = "%homepath%\Documents"
            guardar.DefaultExt = "otz"
            guardar.AddExtension = True
            Dim contador As Integer = 2
            If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                excel = New ExcelApp.Application
                libro = excel.Workbooks.Add()
                hoja = libro.Worksheets.Add()
                hoja.Range("A1").Value = "Nro Legajo"
                hoja.Range("B1").Value = "Apellido y Nombre"
                hoja.Range("C1").Value = "Direccion"
                hoja.Range("D1").Value = "Email"
                hoja.Range("E1").Value = "Estado Civil"
                hoja.Range("F1").Value = "Fecha Nacimiento"
                hoja.Range("G1").Value = "Tipo Doc"
                hoja.Range("H1").Value = "Nro Doc"
                hoja.Range("I1").Value = "Sexo"
                hoja.Range("J1").Value = "Telefono"
                For aux = 0 To tabla.Rows.Count - 1
                    hoja.Range("A" + contador.ToString).Value = tabla.Rows(aux)("nro_legajo_a")
                    hoja.Range("B" + contador.ToString).Value = tabla.Rows(aux)("ape_nomb").Trim
                    hoja.Range("C" + contador.ToString).Value = tabla.Rows(aux)("direccion").Trim
                    hoja.Range("D" + contador.ToString).Value = tabla.Rows(aux)("email").Trim
                    hoja.Range("E" + contador.ToString).Value = tabla.Rows(aux)("est_civil").Trim
                    hoja.Range("F" + contador.ToString).Value = tabla.Rows(aux)("fec_nac")
                    hoja.Range("G" + contador.ToString).Value = tabla.Rows(aux)("desc_doc").Trim
                    hoja.Range("H" + contador.ToString).Value = CInt(tabla.Rows(aux)("nro_doc"))
                    hoja.Range("I" + contador.ToString).Value = tabla.Rows(aux)("sexo").Trim
                    hoja.Range("J" + contador.ToString).Value = tabla.Rows(aux)("telefono").Trim
                    contador = contador + 1
                    pbprogre.Increment(1)
                    pbprogre.Refresh()
                    variable = ("Exportando registros..." + CType(pbprogre.Value, String))
                    lblporcentaje.Text = variable
                    lblporcentaje.Refresh()
                Next
                libro.SaveAs(guardar.FileName)
                libro.Close()
                MessageBox.Show("Reporte creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            Else
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            End If
        End If
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        gb1.Visible = False
        pbprogre.Visible = False
        lblporcentaje.Visible = False
        lblporcentaje.Text = ""
    End Sub

    Private Sub Btnmaterias_Click(sender As Object, e As EventArgs) Handles btnmaterias.Click
        Dim tabla As DataTable
        tabla = New DataTable
        Dim variable As String
        ConsultarDatos("Select cod_materia,desc_mat,desc_carrera, profesores.ape_nomb from materias,profesores where materias.nro_legajo_p = profesores.nro_legajo_p", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay registros en el sistema.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            gb1.Visible = True
            pbprogre.Value = 0
            pbprogre.Minimum = 0
            pbprogre.Visible = True
            lblporcentaje.Visible = True
            pbprogre.Maximum = tabla.Rows.Count - 1
            Dim excel As ExcelApp.Application
            Dim libro As ExcelApp.Workbook
            Dim hoja As ExcelApp.Worksheet
            Dim guardar As New SaveFileDialog
            guardar.Title = "Reporte de Materias"
            guardar.Filter = "Listados (*.xlsx)|*.xlsx"
            guardar.InitialDirectory = "%homepath%\Documents"
            guardar.DefaultExt = "otz"
            guardar.AddExtension = True
            Dim contador As Integer = 2
            If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                pbprogre.Maximum = tabla.Rows.Count - 1
                excel = New ExcelApp.Application
                libro = excel.Workbooks.Add()
                hoja = libro.Worksheets.Add()
                hoja.Range("A1").Value = "Codigo Materia"
                hoja.Range("B1").Value = "Descripcion Materia"
                hoja.Range("C1").Value = "Descripcion Carrera"
                hoja.Range("D1").Value = "Profesor Asignado"
                For aux = 0 To tabla.Rows.Count - 1
                    hoja.Range("A" + contador.ToString).Value = tabla.Rows(aux)("cod_materia")
                    hoja.Range("B" + contador.ToString).Value = tabla.Rows(aux)("desc_mat").Trim
                    hoja.Range("C" + contador.ToString).Value = tabla.Rows(aux)("desc_carrera").Trim
                    hoja.Range("D" + contador.ToString).Value = tabla.Rows(aux)("ape_nomb").Trim
                    contador = contador + 1
                    pbprogre.Increment(1)
                    pbprogre.Refresh()
                    variable = ("Exportando registros..." + CType(pbprogre.Value, String))
                    lblporcentaje.Text = variable
                    lblporcentaje.Refresh()
                Next
                libro.SaveAs(guardar.FileName)
                libro.Close()
                MessageBox.Show("Reporte creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            Else
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            End If
        End If
    End Sub

    Private Sub Btnprofesores_Click(sender As Object, e As EventArgs) Handles btnprofesores.Click
        Dim tabla As DataTable
        tabla = New DataTable
        Dim variable As String
        ConsultarDatos("Select nro_legajo_p, ape_nomb, nro_doc, direccion,email, sexo, fec_nac,est_civil, titulos.desc_titulo from profesores,titulos where titulos.cod_titulo = profesores.cod_titulo", tabla)
        If tabla.Rows.Count = 0 Then
            MessageBox.Show("No hay registros en el sistema.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            gb1.Visible = True
            pbprogre.Value = 0
            pbprogre.Minimum = 0
            pbprogre.Visible = True
            lblporcentaje.Visible = True
            pbprogre.Maximum = tabla.Rows.Count - 1
            Dim excel As ExcelApp.Application
            Dim libro As ExcelApp.Workbook
            Dim hoja As ExcelApp.Worksheet
            Dim guardar As New SaveFileDialog
            guardar.Title = "Reporte de Profesores"
            guardar.Filter = "Listados (*.xlsx)|*.xlsx"
            guardar.InitialDirectory = "%homepath%\Documents"
            guardar.DefaultExt = "otz"
            guardar.AddExtension = True
            Dim contador As Integer = 2
            If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                excel = New ExcelApp.Application
                libro = excel.Workbooks.Add()
                hoja = libro.Worksheets.Add()
                hoja.Range("A1").Value = "Nro Legajo"
                hoja.Range("B1").Value = "Apellido y Nombre"
                hoja.Range("C1").Value = "Direccion"
                hoja.Range("D1").Value = "Email"
                hoja.Range("E1").Value = "Estado Civil"
                hoja.Range("F1").Value = "Fecha Nacimiento"
                hoja.Range("G1").Value = "Nro Doc"
                hoja.Range("H1").Value = "Sexo"
                hoja.Range("I1").Value = "Titulo"
                For aux = 0 To tabla.Rows.Count - 1
                    hoja.Range("A" + contador.ToString).Value = tabla.Rows(aux)("nro_legajo_p")
                    hoja.Range("B" + contador.ToString).Value = tabla.Rows(aux)("ape_nomb").Trim
                    hoja.Range("C" + contador.ToString).Value = tabla.Rows(aux)("direccion").Trim
                    hoja.Range("D" + contador.ToString).Value = tabla.Rows(aux)("email").Trim
                    hoja.Range("E" + contador.ToString).Value = tabla.Rows(aux)("est_civil").Trim
                    hoja.Range("F" + contador.ToString).Value = tabla.Rows(aux)("fec_nac")
                    hoja.Range("G" + contador.ToString).Value = CInt(tabla.Rows(aux)("nro_doc"))
                    hoja.Range("H" + contador.ToString).Value = tabla.Rows(aux)("sexo").Trim
                    hoja.Range("I" + contador.ToString).Value = tabla.Rows(aux)("desc_titulo").Trim
                    contador = contador + 1
                    pbprogre.Increment(1)
                    pbprogre.Refresh()
                    variable = ("Exportando registros..." + CType(pbprogre.Value, String))
                    lblporcentaje.Text = variable
                    lblporcentaje.Refresh()
                Next
                libro.SaveAs(guardar.FileName)
                libro.Close()
                MessageBox.Show("Reporte creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            Else
                gb1.Visible = False
                pbprogre.Visible = False
                pbprogre.Value = 0
                lblporcentaje.Text = ""
                lblporcentaje.Visible = False
            End If
        End If
    End Sub

    Private Sub Btntitulos_Click(sender As Object, e As EventArgs) Handles btntitulos.Click
        ConoSin.ShowDialog()
        Dim tabla As DataTable
        tabla = New DataTable
        Dim variable As String
        If Todo = "SI" Then
            ConsultarDatos("Select cod_titulo,desc_titulo from titulos", tabla)
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No hay registros en el sistema.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                gb1.Visible = True
                pbprogre.Value = 0
                pbprogre.Minimum = 0
                pbprogre.Visible = True
                lblporcentaje.Visible = True
                pbprogre.Maximum = tabla.Rows.Count - 1
                Dim excel As ExcelApp.Application
                Dim libro As ExcelApp.Workbook
                Dim hoja As ExcelApp.Worksheet
                Dim guardar As New SaveFileDialog
                guardar.Title = "Reporte de Titulos"
                guardar.Filter = "Reportes (*.xlsx)|*.xlsx"
                guardar.InitialDirectory = "%homepath%\Documents"
                guardar.DefaultExt = "otz"
                guardar.AddExtension = True
                Dim contador As Integer = 2
                If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                    excel = New ExcelApp.Application
                    libro = excel.Workbooks.Add()
                    hoja = libro.Worksheets.Add()
                    hoja.Range("A1").Value = "Codigo Titulo"
                    hoja.Range("B1").Value = "Descripcion Titulo"
                    For aux = 0 To tabla.Rows.Count - 1
                        hoja.Range("A" + contador.ToString).Value = tabla.Rows(aux)("cod_titulo")
                        hoja.Range("B" + contador.ToString).Value = tabla.Rows(aux)("desc_titulo").Trim
                        contador = contador + 1
                        pbprogre.Increment(1)
                        pbprogre.Refresh()
                        variable = ("Exportando registros..." + CType(pbprogre.Value, String))
                        lblporcentaje.Text = variable
                        lblporcentaje.Refresh()
                    Next
                    libro.SaveAs(guardar.FileName)
                    libro.Close()
                    MessageBox.Show("Reporte creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gb1.Visible = False
                    pbprogre.Visible = False
                    pbprogre.Value = 0
                    lblporcentaje.Text = ""
                    lblporcentaje.Visible = False
                Else
                    gb1.Visible = False
                    pbprogre.Visible = False
                    pbprogre.Value = 0
                    lblporcentaje.Text = ""
                    lblporcentaje.Visible = False
                End If

            End If

        Else
            ConsultarDatos("Select titulos.cod_titulo,desc_titulo,profesores.ape_nomb from titulos,profesores where profesores.cod_titulo = titulos.cod_titulo", tabla)
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No hay registros en el sistema.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                gb1.Visible = True
                pbprogre.Value = 0
                pbprogre.Minimum = 0
                pbprogre.Visible = True
                lblporcentaje.Visible = True
                pbprogre.Maximum = tabla.Rows.Count - 1
                Dim excel As ExcelApp.Application
                Dim libro As ExcelApp.Workbook
                Dim hoja As ExcelApp.Worksheet
                Dim guardar As New SaveFileDialog
                guardar.Title = "Reporte de Titulos"
                guardar.Filter = "Reportes (*.xlsx)|*.xlsx"
                guardar.InitialDirectory = "%homepath%\Documents"
                guardar.DefaultExt = "otz"
                guardar.AddExtension = True
                Dim contador As Integer = 2
                If guardar.ShowDialog = Windows.Forms.DialogResult.OK = True Then
                    excel = New ExcelApp.Application
                    libro = excel.Workbooks.Add()
                    hoja = libro.Worksheets.Add()
                    hoja.Range("A1").Value = "Codigo Titulo"
                    hoja.Range("B1").Value = "Descripcion Titulo"
                    hoja.Range("C1").Value = "Profesor Asignado"
                    For aux = 0 To tabla.Rows.Count - 1
                        hoja.Range("A" + contador.ToString).Value = tabla.Rows(aux)("cod_titulo")
                        hoja.Range("B" + contador.ToString).Value = tabla.Rows(aux)("desc_titulo").Trim
                        hoja.Range("C" + contador.ToString).Value = tabla.Rows(aux)("ape_nomb").Trim
                        contador = contador + 1
                        pbprogre.Increment(1)
                        pbprogre.Refresh()
                        variable = ("Exportando registros..." + CType(pbprogre.Value, String))
                        lblporcentaje.Text = variable
                        lblporcentaje.Refresh()
                    Next
                    libro.SaveAs(guardar.FileName)
                    libro.Close()
                    MessageBox.Show("Reporte creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    gb1.Visible = False
                    pbprogre.Visible = False
                    pbprogre.Value = 0
                    lblporcentaje.Text = ""
                    lblporcentaje.Visible = False
                Else
                    gb1.Visible = False
                    pbprogre.visible = False
                    pbprogre.Value = 0
                    lblporcentaje.Text = ""
                    lblporcentaje.Visible = False
                End If
            End If
        End If

    End Sub

End Class