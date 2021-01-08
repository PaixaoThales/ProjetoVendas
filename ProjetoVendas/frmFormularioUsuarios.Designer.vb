<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormularioUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormularioUsuarios))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRevelarSenha = New System.Windows.Forms.Button()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.ckbStatus = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(12, 5)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(60, 18)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(15, 26)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(84, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncionario.Location = New System.Drawing.Point(12, 108)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(90, 18)
        Me.lblFuncionario.TabIndex = 2
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "login:"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(15, 182)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(188, 20)
        Me.txtLogin.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grupo:"
        '
        'cbGrupos
        '
        Me.cbGrupos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbGrupos.FormattingEnabled = True
        Me.cbGrupos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbGrupos.Location = New System.Drawing.Point(15, 82)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(155, 21)
        Me.cbGrupos.TabIndex = 7
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(12, 213)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(54, 18)
        Me.lblSenha.TabIndex = 8
        Me.lblSenha.Text = "Senha:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(15, 234)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(140, 20)
        Me.txtSenha.TabIndex = 9
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(34, 274)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(161, 277)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRevelarSenha
        '
        Me.btnRevelarSenha.Location = New System.Drawing.Point(163, 232)
        Me.btnRevelarSenha.Name = "btnRevelarSenha"
        Me.btnRevelarSenha.Size = New System.Drawing.Size(96, 23)
        Me.btnRevelarSenha.TabIndex = 12
        Me.btnRevelarSenha.Text = "Revelar Senha"
        Me.btnRevelarSenha.UseVisualStyleBackColor = True
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(15, 130)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(155, 21)
        Me.cbFuncionario.TabIndex = 13
        '
        'ckbStatus
        '
        Me.ckbStatus.AutoSize = True
        Me.ckbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbStatus.Location = New System.Drawing.Point(136, 26)
        Me.ckbStatus.Name = "ckbStatus"
        Me.ckbStatus.Size = New System.Drawing.Size(64, 20)
        Me.ckbStatus.TabIndex = 14
        Me.ckbStatus.Text = "Status"
        Me.ckbStatus.UseVisualStyleBackColor = True
        '
        'frmFormularioUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 304)
        Me.Controls.Add(Me.ckbStatus)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.btnRevelarSenha)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.cbGrupos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFuncionario)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormularioUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRevelarSenha As System.Windows.Forms.Button
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents ckbStatus As CheckBox
End Class
