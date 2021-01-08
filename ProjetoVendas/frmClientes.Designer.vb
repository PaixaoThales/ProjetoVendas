<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckbStatus = New System.Windows.Forms.CheckBox()
        Me.btnAtivar = New System.Windows.Forms.Button()
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
        Me.grid.Location = New System.Drawing.Point(12, 28)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(399, 215)
        Me.grid.TabIndex = 0
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(12, 264)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(122, 23)
        Me.btnInserir.TabIndex = 1
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(140, 264)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(122, 23)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnDesativar
        '
        Me.btnDesativar.Location = New System.Drawing.Point(268, 264)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(64, 23)
        Me.btnDesativar.TabIndex = 3
        Me.btnDesativar.Text = "Desativar"
        Me.btnDesativar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clientes cadastrados:"
        '
        'ckbStatus
        '
        Me.ckbStatus.AutoSize = True
        Me.ckbStatus.Location = New System.Drawing.Point(299, 7)
        Me.ckbStatus.Name = "ckbStatus"
        Me.ckbStatus.Size = New System.Drawing.Size(113, 17)
        Me.ckbStatus.TabIndex = 5
        Me.ckbStatus.Text = "Exibir Desativados"
        Me.ckbStatus.UseVisualStyleBackColor = True
        '
        'btnAtivar
        '
        Me.btnAtivar.Location = New System.Drawing.Point(338, 264)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(73, 23)
        Me.btnAtivar.TabIndex = 6
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 299)
        Me.Controls.Add(Me.btnAtivar)
        Me.Controls.Add(Me.ckbStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário de clientes"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbStatus As CheckBox
    Friend WithEvents btnAtivar As Button
End Class
