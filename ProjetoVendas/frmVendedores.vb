Public Class frmVendedores
    Private objbanco As New Acesso
    Private ds As DataTable

    Private Sub atualizarGrid(ByRef status As Boolean)
        objbanco.conectar()
        objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
        ds = objbanco.executeQuery("SELECT * FROM Vendedores WHERE status = 1 OR status = @status")
        objbanco.fechar()
        grid.DataSource = ds

    End Sub
    Private Sub ExibirDesatualizados()
        If ckbStatus.Checked Then
            atualizarGrid(False)
            For c As Integer = 0 To ds.Rows.Count - 1
                If ds.Rows(c).Item("status") = False Then
                    grid.Rows(c).DefaultCellStyle.BackColor = Color.Red
                End If
            Next
            btnAtivar.Enabled = True
        Else
            atualizarGrid(True)
            btnAtivar.Enabled = False
        End If
    End Sub
    Private Sub AlterarEstado(ByRef status As Boolean, ByRef operacao As String)
        Try
            If MessageBox.Show("Deseja realmente " & operacao & " esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objbanco.conectar()
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.CurrentRow.Index).Item("codigo")))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
                objbanco.executeQuery("UPDATE Vendedores SET status = @status WHERE codigo = @codigo;")
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioVendedores.Text = "Inserir vendedores"
            frmFormularioVendedores.txtCodigo.Text = "(Novo)"
            frmFormularioVendedores.txtNome.Text = ""
            frmFormularioVendedores.txtComissao.Text = ""
            frmFormularioVendedores.txtEmail.Text = ""
            frmFormularioVendedores.ShowDialog()
            If frmFormularioVendedores.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioVendedores.txtNome.Text, 50)
                objbanco.adicionaParametros("@comissao", SqlDbType.Int, CInt(frmFormularioVendedores.txtComissao.Text))
                objbanco.adicionaParametros("@email", SqlDbType.VarChar, frmFormularioVendedores.txtEmail.Text, 60)
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioVendedores.ckbStatus.Checked)
                objbanco.executeQuery("Insert into Vendedores Values (@nome, @comissao, @email, @status);")
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioVendedores.Text = "Alterar vendedores"
            frmFormularioVendedores.txtCodigo.Text = ds.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioVendedores.txtNome.Text = ds.Rows(grid.CurrentRow.Index).Item("nome")
            frmFormularioVendedores.txtComissao.Text = ds.Rows(grid.CurrentRow.Index).Item("comissao")
            frmFormularioVendedores.txtEmail.Text = ds.Rows(grid.CurrentRow.Index).Item("email")
            frmFormularioVendedores.ckbStatus.Checked = ds.Rows(grid.CurrentRow.Index).Item("status")
            frmFormularioVendedores.ShowDialog()
            If frmFormularioVendedores.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioVendedores.txtNome.Text, 50)
                objbanco.adicionaParametros("@comissao", SqlDbType.Int, CInt(frmFormularioVendedores.txtComissao.Text))
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.SelectedRows(0).Index).Item("codigo")))
                objbanco.adicionaParametros("@email", SqlDbType.VarChar, frmFormularioVendedores.txtEmail.Text, 60)
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioVendedores.ckbStatus.Checked)
                objbanco.executeQuery("UPDATE Vendedores SET nome = @nome, comissao = @comissao, email = @email, status = @status WHERE codigo = @codigo;")
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub

    Private Sub btnDesativar_Click(sender As Object, e As EventArgs) Handles btnDesativar.Click
        AlterarEstado(False, "desativar")
    End Sub

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizarGrid(1)
        ExibirDesatualizados()
    End Sub

    Private Sub grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grid.CellFormatting
        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Nome"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Comissão"
            .Columns(3).Width = 150
            .Columns(3).HeaderText = "E-mail"
            .Columns(4).Visible = False

        End With
    End Sub

    Private Sub ckbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles ckbStatus.CheckedChanged
        ExibirDesatualizados()
    End Sub

    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click
        AlterarEstado(True, "ativar")
    End Sub
End Class
