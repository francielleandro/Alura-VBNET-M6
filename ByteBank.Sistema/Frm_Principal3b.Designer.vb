<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal3b
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
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Principal03a = New System.Windows.Forms.Button()
        Me.Btn_Principal03b = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(15, 56)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Principal.TabIndex = 8
        Me.Btn_Principal.Text = "Button1"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 14)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 7
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Principal03a
        '
        Me.Btn_Principal03a.Location = New System.Drawing.Point(15, 86)
        Me.Btn_Principal03a.Name = "Btn_Principal03a"
        Me.Btn_Principal03a.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Principal03a.TabIndex = 9
        Me.Btn_Principal03a.Text = "Button1"
        Me.Btn_Principal03a.UseVisualStyleBackColor = True
        '
        'Btn_Principal03b
        '
        Me.Btn_Principal03b.Location = New System.Drawing.Point(15, 116)
        Me.Btn_Principal03b.Name = "Btn_Principal03b"
        Me.Btn_Principal03b.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Principal03b.TabIndex = 10
        Me.Btn_Principal03b.Text = "Button1"
        Me.Btn_Principal03b.UseVisualStyleBackColor = True
        '
        'Frm_Principal3b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 235)
        Me.Controls.Add(Me.Btn_Principal03b)
        Me.Controls.Add(Me.Btn_Principal03a)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal3b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal3b"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Principal03a As Button
    Friend WithEvents Btn_Principal03b As Button
End Class
