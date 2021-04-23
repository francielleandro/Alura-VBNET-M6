Namespace Classes

    Public Class ExtrairValorDeArgumentosUrl
#Region "Propriedades"
        Public ReadOnly Property url As String
        Public ReadOnly Property argumento As String
#End Region
#Region "Constructors"

        Public Sub New(urlString As String)

            If String.IsNullOrEmpty(urlString) Then
                Throw New ArgumentException("URL possui valor vazio ou nulo", NameOf(urlString))
            End If

            Dim posicaoInt As Integer = InStr(urlString, "?")
            argumento = urlString.Substring(posicaoInt)

            url = urlString
        End Sub
#End Region

    End Class
End Namespace
