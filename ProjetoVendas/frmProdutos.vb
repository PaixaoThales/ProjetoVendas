Public Class frmProdutos
    Private objbanco As New Acesso
    Private ds As DataTable

    Private Sub atualizarGrid(ByRef status As Boolean)
        objbanco.conectar()
        objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
        ds = objbanco.executeQuery("SELECT * FROM Produtos WHERE status = 1 OR status = @status")
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
                objbanco.executeQuery("UPDATE Produtos SET status = @status WHERE codigo = @codigo;")
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub
    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExibirDesatualizados()
        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Nome"
            .Columns(2).Width = 200
            .Columns(2).HeaderText = "Preço"
            .Columns(2).Width = 75
            .Columns(3).HeaderText = "Quantidade"
            .Columns(3).Width = 75
            .Columns(4).Visible = False
            .Columns(5).Visible = False
        End With

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioProdutos.Text = "Inserir"
            frmFormularioProdutos.lblTitulo.Text = "Inserir Produto"
            frmFormularioProdutos.txtCodigo.Text = "(Novo)"
            frmFormularioProdutos.txtNome.Text = ""
            frmFormularioProdutos.txtPreco.Text = ""
            frmFormularioProdutos.txtQuantidade.Text = ""
            frmFormularioProdutos.txtCaminho.Text = ""
            frmFormularioProdutos.txtCaminhoAntigo.Text = ""
            frmFormularioProdutos.pcbImagem.Image = Nothing
            frmFormularioProdutos.ShowDialog()
            If frmFormularioProdutos.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtNome.Text)), 50)
                objbanco.adicionaParametros("@preco", SqlDbType.Decimal, Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtPreco.Text)))
                objbanco.adicionaParametros("@quantidade", SqlDbType.Int, CInt(Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtQuantidade.Text))))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioProdutos.ckbStatus.Checked)
                objbanco.adicionaParametros("@caminhoImagem", SqlDbType.VarChar, frmFormularioProdutos.txtCaminho.Text, 100)
                objbanco.executeQuery("INSERT INTO Produtos VALUES  (@nome, @preco, @quantidade, @status, @caminhoImagem)")
                objbanco.fechar()
                ExibirDesatualizados()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid! " & ex.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioProdutos.Text = "Alterar"
            frmFormularioProdutos.lblTitulo.Text = "Alterar Produto"
            frmFormularioProdutos.txtCodigo.Text = ds.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioProdutos.txtNome.Text = ds.Rows(grid.CurrentRow.Index).Item("nome")
            frmFormularioProdutos.txtPreco.Text = ds.Rows(grid.CurrentRow.Index).Item("preco")
            frmFormularioProdutos.txtQuantidade.Text = ds.Rows(grid.CurrentRow.Index).Item("quantidade")
            frmFormularioProdutos.ckbStatus.Checked = ds.Rows(grid.CurrentRow.Index).Item("status")
            frmFormularioProdutos.txtCaminho.Text = ds.Rows(grid.CurrentRow.Index).Item("caminhoFoto")
            frmFormularioProdutos.txtCaminhoAntigo.Text = ds.Rows(grid.CurrentRow.Index).Item("caminhoFoto")
            frmFormularioProdutos.pcbImagem.Image = New Bitmap(Application.StartupPath & "\Imagens\" & frmFormularioProdutos.txtCaminho.Text)
            frmFormularioProdutos.ShowDialog()
            If frmFormularioProdutos.DialogResult = Windows.Forms.DialogResult.OK Then
                If frmFormularioProdutos.txtCaminho.Text <> frmFormularioProdutos.txtCaminhoAntigo.Text Then
                    frmFormularioProdutos.txtCaminho.Text = frmFormularioProdutos.txtNome.Text & Date.Now.Second & Date.Now.Millisecond & ".jpg"
                    frmFormularioProdutos.pcbImagem.Image.Save(Application.StartupPath & "\Imagens\" & frmFormularioProdutos.txtCaminho.Text)
                    DialogResult = DialogResult.OK
                End If
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtNome.Text)), 50)
                objbanco.adicionaParametros("@preco", SqlDbType.Decimal, Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtPreco.Text)))
                objbanco.adicionaParametros("@quantidade", SqlDbType.Int, CInt(Biblioteca.removerEspaçoDuplo(Trim(frmFormularioProdutos.txtQuantidade.Text))))
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.SelectedRows(0).Index).Item("codigo")))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioProdutos.ckbStatus.Checked)
                objbanco.adicionaParametros("@caminhoFoto", SqlDbType.VarChar, frmFormularioProdutos.txtCaminho.Text, 100)
                objbanco.executeQuery("UPDATE Produtos SET nome = @nome, preco = @preco, quantidade = @quantidade, status = @status, caminhoFoto = @caminhoFoto WHERE codigo = @codigo")
                objbanco.fechar()
                ExibirDesatualizados()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid! " & ex.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnDesativar_Click(sender As Object, e As EventArgs) Handles btnDesativar.Click
        AlterarEstado(False, "desativar")
    End Sub

    Private Sub ckbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles ckbStatus.CheckedChanged
        ExibirDesatualizados()
    End Sub

    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click
        AlterarEstado(True, "ativar")
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        frmFormularioProdutos.Text = "Visualizar"
        frmFormularioProdutos.lblTitulo.Text = "Visualizar Produto"
        frmFormularioProdutos.txtCodigo.Text = ds.Rows(grid.CurrentRow.Index).Item("codigo")
        frmFormularioProdutos.txtNome.Text = ds.Rows(grid.CurrentRow.Index).Item("nome")
        frmFormularioProdutos.txtPreco.Text = ds.Rows(grid.CurrentRow.Index).Item("preco")
        frmFormularioProdutos.txtQuantidade.Text = ds.Rows(grid.CurrentRow.Index).Item("quantidade")
        frmFormularioProdutos.ckbStatus.Checked = ds.Rows(grid.CurrentRow.Index).Item("status")
        frmFormularioProdutos.txtCaminho.Text = ds.Rows(grid.CurrentRow.Index).Item("caminhoFoto")
        frmFormularioProdutos.txtCaminhoAntigo.Text = ds.Rows(grid.CurrentRow.Index).Item("caminhoFoto")
        frmFormularioProdutos.pcbImagem.Image = New Bitmap(Application.StartupPath & "\Imagens\" & frmFormularioProdutos.txtCaminho.Text)
        frmFormularioProdutos.txtCodigo.Enabled = False
        frmFormularioProdutos.txtNome.Enabled = False
        frmFormularioProdutos.txtPreco.Enabled = False
        frmFormularioProdutos.txtQuantidade.Enabled = False
        frmFormularioProdutos.ckbStatus.Enabled = False
        frmFormularioProdutos.btnSelecionar.Enabled = False
        frmFormularioProdutos.btnRemover.Enabled = False
        frmFormularioProdutos.ShowDialog()
        frmFormularioProdutos.txtCodigo.Enabled = True
        frmFormularioProdutos.txtNome.Enabled = True
        frmFormularioProdutos.txtPreco.Enabled = True
        frmFormularioProdutos.txtQuantidade.Enabled = True
        frmFormularioProdutos.ckbStatus.Enabled = True
        frmFormularioProdutos.btnSelecionar.Enabled = True
        frmFormularioProdutos.btnRemover.Enabled = True
    End Sub
End Class