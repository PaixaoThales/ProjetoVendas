Public Class frmClientes
    Private objbanco As New Acesso
    Private ds As DataTable
    Private dtbTelefones As DataTable = New DataTable("Telefones")
    Public Function getDtbTelefones()
        Return dtbTelefones
    End Function
    Public Sub setDtbTelefones(dtb As DataTable)
        dtbTelefones = dtb
    End Sub

    Private Sub atualizarGrid(ByRef status As Boolean)
        objbanco.conectar()
        objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
        ds = objbanco.executeQuery("SELECT * FROM Clientes WHERE status = 1 OR status = @status")
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
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioClientes.Text = "Inserir cliente"
            dtbTelefones.Clear()
            dtbTelefones.Columns.Clear()
            frmFormularioClientes.txtCodigo.Text = "(Novo)"
            frmFormularioClientes.txtNome.Text = ""
            frmFormularioClientes.txtEndereco.Text = ""
            Dim colCodigo As DataColumn = New DataColumn("codigo")
            colCodigo.DataType = System.Type.GetType("System.String")
            Dim colNumero As DataColumn = New DataColumn("numero")
            colNumero.DataType = System.Type.GetType("System.String")
            Dim colTipo As DataColumn = New DataColumn("tipo")
            colTipo.DataType = System.Type.GetType("System.String")
            dtbTelefones.Columns.Add(colCodigo)
            dtbTelefones.Columns.Add(colNumero)
            dtbTelefones.Columns.Add(colTipo)
            frmFormularioClientes.gridTelefones.DataSource = dtbTelefones
            frmFormularioClientes.ShowDialog()
            If frmFormularioClientes.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioClientes.txtNome.Text, 50)
                objbanco.adicionaParametros("@endereco", SqlDbType.VarChar, frmFormularioClientes.txtEndereco.Text, 50)
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioClientes.ckbStatus.Checked)
                Dim cmd As DataTable = objbanco.executeQuery("Insert into Clientes Values (@nome, @endereco, @status);")
                Dim cmdMax As DataTable = objbanco.executeQuery("SELECT MAX(codigo) as maximo FROM Clientes")
                For x As Integer = 0 To (frmFormularioClientes.gridTelefones.Rows.Count() - 2)
                    objbanco.adicionaParametros("@codCliente", SqlDbType.Int, CInt(cmdMax.Rows(0).Item("maximo")))
                    objbanco.adicionaParametros("@numero", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("numero"), 50)
                    objbanco.adicionaParametros("@tipo", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("tipo"), 50)
                    objbanco.executeQuery("Insert into Telefones Values (@codCliente, @numero, @tipo);")
                Next
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioClientes.Text = "Alterar cliente"
            dtbTelefones.Clear()
            frmFormularioClientes.txtCodigo.Text = ds.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioClientes.txtNome.Text = ds.Rows(grid.CurrentRow.Index).Item("nome")
            frmFormularioClientes.txtEndereco.Text = ds.Rows(grid.CurrentRow.Index).Item("endereco")
            frmFormularioClientes.ckbStatus.Checked = ds.Rows(grid.CurrentRow.Index).Item("status")
            objbanco.conectar()
            objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.CurrentRow.Index).Item("codigo")))
            Dim cmdTelefones As DataTable = objbanco.executeQuery("SELECT Telefones.codigo, Telefones.numero,Telefones.tipo FROM Telefones WHERE codCliente = @codigo")
            objbanco.fechar()
            dtbTelefones = cmdTelefones
            frmFormularioClientes.gridTelefones.DataSource = dtbTelefones
            frmFormularioClientes.ShowDialog()
            If frmFormularioClientes.DialogResult = Windows.Forms.DialogResult.OK Then
                For x As Integer = 0 To frmFormularioClientes.gridTelefones.Rows.Count() - 2
                    If dtbTelefones.Rows(x).Item("Codigo") = "0" Then
                        objbanco.conectar()
                        objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.SelectedRows(0).Index).Item("codigo")))
                        objbanco.adicionaParametros("@numero", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("numero"), 15)
                        objbanco.adicionaParametros("@tipo", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("tipo"), 20)
                        objbanco.executeQuery("INSERT INTO Telefones VALUES (@codigo,@numero,@tipo)")
                        objbanco.fechar()
                        'Else
                        '    objbanco.conectar()
                        '    objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.SelectedRows(0).Index).Item("codigo")))
                        '    objbanco.adicionaParametros("@numero", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("numero"), 15)
                        '    objbanco.adicionaParametros("@tipo", SqlDbType.VarChar, dtbTelefones.Rows(x).Item("tipo"), 20)
                        '    objbanco.executeQuery("UPDATE Telefones SET numero = @numero,tipo = @tipo WHERE codigo = @codigo")
                        '    objbanco.fechar()
                    End If
                Next
                objbanco.conectar()
                objbanco.adicionaParametros("@nome", SqlDbType.VarChar, frmFormularioClientes.txtNome.Text, 50)
                objbanco.adicionaParametros("@endereco", SqlDbType.VarChar, frmFormularioClientes.txtEndereco.Text, 50)
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.SelectedRows(0).Index).Item("codigo")))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioClientes.ckbStatus.Checked)
                objbanco.executeQuery("UPDATE Clientes SET nome = @nome, endereco = @endereco, status = @status WHERE codigo = @codigo;")
                objbanco.fechar()
                atualizarGrid(True)
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub
    Private Sub AlterarEstado(ByRef status As Boolean, ByRef operacao As String)
        Try
            If MessageBox.Show("Deseja realmente " & operacao & " esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objbanco.conectar()
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(ds.Rows(grid.CurrentRow.Index).Item("codigo")))
                objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
                objbanco.executeQuery("UPDATE Clientes SET status = @status WHERE codigo = @codigo;")
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
    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click
        AlterarEstado(True, "ativar")
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizarGrid(True)
        ExibirDesatualizados()
        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Endereço"
            .Columns(0).Width = 50
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Visible = False
        End With
    End Sub

    Private Sub ckbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles ckbStatus.CheckedChanged
        ExibirDesatualizados()
    End Sub
End Class