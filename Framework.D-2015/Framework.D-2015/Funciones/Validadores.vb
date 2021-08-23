Namespace Funciones

    Public Class Validadores

        ''' <summary>
        ''' Esta función permite conocer si la fecha provista es mayor al día contemporáneo
        ''' </summary>
        ''' <param name="fecha">La fecha a analizar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function FechaEsMayorAHoy(fecha As Date) As Boolean
            If Date.Now > fecha Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' Esta función permite conocer si la fecha provista es mayor al día contemporáneo
        ''' </summary>
        ''' <param name="fecha">La fecha a analizar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function FechaEsMayorAHoy(fecha As String) As Boolean
            Dim fechaCasteada As Date
            fechaCasteada = CDate(fecha)


            If Date.Now > fechaCasteada Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' Permite conocer si la cadena no tiene valores.
        ''' </summary>
        ''' <param name="cadena">Cadena de texto</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CadenaEstaVacia(cadena As String) As Boolean
            If cadena = String.Empty Then
                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' Da verdadero si la fecha podrá ser de tipo Date.
        ''' </summary>
        ''' <param name="texto">Cadena de texto</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function EsFechaValida(texto As String) As Boolean
            If IsDate(texto) = True Then
                Return True
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Da verdadero si el texto se puede evaluar como un número.
        ''' </summary>
        ''' <param name="texto">Cadena de texto</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function EsNumeroValido(texto As String) As Boolean
            If IsNumeric(texto) = True Then
                Return True
            Else
                Return False
            End If
        End Function


    End Class

End Namespace