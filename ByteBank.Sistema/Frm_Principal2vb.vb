Imports ByteBank.Bibliotecas.Classes
Public Class Frm_Principal2vb
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Formulario Principal 2"
        Lbl_Principal2.Text = "Formulario Principal 2"
        Lbl_Url.Text = "URL"
        Lbl_Resultado.Text = "Resultado"
        Txt_Resultado.ReadOnly = True
        Btn_Processo.Text = "Processar"
    End Sub

    Private Sub Btn_Processo_Click(sender As Object, e As EventArgs) Handles Btn_Processo.Click
        Dim vUrl As New ExtrairValorDeArgumentosUrl(Txt_Url.Text)
        Txt_Resultado.Text = vUrl.argumento
    End Sub
End Class