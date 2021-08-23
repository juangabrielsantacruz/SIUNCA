Imports System.Globalization
Imports System.Threading

Namespace Idiomas

    Public Class Idioma

        ''' <summary>
        ''' Necesario para poder pasar un metodo como parametro en metodo cambiar idioma
        ''' </summary>
        Delegate Sub ParametroEnMetodo()
        ''' <summary>
        ''' Propiedad para guardar el idioma de forma temporal
        ''' </summary>
        Public Shared cacheIdioma As String = "Español"

        ''' <summary>
        ''' Metodo para cambiar el idioma del sistema
        ''' </summary>
        ''' <param name="idioma">Recibe "Ingles" o "Español"</param>
        ''' <param name="metodo">parametro que recibe un metodo con retorno void y ningun parametro (Delegado)</param>
        Public Shared Sub cambiarIdioma(idioma As String, metodo As ParametroEnMetodo)

            If idioma = "Ingles" Then
                'Selecciona el archivo Res.en-US.resx
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
                metodo()

            End If
            If idioma = "Español" Then
                'Selecciona el archivo Res.resx
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("")
                metodo()

            End If

        End Sub
    End Class
End Namespace
