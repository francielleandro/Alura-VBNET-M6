Namespace Classes

    Public Class ExtrairValorDeArgumentosUrl
#Region "Propriedades"
        Public ReadOnly url As String
#End Region
#Region "Constructors"

        Public Sub New(urlString As String)

            If urlString Is Nothing Then
                Throw New ArgumentNullException(NameOf(urlString), "URL nula")
            End If

            If urlString = "" Then
                Throw New ArgumentException("URL vazia", NameOf(urlString))
            End If

            url = urlString
        End Sub
#End Region

        '#Region "metodhs"

        '        Public Function TestVazioOuNulo(vString As String) As Boolean
        '            If vString Is Nothing Then
        '                Return True
        '            End If

        '            If vString = "" Then
        '                Return True
        '            End If

        '            Return False
        '        End Function
        '#End Region
    End Class
End Namespace
