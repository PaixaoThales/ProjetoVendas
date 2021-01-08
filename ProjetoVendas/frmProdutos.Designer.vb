<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.lblProdutosCadastrados = New System.Windows.Forms.Label()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.ckbStatus = New System.Windows.Forms.CheckBox()
        Me.gbbPesquina = New System.Windows.Forms.GroupBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 127)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(461, 190)
        Me.grid.TabIndex = 0
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(12, 323)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 1
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(109, 323)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(97, 23)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnDesativar
        '
        Me.btnDesativar.Location = New System.Drawing.Point(293, 323)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(83, 23)
        Me.btnDesativar.TabIndex = 3
        Me.btnDesativar.Text = "Desativar"
        Me.btnDesativar.UseVisualStyleBackColor = True
        '
        'lblProdutosCadastrados
        '
        Me.lblProdutosCadastrados.AutoSize = True
        Me.lblProdutosCadastrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutosCadastrados.Location = New System.Drawing.Point(163, 9)
        Me.lblProdutosCadastrados.Name = "lblProdutosCadastrados"
        Me.lblProdutosCadastrados.Size = New System.Drawing.Size(169, 20)
        Me.lblProdutosCadastrados.TabIndex = 4
        Me.lblProdutosCadastrados.Text = "Produtos cadastrados:"
        '
        'btnAtivar
        '
        Me.btnAtivar.Location = New System.Drawing.Point(382, 323)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtivar.TabIndex = 5
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.UseVisualStyleBackColor = True
        '
        'ckbStatus
        '
        Me.ckbStatus.AutoSize = True
        Me.ckbStatus.Location = New System.Drawing.Point(362, 13)
        Me.ckbStatus.Name = "ckbStatus"
        Me.ckbStatus.Size = New System.Drawing.Size(111, 17)
        Me.ckbStatus.TabIndex = 6
        Me.ckbStatus.Text = "Exibir desativados"
        Me.ckbStatus.UseVisualStyleBackColor = True
        '
        'gbbPesquina
        '
        Me.gbbPesquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbbPesquina.Location = New System.Drawing.Point(87, 52)
        Me.gbbPesquina.Name = "gbbPesquina"
        Me.gbbPesquina.Size = New System.Drawing.Size(334, 69)
        Me.gbbPesquina.TabIndex = 7
        Me.gbbPesquina.TabStop = False
        Me.gbbPesquina.Text = "Pesquisa"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(212, 323)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnVisualizar.TabIndex = 8
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 361)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.gbbPesquina)
        Me.Controls.Add(Me.ckbStatus)
        Me.Controls.Add(Me.btnAtivar)
        Me.Controls.Add(Me.lblProdutosCadastrados)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário de produtos"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents lblProdutosCadastrados As System.Windows.Forms.Label
    Friend WithEvents btnAtivar As Button
    Friend WithEvents ckbStatus As CheckBox
    Friend WithEvents gbbPesquina As GroupBox
    Friend WithEvents btnVisualizar As Button
End Class
