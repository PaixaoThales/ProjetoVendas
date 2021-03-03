Imports System.Net
Imports System.Net.Mail
Public Class Login
    Private objBanco As New Acesso
    Private codigoRecuperarSenha As String
    Private dt As DataTable
    Private dtb As DataTable
    Public Function getCodigoRecuperarSenha()
        Return codigoRecuperarSenha
    End Function
    Private Sub setCodigoRecuperarSenha()
        Static rand As New Random
        Dim senha As New System.Text.StringBuilder(9)
        For i As Integer = 1 To 9
            Dim index As Integer
            Do
                index = rand.Next(48, 123)
            Loop Until (index >= 48 AndAlso index <= 57) OrElse (index >= 65 AndAlso index <= 90) OrElse (index >= 97 AndAlso index <= 122)
            senha.Append(Convert.ToChar(index))
        Next
        codigoRecuperarSenha = senha.ToString
    End Sub
    Private Function EnviarEmail(ByVal emailDestino As String, ByVal NomeUsuario As String, ByVal codigo As String) As Boolean
        Dim objEnvio As SmtpClient = Nothing
        Dim objEmail As MailMessage = Nothing
        Dim blnRetorno As Boolean = False
        Try
            objEnvio = New SmtpClient("smtp.gmail.com", 587)
            objEmail = New MailMessage
            objEmail.To.Add(New MailAddress(emailDestino, NomeUsuario))
            objEmail.From = New MailAddress("testedeemailemail@gmail.com", "Projeto Vendas")
            objEmail.Priority = MailPriority.High
            objEmail.Headers.Add("Disposition-Notification-To", emailDestino)
            Dim messagem As AlternateView = AlternateView.CreateAlternateViewFromString("Utilize esse código: " & codigo, Nothing, Mime.MediaTypeNames.Text.Plain)
            objEmail.Subject = "Recuperação de senha"
            objEmail.AlternateViews.Add(messagem)
            Dim credencial As New NetworkCredential("testedeemailemail@gmail.com", "")
            objEnvio.Credentials = credencial
            objEnvio.EnableSsl = True
            objEnvio.Send(objEmail)
            blnRetorno = True
        Catch ex As Exception
            Biblioteca.exibirNotificacao("Envio de email", "Erro ao enviar o Email! Verifique o email cadastrado, ou a disponibilidade do serviço. Erro: " & ex.Message, "Erro")
        Finally
            objEmail = Nothing
            objEnvio = Nothing
        End Try
        Return blnRetorno
    End Function
    Public Function logar() As Boolean
        Dim retorno As Boolean = False
        objBanco.conectar()
        objBanco.adicionaParametros("@login", SqlDbType.VarChar, frmLogin.txtNome.Text, 20)
        objBanco.adicionaParametros("@senha", SqlDbType.VarChar, Biblioteca.Criptografar(frmLogin.txtSenha.Text), 32)
        dt = objBanco.executeQuery("SELECT F.nome, U.codGrupo, G.codigo AS codigoGrupo, U.codigo, U.status FROM Usuarios U INNER JOIN Vendedores F ON U.codFuncionario = F.codigo INNER JOIN Grupos G ON U.codGrupo = G.codigo WHERE U.login = @login AND U.senha = @senha")
        objBanco.fechar()
        If dt.Rows.Count() > 0 Then
            If dt.Rows(0).Item("status") Then
                objBanco.conectar()
                objBanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(0).Item("codGrupo"))
                dtb = objBanco.executeQuery("SELECT * FROM Grupos WHERE codigo = @codigo")
                objBanco.fechar()
                objBanco.fechar()
                DadosUsuario.grupo = dtb.Rows(0).Item("nome")
                DadosUsuario.codGrupo = dt.Rows(0).Item("codigoGrupo")
                DadosUsuario.codUsuario = dt.Rows(0).Item("codigo")
                Menu.ClientesToolStripMenuItem.Enabled = dtb.Rows(0).Item("clienteConsultar")
                frmClientes.btnInserir.Enabled = dtb.Rows(0).Item("clienteIncluir")
                frmClientes.btnAlterar.Enabled = dtb.Rows(0).Item("clienteAlterar")
                frmClientes.btnDesativar.Enabled = dtb.Rows(0).Item("clienteDesativar")
                frmClientes.btnAtivar.Enabled = dtb.Rows(0).Item("clienteAtivar")
                frmClientes.ckbStatus.Visible = True
                frmClientes.ckbStatus.Visible = True
                If dtb.Rows(0).Item("clienteDesativar") = False Then
                    frmClientes.ckbStatus.Visible = False
                End If
                If dtb.Rows(0).Item("clienteAtivar") = False Then
                    frmClientes.ckbStatus.Visible = False
                End If

                Menu.VendedoresToolStripMenuItem.Enabled = dtb.Rows(0).Item("vendedoresConsultar")
                frmVendedores.btnInserir.Enabled = dtb.Rows(0).Item("vendedoresIncluir")
                frmVendedores.btnAlterar.Enabled = dtb.Rows(0).Item("vendedoresAlterar")
                frmVendedores.btnDesativar.Enabled = dtb.Rows(0).Item("vendedoresDesativar")
                frmVendedores.btnAtivar.Enabled = dtb.Rows(0).Item("vendedoresAtivar")
                frmVendedores.ckbStatus.Visible = True
                frmVendedores.ckbStatus.Visible = True
                If dtb.Rows(0).Item("vendedoresDesativar") = False Then
                    frmVendedores.ckbStatus.Visible = False
                End If
                If dtb.Rows(0).Item("vendedoresAtivar") = False Then
                    frmVendedores.ckbStatus.Visible = False
                End If

                Menu.ProdutosToolStripMenuItem.Enabled = dtb.Rows(0).Item("produtoConsultar")
                frmProdutos.btnInserir.Enabled = dtb.Rows(0).Item("produtoIncluir")
                frmProdutos.btnAlterar.Enabled = dtb.Rows(0).Item("produtoAlterar")
                frmProdutos.btnDesativar.Enabled = dtb.Rows(0).Item("produtoDesativar")
                frmProdutos.btnAtivar.Enabled = dtb.Rows(0).Item("produtoAtivar")
                frmProdutos.ckbStatus.Visible = True
                frmProdutos.ckbStatus.Visible = True
                If dtb.Rows(0).Item("produtoDesativar") = False Then
                    frmProdutos.ckbStatus.Visible = False
                End If
                If dtb.Rows(0).Item("produtoAtivar") = False Then
                    frmProdutos.ckbStatus.Visible = False
                End If

                Menu.VendasToolStripMenuItem.Enabled = dtb.Rows(0).Item("vendasConsultar")
                frmVendas.btnInserir.Enabled = dtb.Rows(0).Item("vendasIncluir")
                frmVendas.btnAlterar.Enabled = dtb.Rows(0).Item("vendasAlterar")
                frmVendas.btnExcluir.Enabled = dtb.Rows(0).Item("vendasDesativar")
                'frmVendas.btnAtivar.Enabled = dtb.Rows(0).Item("vendasAtivar")
                'frmVendas.ckbStatus.Visible = True
                'frmVendas.ckbStatus.Visible = True
                'If dtb.Rows(0).Item("vendasDesativar") = False Then
                'frmVendas.ckbStatus.Visible = False
                'End If
                'If dtb.Rows(0).Item("vendasAtivar") = False Then
                'frmVendas.ckbStatus.Visible = False
                'End If

                Menu.GruposToolStripMenuItem1.Enabled = dtb.Rows(0).Item("grupoConsultar")
                frmGrupo.btnInserir.Enabled = dtb.Rows(0).Item("grupoIncluir")
                frmGrupo.btnAlterar.Enabled = dtb.Rows(0).Item("grupoAlterar")
                frmGrupo.btnDesativar.Enabled = dtb.Rows(0).Item("grupoDesativar")
                frmGrupo.btnAtivar.Enabled = dtb.Rows(0).Item("grupoAtivar")
                frmGrupo.cbkStatus.Visible = True
                frmGrupo.cbkStatus.Visible = True
                If dtb.Rows(0).Item("grupoDesativar") = False Then
                    frmGrupo.cbkStatus.Visible = False
                End If
                If dtb.Rows(0).Item("grupoAtivar") = False Then
                    frmGrupo.cbkStatus.Visible = False
                End If

                Menu.UsuáriosToolStripMenuItem.Enabled = dtb.Rows(0).Item("usuarioConsultar")
                frmUsuarios.btnInserir.Enabled = dtb.Rows(0).Item("usuarioIncluir")
                frmUsuarios.btnAlterar.Enabled = dtb.Rows(0).Item("usuarioAlterar")
                frmUsuarios.btnDesativar.Enabled = dtb.Rows(0).Item("usuarioDesativar")
                'frmUsuarios.btnAtivar.Enabled = dtb.Rows(0).Item("usuarioAtivar")
                'frmUsuario.cbkStatus.Visible = True
                'frmUsuario.cbkStatus.Visible = True
                'If dtb.Rows(0).Item("usuarioDesativar") = False Then
                'frmUsuario.cbkStatus.Visible = False
                'End If
                'If dtb.Rows(0).Item("usuarioAtivar") = False Then
                'frmUsuario.cbkStatus.Visible = False
                'End If

                DadosUsuario.usuario = dt.Rows(0).Item("nome")
                DadosUsuario.dataLogado = Date.Now
                Menu.lblToolStripStatus.Text = "Usuário: " & DadosUsuario.usuario & " - Grupo: " & DadosUsuario.grupo & " - Data de login: " & DadosUsuario.dataLogado
                retorno = True
            Else
                Biblioteca.exibirNotificacao("Login", "O usuário está inativo.", "Erro")
            End If
        Else
            Biblioteca.exibirNotificacao("Login", "Login ou Senha inválidos.", "Erro")
        End If
        Return retorno
    End Function
    Public Function verificarLogin()
        Dim retorno As Boolean = False
        objBanco.conectar()
        objBanco.adicionaParametros("@login", SqlDbType.VarChar, frmLogin.txtNome.Text, 20)
        dt = objBanco.executeQuery("SELECT U.codigo, U.login, F.email FROM [dbo].[Usuarios] U INNER JOIN [dbo].[Vendedores] F ON U.codFuncionario = F.codigo  WHERE U.login = @login")
        objBanco.fechar()
        If dt.Rows.Count() > 0 Then
            setCodigoRecuperarSenha()
            frmRecuperarSenha.codigoVerificador = getCodigoRecuperarSenha()
            If EnviarEmail(dt.Rows(0).Item("email"), dt.Rows(0).Item("login"), getCodigoRecuperarSenha) Then
                retorno = True
            End If
        Else
            Biblioteca.exibirNotificacao("Recuperação de senha", "Login inválido.", "Erro")
        End If
        Return retorno
    End Function
    Public Sub recuperarSenha()
        objBanco.conectar()
        objBanco.adicionaParametros("@novaSenha", SqlDbType.VarChar, Biblioteca.Criptografar(frmRecuperarSenha.txtNovaSenha.Text), 32)
        objBanco.adicionaParametros("@codigo", SqlDbType.VarChar, dt.Rows(0).Item("codigo"))
        objBanco.executeQuery("UPDATE [dbo].[Usuarios] SET senha = @novaSenha WHERE codigo = @codigo;")
        objBanco.fechar()
        Biblioteca.exibirNotificacao("Recuperação de Senha", "Senha trocada com sucesso!", "Sucesso")
    End Sub

End Class
