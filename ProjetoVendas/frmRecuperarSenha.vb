Public Class frmRecuperarSenha
    Private tempo As Integer = 300
    Private objBanco As New Acesso
    Private auxiliar As Boolean = True
    Public codigoVerificador As String = ""

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtCodigo.Text = codigoVerificador Then
            If txtNovaSenha.TextLength >= 6 Or txtNovaSenhaDeNovo.TextLength >= 6 Then
                If txtNovaSenha.Text = txtNovaSenhaDeNovo.Text Then
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Os campos de senhas não conferem.", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("A senha devem conter 6 (seis) ou caracteres.", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("O código validador está incorreto.", "Recuperação de senha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub tmTempo_Tick(sender As Object, e As EventArgs) Handles tmTempo.Tick
        tempo -= 1
        If tempo <= 0 Then
            tmTempo.Enabled = False
            Biblioteca.exibirNotificacao("Recuperação de senha", "O código expirou! Gere outro código.", "Erro")
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub frmRecuperarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmTempo.Enabled = True
    End Sub

    Private Sub btnRevelarSenhaNova_Click(sender As Object, e As EventArgs) Handles btnRevelarSenhaNova.Click
        If auxiliar Then
            txtNovaSenha.PasswordChar = ""
            btnRevelarSenhaNova.Text = "Esconder senha"
            auxiliar = False
        Else
            txtNovaSenha.PasswordChar = "*"
            btnRevelarSenhaNova.Text = "Revelar senha"
            auxiliar = True
        End If
    End Sub

    Private Sub btnRevelarSenhaDeNovo_Click(sender As Object, e As EventArgs) Handles btnRevelarSenhaDeNovo.Click
        If auxiliar Then
            txtNovaSenhaDeNovo.PasswordChar = ""
            btnRevelarSenhaDeNovo.Text = "Esconder senha"
            auxiliar = False
        Else
            txtNovaSenhaDeNovo.PasswordChar = "*"
            btnRevelarSenhaDeNovo.Text = "Revelar senha"
            auxiliar = True
        End If
    End Sub
End Class