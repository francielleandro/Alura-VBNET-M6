<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_URLs
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
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelaHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelaVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelaCascataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JanelaHorizontalToolStripMenuItem, Me.JanelaVerticalToolStripMenuItem, Me.JanelaCascataToolStripMenuItem})
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'JanelaHorizontalToolStripMenuItem
        '
        Me.JanelaHorizontalToolStripMenuItem.Name = "JanelaHorizontalToolStripMenuItem"
        Me.JanelaHorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JanelaHorizontalToolStripMenuItem.Text = "Janelas Horizontais"
        '
        'JanelaVerticalToolStripMenuItem
        '
        Me.JanelaVerticalToolStripMenuItem.Name = "JanelaVerticalToolStripMenuItem"
        Me.JanelaVerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JanelaVerticalToolStripMenuItem.Text = "Janelas Verticais"
        '
        'JanelaCascataToolStripMenuItem
        '
        Me.JanelaCascataToolStripMenuItem.Name = "JanelaCascataToolStripMenuItem"
        Me.JanelaCascataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JanelaCascataToolStripMenuItem.Text = "Janelas em Cascata"
        '
        'Frm_URLs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_URLs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_URLs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelaHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelaVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelaCascataToolStripMenuItem As ToolStripMenuItem
End Class
