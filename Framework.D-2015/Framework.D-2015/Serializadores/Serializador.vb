Imports System.Xml.Serialization
Imports System.IO
Imports Framework.D_2015.Funciones
Namespace Serializadores

    Public Class SerializadorXml
        Implements ISerializador


        Public Function Serializar(unObjeto As Object) As String Implements ISerializador.Serializar

            Dim xmlSerializer As New XmlSerializer(unObjeto.GetType())

            Dim ms As New System.IO.MemoryStream

            xmlSerializer.Serialize(ms, unObjeto)

            Return Cadenas.StreamACadena(ms)

        End Function

        Public Function Deserealizar(Of T As New)(unObjetoSerializadoEnXml As String) As T Implements ISerializador.Deserealizar

            Dim xmlSerializer As New XmlSerializer(GetType(T))

            Dim resultado = xmlSerializer.Deserialize(New MemoryStream(Cadenas.CadenaABytes(unObjetoSerializadoEnXml)))

            Return CType(resultado, T)

        End Function

    End Class
End Namespace
