Public Class frmFormularioVendedores

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If txtNome.Text <> "" And Biblioteca.validaCaractere(txtNome.Text) And txtComissao.Text <> "" And Biblioteca.validaNumero(txtComissao.Text) Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Preencha todos os campos corretamente!!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class