Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Fomulário Principal"
        Lbl_Principal.Text = "Fomulário Principal"
        Btn_Principal.Text = "Teste (InStr)"
        Btn_Principal2.Text = "Teste (IndexOf)"
        Lbl_Url.Text = "URL"
        Lbl_Separador.Text = "Separador"

    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Try
            ExecutaTesteURL()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ExecutaTesteURL()

        Dim url As String = Txt_Url.Text
        Dim separador As String = Txt_Separador.Text

        If url = "" Then
            Throw New Exception("URL vazia")
        End If

        If separador = "" Then
            Throw New Exception("Separador vazio")
        End If

        Dim posicaoInt As Integer = InStr(url, separador)

        If posicaoInt = 0 Then
            Throw New Exception("Posição vazia")
        End If

        Dim principal As String = url.Substring(posicaoInt)

        MsgBox(principal)

    End Sub

    Private Sub Btn_Principal2_Click(sender As Object, e As EventArgs) Handles Btn_Principal2.Click
        Try
            ExecutaTesteURL2()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ExecutaTesteURL2()

        Dim url As String = Txt_Url.Text
        Dim separador As String = Txt_Separador.Text

        If url = "" Then
            Throw New Exception("URL vazia")
        End If

        If separador = "" Then
            Throw New Exception("Separador vazio")
        End If

        Dim posicaoInt As Integer = url.IndexOf(separador)

        If posicaoInt = 0 Then
            Throw New Exception("Posição vazia")
        End If

        Dim principal As String = url.Substring(posicaoInt)

        MsgBox(principal)

    End Sub
End Class
