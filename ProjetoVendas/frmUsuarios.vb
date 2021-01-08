Public Class frmUsuarios
    Private dt As DataTable
    Private objbanco As New Acesso

    Private Sub atualizarGrid(ByRef status As Boolean)
        objbanco.conectar()
        objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
        dt = objbanco.executeQuery("SELECT U.codigo, G.nome, V.nome, U.login, U.codGrupo, U.codFuncionario, U.status FROM Usuarios U INNER JOIN Grupos G ON U.codGrupo = G.codigo INNER JOIN Vendedores V ON V.codigo = U.codFuncionario WHERE U.status = 1 OR U.status = @status")
        objbanco.fechar()
        grid.DataSource = dt

    End Sub
    Private Sub ExibirDesatualizados()
        If ckbStatus.Checked Then
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
            If status = False And DadosUsuario.codUsuario = CInt(dt.Rows(grid.CurrentRow.Index).Item("codigo")) Then
                MessageBox.Show("Não é permitido desativar o usuário do atual.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If MessageBox.Show("Deseja realmente " & operacao & " esses dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objbanco.conectar()
                    objbanco.adicionaParametros("@codigo", SqlDbType.Int, CInt(dt.Rows(grid.CurrentRow.Index).Item("codigo")))
                    objbanco.adicionaParametros("@status", SqlDbType.Bit, status)
                    objbanco.executeQuery("UPDATE Usuarios SET status = @status WHERE codigo = @codigo;")
                    objbanco.fechar()
                    atualizarGrid(True)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ExibirDesatualizados()
    End Sub
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try
            frmFormularioUsuarios.Text = "Inserir usuário"
            iniciaCombos()
            frmFormularioUsuarios.txtCodigo.Text = "(Novo)"
            frmFormularioUsuarios.txtLogin.Text = ""
            frmFormularioUsuarios.txtSenha.Text = ""
            frmFormularioUsuarios.lblSenha.Text = "Senha:"
            frmFormularioUsuarios.cbGrupos.SelectedIndex = -1
            frmFormularioUsuarios.cbFuncionario.SelectedIndex = -1
            frmFormularioUsuarios.ShowDialog()
            If frmFormularioUsuarios.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioUsuarios.ckbStatus.Checked)
                objbanco.adicionaParametros("@login", SqlDbType.VarChar, frmFormularioUsuarios.txtLogin.Text, 20)
                objbanco.adicionaParametros("@codFuncionario", SqlDbType.Int, frmFormularioUsuarios.cbFuncionario.SelectedValue)
                objbanco.adicionaParametros("@senha", SqlDbType.VarChar, Biblioteca.Criptografar(frmFormularioUsuarios.txtSenha.Text), 32)
                objbanco.adicionaParametros("@codGrupo", SqlDbType.Int, frmFormularioUsuarios.cbGrupos.SelectedValue)
                objbanco.executeQuery("INSERT INTO Usuarios VALUES(@codFuncionario, @login, @senha, @status, @codGrupo)")
                objbanco.fechar()
            End If
            ExibirDesatualizados()
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExibirDesatualizados()
        With grid
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Grupo nome"
            .Columns(2).HeaderText = "Funcionário"
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
        End With

    End Sub
    Public Sub iniciaCombos(Optional ByRef resto As String = "")
        objbanco.conectar()
        Dim dt As DataTable = objbanco.executeQuery("SELECT nome, codigo FROM Grupos")
        Dim dte As DataTable = objbanco.executeQuery("SELECT V.codigo, V.nome FROM Vendedores V where (v.codigo not in(SELECT codFuncionario FROM Usuarios where V.codigo = codFuncionario))" & resto)
        objbanco.fechar()
        frmFormularioUsuarios.cbGrupos.DataSource = dt
        frmFormularioUsuarios.cbGrupos.DisplayMember = "nome"
        frmFormularioUsuarios.cbGrupos.ValueMember = "codigo"
        frmFormularioUsuarios.cbFuncionario.DataSource = dte
        frmFormularioUsuarios.cbFuncionario.DisplayMember = "nome"
        frmFormularioUsuarios.cbFuncionario.ValueMember = "codigo"
    End Sub

    Private Sub btnDesativar_Click(sender As Object, e As EventArgs) Handles btnDesativar.Click
        AlterarEstado(False, "desativar")
    End Sub
    Private Sub btnAtivar_Click(sender As Object, e As EventArgs) Handles btnAtivar.Click
        AlterarEstado(True, "ativar")
    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Try
            frmFormularioUsuarios.Text = "Alterar usuário"
            iniciaCombos("OR V.codigo = " & dt.Rows(grid.CurrentRow.Index).Item("codFuncionario"))
            frmFormularioUsuarios.txtCodigo.Text = dt.Rows(grid.CurrentRow.Index).Item("codigo")
            frmFormularioUsuarios.txtLogin.Text = dt.Rows(grid.CurrentRow.Index).Item("login")
            frmFormularioUsuarios.ckbStatus.Checked = dt.Rows(grid.CurrentRow.Index).Item("status")
            frmFormularioUsuarios.lblSenha.Text = "Nova senha:"
            frmFormularioUsuarios.cbGrupos.SelectedValue = dt.Rows(grid.CurrentRow.Index).Item("codGrupo")
            frmFormularioUsuarios.cbFuncionario.SelectedValue = dt.Rows(grid.CurrentRow.Index).Item("codFuncionario")
            frmFormularioUsuarios.ShowDialog()
            If frmFormularioUsuarios.DialogResult = Windows.Forms.DialogResult.OK Then
                objbanco.conectar()
                objbanco.adicionaParametros("@status", SqlDbType.Bit, frmFormularioUsuarios.ckbStatus.Checked)
                objbanco.adicionaParametros("@login", SqlDbType.VarChar, frmFormularioUsuarios.txtLogin.Text, 20)
                objbanco.adicionaParametros("@senha", SqlDbType.VarChar, Biblioteca.Criptografar(frmFormularioUsuarios.txtSenha.Text), 32)
                objbanco.adicionaParametros("@codGrupo", SqlDbType.Int, frmFormularioUsuarios.cbGrupos.SelectedValue)
                objbanco.adicionaParametros("@codFuncionario", SqlDbType.Int, frmFormularioUsuarios.cbFuncionario.SelectedValue)
                objbanco.adicionaParametros("@codigo", SqlDbType.Int, dt.Rows(grid.CurrentRow.Index).Item("codigo"))
                Dim senha As String = ""
                If frmFormularioUsuarios.txtSenha.Text <> "" Then
                    senha = ", senha = @senha"
                End If
                objbanco.executeQuery("UPDATE Usuarios SET status = @status, login = @login" & senha & ", codGrupo = @codGrupo, codFuncionario = @codFuncionario WHERE codigo = @codigo")
                objbanco.fechar()
                ExibirDesatualizados()
            End If
        Catch ex As Exception
            MessageBox.Show("Selecione uma linha do grid!" & ex.Message, "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ckbStatus_CheckedChanged(sender As Object, e As EventArgs) Handles ckbStatus.CheckedChanged
        ExibirDesatualizados()
    End Sub
End Class