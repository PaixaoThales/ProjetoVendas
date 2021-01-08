Public Class frmFormularioVendasProdutos
    Private objbanco As New Acesso
    Private dtb As New DataTable("Produtos")

    Public Sub carregaCombo()
        dtb.Clear()
        objbanco.conectar()
        dtb = objbanco.executeQuery("Select * from Produtos")
        objbanco.fechar()
    End Sub

    Private Sub calculaTotal()
        If txtQuantidade.Text <> "" And txtVlUnit.Text <> "" Then
            txtTotal.Text = (CDbl(txtVlUnit.Text) * CDbl(txtQuantidade.Text)).ToString("###,##0.00")
        Else
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub cmbProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdutos.SelectedIndexChanged
        If cmbProdutos.SelectedIndex > -1 Then
            txtVlUnit.Text = CDbl(dtb.Rows(cmbProdutos.SelectedIndex).Item("preco")).ToString("###,##0.00")
        Else
            txtVlUnit.Text = ""
        End If
        calculaTotal()
    End Sub


    Private Sub txtQuantidade_Leave(sender As Object, e As EventArgs) Handles txtQuantidade.Leave
        calculaTotal()
    End Sub

    Private Sub frmFormularioVendasProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaCombo()
        cmbProdutos.DataSource = dtb
        cmbProdutos.DisplayMember = "nome"
        cmbProdutos.ValueMember = "codigo"
        cmbProdutos.SelectedIndex = -1
        txtVlUnit.Text = ""
        txtQuantidade.Text = ""
        txtVlUnit.Text = ""
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtTotal.Text <> "" Then
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub cmbProdutos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProdutos.KeyPress
        e.Handled = True
    End Sub

End Class