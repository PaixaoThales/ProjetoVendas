<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigConexao
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.ckbAutWindows = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnTestar = New System.Windows.Forms.Button()
        Me.btnStringConexao = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servidor:"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(35, 26)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(171, 20)
        Me.txtServidor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Banco:"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(35, 77)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(171, 20)
        Me.txtBanco.TabIndex = 2
        '
        'ckbAutWindows
        '
        Me.ckbAutWindows.AutoSize = True
        Me.ckbAutWindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbAutWindows.Location = New System.Drawing.Point(35, 118)
        Me.ckbAutWindows.Name = "ckbAutWindows"
        Me.ckbAutWindows.Size = New System.Drawing.Size(182, 20)
        Me.ckbAutWindows.TabIndex = 3
        Me.ckbAutWindows.Text = "Autenticação do Windows"
        Me.ckbAutWindows.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuário:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(35, 169)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(168, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(35, 217)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(168, 20)
        Me.txtSenha.TabIndex = 5
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'btnTestar
        '
        Me.btnTestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestar.Location = New System.Drawing.Point(12, 243)
        Me.btnTestar.Name = "btnTestar"
        Me.btnTestar.Size = New System.Drawing.Size(101, 23)
        Me.btnTestar.TabIndex = 6
        Me.btnTestar.Text = "Testar "
        Me.btnTestar.UseVisualStyleBackColor = True
        '
        'btnStringConexao
        '
        Me.btnStringConexao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStringConexao.Location = New System.Drawing.Point(38, 272)
        Me.btnStringConexao.Name = "btnStringConexao"
        Me.btnStringConexao.Size = New System.Drawing.Size(173, 23)
        Me.btnStringConexao.TabIndex = 8
        Me.btnStringConexao.Text = "Exibir String de Conexão"
        Me.btnStringConexao.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Location = New System.Drawing.Point(134, 243)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(100, 23)
        Me.btnGravar.TabIndex = 7
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(56, 310)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(135, 23)
        Me.btnFinalizar.TabIndex = 9
        Me.btnFinalizar.Text = "Finalizar configurações"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'frmConfigConexao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 345)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnStringConexao)
        Me.Controls.Add(Me.btnTestar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ckbAutWindows)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServidor)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigConexao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração da conexão"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents ckbAutWindows As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnTestar As System.Windows.Forms.Button
    Friend WithEvents btnStringConexao As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
End Class
