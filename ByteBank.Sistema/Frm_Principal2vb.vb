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
        Txt_Argumento.ReadOnly = True
        Btn_Processo.Text = "Processar"
        Lbl_Propriedade.Text = "Propriedade"
    End Sub

    Private Sub Btn_Processo_Click(sender As Object, e As EventArgs) Handles Btn_Processo.Click
        Dim vUrl As New ExtrairValorDeArgumentosUrl(Txt_Url.Text)
        If Not vUrl.IsByteBank Then
            MsgBox("URL não é do dominio do banco ByteBank")
        Else
            Txt_Argumento.Text = vUrl.argumento
            Dim vPropriedade As String = Txt_Propriedade.Text
            MsgBox(vUrl.GetValor(vPropriedade))
        End If

    End Sub
End Class