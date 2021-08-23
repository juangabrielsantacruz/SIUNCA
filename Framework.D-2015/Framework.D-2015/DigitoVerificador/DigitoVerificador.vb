
Namespace DigitoVerificador

    Public Class DigitoVerificador
        Public Function calcularDV(cadena As String) As Integer

            Dim multiplo As Integer = 2
            Dim contador As Integer

            For i As Integer = cadena.Length - 1 To 0 Step -1

                Dim unChar As Char = cadena.Chars(i)
                Dim vChar As Integer = AscW(unChar)
                Dim subTot As Integer
                subTot = vChar * multiplo
                contador = contador + subTot

            Next

            contador = (11 - (contador Mod 11)) * cadena.Length

            Return contador

        End Function

        Public Function VerificarDV(cadena As String, dv As Integer) As Boolean
            If calcularDV(cadena) = dv Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class
End Namespace
