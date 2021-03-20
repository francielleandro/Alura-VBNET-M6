<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Lbl_Url = New System.Windows.Forms.Label()
        Me.Lbl_Separador = New System.Windows.Forms.Label()
        Me.Txt_Url = New System.Windows.Forms.TextBox()
        Me.Txt_Separador = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(188, 195)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(144, 67)
        Me.Btn_Principal.TabIndex = 1
        Me.Btn_Principal.Text = "Button1"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_Url
        '
        Me.Lbl_Url.AutoSize = True
        Me.Lbl_Url.Location = New System.Drawing.Point(13, 80)
        Me.Lbl_Url.Name = "Lbl_Url"
        Me.Lbl_Url.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Url.TabIndex = 2
        Me.Lbl_Url.Text = "Label1"
        '
        'Lbl_Separador
        '
        Me.Lbl_Separador.AutoSize = True
        Me.Lbl_Separador.Location = New System.Drawing.Point(13, 135)
        Me.Lbl_Separador.Name = "Lbl_Separador"
        Me.Lbl_Separador.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Separador.TabIndex = 3
        Me.Lbl_Separador.Text = "Label1"
        '
        'Txt_Url
        '
        Me.Txt_Url.Location = New System.Drawing.Point(74, 73)
        Me.Txt_Url.Name = "Txt_Url"
        Me.Txt_Url.Size = New System.Drawing.Size(473, 20)
        Me.Txt_Url.TabIndex = 4
        '
        'Txt_Separador
        '
        Me.Txt_Separador.Location = New System.Drawing.Point(74, 128)
        Me.Txt_Separador.Name = "Txt_Separador"
        Me.Txt_Separador.Size = New System.Drawing.Size(473, 20)
        Me.Txt_Separador.TabIndex = 5
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 310)
        Me.Controls.Add(Me.Txt_Separador)
        Me.Controls.Add(Me.Txt_Url)
        Me.Controls.Add(Me.Lbl_Separador)
        Me.Controls.Add(Me.Lbl_Url)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_Url As Label
    Friend WithEvents Lbl_Separador As Label
    Friend WithEvents Txt_Url As TextBox
    Friend WithEvents Txt_Separador As TextBox
End Class
