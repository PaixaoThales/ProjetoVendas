<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConexao = New System.Windows.Forms.Button()
        Me.lklblEsqueceuSenha = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtNome
        '
        resources.ApplyResources(Me.txtNome, "txtNome")
        Me.txtNome.Name = "txtNome"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtSenha
        '
        resources.ApplyResources(Me.txtSenha, "txtSenha")
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnConexao
        '
        Me.btnConexao.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.btnConexao, "btnConexao")
        Me.btnConexao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConexao.Name = "btnConexao"
        Me.btnConexao.UseVisualStyleBackColor = False
        '
        'lklblEsqueceuSenha
        '
        resources.ApplyResources(Me.lklblEsqueceuSenha, "lklblEsqueceuSenha")
        Me.lklblEsqueceuSenha.Name = "lklblEsqueceuSenha"
        Me.lklblEsqueceuSenha.TabStop = True
        '
        'frmLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lklblEsqueceuSenha)
        Me.Controls.Add(Me.btnConexao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConexao As System.Windows.Forms.Button
    Friend WithEvents lklblEsqueceuSenha As LinkLabel
End Class
