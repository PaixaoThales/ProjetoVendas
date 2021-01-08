<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormularioProdutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormularioProdutos))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.ckbStatus = New System.Windows.Forms.CheckBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.epErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pcbImagem = New System.Windows.Forms.PictureBox()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.txtCaminho = New System.Windows.Forms.TextBox()
        Me.lblImagem = New System.Windows.Forms.Label()
        Me.txtCaminhoAntigo = New System.Windows.Forms.TextBox()
        CType(Me.epErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(26, 51)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(60, 18)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(26, 109)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 18)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome:"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.Location = New System.Drawing.Point(27, 167)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(52, 18)
        Me.lblPreco.TabIndex = 2
        Me.lblPreco.Text = "Preço:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(29, 72)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(58, 24)
        Me.txtCodigo.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(29, 130)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 24)
        Me.txtNome.TabIndex = 1
        '
        'txtPreco
        '
        Me.txtPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreco.Location = New System.Drawing.Point(30, 188)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(173, 24)
        Me.txtPreco.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Green
        Me.btnOK.Location = New System.Drawing.Point(26, 296)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(128, 296)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(27, 231)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(87, 18)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(30, 252)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(173, 24)
        Me.txtQuantidade.TabIndex = 3
        '
        'ckbStatus
        '
        Me.ckbStatus.AutoSize = True
        Me.ckbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbStatus.Location = New System.Drawing.Point(111, 67)
        Me.ckbStatus.Name = "ckbStatus"
        Me.ckbStatus.Size = New System.Drawing.Size(75, 24)
        Me.ckbStatus.TabIndex = 4
        Me.ckbStatus.Text = "Status"
        Me.ckbStatus.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(21, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(71, 25)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Título"
        '
        'epErro
        '
        Me.epErro.ContainerControl = Me
        '
        'pcbImagem
        '
        Me.pcbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbImagem.Location = New System.Drawing.Point(246, 51)
        Me.pcbImagem.Name = "pcbImagem"
        Me.pcbImagem.Size = New System.Drawing.Size(156, 182)
        Me.pcbImagem.TabIndex = 12
        Me.pcbImagem.TabStop = False
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(246, 252)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionar.TabIndex = 13
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(327, 252)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 14
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'txtCaminho
        '
        Me.txtCaminho.Location = New System.Drawing.Point(246, 299)
        Me.txtCaminho.Name = "txtCaminho"
        Me.txtCaminho.Size = New System.Drawing.Size(75, 20)
        Me.txtCaminho.TabIndex = 15
        Me.txtCaminho.Visible = False
        '
        'lblImagem
        '
        Me.lblImagem.AutoSize = True
        Me.lblImagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagem.Location = New System.Drawing.Point(301, 32)
        Me.lblImagem.Name = "lblImagem"
        Me.lblImagem.Size = New System.Drawing.Size(57, 16)
        Me.lblImagem.TabIndex = 16
        Me.lblImagem.Text = "Imagem"
        '
        'txtCaminhoAntigo
        '
        Me.txtCaminhoAntigo.Location = New System.Drawing.Point(327, 299)
        Me.txtCaminhoAntigo.Name = "txtCaminhoAntigo"
        Me.txtCaminhoAntigo.Size = New System.Drawing.Size(75, 20)
        Me.txtCaminhoAntigo.TabIndex = 17
        Me.txtCaminhoAntigo.Visible = False
        '
        'frmFormularioProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 341)
        Me.Controls.Add(Me.txtCaminhoAntigo)
        Me.Controls.Add(Me.lblImagem)
        Me.Controls.Add(Me.txtCaminho)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.pcbImagem)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.ckbStatus)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormularioProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.epErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents ckbStatus As CheckBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents epErro As ErrorProvider
    Friend WithEvents txtCaminho As TextBox
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnSelecionar As Button
    Friend WithEvents pcbImagem As PictureBox
    Friend WithEvents lblImagem As Label
    Friend WithEvents txtCaminhoAntigo As TextBox
End Class
