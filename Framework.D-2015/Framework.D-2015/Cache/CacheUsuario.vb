Namespace Cache
    ''' <summary>
    ''' Clase estatica para guardar los datos del usuario de forma temporal en memoria,
    ''' una vez se que la aplicacion se cierra no guarda los datos
    ''' </summary>
    Public Class CacheUsuario

        Public Shared iduser As Integer

        Public Shared username As String

        Public Shared password As String

        Public Shared email As String

        Public Shared rol As String

    End Class
End Namespace
