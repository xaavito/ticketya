﻿Public Class UsuarioDAL
    'Dim repo As RepositorioFactory
    Public Shared Function buscarUsuario(ByVal usr As String,
                                         ByVal pass As String) As BE.UsuarioBE

        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LOGIN_SP")
            repository.addParam("@usr", usr)
            repository.addParam("@pass", pass)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <> 1) Then
                Throw New Excepciones.UsuarioNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                usuario.usuario = usr
                usuario.password = pass
                usuario.activo = pepe.Item(4)
                Dim idioma As New BE.IdiomaBE
                idioma.identificador = pepe.Item(3)
                usuario.idioma = idioma
                Return usuario
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuarioNoEncontradoExcepcion
        End Try

        Return Nothing
    End Function

    Public Shared Function listarUsuarios()
        Dim table As DataTable

        Dim lista As New List(Of BE.UsuarioBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_USUARIOS_SP")

            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)

                lista.Add(usuario)
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarUsuario(ByVal usr As String) As List(Of BE.UsuarioBE)
        Dim table As DataTable
        Dim listaUsuarios As New List(Of BE.UsuarioBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_USUARIO_SP")
            repository.addParam("@usr", usr)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                usuario.usuario = pepe.Item(3)
                usuario.activo = pepe.Item(4)
                usuario.fechaAlta = pepe.Item(5)
                If Not IsDBNull(pepe.Item(6)) Then
                    usuario.fechaBaja = pepe.Item(6)
                End If
                Dim idioma As New BE.IdiomaBE
                idioma.identificador = pepe.Item(7)
                usuario.password = pepe.Item(8)
                usuario.idioma = idioma
                listaUsuarios.add(usuario)
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return listaUsuarios
    End Function

    Shared Function buscarUsuarioPorId(ByVal id As Integer) As BE.UsuarioBE
        Dim table As DataTable
        'Dim listaUsuarios As New List(Of BE.UsuarioBE)
        Dim usuario As New BE.UsuarioBE
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_USUARIO_POR_ID_SP")
            repository.addParam("@idUsr", id)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                If Not IsDBNull(pepe.Item(3)) Then
                    usuario.usuario = pepe.Item(3)
                End If

                If Not IsDBNull(pepe.Item(4)) Then
                    usuario.activo = pepe.Item(4)
                End If
                If Not IsDBNull(pepe.Item(5)) Then
                    usuario.fechaAlta = pepe.Item(5)
                End If

                If Not IsDBNull(pepe.Item(6)) Then
                    usuario.fechaBaja = pepe.Item(6)
                End If

                If Not IsDBNull(pepe.Item(7)) Then
                    Dim idioma As New BE.IdiomaBE
                    idioma.identificador = pepe.Item(7)
                    usuario.idioma = idioma
                End If
                If Not IsDBNull(pepe.Item(8)) Then
                    usuario.password = pepe.Item(8)
                End If
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return usuario
    End Function

    Shared Function altaUsuario(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal idiomaBE As BE.IdiomaBE, ByVal list As List(Of BE.FamiliaBE)) As Integer
        Dim result As Integer
        Dim retorno As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_USUARIO_SP")
            'repository.transactionON()
            repository.addParam("@usr", p1)
            repository.addParam("@pass", p2)
            repository.addParam("@nom", p3)
            repository.addParam("@ape", p4)
            repository.addParam("@idioma", idiomaBE.identificador)

            retorno = repository.executeSearchWithReturnValue
            If (retorno <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

            If (list.Count > 0) Then
                repository.crearComando("INSERTAR_USUARIO_FAMILIA_SP")
                For Each fam As BE.FamiliaBE In list
                    repository.addParam("@idUsuario", retorno)
                    repository.addParam("@idFamilia", fam.identificador)
                    result = repository.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.InsertExcepcion
                    End If
                Next
            End If
            'repository.transactionOK()

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarUsuario(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_USUARIO_SP")
            repository.addParam("@usr", p1)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.DeleteExcepcion
            End If

        Catch ex As Excepciones.DeleteExcepcion
            Throw New Excepciones.DeleteExcepcion
        End Try

        If result > 0 Then
            Throw New Excepciones.UsuarioEliminadoExistosamenteExcepcion
        End If

        Return result
    End Function

    Shared Function modificarUsuario(ByVal id As Integer, ByVal usr As String, ByVal pass As String, ByVal nom As String, ByVal ape As String, ByVal act As Integer, ByVal p7 As Integer, ByVal list As List(Of BE.FamiliaBE)) As Integer
        Dim result As Integer
        
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_USUARIO_SP")
            'repository.transactionON()
            repository.addParam("@id", id)
            repository.addParam("@usr", usr)
            repository.addParam("@pass", pass)
            repository.addParam("@nom", nom)
            repository.addParam("@ape", ape)
            repository.addParam("@act", act)
            repository.addParam("@idioma", p7)

            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

            repository.crearComando("REMOVER_USUARIO_FAMILIA_SP")
            repository.addParam("@idUsuario", id)
            result = repository.executeSearchWithStatus

            If (list.Count > 0) Then
                repository.crearComando("INSERTAR_USUARIO_FAMILIA_SP")
                For Each fam As BE.FamiliaBE In list
                    repository.addParam("@idUsuario", id)
                    repository.addParam("@idFamilia", fam.identificador)
                    result = repository.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.InsertExcepcion
                    End If
                Next
            End If
            'repository.transactionOK()

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function buscarComprador(ByVal usr As String) As List(Of BE.UsuarioBE)
        Dim table As DataTable
        Dim listaUsuarios As New List(Of BE.UsuarioBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_COMPRADOR_SP")
            repository.addParam("@usr", usr)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                usuario.mail = pepe.Item(3)
                usuario.direccion = pepe.Item(4)
                usuario.numero = pepe.Item(5)
                usuario.piso = pepe.Item(6)
                usuario.dpto = pepe.Item(7)
                usuario.codPost = pepe.Item(8)
                usuario.telefono = pepe.Item(9)
                usuario.activo = pepe.Item(10)
                usuario.fechaAlta = pepe.Item(11)
                If Not IsDBNull(pepe.Item(12)) Then
                    usuario.fechaBaja = pepe.Item(12)
                End If
                listaUsuarios.Add(usuario)
            Next

        Catch ex As Excepciones.UsuariosNoEncontradosExcepcion
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return listaUsuarios
    End Function

    Shared Function altaComprador(ByVal p1 As String,
                                  ByVal p2 As String,
                                  ByVal p3 As String,
                                  ByVal p4 As String,
                                  ByVal p5 As String,
                                  ByVal p6 As String,
                                  ByVal p7 As String,
                                  ByVal p8 As Integer,
                                  ByVal p9 As String,
                                  ByVal p10 As List(Of BE.TipoShowBE)) As Integer
        Dim result As Integer
        Dim retorno As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_COMPRADOR_SP")

            repository.addParam("@nom", p1)
            repository.addParam("@ape", p2)
            repository.addParam("@mail", p3)
            repository.addParam("@dir", p4)
            repository.addParam("@num", p5)
            repository.addParam("@piso", p6)
            repository.addParam("@dpto", p7)
            repository.addParam("@cp", p8)
            repository.addParam("@tel", p9)

            retorno = repository.executeSearchWithReturnValue
            If (retorno <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

            If (p10.Count > 0) Then
                repository.crearComando("INSERTAR_USUARIO_PREFERENCIA_SP")
                For Each pref As BE.TipoShowBE In p10
                    repository.addParam("@idUsuario", retorno)
                    repository.addParam("@idPreferencia", pref.identificador)
                    result = repository.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.InsertExcepcion
                    End If
                Next
            End If
            If (retorno > 0) Then
                Throw New Excepciones.UsuarioCreadoExistosamente
            End If
        Catch ex As Excepciones.InsertExcepcion
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarComprador(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_COMPRADOR_SP")
            repository.addParam("@usr", p1)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.DeleteExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.DeleteExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarComprador(ByVal p0 As Integer, ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String, ByVal p8 As Integer, ByVal p9 As String, ByVal p10 As List(Of BE.TipoShowBE)) As Object
        Throw New NotImplementedException
    End Function

    Shared Function buscarCompradorCombo(ByVal p1 As String) As Object
        Dim table As DataTable
        Dim listaUsuarios As New List(Of BE.UsuarioBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_COMPRADOR_COMBO_SP")
            repository.addParam("@usr", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                
                listaUsuarios.Add(usuario)
            Next

        Catch ex As Excepciones.UsuariosNoEncontradosExcepcion
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return listaUsuarios
    End Function


End Class
