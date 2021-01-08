Public Class frmLogin
    Private objLogin As New Login()
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtNome.TextLength >= 6 Or txtSenha.TextLength >= 6 Then
            If objLogin.logar() Then
                txtNome.Text = ""
                txtSenha.Text = ""
                DialogResult = DialogResult.OK
            End If
        Else
            MessageBox.Show("Todos os campos devem estar preenchidos, e com no minímo 6 caracteres.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnConexao_Click(sender As Object, e As EventArgs) Handles btnConexao.Click
        frmConfigConexao.ShowDialog()
    End Sub

    Private Sub lklblEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblEsqueceuSenha.LinkClicked
        If txtNome.TextLength >= 6 Then
            If objLogin.verificarLogin() Then
                frmRecuperarSenha.txtCodigo.Text = ""
                frmRecuperarSenha.txtNovaSenha.Text = ""
                frmRecuperarSenha.txtNovaSenhaDeNovo.Text = ""
                frmRecuperarSenha.ShowDialog()
                If frmRecuperarSenha.DialogResult = DialogResult.OK Then
                    objLogin.recuperarSenha()
                End If
            End If
        Else
            MessageBox.Show("Preencha o campo 'Login' para recuperar senha.", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class