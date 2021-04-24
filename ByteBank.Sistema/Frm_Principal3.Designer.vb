<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal3
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.Txt_Verificar = New System.Windows.Forms.TextBox()
        Me.Lbl_Texto = New System.Windows.Forms.Label()
        Me.Lbl_Expressao = New System.Windows.Forms.Label()
        Me.Txt_Expressao = New System.Windows.Forms.TextBox()
        Me.Lbl_Padrao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(362, 222)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Principal.TabIndex = 1
        Me.Btn_Principal.Text = "Button1"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Txt_Verificar
        '
        Me.Txt_Verificar.Location = New System.Drawing.Point(12, 58)
        Me.Txt_Verificar.Name = "Txt_Verificar"
        Me.Txt_Verificar.Size = New System.Drawing.Size(425, 20)
        Me.Txt_Verificar.TabIndex = 2
        '
        'Lbl_Texto
        '
        Me.Lbl_Texto.AutoSize = True
        Me.Lbl_Texto.Location = New System.Drawing.Point(12, 42)
        Me.Lbl_Texto.Name = "Lbl_Texto"
        Me.Lbl_Texto.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Texto.TabIndex = 3
        Me.Lbl_Texto.Text = "Label1"
        '
        'Lbl_Expressao
        '
        Me.Lbl_Expressao.AutoSize = True
        Me.Lbl_Expressao.Location = New System.Drawing.Point(12, 110)
        Me.Lbl_Expressao.Name = "Lbl_Expressao"
        Me.Lbl_Expressao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Expressao.TabIndex = 5
        Me.Lbl_Expressao.Text = "Label1"
        '
        'Txt_Expressao
        '
        Me.Txt_Expressao.Location = New System.Drawing.Point(12, 126)
        Me.Txt_Expressao.Name = "Txt_Expressao"
        Me.Txt_Expressao.Size = New System.Drawing.Size(425, 20)
        Me.Txt_Expressao.TabIndex = 4
        '
        'Lbl_Padrao
        '
        Me.Lbl_Padrao.AutoSize = True
        Me.Lbl_Padrao.Location = New System.Drawing.Point(15, 153)
        Me.Lbl_Padrao.Name = "Lbl_Padrao"
        Me.Lbl_Padrao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Padrao.TabIndex = 6
        Me.Lbl_Padrao.Text = "Label1"
        '
        'Frm_Principal3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 257)
        Me.Controls.Add(Me.Lbl_Padrao)
        Me.Controls.Add(Me.Lbl_Expressao)
        Me.Controls.Add(Me.Txt_Expressao)
        Me.Controls.Add(Me.Lbl_Texto)
        Me.Controls.Add(Me.Txt_Verificar)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Txt_Verificar As TextBox
    Friend WithEvents Lbl_Texto As Label
    Friend WithEvents Lbl_Expressao As Label
    Friend WithEvents Txt_Expressao As TextBox
    Friend WithEvents Lbl_Padrao As Label
End Class
