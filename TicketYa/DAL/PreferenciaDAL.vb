Public Class PreferenciaDAL

    Shared Function buscarPreferencias(ByVal p1 As Integer) As List(Of BE.PreferenciaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim preferencias As New List(Of BE.PreferenciaBE)
        Try
            repository.crearComando("BUSCAR_PREFERENCIA_PERSONA_SP")
            table = New DataTable
            repository.addParam("@idUsuario", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PreferenciasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim preferencia As New BE.PreferenciaBE
                preferencia.identificador = pepe.Item(0)
                preferencia.descripcion = pepe.Item(1)
                preferencias.Add(preferencia)
            Next

        Catch ex As Excepciones.PreferenciasNoEncontradasExcepcion
            Throw New Excepciones.PreferenciasNoEncontradasExcepcion
        End Try

        Return preferencias
    End Function

    Shared Function listarPreferencias() As List(Of BE.PreferenciaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim preferencias As New List(Of BE.PreferenciaBE)
        Try
            repository.crearComando("LISTAR_PREFERENCIAS_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PreferenciasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim preferencia As New BE.PreferenciaBE
                preferencia.identificador = pepe.Item(0)
                preferencia.descripcion = pepe.Item(1)
                preferencias.Add(preferencia)
            Next

        Catch ex As Excepciones.PreferenciasNoEncontradasExcepcion
            Throw New Excepciones.PreferenciasNoEncontradasExcepcion
        End Try

        Return preferencias
    End Function

End Class
