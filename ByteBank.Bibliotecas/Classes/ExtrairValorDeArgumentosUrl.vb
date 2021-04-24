Namespace Classes

    Public Class ExtrairValorDeArgumentosUrl
#Region "Propriedades"
        Public ReadOnly Property url As String
        Public ReadOnly Property argumento As String
        Private ReadOnly Property dominio As String
#End Region
#Region "Constructors"

        Public Sub New(urlString As String)
            dominio = "https://www.bytebank.com.br"
            If String.IsNullOrEmpty(urlString) Then
                Throw New ArgumentException("URL possui valor vazio ou nulo", NameOf(urlString))
            End If

            Dim posicaoInt As Integer = InStr(urlString, "?")
            argumento = urlString.Substring(posicaoInt)

            url = urlString
        End Sub
#End Region

        Public Function GetValor(propriedade As String) As String

            Dim vPropriedade As String = propriedade + "="
            Dim vIndex As Integer = argumento.ToUpper.IndexOf(vPropriedade.ToUpper)
            Dim vValor As String

            If vIndex = -1 Then
                vValor = ""
            Else
                vIndex += vPropriedade.Length
                Dim vArgumentoParcial As String = argumento.Substring(vIndex)
                Dim vIndex2 As Integer = vArgumentoParcial.IndexOf("&")
                If vIndex2 = -1 Then
                    vValor = vArgumentoParcial
                Else
                    vValor = vArgumentoParcial.Remove(vIndex2)
                End If
            End If

            Return vValor

        End Function

        Public Function IsByteBank() As Boolean
            Return url.ToLower.StartsWith(dominio)
        End Function

    End Class
End Namespace
