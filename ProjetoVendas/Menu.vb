Public Class Menu
    Private objBanco As New Acesso
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        frmVendedores.MdiParent = Me
        frmVendedores.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        frmProdutos.MdiParent = Me
        frmProdutos.Show()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        frmVendas.MdiParent = Me
        frmVendas.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja realmente deslogar do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Hide()
            frmLogin.ShowDialog()
            If frmLogin.DialogResult = DialogResult.OK Then
                Show()
            Else
                End
            End If
        End If
    End Sub

    Private Sub GruposToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem1.Click
        frmGrupo.MdiParent = Me
        frmGrupo.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        If frmLogin.DialogResult <> DialogResult.OK Then
            End
        End If
    End Sub
    Private Sub ConexãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexãoToolStripMenuItem.Click
        frmConfigConexao.ShowDialog()
    End Sub
End Class