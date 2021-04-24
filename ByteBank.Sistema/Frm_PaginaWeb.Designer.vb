<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PaginaWeb
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
        Me.Grp_Url = New System.Windows.Forms.GroupBox()
        Me.Lbl_Url = New System.Windows.Forms.Label()
        Me.Btn_Url = New System.Windows.Forms.Button()
        Me.Btn_Propriedades = New System.Windows.Forms.Button()
        Me.Txt_Url = New System.Windows.Forms.TextBox()
        Me.Grp_WebBrowser = New System.Windows.Forms.GroupBox()
        Me.Wb_Pagina = New System.Windows.Forms.WebBrowser()
        Me.Grp_Url.SuspendLayout()
        Me.Grp_WebBrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_Url
        '
        Me.Grp_Url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Url.Controls.Add(Me.Txt_Url)
        Me.Grp_Url.Controls.Add(Me.Btn_Propriedades)
        Me.Grp_Url.Controls.Add(Me.Btn_Url)
        Me.Grp_Url.Controls.Add(Me.Lbl_Url)
        Me.Grp_Url.Location = New System.Drawing.Point(13, 13)
        Me.Grp_Url.Name = "Grp_Url"
        Me.Grp_Url.Size = New System.Drawing.Size(758, 177)
        Me.Grp_Url.TabIndex = 0
        Me.Grp_Url.TabStop = False
        Me.Grp_Url.Text = "GroupBox1"
        '
        'Lbl_Url
        '
        Me.Lbl_Url.AutoSize = True
        Me.Lbl_Url.Location = New System.Drawing.Point(7, 28)
        Me.Lbl_Url.Name = "Lbl_Url"
        Me.Lbl_Url.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Url.TabIndex = 0
        Me.Lbl_Url.Text = "Label1"
        '
        'Btn_Url
        '
        Me.Btn_Url.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Url.Location = New System.Drawing.Point(10, 56)
        Me.Btn_Url.Name = "Btn_Url"
        Me.Btn_Url.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Url.TabIndex = 1
        Me.Btn_Url.Text = "Button1"
        Me.Btn_Url.UseVisualStyleBackColor = True
        '
        'Btn_Propriedades
        '
        Me.Btn_Propriedades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Propriedades.Location = New System.Drawing.Point(10, 94)
        Me.Btn_Propriedades.Name = "Btn_Propriedades"
        Me.Btn_Propriedades.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Propriedades.TabIndex = 2
        Me.Btn_Propriedades.Text = "Button1"
        Me.Btn_Propriedades.UseVisualStyleBackColor = True
        '
        'Txt_Url
        '
        Me.Txt_Url.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Url.Location = New System.Drawing.Point(10, 123)
        Me.Txt_Url.Multiline = True
        Me.Txt_Url.Name = "Txt_Url"
        Me.Txt_Url.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Url.Size = New System.Drawing.Size(719, 25)
        Me.Txt_Url.TabIndex = 3
        '
        'Grp_WebBrowser
        '
        Me.Grp_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_WebBrowser.Controls.Add(Me.Wb_Pagina)
        Me.Grp_WebBrowser.Location = New System.Drawing.Point(13, 196)
        Me.Grp_WebBrowser.Name = "Grp_WebBrowser"
        Me.Grp_WebBrowser.Size = New System.Drawing.Size(775, 242)
        Me.Grp_WebBrowser.TabIndex = 1
        Me.Grp_WebBrowser.TabStop = False
        Me.Grp_WebBrowser.Text = "GroupBox1"
        '
        'Wb_Pagina
        '
        Me.Wb_Pagina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wb_Pagina.Location = New System.Drawing.Point(3, 16)
        Me.Wb_Pagina.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Wb_Pagina.Name = "Wb_Pagina"
        Me.Wb_Pagina.Size = New System.Drawing.Size(769, 223)
        Me.Wb_Pagina.TabIndex = 0
        '
        'Frm_PaginaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Grp_WebBrowser)
        Me.Controls.Add(Me.Grp_Url)
        Me.Name = "Frm_PaginaWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_PaginaWeb"
        Me.Grp_Url.ResumeLayout(False)
        Me.Grp_Url.PerformLayout()
        Me.Grp_WebBrowser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grp_Url As GroupBox
    Friend WithEvents Lbl_Url As Label
    Friend WithEvents Txt_Url As TextBox
    Friend WithEvents Btn_Propriedades As Button
    Friend WithEvents Btn_Url As Button
    Friend WithEvents Grp_WebBrowser As GroupBox
    Friend WithEvents Wb_Pagina As WebBrowser
End Class
