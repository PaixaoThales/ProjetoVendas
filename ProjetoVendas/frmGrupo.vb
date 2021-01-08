Public Class frmGrupo
    Private objbanco As New Acesso
    Private dt As DataTable

    Private Sub atualizarGrid(ByRef status As Boolean)
        objbanco.conectar()
        objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
        dt = objbanco.executeQuery("SELECT * FROM Grupos WHERE status = 1 OR status = @status")
        objbanco.fechar()
        grid.DataSource = dt

    End Sub
    Private Sub ExibirDesatualizados()
        If cbkStatus.Checked Then
            atualizarGrid(False)
            For c As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(c).Item("status") = False Then
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
            If status = False And DadosUsuario.codGrupo = CInt(dt.Rows(grid.CurrentRow.Index).Item("codigo")) Then
                MessageBox.Show("Não é permitido desativar o grupo do atual usuário.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If MessageBox.Show("Deseja realmente " & operacao & " esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objbanco.conectar()
                    objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(dt.Rows(grid.CurrentRow.Index).Item("codigo")))
                    objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
                    objbanco.executeQuery("UPDATE Grupos SET status = @status WHERE codigo = @codigo;")
                    objbanco.fechar()
                    ExibirDesatualizados()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub frmGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExibirDesatualizados()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioGrupo.Text = "Inserir grupo"
            frmFormularioGrupo.txtGrupo.Text = ""
            frmFormularioGrupo.txtCodigo.Text = "(novo)"
            Biblioteca.gerenciarControles(False, frmFormularioUsuarios)
            frmFormularioGrupo.ShowDialog()
            If frmFormularioGrupo.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioGrupo.txtGrupo.Text, 30)
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioGrupo.ckbStatus.Checked)

                objbanco.adicionaParametros("@clienteConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesConsultar.Checked)
                objbanco.adicionaParametros("@clienteIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbClientesInserir.Checked)
                objbanco.adicionaParametros("@clienteAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesAlterar.Checked)
                objbanco.adicionaParametros("@clienteDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesDesativar.Checked)
                objbanco.adicionaParametros("@clienteAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesAtivar.Checked)

                objbanco.adicionaParametros("@produtoConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosConsultar.Checked)
                objbanco.adicionaParametros("@produtoIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosInserir.Checked)
                objbanco.adicionaParametros("@produtoAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosAlterar.Checked)
                objbanco.adicionaParametros("@produtoDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosDesativar.Checked)
                objbanco.adicionaParametros("@produtoAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosAtivar.Checked)

                objbanco.adicionaParametros("@vendaConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasConsultar.Checked)
                objbanco.adicionaParametros("@vendaIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbVendasInserir.Checked)
                objbanco.adicionaParametros("@vendaAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasAlterar.Checked)
                objbanco.adicionaParametros("@vendaDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasDesativar.Checked)
                objbanco.adicionaParametros("@VendaAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasAtivar.Checked)

                objbanco.adicionaParametros("@vendedorConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresConsultar.Checked)
                objbanco.adicionaParametros("@vendedorIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresInserir.Checked)
                objbanco.adicionaParametros("@vendedorAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresAlterar.Checked)
                objbanco.adicionaParametros("@vendedorDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresDesativar.Checked)
                objbanco.adicionaParametros("@vendedorAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresAtivar.Checked)

                objbanco.adicionaParametros("@usuarioConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosConsultar.Checked)
                objbanco.adicionaParametros("@usuarioIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosInserir.Checked)
                objbanco.adicionaParametros("@usuarioAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosAlterar.Checked)
                objbanco.adicionaParametros("@usuarioDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosDesativar.Checked)
                objbanco.adicionaParametros("@usuarioAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosAtivar.Checked)

                objbanco.adicionaParametros("@gruposConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposConsultar.Checked)
                objbanco.adicionaParametros("@gruposIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbGruposInserir.Checked)
                objbanco.adicionaParametros("@gruposAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposAlterar.Checked)
                objbanco.adicionaParametros("@gruposDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposDesativar.Checked)
                objbanco.adicionaParametros("@gruposAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposAtivar.Checked)

                objbanco.executeQuery("INSERT INTO Grupos VALUES (@nome, @status, 
                @clienteConsultar, @clienteIncluir, @clienteAlterar, @clienteAtivar, @clienteDesativar, 
                @produtoConsultar, @produtoIncluir, @produtoAlterar, @produtoAtivar, @produtoDesativar, 
                @vendedorConsultar, @vendedorIncluir, @vendedorAlterar, @vendedorAtivar, @vendedorDesativar, 
                @vendaConsultar, @vendaIncluir, @vendaAlterar, @vendaAtivar, @vendaDesativar, 
                @usuarioConsultar, @usuarioIncluir, @usuarioAlterar, @usuarioAtivar, @usuarioDesativar, 
                @gruposConsultar, @gruposIncluir, @gruposAlterar, @gruposAtivar, @gruposDesativar)")
                objbanco.fechar()
                ExibirDesatualizados()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnDesativar.Click
        AlterarEstado(False, "desativar")
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioGrupo.Text = "Alterar grupo"
            frmFormularioGrupo.txtCodigo.Text = dt.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioGrupo.txtGrupo.Text = dt.Rows(grid.CurrentRow.Index).Item("nome")
            frmFormularioGrupo.ckbStatus.Checked = dt.Rows(grid.CurrentRow.Index).Item("status")

            frmFormularioGrupo.ckbClientesConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("clienteConsultar")
            frmFormularioGrupo.ckbClientesInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("clienteIncluir")
            frmFormularioGrupo.ckbClientesAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("clienteAlterar")
            frmFormularioGrupo.ckbClientesDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("clienteDesativar")
            frmFormularioGrupo.ckbClientesAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("clienteAtivar")

            frmFormularioGrupo.ckbProdutosConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("produtoConsultar")
            frmFormularioGrupo.ckbProdutosInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("produtoIncluir")
            frmFormularioGrupo.ckbProdutosAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("produtoAlterar")
            frmFormularioGrupo.ckbProdutosDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("produtoDesativar")
            frmFormularioGrupo.ckbProdutosAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("produtoAtivar")

            frmFormularioGrupo.ckbVendedoresConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendedoresConsultar")
            frmFormularioGrupo.ckbVendedoresInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendedoresIncluir")
            frmFormularioGrupo.ckbVendedoresAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendedoresAlterar")
            frmFormularioGrupo.ckbVendedoresDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendedoresDesativar")
            frmFormularioGrupo.ckbVendedoresAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendedoresAtivar")

            frmFormularioGrupo.ckbVendasConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendasConsultar")
            frmFormularioGrupo.ckbVendasInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendasIncluir")
            frmFormularioGrupo.ckbVendasAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendasAlterar")
            frmFormularioGrupo.ckbVendasDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendasDesativar")
            frmFormularioGrupo.ckbVendasAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("vendasAtivar")

            frmFormularioGrupo.ckbUsuariosConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("usuarioConsultar")
            frmFormularioGrupo.ckbUsuariosInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("usuarioIncluir")
            frmFormularioGrupo.ckbUsuariosAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("usuarioAlterar")
            frmFormularioGrupo.ckbUsuariosDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("usuarioDesativar")
            frmFormularioGrupo.ckbUsuariosAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("usuarioAtivar")

            frmFormularioGrupo.ckbGruposConsultar.Checked = dt.Rows(grid.CurrentRow.Index).Item("grupoConsultar")
            frmFormularioGrupo.ckbGruposInserir.Checked = dt.Rows(grid.CurrentRow.Index).Item("grupoIncluir")
            frmFormularioGrupo.ckbGruposAlterar.Checked = dt.Rows(grid.CurrentRow.Index).Item("grupoAlterar")
            frmFormularioGrupo.ckbGruposDesativar.Checked = dt.Rows(grid.CurrentRow.Index).Item("grupoDesativar")
            frmFormularioGrupo.ckbGruposAtivar.Checked = dt.Rows(grid.CurrentRow.Index).Item("grupoAtivar")

            frmFormularioGrupo.ShowDialog()
            If frmFormularioGrupo.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioGrupo.txtGrupo.Text, 30)
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioGrupo.ckbStatus.Checked)

                objbanco.adicionaParametros("@clienteConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesConsultar.Checked)
                objbanco.adicionaParametros("@clienteIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbClientesInserir.Checked)
                objbanco.adicionaParametros("@clienteAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesAlterar.Checked)
                objbanco.adicionaParametros("@clienteDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesDesativar.Checked)
                objbanco.adicionaParametros("@clienteAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbClientesAtivar.Checked)

                objbanco.adicionaParametros("@produtoConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosConsultar.Checked)
                objbanco.adicionaParametros("@produtoIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosInserir.Checked)
                objbanco.adicionaParametros("@produtoAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosAlterar.Checked)
                objbanco.adicionaParametros("@produtoDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosDesativar.Checked)
                objbanco.adicionaParametros("@produtoAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbProdutosAtivar.Checked)

                objbanco.adicionaParametros("@vendaConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasConsultar.Checked)
                objbanco.adicionaParametros("@vendaIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbVendasInserir.Checked)
                objbanco.adicionaParametros("@vendaAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasAlterar.Checked)
                objbanco.adicionaParametros("@vendaDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasDesativar.Checked)
                objbanco.adicionaParametros("@VendaAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbVendasAtivar.Checked)

                objbanco.adicionaParametros("@vendedorConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresConsultar.Checked)
                objbanco.adicionaParametros("@vendedorIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresInserir.Checked)
                objbanco.adicionaParametros("@vendedorAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresAlterar.Checked)
                objbanco.adicionaParametros("@vendedorDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresDesativar.Checked)
                objbanco.adicionaParametros("@vendedorAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbVendedoresAtivar.Checked)

                objbanco.adicionaParametros("@usuarioConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosConsultar.Checked)
                objbanco.adicionaParametros("@usuarioIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosInserir.Checked)
                objbanco.adicionaParametros("@usuarioAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosAlterar.Checked)
                objbanco.adicionaParametros("@usuarioDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosDesativar.Checked)
                objbanco.adicionaParametros("@usuarioAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbUsuariosAtivar.Checked)

                objbanco.adicionaParametros("@gruposConsultar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposConsultar.Checked)
                objbanco.adicionaParametros("@gruposIncluir", SqlDbType.Bit, frmFormularioGrupo.ckbGruposInserir.Checked)
                objbanco.adicionaParametros("@gruposAlterar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposAlterar.Checked)
                objbanco.adicionaParametros("@gruposDesativar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposDesativar.Checked)
                objbanco.adicionaParametros("@gruposAtivar", SqlDbType.Bit, frmFormularioGrupo.ckbGruposAtivar.Checked)

                objbanco.executeQuery("UPDATE Grupos SET nome = @nome, status = @status, clienteConsultar = @clienteConsultar, clienteIncluir = @clienteIncluir, clienteAlterar = @clienteAlterar, clienteAtivar = @clienteAtivar, clienteDesativar = @clienteDesativar, produtoConsultar = @produtoConsultar, produtoIncluir = @produtoIncluir, produtoAlterar = @produtoAlterar, produtoDesativar = @produtoDesativar, produtoAtivar = @produtoAtivar, vendedoresConsultar = @vendedorConsultar, vendedoresIncluir = @vendedorIncluir, vendedoresAlterar = @vendedorAlterar, vendedoresDesativar = @vendedorDesativar, VendedoresAtivar = @vendedorAtivar, vendasConsultar = @vendaConsultar, vendasIncluir = @vendaIncluir, vendasAlterar = @vendaAlterar, vendasDesativar = @vendaDesativar, vendasAtivar = @vendaAtivar, usuarioConsultar = @usuarioConsultar, usuarioIncluir = @usuarioIncluir, usuarioAlterar = @usuarioAlterar, usuarioDesativar = @usuarioDesativar, usuarioAtivar = @usuarioAtivar, grupoConsultar = @gruposConsultar, grupoIncluir = @gruposIncluir, grupoAlterar = @gruposAlterar, grupoDesativar = @gruposDesativar, grupoAtivar = @gruposAtivar WHERE codigo = @codigo")
                objbanco.fechar()
                ExibirDesatualizados()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click
        AlterarEstado(True, "ativar")
    End Sub

    Private Sub grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grid.CellFormatting

        For c As Integer = 2 To dt.Columns.Count - 1
            grid.Columns(c).Visible = False
        Next
        grid.Columns(0).HeaderText = "Código"
        grid.Columns(0).Width = 50
        grid.Columns(1).HeaderText = "Nome"
        grid.Columns(1).Width = 190
    End Sub

    Private Sub cbkStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbkStatus.CheckedChanged
        ExibirDesatualizados()
    End Sub
End Class