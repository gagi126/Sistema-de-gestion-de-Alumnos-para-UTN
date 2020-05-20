<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtapenomb = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.rdmasculino = New System.Windows.Forms.RadioButton()
        Me.rdfemenino = New System.Windows.Forms.RadioButton()
        Me.datefecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbtipodni = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.checksol = New System.Windows.Forms.CheckBox()
        Me.checkcasa = New System.Windows.Forms.CheckBox()
        Me.cmbtitulo = New System.Windows.Forms.ComboBox()
        Me.labeltitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtapenomb
        '
        Me.txtapenomb.Location = New System.Drawing.Point(121, 38)
        Me.txtapenomb.Name = "txtapenomb"
        Me.txtapenomb.Size = New System.Drawing.Size(200, 20)
        Me.txtapenomb.TabIndex = 0
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(121, 65)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(200, 20)
        Me.txtdireccion.TabIndex = 1
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(121, 119)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(200, 20)
        Me.txtemail.TabIndex = 3
        '
        'rdmasculino
        '
        Me.rdmasculino.AutoSize = True
        Me.rdmasculino.Location = New System.Drawing.Point(121, 156)
        Me.rdmasculino.Name = "rdmasculino"
        Me.rdmasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdmasculino.TabIndex = 4
        Me.rdmasculino.TabStop = True
        Me.rdmasculino.Text = "Masculino"
        Me.rdmasculino.UseVisualStyleBackColor = True
        '
        'rdfemenino
        '
        Me.rdfemenino.AutoSize = True
        Me.rdfemenino.Location = New System.Drawing.Point(217, 156)
        Me.rdfemenino.Name = "rdfemenino"
        Me.rdfemenino.Size = New System.Drawing.Size(71, 17)
        Me.rdfemenino.TabIndex = 5
        Me.rdfemenino.TabStop = True
        Me.rdfemenino.Text = "Femenino"
        Me.rdfemenino.UseVisualStyleBackColor = True
        '
        'datefecha
        '
        Me.datefecha.Location = New System.Drawing.Point(121, 190)
        Me.datefecha.Name = "datefecha"
        Me.datefecha.Size = New System.Drawing.Size(200, 20)
        Me.datefecha.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Apellido y Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nro Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo Doc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email"
        '
        'cmbtipodni
        '
        Me.cmbtipodni.FormattingEnabled = True
        Me.cmbtipodni.Location = New System.Drawing.Point(395, 91)
        Me.cmbtipodni.Name = "cmbtipodni"
        Me.cmbtipodni.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipodni.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sexo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Fecha Nac"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Estado Civil"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(121, 93)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(200, 20)
        Me.txtdni.TabIndex = 2
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(178, 324)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnregistrar.TabIndex = 10
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(121, 259)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(200, 20)
        Me.txttelefono.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Telefono"
        '
        'checksol
        '
        Me.checksol.AutoSize = True
        Me.checksol.Location = New System.Drawing.Point(121, 222)
        Me.checksol.Name = "checksol"
        Me.checksol.Size = New System.Drawing.Size(59, 17)
        Me.checksol.TabIndex = 7
        Me.checksol.Text = "Soltero"
        Me.checksol.UseVisualStyleBackColor = True
        '
        'checkcasa
        '
        Me.checkcasa.AutoSize = True
        Me.checkcasa.Location = New System.Drawing.Point(217, 221)
        Me.checkcasa.Name = "checkcasa"
        Me.checkcasa.Size = New System.Drawing.Size(62, 17)
        Me.checkcasa.TabIndex = 8
        Me.checkcasa.Text = "Casado"
        Me.checkcasa.UseVisualStyleBackColor = True
        '
        'cmbtitulo
        '
        Me.cmbtitulo.FormattingEnabled = True
        Me.cmbtitulo.Location = New System.Drawing.Point(158, 290)
        Me.cmbtitulo.Name = "cmbtitulo"
        Me.cmbtitulo.Size = New System.Drawing.Size(121, 21)
        Me.cmbtitulo.TabIndex = 24
        '
        'labeltitulo
        '
        Me.labeltitulo.AutoSize = True
        Me.labeltitulo.Location = New System.Drawing.Point(26, 293)
        Me.labeltitulo.Name = "labeltitulo"
        Me.labeltitulo.Size = New System.Drawing.Size(33, 13)
        Me.labeltitulo.TabIndex = 25
        Me.labeltitulo.Text = "Titulo"
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 375)
        Me.Controls.Add(Me.labeltitulo)
        Me.Controls.Add(Me.cmbtitulo)
        Me.Controls.Add(Me.checkcasa)
        Me.Controls.Add(Me.checksol)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbtipodni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datefecha)
        Me.Controls.Add(Me.rdfemenino)
        Me.Controls.Add(Me.rdmasculino)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtapenomb)
        Me.Name = "Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtapenomb As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents rdmasculino As RadioButton
    Friend WithEvents rdfemenino As RadioButton
    Friend WithEvents datefecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbtipodni As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents btnregistrar As Button
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents checksol As CheckBox
    Friend WithEvents checkcasa As CheckBox
    Friend WithEvents cmbtitulo As ComboBox
    Friend WithEvents labeltitulo As Label
End Class
