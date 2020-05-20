Module Conexion
    Private Const CadenaConexion As String = ("Data Source=TSP208\SQLEXPRESS;Initial Catalog=BD_SISTEMA1;User ID=UserCreator;Password=UserCreator")
    Public Function ABM(ByVal SQL As String)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand
        Try
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = CadenaConexion
            conexion.Open()
            comando = New SqlClient.SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function ConsultarDatos(ByVal SQL As String, ByRef Tabla As DataTable)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand
        Try
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = CadenaConexion
            conexion.Open()
            comando = New SqlClient.SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            Tabla = New DataTable
            Tabla.Load(comando.ExecuteReader)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public IDPersonaSel As Integer
    Public Accion As String
    Public WHO As String
    Public Todo As String
    Public Function consultamodificacion()
        Dim afirmativo As Boolean = False
        If Accion = "MOD" Then
            afirmativo = True
        Else
            afirmativo = False
        End If
        Return afirmativo
    End Function
End Module
