
Public Class BitacoraDAL
    Shared Function agregarBitacora(ByVal usr As BE.UsuarioBE, ByVal mensaje As String, ByVal codigo As Integer) As String
        Dim result As Integer
        Dim excep As String = ""

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_BITACORA_SP")
            If Not usr Is Nothing Then
                repository.addParam("@idUsuario", usr.identificador)
            Else
                repository.addParam("@idUsuario", 0)
            End If

            repository.addParam("@mensaje", mensaje)
            repository.addParam("@codigo", codigo)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Public Shared Function buscarBitacora(ByVal usr As BE.UsuarioBE,
                                          ByVal mensaje As String,
                                          ByVal codigo As Integer,
                                          ByVal fecha As DateTime,
                                          ByVal idioma As BE.IdiomaBE) As List(Of BE.BitacoraBE)

        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("BUSCAR_BITACORAS_SP")
            table = New DataTable
            repository.addParam("@idUsuario", usr.identificador)
            repository.addParam("@idIdioma", idioma.identificador)
            repository.addParam("@fecha", fecha)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FamiliaNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim bit As String = ""
                Dim men As String = ""

                Dim bitacora As New BE.BitacoraBE
                bitacora.identificador = pepe.Item(0)
                men = pepe.Item(1)
                bit = pepe.Item(2)
                Dim info As String

                Dim index As Integer
                For index = 0 To Split(bit, ",").Length - 1
                    info = Split(bit, ",")(index)
                    men = Replace(men, "{" + (index + 1).ToString + "}", info)
                Next
                bitacora.mensaje = men
                bitacoras.Add(bitacora)
            Next

        Catch ex As Exception
            Throw New Excepciones.FamiliaNoEncontradaExcepcion
        End Try

        Return bitacoras
    End Function

End Class
