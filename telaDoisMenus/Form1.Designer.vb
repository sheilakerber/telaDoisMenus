<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcaoAmenu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcaoBmenu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcaoCmenu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcaoAbrirMenu2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcaoFecharMenu2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.Menu2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcaoAmenu1, Me.opcaoBmenu1, Me.opcaoCmenu1})
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.Menu1ToolStripMenuItem.Text = "Menu 1"
        '
        'opcaoAmenu1
        '
        Me.opcaoAmenu1.Name = "opcaoAmenu1"
        Me.opcaoAmenu1.Size = New System.Drawing.Size(152, 22)
        Me.opcaoAmenu1.Text = "Opção A"
        '
        'opcaoBmenu1
        '
        Me.opcaoBmenu1.Name = "opcaoBmenu1"
        Me.opcaoBmenu1.Size = New System.Drawing.Size(152, 22)
        Me.opcaoBmenu1.Text = "Opção B"
        '
        'opcaoCmenu1
        '
        Me.opcaoCmenu1.Name = "opcaoCmenu1"
        Me.opcaoCmenu1.Size = New System.Drawing.Size(152, 22)
        Me.opcaoCmenu1.Text = "Opção C"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcaoAbrirMenu2, Me.opcaoFecharMenu2})
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.Menu2ToolStripMenuItem.Text = "Menu 2"
        '
        'opcaoAbrirMenu2
        '
        Me.opcaoAbrirMenu2.Name = "opcaoAbrirMenu2"
        Me.opcaoAbrirMenu2.Size = New System.Drawing.Size(152, 22)
        Me.opcaoAbrirMenu2.Text = "Abrir"
        '
        'opcaoFecharMenu2
        '
        Me.opcaoFecharMenu2.Name = "opcaoFecharMenu2"
        Me.opcaoFecharMenu2.Size = New System.Drawing.Size(152, 22)
        Me.opcaoFecharMenu2.Text = "Fechar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menus"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcaoAmenu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcaoBmenu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcaoCmenu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcaoAbrirMenu2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcaoFecharMenu2 As System.Windows.Forms.ToolStripMenuItem

End Class
