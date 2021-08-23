Imports System.Data.SqlClient
Imports System.Configuration

Namespace Persistencia

    Public Class ProveedorSql
        Implements IProveedorBD

        Private _sqlConnection As SqlConnection
        Private _sqlTransansaction As SqlTransaction
        Private _servidor As String
        Private _catalogo As String

        Public Sub New(servidor As String, catalogo As String)
            Me._servidor = servidor
            Me._catalogo = catalogo
        End Sub

        Public Sub New()

        End Sub

        ''' <summary>
        ''' Metodo que obtiene la cadena de conexion (servidor, nombreBD, etc) desde el archivo
        ''' app.config para iniciar la conexion a la BD
        ''' </summary>
        Public Sub ConexionIniciar() Implements IProveedorBD.ConexionIniciar

            Dim ObtenerConnectionString As String = ConfigurationManager.ConnectionStrings("default").ToString()
            ''_sqlConnection = New SqlConnection(ObtenerConnectionString) ''Me.ObtenerCadenaConexion(_servidor, _catalogo))
            _sqlConnection = New SqlConnection(Me.ObtenerCadenaConexion(_servidor, _catalogo))
            _sqlConnection.Open()


        End Sub

        Public Sub ConexionFinalizar() Implements IProveedorBD.ConexionFinalizar

            _sqlConnection.Close()

        End Sub

        Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar

            _sqlTransansaction = _sqlConnection.BeginTransaction()

        End Sub

        Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar

            _sqlTransansaction.Commit()

        End Sub

        Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar

            _sqlTransansaction.Rollback()

        End Sub

        Public Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            unComando.ExecuteNonQuery()

        End Sub

        Public Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T Implements IProveedorBD.EjecutarEscalar

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Return CType(unComando.ExecuteScalar(), T)

        End Function


        Public Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T) Implements IProveedorBD.EjecutarTupla

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Dim resultadoDataReader = unComando.ExecuteReader()

            Return MappearResultado(Of T)(resultadoDataReader)

        End Function


        Private Function ObtenerCadenaConexion(server As String, catalogo As String, usuario As String, clave As String) As String

            Return String.Format("Server={0};Database={1};User Id={2};Password={3};", server, catalogo, usuario, clave)

        End Function

        Private Function ObtenerCadenaConexion(server As String, catalogo As String) As String

            Return String.Format("Server={0};Database={1};Trusted_Connection=True;", server, catalogo)

        End Function

        Private Function MappearResultado(Of T As New)(resultadoDataReader As SqlDataReader) As List(Of T)

            Dim resultado As New List(Of T)

            'Recorro todos los rows.
            Do While resultadoDataReader.Read()

                'Creo un T.
                Dim unT As New T

                'Recorro las columnas de la tabla.
                For i = 0 To resultadoDataReader.FieldCount - 1

                    'A una instancia de T, pegarle cada una de estas propiedades...
                    Dim nombreColumna = resultadoDataReader.GetName(i)

                    'Obtengo la property
                    Dim propiedadInfo = unT.GetType().GetProperty(nombreColumna)

                    'Le pego el valor a esa property.
                    propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i))

                Next

                resultado.Add(unT)

            Loop

            resultadoDataReader.Close()
            Return resultado
        End Function
    End Class
End Namespace