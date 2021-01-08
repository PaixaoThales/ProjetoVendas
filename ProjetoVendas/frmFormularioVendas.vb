Public Class frmFormularioVendas
    Private objbanco As New Acesso
    Public dtbClientes As New DataTable("Clientes")
    Public dtbVendedores As New DataTable("Vendedores")
    Public dtbProdutos As New DataTable("Produtos")

    Public Sub iniciaCombos()
        dtbClientes.Clear()
        dtbVendedores.Clear()
        objbanco.conectar()
        dtbClientes = objbanco.executeQuery("Select * FROM Clientes")
        dtbVendedores = objbanco.executeQuery("Select * FROM Vendedores")
        objbanco.fechar()
        cmbClientes.DataSource = dtbClientes
        cmbClientes.DisplayMember = "nome"
        cmbClientes.ValueMember = "codigo"
        cmbVendedor.DataSource = dtbVendedores
        cmbVendedor.DisplayMember = "nome"
        cmbVendedor.ValueMember = "codigo"
    End Sub

    Private Sub calcularTotal()
        Dim total As Double = 0
        For i As Integer = 0 To dtbProdutos.Rows.Count - 1
            total += CDbl(dtbProdutos.Rows(i).Item("vlTotal"))
        Next
        txtTotalTotal.Text = total.ToString("###,##0.00")
    End Sub

    Private Sub frmFormularioVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbProdutos.Columns.Clear()
        Dim colCodProd As New DataColumn("codProduto", GetType(Integer))
        Dim colNome As New DataColumn("nome", GetType(String))
        Dim colVlUnit As New DataColumn("vlUnit", GetType(String))
        Dim colQtde As New DataColumn("quantidade", GetType(String))
        Dim colVlTotal As New DataColumn("vlTotal", GetType(String))
        Dim colCoditemVenda As New DataColumn("codVenda", GetType(String))
        dtbProdutos.Columns.Add(colCodProd)
        dtbProdutos.Columns.Add(colNome)
        dtbProdutos.Columns.Add(colVlUnit)
        dtbProdutos.Columns.Add(colQtde)
        dtbProdutos.Columns.Add(colVlTotal)
        dtbProdutos.Columns.Add(colCoditemVenda)
        If (txtCodigo.Text <> "(novo)") Then
            objbanco.conectar()
            objbanco.adicionaParametros("@cod", SqlDbType.Int, txtCodigo.Text)
            dtbProdutos = objbanco.executeQuery("Select P.codigo AS [codProduto], P.nome AS [nome], I.preco AS [vlUnit] " &
                                          ", I.quantidade AS [quantidade], (I.preco * I.quantidade) AS [vlTotal], I.codigo as [codVenda]" &
                                          " FROM Produtos P INNER JOIN ItemVenda I On I.codProduto = P.codigo" &
                                          " WHERE I.codVenda = @cod")
            objbanco.fechar()
            calcularTotal()
        End If
        grid.DataSource = dtbProdutos
        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Vl. Unitário"
            .Columns(3).HeaderText = "Quantidade"
            .Columns(4).HeaderText = "Vl. Total"
            .Columns(5).Visible = False

        End With
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cmbClientes.Text <> "" And cmbVendedor.Text <> "" Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            frmFormularioVendasProdutos.Text = "Inserir produto"
            frmFormularioVendasProdutos.ShowDialog()
            If frmFormularioVendasProdutos.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim linha As DataRow
                linha = dtbProdutos.NewRow
                linha("codProduto") = frmFormularioVendasProdutos.cmbProdutos.SelectedValue
                linha("nome") = frmFormularioVendasProdutos.cmbProdutos.Text
                linha("vlUnit") = frmFormularioVendasProdutos.txtVlUnit.Text
                linha("quantidade") = frmFormularioVendasProdutos.txtQuantidade.Text
                linha("vlTotal") = frmFormularioVendasProdutos.txtTotal.Text
                linha("codVenda") = 0
                dtbProdutos.Rows.Add(linha)
                calcularTotal()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja realmente excluir permanentemente esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If dtbProdutos.Rows(grid.CurrentRow.Index).Item("codVenda") <> 0 Then
                    objbanco.conectar()
                    objbanco.adicionaParametros("@codigo", SqlDbType.Int, dtbProdutos.Rows(grid.CurrentRow.Index).Item("codVenda"))
                    objbanco.executeQuery("DELETE FROM ItemVenda WHERE codigo = @codigo")
                    objbanco.fechar()
                End If
                dtbProdutos.Rows(grid.SelectedRows(0).Index).Delete()
                dtbProdutos.AcceptChanges()
                calcularTotal()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class