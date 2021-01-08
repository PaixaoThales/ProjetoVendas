<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoDeAcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.VendasToolStripMenuItem, Me.GrupoDeAcessoToolStripMenuItem, Me.ConexãoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.ProdutosToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'GrupoDeAcessoToolStripMenuItem
        '
        Me.GrupoDeAcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GruposToolStripMenuItem1, Me.UsuáriosToolStripMenuItem})
        Me.GrupoDeAcessoToolStripMenuItem.Name = "GrupoDeAcessoToolStripMenuItem"
        Me.GrupoDeAcessoToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.GrupoDeAcessoToolStripMenuItem.Text = "Grupo de Acesso"
        '
        'GruposToolStripMenuItem1
        '
        Me.GruposToolStripMenuItem1.Name = "GruposToolStripMenuItem1"
        Me.GruposToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.GruposToolStripMenuItem1.Text = "Grupos"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Logoff"
        '
        'ConexãoToolStripMenuItem
        '
        Me.ConexãoToolStripMenuItem.Name = "ConexãoToolStripMenuItem"
        Me.ConexãoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ConexãoToolStripMenuItem.Text = "Conexão"
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblToolStripStatus})
        Me.statusStrip.Location = New System.Drawing.Point(0, 546)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(881, 22)
        Me.statusStrip.TabIndex = 3
        '
        'lblToolStripStatus
        '
        Me.lblToolStripStatus.Name = "lblToolStripStatus"
        Me.lblToolStripStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 568)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Início"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrupoDeAcessoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblToolStripStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ConexãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
