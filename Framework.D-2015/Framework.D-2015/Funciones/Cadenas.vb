Imports System.IO
Imports System.Text

Public Class Cadenas



    ''' <summary>
    ''' Decora una lista por izquierda y derecha
    ''' </summary>
    ''' <param name="unaLista">La lista a decorar</param>
    ''' <param name="DecoradoDerecho">El decorado derecho</param>
    ''' <param name="DecoradoIzquierdo">El decorado izquierdo</param>
    ''' <returns>Devuelve la lista decorada</returns>
    ''' <remarks></remarks>
    Public Shared Function DecorarLista(unaLista As List(Of String), DecoradoDerecho As String, DecoradoIzquierdo As String) As List(Of String)


        Dim Resultado As New List(Of String)

        For Each item In unaLista
            Resultado.Add(DecoradoIzquierdo & item & DecoradoDerecho)

        Next

        Return Resultado

    End Function

    ''' <summary>
    ''' Separar cadena en lista
    ''' </summary>
    ''' <param name="UnaCadena">Cadena a convertir</param>
    ''' <param name="UnSeparador">Separador</param>
    ''' <returns>cadena en lista</returns>
    ''' <remarks></remarks>

    Public Shared Function Parsear(UnaCadena As String, UnSeparador As Char) As List(Of String)

        Dim Resultado As New List(Of String)

        Resultado = Split(UnaCadena, UnSeparador).ToList

        Return Resultado

    End Function


    ''' <summary>
    ''' Borrar basura a la derecha de un texto
    ''' </summary>
    ''' <param name="UnaCadena">Cadena con basura</param>
    ''' <param name="unSeparador">Separador</param>
    ''' <returns>Cadena sin basura</returns>
    ''' <remarks></remarks>

    Public Shared Function TextoSinBasuraDerecha(UnaCadena As String, unSeparador As Char) As String

        Dim Resultado As List(Of String)

        Resultado = Parsear(UnaCadena, unSeparador)


        Return Resultado(0)

    End Function


    ''' <summary>
    ''' Borrar basura a la izquierda de un texto
    ''' </summary>
    ''' <param name="UnaCadena">Cadena con basura</param>
    ''' <param name="unSeparador">Separador</param>
    ''' <returns>Cadena sin basura</returns>
    ''' <remarks></remarks>

    Public Shared Function TextoSinBasuraIzquierda(UnaCadena As String, unSeparador As Char) As String

        Dim Resultado As List(Of String)

        Resultado = Parsear(UnaCadena, unSeparador)

        Return Resultado(1)

    End Function



    ''' <summary>
    ''' Convertir una lista en cadena
    ''' </summary>
    ''' <param name="UnaLista">lista a unir</param>
    ''' <param name="unSeparador">separador</param>
    ''' <returns>Lista convertida en cadena</returns>
    ''' <remarks></remarks>
    Public Shared Function UnirLista(UnaLista As List(Of String), unSeparador As String) As String

        Dim Resultado As String

        Resultado = String.Join(unSeparador, UnaLista)

        Return Resultado

    End Function


    Public Shared Function StreamACadena(stream As Stream) As String

        Dim bytes(stream.Length) As Byte

        stream.Position = 0
        stream.Read(bytes, 0, stream.Length)

        Return BytesACadena(bytes)

    End Function

    Public Shared Function CadenaABytes(cadena As String) As Byte()

        Return Encoding.ASCII.GetBytes(cadena)

    End Function

    Public Shared Function BytesACadena(bytes As Byte()) As String

        Return Encoding.ASCII.GetString(bytes)

    End Function

End Class
