Imports ByteBank.Bibliotecas.Classes
Public Class Frm_PaginaWeb
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Página Web"
        Lbl_Url.Text = "URL"
        Btn_Url.Text = "GO"
        Grp_Url.Text = ""
        Grp_WebBrowser.Text = ""
        Btn_Propriedades.Text = "Prop"
    End Sub

    Private Sub Btn_Url_Click(sender As Object, e As EventArgs) Handles Btn_Url.Click

        Dim URL As String = Txt_Url.Text

        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            Wb_Pagina.ScriptErrorsSuppressed = True
            Wb_Pagina.Navigate(URL)
        End If

    End Sub

    Private Sub Btn_Propriedades_Click(sender As Object, e As EventArgs) Handles Btn_Propriedades.Click

        Dim URL As String = Txt_Url.Text
        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            URL = Wb_Pagina.Url.ToString
            Txt_Url.Text = URL
            Dim paginaURL As New ExtrairValorDeArgumentosUrl(URL)
            Dim propriedadesURL As String = paginaURL.GetTodosArgumentos
            MsgBox(propriedadesURL, MsgBoxStyle.Information, "URL")
        End If

    End Sub
End Class