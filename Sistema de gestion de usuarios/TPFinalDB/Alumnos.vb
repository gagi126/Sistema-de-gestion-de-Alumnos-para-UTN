Imports System.Text.RegularExpressions
Public Class Alumnos
    Dim sexo As String
    Dim estadocivil As String
    Private Sub Cmbtipodni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipodni.SelectedIndexChanged
        If cmbtipodni.SelectedIndex = 0 Then
            txtdni.MaxLength = 8
            If CInt(Len(txtdni.Text)) = 8 Then
            Else
                txtdni.Focus()
            End If
        End If
    End Sub

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        txtapenomb.Focus()
        Dim tabla As DataTable
        tabla = New DataTable
        txtapenomb.MaxLength = 30
        txtdireccion.MaxLength = 50
        txtemail.MaxLength = 20
        txttelefono.MaxLength = 8
        If consultamodificacion() = True And WHO = "Alumno" Then
            ConsultarDatos("Select * from tipo_doc", tabla)
            cmbtipodni.DataSource = tabla
            cmbtipodni.DisplayMember = "desc_doc"
            cmbtipodni.ValueMember = "cod_doc"
            cmbtipodni.DropDownStyle = ComboBoxStyle.DropDownList
            ConsultarDatos("Select * from alumnos where alumnos.nro_legajo_a=" & IDPersonaSel, tabla)
            txtapenomb.Text = tabla.Rows(0)("ape_nomb").Trim
            txtdireccion.Text = tabla.Rows(0)("direccion").Trim
            txtdni.Text = tabla.Rows(0)("nro_doc")
            txtemail.Text = tabla.Rows(0)("email").Trim
            txttelefono.Text = tabla.Rows(0)("telefono").Trim
            If tabla.Rows(0)("sexo") = "M" Then
                rdmasculino.Checked = True
            Else
                rdfemenino.Checked = True
            End If
            cmbtipodni.SelectedValue = tabla.Rows(0)("cod_doc")
            estadoc(tabla.Rows(0)("est_civil").Trim)
            Date.TryParse(tabla.Rows(0)("fec_nac"), datefecha.Value)
            labeltitulo.Visible = False
            cmbtitulo.Visible = False
        ElseIf WHO = "Alumno" Then
            ConsultarDatos("Select * from tipo_doc", tabla)
            cmbtipodni.DataSource = tabla
            cmbtipodni.DisplayMember = "desc_doc"
            cmbtipodni.ValueMember = "cod_doc"
            cmbtipodni.DropDownStyle = ComboBoxStyle.DropDownList
            rdmasculino.Checked = True
            checksol.Checked = True
            datefecha.Value = Today()
            cmbtipodni.SelectedIndex = 0
            labeltitulo.Visible = False
            cmbtitulo.Visible = False
        ElseIf consultamodificacion() = True And WHO = "Profesor" Then
            ConsultarDatos("Select * from titulos", tabla)
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("Para cargar/modificar un profesor debe contar al menos con un titulo cargado en el sistema. Por favor cargue el titulo e intentelo de nuevo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
            ConsultarDatos("Select * from tipo_doc", tabla)
            cmbtipodni.DataSource = tabla
            cmbtipodni.DisplayMember = "desc_doc"
            cmbtipodni.ValueMember = "cod_doc"
            cmbtipodni.DropDownStyle = ComboBoxStyle.DropDownList
            ConsultarDatos("Select * from titulos", tabla)
            cmbtitulo.DataSource = tabla
            cmbtitulo.DisplayMember = "desc_titulo"
            cmbtitulo.ValueMember = "cod_titulo"
            cmbtitulo.DropDownStyle = ComboBoxStyle.DropDownList
            ConsultarDatos("Select * from profesores where profesores.nro_legajo_p=" & IDPersonaSel, tabla)
            txtapenomb.Text = tabla.Rows(0)("ape_nomb").Trim
            txtdireccion.Text = tabla.Rows(0)("direccion").Trim
            txtdni.Text = tabla.Rows(0)("nro_doc")
            txtemail.Text = tabla.Rows(0)("email").Trim
            txttelefono.Text = tabla.Rows(0)("telefono").Trim
            If tabla.Rows(0)("sexo") = "M" Then
                rdmasculino.Checked = True
            Else
                rdfemenino.Checked = True
            End If
            cmbtipodni.SelectedValue = tabla.Rows(0)("cod_doc")
            estadoc(tabla.Rows(0)("est_civil").Trim)
            Date.TryParse(tabla.Rows(0)("fec_nac"), datefecha.Value)
            cmbtitulo.SelectedValue = tabla.Rows(0)("cod_titulo")
        ElseIf WHO = "Profesor" Then
            ConsultarDatos("Select * from titulos", tabla)
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("Para cargar/modificar un profesor debe contar al menos con un titulo cargado en el sistema. Por favor cargue el titulo e intentelo de nuevo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
            ConsultarDatos("Select * from tipo_doc", tabla)
            cmbtipodni.DataSource = tabla
            cmbtipodni.DisplayMember = "desc_doc"
            cmbtipodni.ValueMember = "cod_doc"
            cmbtipodni.DropDownStyle = ComboBoxStyle.DropDownList
            ConsultarDatos("Select * from titulos", tabla)
            cmbtitulo.DataSource = tabla
            cmbtitulo.DisplayMember = "desc_titulo"
            cmbtitulo.ValueMember = "cod_titulo"
            cmbtitulo.DropDownStyle = ComboBoxStyle.DropDownList
            rdmasculino.Checked = True
            checksol.Checked = True
            datefecha.Value = Today()
            cmbtipodni.SelectedIndex = 0
            labeltitulo.Visible = True
            cmbtitulo.Visible = True
        End If
    End Sub

    Public Function estadoc(cadena As String)
        If cadena = "Soltero" Then
            checksol.Checked = True
            checkcasa.Enabled = False
            Return cadena
        ElseIf cadena = "Casado" Then
            checkcasa.Checked = True
            checksol.Enabled = False
            Return cadena
        End If

        Return cadena
    End Function
    Private Function esvalido()
        Dim afirmativo As Boolean = False
        If txtapenomb.Text.Trim <> "" Then
            If txtdireccion.Text.Trim <> "" Then
                If txtdni.Text.Trim <> "" Then
                    If checkcasa.Checked = False Or checksol.Checked = False Then
                        If validar_Mail(LCase(txtemail.Text)) = True Or txtemail.Text.Trim = "" Then
                            If rdfemenino.Checked = True Then
                                sexo = "F"
                            ElseIf rdmasculino.Checked = True Then
                                sexo = "M"
                            End If
                            afirmativo = True
                        Else
                            MessageBox.Show("Dirección de correo electronico no valida,el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtemail.Focus()
                            txtemail.SelectAll()
                        End If
                    Else
                        MessageBox.Show("Debe seleccionar un estado civil", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("El campo DNI no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtdni.Focus()
                End If
            Else
                MessageBox.Show("El campo Direccion no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtdireccion.Focus()
            End If
        Else
            MessageBox.Show("El campo Apellido y Nombre no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtapenomb.Focus()
        End If
        Return afirmativo
    End Function

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
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

    Private Sub Btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If esvalido() = True And WHO = "Alumno" Then
            If consultamodificacion() = True Then
                'aca ocurre si esta en MODO "MOD" 
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select nro_doc from alumnos where nro_doc=" & txtdni.Text & " and nro_legajo_a <> " & IDPersonaSel, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("Update alumnos set ape_nomb= '" & txtapenomb.Text & "', direccion = '" & txtdireccion.Text & "', email = '" & txtemail.Text & "',est_civil = '" & estadocivil & "', fec_nac = '" & datefecha.Value.ToShortDateString & "',cod_doc = " & cmbtipodni.SelectedValue & ", nro_doc = '" & txtdni.Text & "', sexo = '" & sexo & "', telefono = '" & txttelefono.Text & "' where nro_legajo_a =" & IDPersonaSel)
                    MessageBox.Show("Datos actualizados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("El numero de documento ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'aca ocurre en modo alta
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select nro_doc from alumnos where nro_doc=" & txtdni.Text, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("insert into alumnos (ape_nomb,direccion,email,est_civil,fec_nac,cod_doc,nro_doc,sexo,telefono) values('" & txtapenomb.Text & "','" & txtdireccion.Text & "','" & txtemail.Text & "','" & estadocivil & "','" & datefecha.Value.ToShortDateString & "'," & cmbtipodni.SelectedValue & ",'" & txtdni.Text & "','" & sexo & "','" & txttelefono.Text & "')")
                    MessageBox.Show("Datos grabados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'ABM("Insert into alumnos (ape_nomb,direccion,email,est_civil,fec_nac,cod_doc,nro_doc,sexo,telefono) values ('" & txtapenomb.Text & "','" & txtdireccion.Text & "','" & txtemail.Text & "'," & cmbestadocivil.Text & ",'" & datefecha.Value.ToShortDateString & "'," & cmbtipodni.SelectedValue & ",'" & txtdni.Text & "'," & sexo & ",'" & txttelefono.Text & "')")
                    Me.Close()
                Else
                    MessageBox.Show("El numero de documento ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        ElseIf esvalido() = True And WHO = "Profesor" Then

            If consultamodificacion() = True Then
                'aca ocurre si esta en MODO "MOD" 
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select nro_doc from profesores where nro_doc=" & txtdni.Text & " and nro_legajo_p <> " & IDPersonaSel, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("Update profesores set ape_nomb= '" & txtapenomb.Text & "', direccion = '" & txtdireccion.Text & "', email = '" & txtemail.Text & "',est_civil = '" & estadocivil & "', fec_nac = '" & datefecha.Value.ToShortDateString & "',cod_doc = " & cmbtipodni.SelectedValue & ", nro_doc = '" & txtdni.Text & "', sexo = '" & sexo & "', telefono = '" & txttelefono.Text & "', cod_titulo =" & cmbtitulo.SelectedValue & "  where nro_legajo_p =" & IDPersonaSel)
                    MessageBox.Show("Datos actualizados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("El numero de documento ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'aca ocurren en modo alta
                Dim tabla As DataTable
                tabla = New DataTable
                ConsultarDatos("Select nro_doc from profesores where nro_doc=" & txtdni.Text, tabla)
                If tabla.Rows.Count = 0 Then
                    ABM("insert into profesores (ape_nomb,direccion,email,est_civil,fec_nac,cod_doc,nro_doc,sexo,telefono,cod_titulo) values('" & txtapenomb.Text & "','" & txtdireccion.Text & "','" & txtemail.Text & "','" & estadocivil & "','" & datefecha.Value.ToShortDateString & "'," & cmbtipodni.SelectedValue & ",'" & txtdni.Text & "','" & sexo & "','" & txttelefono.Text & "'," & cmbtitulo.SelectedValue & ")")
                    MessageBox.Show("Datos grabados con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("El numero de documento ya existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            MessageBox.Show("Ha ocurrido un error.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
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
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail,
                  "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub txtapenomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapenomb.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Checksol_CheckedChanged(sender As Object, e As EventArgs) Handles checksol.CheckedChanged
        If checksol.Checked = True Then
            checkcasa.Enabled = False
            estadocivil = "Soltero"
        End If
        If checksol.Checked = False Then
            checkcasa.Enabled = True
        End If
    End Sub

    Private Sub Checkcasa_CheckedChanged(sender As Object, e As EventArgs) Handles checkcasa.CheckedChanged
        If checkcasa.Checked = True Then
            checksol.Enabled = False
            estadocivil = "Casado"
        End If
        If checkcasa.Checked = False Then
            checksol.Enabled = True
        End If
    End Sub

    Private Sub Alumnos_FormClosed(sender As Object, e As EventArgs) Handles Me.FormClosed
        txtapenomb.Text = ""
        txtdireccion.Text = ""
        txtdni.Text = ""
        txtemail.Text = ""
        txttelefono.Text = ""
        cmbtipodni.SelectedIndex = 0
        rdmasculino.Checked = True
        checkcasa.Checked = False
        checksol.Checked = False
        Accion = "ALTA"
        WHO = ""
    End Sub


End Class
