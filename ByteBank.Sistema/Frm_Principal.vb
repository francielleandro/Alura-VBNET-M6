Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Fomulário Principal"
        Lbl_Principal.Text = "Fomulário Principal"
        Btn_Principal.Text = "Clique Aqui"
        Lbl_Url.Text = "URL"
        Lbl_Separador.Text = "Separador"

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim url As String = Txt_Url.Text
        Dim separador As String = Txt_Separador.Text
        Dim posiçaoInt As Integer = InStr(url, separador)
        MsgBox(posiçaoInt.ToString)
        MsgBox(url)
        Dim principal As String = url.Substring(posiçaoInt)
        MsgBox(principal)
    End Sub
End Class
