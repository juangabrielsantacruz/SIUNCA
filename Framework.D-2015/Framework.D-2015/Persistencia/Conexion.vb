Imports System.Xml
Imports System.Reflection
Imports Framework.D_2015.Serializadores

Namespace Persistencia

    Public Class Conexion

        Public Enum EstrategiasDbEnum
            SqlServer
        End Enum

        Private _estrategiaConexion As IProveedorBD

        Public Sub New(estrategiaElegida As EstrategiasDbEnum, servidor As String, catalogo As String, usuario As String, clave As String)
            Dim configuracion As New ConfiguracionDB
            configuracion.Catalogo = catalogo
            configuracion.Clave = clave
            configuracion.Servidor = servidor
            configuracion.TipoDeConexion = estrategiaElegida
            configuracion.Usuario = usuario

            GenerarConexion(configuracion)

        End Sub

        Public Sub New(estrategiaElegida As EstrategiasDbEnum, servidor As String, catalogo As String)
            Dim configuracion As New ConfiguracionDB
            configuracion.Catalogo = catalogo
            configuracion.Servidor = servidor
            configuracion.TipoDeConexion = estrategiaElegida

            GenerarConexion(configuracion)

        End Sub

        Public Sub New(archivo As String)

            Dim archivoConf = System.IO.File.ReadAllText(archivo)

            Dim serializador As New SerializadorXml
            Dim configuracion As ConfiguracionDB = serializador.Deserealizar(Of ConfiguracionDB)(archivoConf)

            GenerarConexion(configuracion)

        End Sub

        Public Sub GenerarConexion(configuracion As ConfiguracionDB)
            Dim estrategiaElegida As EstrategiasDbEnum = configuracion.TipoDeConexion
            Select Case estrategiaElegida

                Case EstrategiasDbEnum.SqlServer
                    _estrategiaConexion = New ProveedorSql(configuracion.Servidor, configuracion.Catalogo)

            End Select
        End Sub

        Public Shared Sub GenerarArchivoConfiguracion(estrategiaElegida As EstrategiasDbEnum, servidor As String, catalogo As String, usuario As String, clave As String)
            Dim Configuracion As New ConfiguracionDB
            Configuracion.TipoDeConexion = estrategiaElegida
            Configuracion.Servidor = servidor
            Configuracion.Catalogo = catalogo
            Configuracion.Usuario = usuario
            Configuracion.Clave = clave

            Dim deserializador As New SerializadorXml
            deserializador.Serializar(Configuracion)
        End Sub

        Public Sub ConexionIniciar()
            _estrategiaConexion.ConexionIniciar()
        End Sub

        Public Sub ConexionFinalizar()
            _estrategiaConexion.ConexionFinalizar()
        End Sub

        Public Sub TransaccionIniciar()
            _estrategiaConexion.TransaccionIniciar()
        End Sub

        Public Sub TransaccionAceptar()
            _estrategiaConexion.TransaccionAceptar()
        End Sub

        Public Sub TransaccionCancelar()
            _estrategiaConexion.TransaccionCancelar()
        End Sub

        Public Sub EjecutarSinResultado(query As String, parametros As List(Of Parametro))
            _estrategiaConexion.EjecutarSinResultado(query, parametros)
        End Sub

        Public Function EjecutarEscalar(Of T)(query As String, parametros As List(Of Parametro)) As T
            Return _estrategiaConexion.EjecutarEscalar(Of T)(query, parametros)
        End Function

        Public Function EjecutarTupla(Of T As New)(query As String, parametros As List(Of Parametro)) As List(Of T)
            Return _estrategiaConexion.EjecutarTupla(Of T)(query, parametros)
        End Function

    End Class

End Namespace
