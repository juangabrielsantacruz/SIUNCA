Imports System.Security.Cryptography
Imports System.Text

Namespace Seguridad

    Public Class Hash
        Public Shared Function getSHA256(ByVal contraseña As String) As String
            Dim sha256 As SHA256 = SHA256Managed.Create()
            Dim encoding As ASCIIEncoding = New ASCIIEncoding()
            Dim stream As Byte() = Nothing
            Dim sb As StringBuilder = New StringBuilder()
            stream = sha256.ComputeHash(encoding.GetBytes(contraseña))

            For i As Integer = 0 To stream.Length - 1
                sb.AppendFormat("{0:x2}", stream(i))
            Next

            Return sb.ToString()
        End Function
    End Class
End Namespace
