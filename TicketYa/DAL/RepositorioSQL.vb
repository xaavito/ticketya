﻿Imports System.Data.SqlClient

Public Class RepositorioSQL
    Implements IRepositorio


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim table As DataTable
    Dim result As Integer
    Dim tx As SqlTransaction
    Dim r As String
    Private _conString As String = System.Configuration.ConfigurationManager.ConnectionStrings.Item(1).ToString

    Public Sub New()
        Try
            Dim objConn As SqlConnection = New SqlConnection(_conString)
            objConn.Open()
            objConn.Close()
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try

    End Sub

    Public ReadOnly Property conString() As String
        Get
            Return _conString
        End Get
    End Property

    Public Sub crearComando(ByVal nombre As String) Implements IRepositorio.crearComando
        If con Is Nothing Then
            con = New SqlConnection(conString)
        End If
        cmd = New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        cmd.CommandText = nombre
        If tx IsNot Nothing Then
            cmd.Transaction = tx
        End If
    End Sub

    Public Sub transactionON() Implements IRepositorio.transactionON
        If tx Is Nothing Then
            con.Open()
            tx = con.BeginTransaction
            cmd.Transaction = tx
        End If

    End Sub

    Public Sub transactionCancel() Implements IRepositorio.transactionCancel
        If tx IsNot Nothing Then
            tx.Rollback()
            tx = Nothing
        End If
    End Sub

    Public Sub transactionOK() Implements IRepositorio.transactionOK
        If tx IsNot Nothing Then
            tx.Commit()
            tx = Nothing
        End If
    End Sub

    Public Sub clearParams() Implements IRepositorio.clearParams
        cmd.Parameters.Clear()
    End Sub

    Public Function executeSearchWithAdapter() As DataTable Implements IRepositorio.executeSearchWithAdapter
        adapter = New SqlDataAdapter
        table = New DataTable
        adapter.SelectCommand = cmd
        Try
            adapter.Fill(table)
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        clearParams()
        Return table
    End Function

    Public Function executeSearch() As Integer Implements IRepositorio.executeSearch
        If tx Is Nothing Then
            conectar()
        End If
        'conectar()
        Try
            result = cmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        clearParams()
        If tx Is Nothing Then
            desconectar()
        End If
        'desconectar()

        Return result
    End Function

    Public Function executeSearchWithStatus() As Integer Implements IRepositorio.executeSearchWithStatus
        Dim status As Integer = 0
        If tx Is Nothing Then
            conectar()
        End If
        'conectar()
        Try
            status = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        clearParams()

        If tx Is Nothing Then
            desconectar()
        End If

        Return status
    End Function

    Public Sub crearComandoDirecto(ByVal nombre As String)
        con = New SqlConnection(conString)
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = nombre
    End Sub

    Public Sub addParam(ByVal p1 As String, ByVal p2 As Object) Implements IRepositorio.addParam
        cmd.Parameters.AddWithValue(p1, p2)
    End Sub

    Public Function executeWithReturnValue() As Integer Implements IRepositorio.executeSearchWithReturnValue
        If tx Is Nothing Then
            conectar()
        End If
        'conectar()
        Try
            Dim returnValue As SqlParameter = New SqlParameter
            returnValue.ParameterName = "@Return_Value"
            returnValue.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(returnValue)
            result = cmd.ExecuteNonQuery()
            r = cmd.Parameters("@Return_Value").Value
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        clearParams()
        If tx Is Nothing Then
            desconectar()
        End If
        'desconectar()
        Return r
    End Function

    Public Sub conectar() Implements IRepositorio.conectar
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub desconectar() Implements IRepositorio.desconectar
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

End Class
