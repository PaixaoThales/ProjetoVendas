Public Class frmVendas
    Private objbanco As New Acesso
    Private dt As DataTable

    Private Sub atualizarGrid()
        objbanco.conectar()
        dt = objbanco.executeQuery("SELECT v.codigo,v.data,VD.nome,C.nome, v.codVendedor,v.codCliente FROM Vendas V INNER JOIN Vendedores VD ON V.codVendedor = VD.codigo INNER JOIN Clientes C ON V.codCliente = c.codigo")
        objbanco.fechar()
        grid.DataSource = dt
    End Sub
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioVendas.Text = "Inserir vendas"
            frmFormularioVendas.dtbProdutos.Rows.Clear()
            frmFormularioVendas.txtCodigo.Text = "(novo)"
            frmFormularioVendas.txtTotalTotal.Text = "0"
            frmFormularioVendas.dtp.Value = Date.Today
            frmFormularioVendas.iniciaCombos()
            frmFormularioVendas.cmbClientes.SelectedIndex = -1
            frmFormularioVendas.cmbVendedor.SelectedIndex = -1
            frmFormularioVendas.ShowDialog()
            If frmFormularioVendas.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@data", SqlDbType.Date, frmFormularioVendas.dtp.Value)
                objbanco.adicionaParametros("@codVendedor", SqlDbType.Int, CInt(frmFormularioVendas.cmbVendedor.SelectedValue))
                objbanco.adicionaParametros("@codCliente", SqlDbType.Int, CInt(frmFormularioVendas.cmbClientes.SelectedValue))
                objbanco.executeQuery("INSERT INTO Vendas VALUES(@data, @codVendedor, @codCliente)")
                Dim cmd As DataTable = objbanco.executeQuery("SELECT MAX(codigo) FROM Vendas")
                For x As Integer = 0 To frmFormularioVendas.dtbProdutos.Rows.Count - 1
                    objbanco.adicionaParametros("@codProduto", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("codProduto")))
                    Dim dtp As DataTable = objbanco.executeQuery("SELECT preco FROM Produtos WHERE codigo = @codProduto")
                    objbanco.adicionaParametros("@codVenda", SqlDbType.Int, CInt(cmd.Rows(0).Item(0)))
                    objbanco.adicionaParametros("@codProduto", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("codProduto")))
                    objbanco.adicionaParametros("@quantidade", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("quantidade")))
                    objbanco.adicionaParametros("@preco", SqlDbType.Decimal, dtp.Rows(0).Item("preco"))
                    objbanco.executeQuery("INSERT INTO ItemVenda VALUES(@codVenda, @codProduto, @quantidade, @preco)")
                Next
                objbanco.fechar()
            End If
            atualizarGrid()
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizarGrid()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja realmente excluir permanentemente esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objbanco.conectar()
                objbanco.adicionaParametros("@codVenda", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                objbanco.executeQuery("DELETE FROM ItemVenda WHERE codVenda = @codVenda")
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                objbanco.executeQuery("DELETE FROM Vendas WHERE codigo = @codigo")
                objbanco.fechar()
                atualizarGrid()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioVendas.Text = "Alterar vendas"
            frmFormularioVendas.iniciaCombos()
            frmFormularioVendas.txtCodigo.Text = dt.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioVendas.dtp.Value = dt.Rows(grid.CurrentRow.Index).Item("data")
            frmFormularioVendas.cmbClientes.SelectedValue = dt.Rows(grid.CurrentRow.Index).Item("codCliente")
            frmFormularioVendas.cmbVendedor.SelectedValue = dt.Rows(grid.CurrentRow.Index).Item("codVendedor")
            objbanco.conectar()
            objbanco.adicionaParametros("@codVenda", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
            Dim cmdDefinitivo As DataTable = objbanco.executeQuery("SELECT Produtos.codigo AS [codProduto], Produtos.nome AS [nome], ItemVenda.preco AS [vlUnit], ItemVenda.quantidade AS [quantidade],  (ItemVenda.preco * ItemVenda.quantidade) AS [total], ItemVenda.codigo AS [codigo] FROM ItemVenda INNER JOIN Produtos ON ItemVenda.codProduto = Produtos.codigo WHERE ItemVenda.codVenda = @codVenda")
            objbanco.fechar()
            frmFormularioVendas.dtbProdutos = cmdDefinitivo
            frmFormularioVendas.grid.DataSource = frmFormularioVendas.dtbProdutos
            frmFormularioVendas.ShowDialog()
            If frmFormularioVendas.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@data", SqlDbType.Date, frmFormularioVendas.dtp.Value)
                objbanco.adicionaParametros("@codCliente", SqlDbType.Int, frmFormularioVendas.cmbClientes.SelectedValue)
                objbanco.adicionaParametros("@codVendedor", SqlDbType.Int, frmFormularioVendas.cmbVendedor.SelectedValue)
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                objbanco.executeQuery("UPDATE Vendas SET data = @data, codVendedor = @codVendedor, codCliente = @codCliente WHERE codigo = @codigo")
                objbanco.fechar()
                For x As Integer = 0 To frmFormularioVendas.dtbProdutos.Rows.Count - 1
                    If frmFormularioVendas.dtbProdutos.Rows(x).Item("codVenda") = 0 Then
                        objbanco.conectar()
                        objbanco.adicionaParametros("@codProduto", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("codProduto")))
                        Dim dtpa As DataTable = objbanco.executeQuery("SELECT preco FROM Produtos WHERE codigo = @codProduto")
                        objbanco.adicionaParametros("@codVenda", SqlDbType.Int, CInt(dt.Rows(grid.CurrentRow.Index).Item("codigo")))
                        objbanco.adicionaParametros("@codProduto", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("codProduto")))
                        objbanco.adicionaParametros("@quantidade", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("quantidade")))
                        objbanco.adicionaParametros("@preco", SqlDbType.Decimal, dtpa.Rows(0).Item("preco"))
                        objbanco.executeQuery("INSERT INTO ItemVenda VALUES(@codVenda, @codProduto, @quantidade, @preco)")
                        objbanco.fechar()
                        'Else
                        '    objbanco.conectar()
                        '    objbanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                        '    objbanco.adicionaParametros("@codProduto", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("codProduto")))
                        '    objbanco.adicionaParametros("@quantidade", SqlDbType.Int, CInt(frmFormularioVendas.dtbProdutos.Rows(x).Item("quantidade")))
                        '    objbanco.executeQuery("UPDATE ItemVenda SET codProduto = @codProduto, quantidade = @quantidade WHERE codigo = @codigo")
                        '    objbanco.fechar()
                    End If
                Next
            End If
            atualizarGrid()
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid! " & ex.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grid.CellFormatting

        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(0).Width = 50
            .Columns(1).HeaderText = "Data"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "Vendedor"
            .Columns(3).HeaderText = "Cliente"
            .Columns(4).Visible = False
            .Columns(5).Visible = False
        End With
    End Sub

End Class