Imports System.Text.RegularExpressions

Public Class Frm_Principal3

    Public Property expression As String = "[0-9]{4,5}-?[0-9]{4}"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulario Principal 3"
        Lbl_Principal.Text = "Formulario Principal 3"
        Btn_Principal.Text = "Testar expressão regular!"
        Lbl_Texto.Text = "Texto a ser verificado"
        Lbl_Expressao.Text = "Expressão regular"
        Lbl_Padrao.Text = "O padrão é: " + expression
    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim vFrase As String = Txt_Verificar.Text
        'Dim vExpressaoRegular As String = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
        'Dim vExpressaoRegular As String = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
        'Dim vExpressaoRegular As String = "[0-9]{5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]?[0-9]{4}"

        Dim exp = Txt_Expressao.Text

        Dim vExpressaoRegular As String

        If String.IsNullOrEmpty(exp) Then
            vExpressaoRegular = expression
        Else
            vExpressaoRegular = exp
        End If

        Dim X As Boolean = Regex.IsMatch(vFrase, vExpressaoRegular)
        MsgBox(X)

        Dim Y As Match = Regex.Match(vFrase, vExpressaoRegular)
        MsgBox(Y.Value)
    End Sub
End Class