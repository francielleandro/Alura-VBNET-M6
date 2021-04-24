Imports System.Text.RegularExpressions
Imports ByteBank.Bibliotecas.Classes
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Public Class Frm_Principal3b
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Formulario Principal 3b"
        Lbl_Principal.Text = "Formulario Principal 3b"
        Btn_Principal.Text = "Testar"
        Btn_Principal03a.Text = "Clique Aqui"
        Btn_Principal03b.Text = "Clique Aqui"
    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim vFrase As String = "O telefone é 23344332"
        'Dim vExpressaoRegular As String = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
        'Dim vExpressaoRegular As String = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
        'Dim vExpressaoRegular As String = "[0-9]{5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]?[0-9]{4}"
        Dim vExpressaoRegular As String = "[0-9]{4,5}-?[0-9]{4}"

        Dim X As Boolean = Regex.IsMatch(vFrase, vExpressaoRegular)
        MsgBox(X)

        Dim Y As Match = Regex.Match(vFrase, vExpressaoRegular)
        MsgBox(Y.Value)
    End Sub

    Private Sub Btn_Principal03a_Click(sender As Object, e As EventArgs) Handles Btn_Principal03a.Click

        Dim Cliente_1 As New Cliente()
        Dim Cliente_2 As New Cliente()

        Cliente_1.nome = "Carlos"
        Cliente_1.cpf = "123.123.123-23"
        Cliente_1.profissao = "Analista de Sistemas"

        Cliente_2.nome = "Carlos"
        Cliente_2.cpf = "123.123.123-23"
        Cliente_2.profissao = "Analista de Sistemas"

        Dim Ger As New Gerente("123.123.123-23")
        Dim KK As String = "aaaaaaaaaaaaaaaaaaaa"

        If (Cliente_1.Equals(Cliente_2)) Then
            MsgBox("SÃO IGUAIS !!!!")
        Else
            MsgBox("NÃO SÃO IGUAIS !!!!")
        End If
    End Sub

    Private Sub Btn_Principal03b_Click(sender As Object, e As EventArgs) Handles Btn_Principal03b.Click
        Dim url As String = "https://www.bytebank.com.br/cambio"
        Dim X As New ExtrairValorDeArgumentosUrl(url)
        Dim Y As String = X.GetTodosArgumentos()
        MsgBox(Y)
    End Sub
End Class