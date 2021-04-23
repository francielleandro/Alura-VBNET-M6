<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal2vb
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
        Me.Lbl_Principal2 = New System.Windows.Forms.Label()
        Me.Txt_Url = New System.Windows.Forms.TextBox()
        Me.Lbl_Url = New System.Windows.Forms.Label()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Btn_Processo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal2
        '
        Me.Lbl_Principal2.AutoSize = True
        Me.Lbl_Principal2.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Principal2.Name = "Lbl_Principal2"
        Me.Lbl_Principal2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal2.TabIndex = 0
        Me.Lbl_Principal2.Text = "Label1"
        '
        'Txt_Url
        '
        Me.Txt_Url.Location = New System.Drawing.Point(16, 65)
        Me.Txt_Url.Multiline = True
        Me.Txt_Url.Name = "Txt_Url"
        Me.Txt_Url.Size = New System.Drawing.Size(649, 161)
        Me.Txt_Url.TabIndex = 6
        '
        'Lbl_Url
        '
        Me.Lbl_Url.AutoSize = True
        Me.Lbl_Url.Location = New System.Drawing.Point(12, 38)
        Me.Lbl_Url.Name = "Lbl_Url"
        Me.Lbl_Url.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Url.TabIndex = 5
        Me.Lbl_Url.Text = "Label1"
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(16, 266)
        Me.Txt_Resultado.Multiline = True
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(649, 109)
        Me.Txt_Resultado.TabIndex = 8
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(12, 239)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Resultado.TabIndex = 7
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Btn_Processo
        '
        Me.Btn_Processo.Location = New System.Drawing.Point(552, 237)
        Me.Btn_Processo.Name = "Btn_Processo"
        Me.Btn_Processo.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Processo.TabIndex = 9
        Me.Btn_Processo.Text = "Button1"
        Me.Btn_Processo.UseVisualStyleBackColor = True
        '
        'Frm_Principal2vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Processo)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Url)
        Me.Controls.Add(Me.Lbl_Url)
        Me.Controls.Add(Me.Lbl_Principal2)
        Me.Name = "Frm_Principal2vb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal2vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal2 As Label
    Friend WithEvents Txt_Url As TextBox
    Friend WithEvents Lbl_Url As Label
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Btn_Processo As Button
End Class
