Imports System.Data.SqlClient

Namespace Seguridad

    Public Class BackupSQL

        Property servidor As String
        Property baseDatos As String
        Property ruta As String

        ''' <summary>
        ''' Realiza un Backup full de la Base de Datos
        ''' </summary>
        ''' <param name="cadenaConexion"></param>
        ''' <remarks></remarks>
        Sub realizarBackup(cadenaConexion As String)

            Dim con As New SqlConnection(cadenaConexion)
            con.Open()

            Dim strQuery = "backup database " & baseDatos & " to disk='" & ruta & "'"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(strQuery, con)
            cmd.ExecuteNonQuery()

            con.Close()


        End Sub

        ''' <summary>
        ''' Realiza una restauración de la Base de Datos
        ''' </summary>
        ''' <param name="cadenaConexion"></param>
        ''' <remarks></remarks>
        Sub restaurarBackup(cadenaConexion As String)

            Dim con As New SqlConnection(cadenaConexion)
            con.Open()

            ''Dim strQuery = "RESTORE DATABASE " & baseDatos & " FROM disk='" & ruta & "'"
            Dim strQuery = "ALTER DATABASE " & baseDatos & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;  RESTORE DATABASE " & baseDatos & " FROM disk='" & ruta & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(strQuery, con)
            cmd.ExecuteNonQuery()

            con.Close()

        End Sub
    End Class

End Namespace
