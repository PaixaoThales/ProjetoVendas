Imports System.IO
Public Class frmFormularioProdutos
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtNome.Text <> "" And txtPreco.Text <> "" And Biblioteca.validaNumero(txtPreco.Text) And txtQuantidade.Text <> "" And Biblioteca.validaNumero(txtQuantidade.Text) Then
            If txtCaminho.Text <> txtCaminhoAntigo.Text And File.Exists(Application.StartupPath & "\Imagens\" & txtCaminhoAntigo.Text) Then

                File.Delete(Application.StartupPath & "\Imagens\" & txtCaminhoAntigo.Text)
            End If
            DialogResult = DialogResult.OK
        Else
            Biblioteca.exibirNotificacao("Erro", "Verifique todas as restrições dos campos de dados!", "Erro")
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub txtNome_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNome.KeyUp
        If txtNome.Text = "" Then
            epErro.SetError(txtNome, "Esse campo não pode ser vazio.")
        Else
            epErro.SetError(txtNome, "")
        End If
    End Sub

    Private Sub txtPreco_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPreco.KeyUp
        If txtPreco.Text = "" Then
            epErro.SetError(txtPreco, "Esse campo não pode ser vazio.")
        Else
            epErro.SetError(txtPreco, "")
        End If
        If Biblioteca.validaNumero(txtPreco.Text) Then
            epErro.SetError(txtPreco, "")
        Else
            epErro.SetError(txtPreco, "Esse campo só aceita números.")
        End If
    End Sub

    Private Sub txtQuantidade_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyUp
        If txtQuantidade.Text = "" Then
            epErro.SetError(txtQuantidade, "Esse campo não pode ser vazio.")
        Else
            epErro.SetError(txtQuantidade, "")
        End If
        If Biblioteca.validaNumero(txtQuantidade.Text) Then
            epErro.SetError(txtQuantidade, "")
        Else
            epErro.SetError(txtQuantidade, "Esse campo só aceita números.")
        End If
    End Sub

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        Dim selecionarImagem As New OpenFileDialog
        selecionarImagem.Filter = "(*.jpg;*.bmp;*.gif;*.png;*.jpeg)|*.jpg;*.bmp;*.gif;*.png;*.jpeg"
        selecionarImagem.Title = "Selecione uma imagem"

        If selecionarImagem.ShowDialog = DialogResult.OK Then

            If selecionarImagem.FileName.Length <= 100 Then
                txtCaminho.Text = selecionarImagem.FileName
                pcbImagem.Image = New Bitmap(txtCaminho.Text)
            Else
                Biblioteca.exibirNotificacao("Erro", "O caminho é longo demais! Selecione um caminho de imagem com no máximo 100 caractéres!", "Erro")
            End If

        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        pcbImagem.Image = Nothing
        txtCaminho.Text = ""
    End Sub
End Class