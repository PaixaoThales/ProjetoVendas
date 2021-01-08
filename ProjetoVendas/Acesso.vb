
Public Class Acesso
    Private objConexao As SqlClient.SqlConnection
    Private objCommand As New SqlClient.SqlCommand
    Private conexao As String = ""

    Public Function exibirConexao() As String
        Return conexao
    End Function
    Public Sub New()
        lerConexao()
    End Sub
    Public Sub lerConexao()
        Try
            Dim ds As New DataSet
            ds.ReadXml(Application.StartupPath & "/Configurações/confgBanco.xml")
            Dim dtb As New DataTable
            dtb = ds.Tables(0)
            conexao = "server=" & dtb.Rows(0).Item("Servidor") & ";Initial Catalog=" & dtb.Rows(0).Item("Banco") & ";"
            If dtb.Rows(0).Item("AutWindows") Then
                conexao &= "Integrated Security=true"
            Else
                conexao &= "PWD=" & dtb.Rows(0).Item("Senha") & ";UID=" & dtb.Rows(0).Item("Usuario")
            End If
        Catch ex As Exception
            conexao = "server=L3CORE511; Initial Catalog=dbVendas; PWD=etec; UID=sa"
        End Try
    End Sub
    Public Function testarConexao() As Boolean
        Try
            conectar()
            Dim retorno As Boolean = False
            If Not IsNothing(objConexao) Then
                If objConexao.State = ConnectionState.Open Then
                    retorno = True
                End If
            End If
            fechar()
            Return retorno
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub conectar()
        Try
            'objConexao = New SqlClient.SqlConnection("server=MARIA-PC\SQLEXPRESS; Initial Catalog=dbVendas; Integrated Security=true;")
            'objConexao = New SqlClient.SqlConnection("server=L3CORE511; Initial Catalog=dbVendas; PWD=etec; UID=sa")
            objConexao = New SqlClient.SqlConnection(conexao)
            objConexao.Open()
            objCommand = objConexao.CreateCommand
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar com o Banco de Dados. " & ex.Message, "Conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub fechar()
        Try
            If Not IsNothing(objConexao) Then
                If objConexao.State = ConnectionState.Open Then
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao fechar a instância do Banco de Dados. " & ex.Message, "Conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function executeQuery(ByVal command As String) As DataTable
        Dim ds As New DataTable
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Try
            objCommand.CommandText = command
            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(ds)
            objCommand.Parameters.Clear()
        Catch ex As Exception
            MessageBox.Show("Erro na query. " & ex.Message, "Conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function
    Public Sub adicionaParametros(ByVal nome As String, ByVal tipoDado As SqlDbType, ByVal valor As String, Optional ByVal tamanho As Integer = 0)
        Try
            Dim parametro As New SqlClient.SqlParameter
            parametro.ParameterName = nome
            parametro.SqlDbType = tipoDado
            parametro.Value = valor
            If tipoDado = SqlDbType.Char Or tipoDado = SqlDbType.VarChar Then
                parametro.Size = tamanho
            End If
            objCommand.Parameters.Add(parametro)
        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar paramentros. " & ex.Message, "Conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class