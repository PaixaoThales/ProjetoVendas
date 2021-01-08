Public Class frmFormularioClientes
    Private objbanco As New Acesso
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtNome.Text <> "" And Biblioteca.validaCaractere(txtNome.Text) = True And txtEndereco.Text <> "" Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Preencha todos os campos corretamente!!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            frmFormularioTelefones.txtNumero.Text = ""
            frmFormularioTelefones.txtTipo.Text = ""
            frmFormularioTelefones.ShowDialog()
            If frmFormularioTelefones.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim linha As DataRow = frmClientes.getDtbTelefones.NewRow()
                linha.Item("codigo") = "0"
                linha.Item("numero") = frmFormularioTelefones.txtNumero.Text
                linha.Item("tipo") = frmFormularioTelefones.txtTipo.Text
                frmClientes.getDtbTelefones.Rows.Add(linha)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja realmente excluir permanentemente esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If frmClientes.getDtbTelefones.rows(gridTelefones.CurrentRow.Index).item("codigo") <> "0" Then
                    objbanco.conectar()
                    objbanco.adicionaParametros("@codigo", SqlDbType.Int, frmClientes.getDtbTelefones.Rows(gridTelefones.CurrentRow.Index).Item("codigo"))
                    objbanco.executeQuery("DELETE FROM Telefones WHERE codigo = @codigo")
                    objbanco.fechar()
                End If
                frmClientes.getDtbTelefones.Rows(gridTelefones.SelectedRows(0).Index).Delete()
                frmClientes.getDtbTelefones.AcceptChanges()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmFormularioClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With gridTelefones
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Número"
            .Columns(2).HeaderText = "Tipo"
        End With
    End Sub
End Class