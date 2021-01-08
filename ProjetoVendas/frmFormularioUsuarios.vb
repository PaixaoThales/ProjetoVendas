Public Class frmFormularioUsuarios
    Private objbanco As New Acesso
    Private auxiliar As Boolean = True
    Private Sub btnRevelarSenha_Click(sender As Object, e As EventArgs) Handles btnRevelarSenha.Click
        If auxiliar Then
            txtSenha.PasswordChar = ""
            btnRevelarSenha.Text = "Esconder senha"
            auxiliar = False
        Else
            txtSenha.PasswordChar = "*"
            btnRevelarSenha.Text = "Revelar senha"
            auxiliar = True
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Me.Text = "Alterar usuário" Then
            If txtLogin.Text <> "" And cbGrupos.SelectedValue <> 0 Then
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Preencha todos os campos corretamente!!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If
        Else
            If txtLogin.Text <> "" And txtSenha.Text <> "" And cbGrupos.SelectedValue <> 0 Then
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Preencha todos os campos corretamente!!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If
        End If
        

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class