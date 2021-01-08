<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperarSenha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperarSenha))
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtNovaSenhaDeNovo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNovaSenha = New System.Windows.Forms.Label()
        Me.lblNovaSenhaDeNovo = New System.Windows.Forms.Label()
        Me.btnRevelarSenhaNova = New System.Windows.Forms.Button()
        Me.btnRevelarSenhaDeNovo = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmTempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(48, 235)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(148, 235)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(81, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(34, 95)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtNovaSenha.TabIndex = 3
        '
        'txtNovaSenhaDeNovo
        '
        Me.txtNovaSenhaDeNovo.Location = New System.Drawing.Point(34, 171)
        Me.txtNovaSenhaDeNovo.Name = "txtNovaSenhaDeNovo"
        Me.txtNovaSenhaDeNovo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenhaDeNovo.Size = New System.Drawing.Size(100, 20)
        Me.txtNovaSenhaDeNovo.TabIndex = 4
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(111, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código:"
        '
        'lblNovaSenha
        '
        Me.lblNovaSenha.AutoSize = True
        Me.lblNovaSenha.Location = New System.Drawing.Point(31, 70)
        Me.lblNovaSenha.Name = "lblNovaSenha"
        Me.lblNovaSenha.Size = New System.Drawing.Size(70, 13)
        Me.lblNovaSenha.TabIndex = 6
        Me.lblNovaSenha.Text = "Nova Senha:"
        '
        'lblNovaSenhaDeNovo
        '
        Me.lblNovaSenhaDeNovo.AutoSize = True
        Me.lblNovaSenhaDeNovo.Location = New System.Drawing.Point(31, 143)
        Me.lblNovaSenhaDeNovo.Name = "lblNovaSenhaDeNovo"
        Me.lblNovaSenhaDeNovo.Size = New System.Drawing.Size(94, 13)
        Me.lblNovaSenhaDeNovo.TabIndex = 7
        Me.lblNovaSenhaDeNovo.Text = "Confirme a Senha:"
        '
        'btnRevelarSenhaNova
        '
        Me.btnRevelarSenhaNova.Location = New System.Drawing.Point(148, 92)
        Me.btnRevelarSenhaNova.Name = "btnRevelarSenhaNova"
        Me.btnRevelarSenhaNova.Size = New System.Drawing.Size(93, 23)
        Me.btnRevelarSenhaNova.TabIndex = 8
        Me.btnRevelarSenhaNova.Text = "Revelar Senha"
        Me.btnRevelarSenhaNova.UseVisualStyleBackColor = True
        '
        'btnRevelarSenhaDeNovo
        '
        Me.btnRevelarSenhaDeNovo.Location = New System.Drawing.Point(148, 169)
        Me.btnRevelarSenhaDeNovo.Name = "btnRevelarSenhaDeNovo"
        Me.btnRevelarSenhaDeNovo.Size = New System.Drawing.Size(93, 23)
        Me.btnRevelarSenhaDeNovo.TabIndex = 9
        Me.btnRevelarSenhaDeNovo.Text = "Revelar Senha"
        Me.btnRevelarSenhaDeNovo.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tmTempo
        '
        Me.tmTempo.Interval = 1000
        '
        'frmRecuperarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 275)
        Me.Controls.Add(Me.btnRevelarSenhaDeNovo)
        Me.Controls.Add(Me.btnRevelarSenhaNova)
        Me.Controls.Add(Me.lblNovaSenhaDeNovo)
        Me.Controls.Add(Me.lblNovaSenha)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtNovaSenhaDeNovo)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecuperarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Senha:"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNovaSenha As TextBox
    Friend WithEvents txtNovaSenhaDeNovo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNovaSenha As Label
    Friend WithEvents lblNovaSenhaDeNovo As Label
    Friend WithEvents btnRevelarSenhaNova As Button
    Friend WithEvents btnRevelarSenhaDeNovo As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tmTempo As Timer
End Class
