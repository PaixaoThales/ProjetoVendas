Imports System.IO

Public Class frmConfigConexao
    Private objBanco As Acesso = New Acesso
    Private Sub ckbAutWindows_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAutWindows.CheckedChanged
        If ckbAutWindows.Checked Then
            txtUsuario.Enabled = False
            txtSenha.Enabled = False
        Else
            txtUsuario.Enabled = True
            txtSenha.Enabled = True
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If txtBanco.Text <> "" And txtServidor.Text <> "" Then
            Try
                Dim dtb As New DataTable("ConexaoBanco")
                Dim colServidor As DataColumn = New DataColumn("Servidor", GetType(String))
                Dim colBanco As DataColumn = New DataColumn("Banco", GetType(String))
                Dim colAutWindow As DataColumn = New DataColumn("AutWindows", GetType(Boolean))
                Dim colSenha As DataColumn = New DataColumn("Senha", GetType(String))
                Dim colUsuario As DataColumn = New DataColumn("Usuario", GetType(String))

                dtb.Columns.Add(colServidor)
                dtb.Columns.Add(colBanco)
                dtb.Columns.Add(colAutWindow)
                dtb.Columns.Add(colSenha)
                dtb.Columns.Add(colUsuario)

                Dim linha As DataRow
                linha = dtb.NewRow()
                linha.Item("Servidor") = txtServidor.Text
                linha.Item("Banco") = txtBanco.Text
                linha.Item("AutWindows") = ckbAutWindows.Checked
                If ckbAutWindows.Checked Then
                    linha.Item("Senha") = "Vazio"
                    linha.Item("Usuario") = "Vazio"
                Else
                    linha.Item("Senha") = txtSenha.Text
                    linha.Item("Usuario") = txtUsuario.Text
                End If

                dtb.Rows.Add(linha)

                Dim ds As New DataSet
                ds.Tables.Add(dtb)
                ds.WriteXml(Application.StartupPath & "/Configurações/confgBanco.xml")
                MessageBox.Show("Configurações salvas com sucesso!!!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Configurações salvas não salvas." & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            MessageBox.Show("Preencha os campos 'Servidor' e 'Senha'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTestar_Click(sender As Object, e As EventArgs) Handles btnTestar.Click
        If File.Exists(Application.StartupPath & "/Configurações/confgBanco.xml") Then
            objBanco.lerConexao()
            If objBanco.testarConexao Then
                MessageBox.Show("Conexão foi estabelecida com sucesso!!!", "Teste de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Grave as informações do banco e servidor primeiro", "Conexão banco", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnStringConexao_Click(sender As Object, e As EventArgs) Handles btnStringConexao.Click
        If File.Exists(Application.StartupPath & "/Configurações/confgBanco.xml") Then
            objBanco.lerConexao()
            MessageBox.Show(objBanco.exibirConexao, "String de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Grave as informações do banco e servidor primeiro", "Conexão banco", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmConfigConexao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexao, auxiliario As String()
        Dim texto() As String = {" ", " ", " ", " ", " "}
        conexao = objBanco.exibirConexao.Split(";")
        Dim auxiliar As String
        For i As Integer = 0 To conexao.Length - 1
            auxiliar = conexao(i)
            auxiliario = auxiliar.Split("=")
            For c As Integer = 0 To auxiliario.Length - 1
                If c Mod 2 <> 0 Then
                    texto(i) = auxiliario(c)
                End If
            Next
        Next
        txtServidor.Text = texto(0)
        txtBanco.Text = texto(1)
        ckbAutWindows.Checked = texto(2)
        txtUsuario.Text = texto(3)
        txtUsuario.Text = texto(4)
    End Sub
End Class