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
        Lbl_Propriedade.Text = "Propriedade"
    End Sub

    Private Sub Btn_Processo_Click(sender As Object, e As EventArgs) Handles Btn_Processo.Click
        Dim vUrl As New ExtrairValorDeArgumentosUrl(Txt_Url.Text)
        Txt_Resultado.Text = vUrl.argumento

        Dim vPropriedade As String = Txt_Propriedade.Text
        Dim vIndex As Integer = vUrl.argumento.IndexOf(vPropriedade)

        Dim vValorParcial As String = vUrl.argumento.Substring(vIndex)

        Dim vIndex2 As Integer = vValorParcial.IndexOf("&")

        Dim vValor As String = Nothing
        If vIndex2 = -1 Then
            vValor = vValorParcial.Substring(0)
        Else
            vValor = vValorParcial.Substring(0, vIndex2)
        End If



        MsgBox(vValor)

    End Sub
End Class