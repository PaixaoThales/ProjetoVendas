<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormularioGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormularioGrupo))
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.ckbClientesAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbClientesDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbClientesAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbClientesInserir = New System.Windows.Forms.CheckBox()
        Me.ckbClientesConsultar = New System.Windows.Forms.CheckBox()
        Me.gbVendas = New System.Windows.Forms.GroupBox()
        Me.ckbVendasAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbVendasDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbVendasAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbVendasInserir = New System.Windows.Forms.CheckBox()
        Me.ckbVendasConsultar = New System.Windows.Forms.CheckBox()
        Me.gpUsuarios = New System.Windows.Forms.GroupBox()
        Me.ckbUsuariosAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbUsuariosDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbUsuariosAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbUsuariosInserir = New System.Windows.Forms.CheckBox()
        Me.ckbUsuariosConsultar = New System.Windows.Forms.CheckBox()
        Me.gbProdutos = New System.Windows.Forms.GroupBox()
        Me.ckbProdutosAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbProdutosDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbProdutosAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbProdutosInserir = New System.Windows.Forms.CheckBox()
        Me.ckbProdutosConsultar = New System.Windows.Forms.CheckBox()
        Me.gpVendedores = New System.Windows.Forms.GroupBox()
        Me.ckbVendedoresAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbVendedoresDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbVendedoresAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbVendedoresInserir = New System.Windows.Forms.CheckBox()
        Me.ckbVendedoresConsultar = New System.Windows.Forms.CheckBox()
        Me.gpGrupos = New System.Windows.Forms.GroupBox()
        Me.ckbGruposAtivar = New System.Windows.Forms.CheckBox()
        Me.ckbGruposDesativar = New System.Windows.Forms.CheckBox()
        Me.ckbGruposAlterar = New System.Windows.Forms.CheckBox()
        Me.ckbGruposInserir = New System.Windows.Forms.CheckBox()
        Me.ckbGruposConsultar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSelecionarTodos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ckbStatus = New System.Windows.Forms.CheckBox()
        Me.btnDesmarcarTodos = New System.Windows.Forms.Button()
        Me.gbClientes.SuspendLayout()
        Me.gbVendas.SuspendLayout()
        Me.gpUsuarios.SuspendLayout()
        Me.gbProdutos.SuspendLayout()
        Me.gpVendedores.SuspendLayout()
        Me.gpGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(148, 25)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(173, 20)
        Me.txtGrupo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome:"
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.ckbClientesAtivar)
        Me.gbClientes.Controls.Add(Me.ckbClientesDesativar)
        Me.gbClientes.Controls.Add(Me.ckbClientesAlterar)
        Me.gbClientes.Controls.Add(Me.ckbClientesInserir)
        Me.gbClientes.Controls.Add(Me.ckbClientesConsultar)
        Me.gbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbClientes.Location = New System.Drawing.Point(32, 95)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(151, 149)
        Me.gbClientes.TabIndex = 4
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Clientes"
        '
        'ckbClientesAtivar
        '
        Me.ckbClientesAtivar.AutoSize = True
        Me.ckbClientesAtivar.Location = New System.Drawing.Point(6, 117)
        Me.ckbClientesAtivar.Name = "ckbClientesAtivar"
        Me.ckbClientesAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbClientesAtivar.TabIndex = 4
        Me.ckbClientesAtivar.Text = "Ativar"
        Me.ckbClientesAtivar.UseVisualStyleBackColor = True
        '
        'ckbClientesDesativar
        '
        Me.ckbClientesDesativar.AutoSize = True
        Me.ckbClientesDesativar.Location = New System.Drawing.Point(6, 90)
        Me.ckbClientesDesativar.Name = "ckbClientesDesativar"
        Me.ckbClientesDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbClientesDesativar.TabIndex = 3
        Me.ckbClientesDesativar.Text = "Desativar"
        Me.ckbClientesDesativar.UseVisualStyleBackColor = True
        '
        'ckbClientesAlterar
        '
        Me.ckbClientesAlterar.AutoSize = True
        Me.ckbClientesAlterar.Location = New System.Drawing.Point(6, 67)
        Me.ckbClientesAlterar.Name = "ckbClientesAlterar"
        Me.ckbClientesAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbClientesAlterar.TabIndex = 2
        Me.ckbClientesAlterar.Text = "Alterar"
        Me.ckbClientesAlterar.UseVisualStyleBackColor = True
        '
        'ckbClientesInserir
        '
        Me.ckbClientesInserir.AutoSize = True
        Me.ckbClientesInserir.Location = New System.Drawing.Point(6, 43)
        Me.ckbClientesInserir.Name = "ckbClientesInserir"
        Me.ckbClientesInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbClientesInserir.TabIndex = 1
        Me.ckbClientesInserir.Text = "Inserir"
        Me.ckbClientesInserir.UseVisualStyleBackColor = True
        '
        'ckbClientesConsultar
        '
        Me.ckbClientesConsultar.AutoSize = True
        Me.ckbClientesConsultar.Location = New System.Drawing.Point(6, 19)
        Me.ckbClientesConsultar.Name = "ckbClientesConsultar"
        Me.ckbClientesConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbClientesConsultar.TabIndex = 0
        Me.ckbClientesConsultar.Text = "Consultar"
        Me.ckbClientesConsultar.UseVisualStyleBackColor = True
        '
        'gbVendas
        '
        Me.gbVendas.Controls.Add(Me.ckbVendasAtivar)
        Me.gbVendas.Controls.Add(Me.ckbVendasDesativar)
        Me.gbVendas.Controls.Add(Me.ckbVendasAlterar)
        Me.gbVendas.Controls.Add(Me.ckbVendasInserir)
        Me.gbVendas.Controls.Add(Me.ckbVendasConsultar)
        Me.gbVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVendas.Location = New System.Drawing.Point(32, 250)
        Me.gbVendas.Name = "gbVendas"
        Me.gbVendas.Size = New System.Drawing.Size(151, 148)
        Me.gbVendas.TabIndex = 5
        Me.gbVendas.TabStop = False
        Me.gbVendas.Text = "Vendas"
        '
        'ckbVendasAtivar
        '
        Me.ckbVendasAtivar.AutoSize = True
        Me.ckbVendasAtivar.Location = New System.Drawing.Point(6, 115)
        Me.ckbVendasAtivar.Name = "ckbVendasAtivar"
        Me.ckbVendasAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbVendasAtivar.TabIndex = 8
        Me.ckbVendasAtivar.Text = "Ativar"
        Me.ckbVendasAtivar.UseVisualStyleBackColor = True
        '
        'ckbVendasDesativar
        '
        Me.ckbVendasDesativar.AutoSize = True
        Me.ckbVendasDesativar.Location = New System.Drawing.Point(6, 89)
        Me.ckbVendasDesativar.Name = "ckbVendasDesativar"
        Me.ckbVendasDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbVendasDesativar.TabIndex = 7
        Me.ckbVendasDesativar.Text = "Desativar"
        Me.ckbVendasDesativar.UseVisualStyleBackColor = True
        '
        'ckbVendasAlterar
        '
        Me.ckbVendasAlterar.AutoSize = True
        Me.ckbVendasAlterar.Location = New System.Drawing.Point(6, 66)
        Me.ckbVendasAlterar.Name = "ckbVendasAlterar"
        Me.ckbVendasAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbVendasAlterar.TabIndex = 6
        Me.ckbVendasAlterar.Text = "Alterar"
        Me.ckbVendasAlterar.UseVisualStyleBackColor = True
        '
        'ckbVendasInserir
        '
        Me.ckbVendasInserir.AutoSize = True
        Me.ckbVendasInserir.Location = New System.Drawing.Point(6, 43)
        Me.ckbVendasInserir.Name = "ckbVendasInserir"
        Me.ckbVendasInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbVendasInserir.TabIndex = 5
        Me.ckbVendasInserir.Text = "Inserir"
        Me.ckbVendasInserir.UseVisualStyleBackColor = True
        '
        'ckbVendasConsultar
        '
        Me.ckbVendasConsultar.AutoSize = True
        Me.ckbVendasConsultar.Location = New System.Drawing.Point(6, 20)
        Me.ckbVendasConsultar.Name = "ckbVendasConsultar"
        Me.ckbVendasConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbVendasConsultar.TabIndex = 4
        Me.ckbVendasConsultar.Text = "Consultar"
        Me.ckbVendasConsultar.UseVisualStyleBackColor = True
        '
        'gpUsuarios
        '
        Me.gpUsuarios.Controls.Add(Me.ckbUsuariosAtivar)
        Me.gpUsuarios.Controls.Add(Me.ckbUsuariosDesativar)
        Me.gpUsuarios.Controls.Add(Me.ckbUsuariosAlterar)
        Me.gpUsuarios.Controls.Add(Me.ckbUsuariosInserir)
        Me.gpUsuarios.Controls.Add(Me.ckbUsuariosConsultar)
        Me.gpUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpUsuarios.Location = New System.Drawing.Point(370, 250)
        Me.gpUsuarios.Name = "gpUsuarios"
        Me.gpUsuarios.Size = New System.Drawing.Size(151, 148)
        Me.gpUsuarios.TabIndex = 6
        Me.gpUsuarios.TabStop = False
        Me.gpUsuarios.Text = "Usuarios"
        '
        'ckbUsuariosAtivar
        '
        Me.ckbUsuariosAtivar.AutoSize = True
        Me.ckbUsuariosAtivar.Location = New System.Drawing.Point(6, 115)
        Me.ckbUsuariosAtivar.Name = "ckbUsuariosAtivar"
        Me.ckbUsuariosAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbUsuariosAtivar.TabIndex = 8
        Me.ckbUsuariosAtivar.Text = "Ativar"
        Me.ckbUsuariosAtivar.UseVisualStyleBackColor = True
        '
        'ckbUsuariosDesativar
        '
        Me.ckbUsuariosDesativar.AutoSize = True
        Me.ckbUsuariosDesativar.Location = New System.Drawing.Point(6, 88)
        Me.ckbUsuariosDesativar.Name = "ckbUsuariosDesativar"
        Me.ckbUsuariosDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbUsuariosDesativar.TabIndex = 7
        Me.ckbUsuariosDesativar.Text = "Desativar"
        Me.ckbUsuariosDesativar.UseVisualStyleBackColor = True
        '
        'ckbUsuariosAlterar
        '
        Me.ckbUsuariosAlterar.AutoSize = True
        Me.ckbUsuariosAlterar.Location = New System.Drawing.Point(6, 65)
        Me.ckbUsuariosAlterar.Name = "ckbUsuariosAlterar"
        Me.ckbUsuariosAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbUsuariosAlterar.TabIndex = 6
        Me.ckbUsuariosAlterar.Text = "Alterar"
        Me.ckbUsuariosAlterar.UseVisualStyleBackColor = True
        '
        'ckbUsuariosInserir
        '
        Me.ckbUsuariosInserir.AutoSize = True
        Me.ckbUsuariosInserir.Location = New System.Drawing.Point(6, 42)
        Me.ckbUsuariosInserir.Name = "ckbUsuariosInserir"
        Me.ckbUsuariosInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbUsuariosInserir.TabIndex = 5
        Me.ckbUsuariosInserir.Text = "Inserir"
        Me.ckbUsuariosInserir.UseVisualStyleBackColor = True
        '
        'ckbUsuariosConsultar
        '
        Me.ckbUsuariosConsultar.AutoSize = True
        Me.ckbUsuariosConsultar.Location = New System.Drawing.Point(6, 19)
        Me.ckbUsuariosConsultar.Name = "ckbUsuariosConsultar"
        Me.ckbUsuariosConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbUsuariosConsultar.TabIndex = 4
        Me.ckbUsuariosConsultar.Text = "Consultar"
        Me.ckbUsuariosConsultar.UseVisualStyleBackColor = True
        '
        'gbProdutos
        '
        Me.gbProdutos.Controls.Add(Me.ckbProdutosAtivar)
        Me.gbProdutos.Controls.Add(Me.ckbProdutosDesativar)
        Me.gbProdutos.Controls.Add(Me.ckbProdutosAlterar)
        Me.gbProdutos.Controls.Add(Me.ckbProdutosInserir)
        Me.gbProdutos.Controls.Add(Me.ckbProdutosConsultar)
        Me.gbProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProdutos.Location = New System.Drawing.Point(202, 95)
        Me.gbProdutos.Name = "gbProdutos"
        Me.gbProdutos.Size = New System.Drawing.Size(151, 149)
        Me.gbProdutos.TabIndex = 7
        Me.gbProdutos.TabStop = False
        Me.gbProdutos.Text = "Produtos"
        '
        'ckbProdutosAtivar
        '
        Me.ckbProdutosAtivar.AutoSize = True
        Me.ckbProdutosAtivar.Location = New System.Drawing.Point(6, 117)
        Me.ckbProdutosAtivar.Name = "ckbProdutosAtivar"
        Me.ckbProdutosAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbProdutosAtivar.TabIndex = 8
        Me.ckbProdutosAtivar.Text = "Ativar"
        Me.ckbProdutosAtivar.UseVisualStyleBackColor = True
        '
        'ckbProdutosDesativar
        '
        Me.ckbProdutosDesativar.AutoSize = True
        Me.ckbProdutosDesativar.Location = New System.Drawing.Point(7, 88)
        Me.ckbProdutosDesativar.Name = "ckbProdutosDesativar"
        Me.ckbProdutosDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbProdutosDesativar.TabIndex = 7
        Me.ckbProdutosDesativar.Text = "Desativar"
        Me.ckbProdutosDesativar.UseVisualStyleBackColor = True
        '
        'ckbProdutosAlterar
        '
        Me.ckbProdutosAlterar.AutoSize = True
        Me.ckbProdutosAlterar.Location = New System.Drawing.Point(7, 65)
        Me.ckbProdutosAlterar.Name = "ckbProdutosAlterar"
        Me.ckbProdutosAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbProdutosAlterar.TabIndex = 6
        Me.ckbProdutosAlterar.Text = "Alterar"
        Me.ckbProdutosAlterar.UseVisualStyleBackColor = True
        '
        'ckbProdutosInserir
        '
        Me.ckbProdutosInserir.AutoSize = True
        Me.ckbProdutosInserir.Location = New System.Drawing.Point(7, 42)
        Me.ckbProdutosInserir.Name = "ckbProdutosInserir"
        Me.ckbProdutosInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbProdutosInserir.TabIndex = 5
        Me.ckbProdutosInserir.Text = "Inserir"
        Me.ckbProdutosInserir.UseVisualStyleBackColor = True
        '
        'ckbProdutosConsultar
        '
        Me.ckbProdutosConsultar.AutoSize = True
        Me.ckbProdutosConsultar.Location = New System.Drawing.Point(7, 19)
        Me.ckbProdutosConsultar.Name = "ckbProdutosConsultar"
        Me.ckbProdutosConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbProdutosConsultar.TabIndex = 4
        Me.ckbProdutosConsultar.Text = "Consultar"
        Me.ckbProdutosConsultar.UseVisualStyleBackColor = True
        '
        'gpVendedores
        '
        Me.gpVendedores.Controls.Add(Me.ckbVendedoresAtivar)
        Me.gpVendedores.Controls.Add(Me.ckbVendedoresDesativar)
        Me.gpVendedores.Controls.Add(Me.ckbVendedoresAlterar)
        Me.gpVendedores.Controls.Add(Me.ckbVendedoresInserir)
        Me.gpVendedores.Controls.Add(Me.ckbVendedoresConsultar)
        Me.gpVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpVendedores.Location = New System.Drawing.Point(202, 250)
        Me.gpVendedores.Name = "gpVendedores"
        Me.gpVendedores.Size = New System.Drawing.Size(151, 148)
        Me.gpVendedores.TabIndex = 8
        Me.gpVendedores.TabStop = False
        Me.gpVendedores.Text = "Vendedores"
        '
        'ckbVendedoresAtivar
        '
        Me.ckbVendedoresAtivar.AutoSize = True
        Me.ckbVendedoresAtivar.Location = New System.Drawing.Point(7, 115)
        Me.ckbVendedoresAtivar.Name = "ckbVendedoresAtivar"
        Me.ckbVendedoresAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbVendedoresAtivar.TabIndex = 8
        Me.ckbVendedoresAtivar.Text = "Ativar"
        Me.ckbVendedoresAtivar.UseVisualStyleBackColor = True
        '
        'ckbVendedoresDesativar
        '
        Me.ckbVendedoresDesativar.AutoSize = True
        Me.ckbVendedoresDesativar.Location = New System.Drawing.Point(7, 89)
        Me.ckbVendedoresDesativar.Name = "ckbVendedoresDesativar"
        Me.ckbVendedoresDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbVendedoresDesativar.TabIndex = 7
        Me.ckbVendedoresDesativar.Text = "Desativar"
        Me.ckbVendedoresDesativar.UseVisualStyleBackColor = True
        '
        'ckbVendedoresAlterar
        '
        Me.ckbVendedoresAlterar.AutoSize = True
        Me.ckbVendedoresAlterar.Location = New System.Drawing.Point(7, 65)
        Me.ckbVendedoresAlterar.Name = "ckbVendedoresAlterar"
        Me.ckbVendedoresAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbVendedoresAlterar.TabIndex = 6
        Me.ckbVendedoresAlterar.Text = "Alterar"
        Me.ckbVendedoresAlterar.UseVisualStyleBackColor = True
        '
        'ckbVendedoresInserir
        '
        Me.ckbVendedoresInserir.AutoSize = True
        Me.ckbVendedoresInserir.Location = New System.Drawing.Point(7, 42)
        Me.ckbVendedoresInserir.Name = "ckbVendedoresInserir"
        Me.ckbVendedoresInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbVendedoresInserir.TabIndex = 5
        Me.ckbVendedoresInserir.Text = "Inserir"
        Me.ckbVendedoresInserir.UseVisualStyleBackColor = True
        '
        'ckbVendedoresConsultar
        '
        Me.ckbVendedoresConsultar.AutoSize = True
        Me.ckbVendedoresConsultar.Location = New System.Drawing.Point(7, 19)
        Me.ckbVendedoresConsultar.Name = "ckbVendedoresConsultar"
        Me.ckbVendedoresConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbVendedoresConsultar.TabIndex = 4
        Me.ckbVendedoresConsultar.Text = "Consultar"
        Me.ckbVendedoresConsultar.UseVisualStyleBackColor = True
        '
        'gpGrupos
        '
        Me.gpGrupos.Controls.Add(Me.ckbGruposAtivar)
        Me.gpGrupos.Controls.Add(Me.ckbGruposDesativar)
        Me.gpGrupos.Controls.Add(Me.ckbGruposAlterar)
        Me.gpGrupos.Controls.Add(Me.ckbGruposInserir)
        Me.gpGrupos.Controls.Add(Me.ckbGruposConsultar)
        Me.gpGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpGrupos.Location = New System.Drawing.Point(370, 95)
        Me.gpGrupos.Name = "gpGrupos"
        Me.gpGrupos.Size = New System.Drawing.Size(151, 149)
        Me.gpGrupos.TabIndex = 9
        Me.gpGrupos.TabStop = False
        Me.gpGrupos.Text = "Grupos"
        '
        'ckbGruposAtivar
        '
        Me.ckbGruposAtivar.AutoSize = True
        Me.ckbGruposAtivar.Location = New System.Drawing.Point(6, 114)
        Me.ckbGruposAtivar.Name = "ckbGruposAtivar"
        Me.ckbGruposAtivar.Size = New System.Drawing.Size(61, 20)
        Me.ckbGruposAtivar.TabIndex = 8
        Me.ckbGruposAtivar.Text = "Ativar"
        Me.ckbGruposAtivar.UseVisualStyleBackColor = True
        '
        'ckbGruposDesativar
        '
        Me.ckbGruposDesativar.AutoSize = True
        Me.ckbGruposDesativar.Location = New System.Drawing.Point(7, 88)
        Me.ckbGruposDesativar.Name = "ckbGruposDesativar"
        Me.ckbGruposDesativar.Size = New System.Drawing.Size(85, 20)
        Me.ckbGruposDesativar.TabIndex = 7
        Me.ckbGruposDesativar.Text = "Desativar"
        Me.ckbGruposDesativar.UseVisualStyleBackColor = True
        '
        'ckbGruposAlterar
        '
        Me.ckbGruposAlterar.AutoSize = True
        Me.ckbGruposAlterar.Location = New System.Drawing.Point(7, 65)
        Me.ckbGruposAlterar.Name = "ckbGruposAlterar"
        Me.ckbGruposAlterar.Size = New System.Drawing.Size(66, 20)
        Me.ckbGruposAlterar.TabIndex = 6
        Me.ckbGruposAlterar.Text = "Alterar"
        Me.ckbGruposAlterar.UseVisualStyleBackColor = True
        '
        'ckbGruposInserir
        '
        Me.ckbGruposInserir.AutoSize = True
        Me.ckbGruposInserir.Location = New System.Drawing.Point(7, 42)
        Me.ckbGruposInserir.Name = "ckbGruposInserir"
        Me.ckbGruposInserir.Size = New System.Drawing.Size(63, 20)
        Me.ckbGruposInserir.TabIndex = 5
        Me.ckbGruposInserir.Text = "Inserir"
        Me.ckbGruposInserir.UseVisualStyleBackColor = True
        '
        'ckbGruposConsultar
        '
        Me.ckbGruposConsultar.AutoSize = True
        Me.ckbGruposConsultar.Location = New System.Drawing.Point(7, 19)
        Me.ckbGruposConsultar.Name = "ckbGruposConsultar"
        Me.ckbGruposConsultar.Size = New System.Drawing.Size(83, 20)
        Me.ckbGruposConsultar.TabIndex = 4
        Me.ckbGruposConsultar.Text = "Consultar"
        Me.ckbGruposConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Permissões:"
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(191, 433)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 11
        Me.btnInserir.Text = "OK"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(314, 433)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSelecionarTodos
        '
        Me.btnSelecionarTodos.Location = New System.Drawing.Point(146, 404)
        Me.btnSelecionarTodos.Name = "btnSelecionarTodos"
        Me.btnSelecionarTodos.Size = New System.Drawing.Size(120, 23)
        Me.btnSelecionarTodos.TabIndex = 13
        Me.btnSelecionarTodos.Text = "Selecionar todos"
        Me.btnSelecionarTodos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(32, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigo.TabIndex = 15
        '
        'ckbStatus
        '
        Me.ckbStatus.AutoSize = True
        Me.ckbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbStatus.Location = New System.Drawing.Point(350, 25)
        Me.ckbStatus.Name = "ckbStatus"
        Me.ckbStatus.Size = New System.Drawing.Size(64, 20)
        Me.ckbStatus.TabIndex = 16
        Me.ckbStatus.Text = "Status"
        Me.ckbStatus.UseVisualStyleBackColor = True
        '
        'btnDesmarcarTodos
        '
        Me.btnDesmarcarTodos.Location = New System.Drawing.Point(314, 404)
        Me.btnDesmarcarTodos.Name = "btnDesmarcarTodos"
        Me.btnDesmarcarTodos.Size = New System.Drawing.Size(115, 23)
        Me.btnDesmarcarTodos.TabIndex = 17
        Me.btnDesmarcarTodos.Text = "Desamarcar todos"
        Me.btnDesmarcarTodos.UseVisualStyleBackColor = True
        '
        'frmFormularioGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 473)
        Me.Controls.Add(Me.btnDesmarcarTodos)
        Me.Controls.Add(Me.ckbStatus)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSelecionarTodos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gpGrupos)
        Me.Controls.Add(Me.gpVendedores)
        Me.Controls.Add(Me.gbProdutos)
        Me.Controls.Add(Me.gpUsuarios)
        Me.Controls.Add(Me.gbVendas)
        Me.Controls.Add(Me.gbClientes)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormularioGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário Grupo"
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        Me.gbVendas.ResumeLayout(False)
        Me.gbVendas.PerformLayout()
        Me.gpUsuarios.ResumeLayout(False)
        Me.gpUsuarios.PerformLayout()
        Me.gbProdutos.ResumeLayout(False)
        Me.gbProdutos.PerformLayout()
        Me.gpVendedores.ResumeLayout(False)
        Me.gpVendedores.PerformLayout()
        Me.gpGrupos.ResumeLayout(False)
        Me.gpGrupos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents gbVendas As System.Windows.Forms.GroupBox
    Friend WithEvents gpUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents gbProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents gpVendedores As System.Windows.Forms.GroupBox
    Friend WithEvents gpGrupos As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckbClientesDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbClientesAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbClientesInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbClientesConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendasDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendasAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendasInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendasConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbUsuariosDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbUsuariosAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbUsuariosInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbUsuariosConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProdutosDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProdutosAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProdutosInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProdutosConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendedoresDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendedoresAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendedoresInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbVendedoresConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbGruposDesativar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbGruposAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents ckbGruposInserir As System.Windows.Forms.CheckBox
    Friend WithEvents ckbGruposConsultar As System.Windows.Forms.CheckBox
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSelecionarTodos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ckbStatus As CheckBox
    Friend WithEvents ckbClientesAtivar As CheckBox
    Friend WithEvents ckbVendasAtivar As CheckBox
    Friend WithEvents ckbProdutosAtivar As CheckBox
    Friend WithEvents ckbVendedoresAtivar As CheckBox
    Friend WithEvents ckbUsuariosAtivar As CheckBox
    Friend WithEvents ckbGruposAtivar As CheckBox
    Friend WithEvents btnDesmarcarTodos As Button
End Class
