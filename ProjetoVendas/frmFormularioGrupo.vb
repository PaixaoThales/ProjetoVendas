Public Class frmFormularioGrupo
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        If txtGrupo.Text <> "" Then
            If MessageBox.Show("Deseja realmente inserir esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            MessageBox.Show("Prencha o campo 'Nome de grupo'", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnSelecionarTodos_Click(sender As Object, e As EventArgs) Handles btnSelecionarTodos.Click
        Biblioteca.gerenciarControles(True, frmFormularioUsuarios)

    End Sub

    Private Sub btnDesmarcarTodos_Click(sender As Object, e As EventArgs) Handles btnDesmarcarTodos.Click
        Biblioteca.gerenciarControles(False, frmFormularioUsuarios)
    End Sub

End Class