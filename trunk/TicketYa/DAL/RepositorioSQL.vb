Imports System.Data.SqlClient

Public Class RepositorioSQL
    Implements IRepositorio

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim table As DataTable
    Dim result As Integer
    Dim tx As SqlTransaction

    Public Sub crearComando(ByVal nombre As String) Implements IRepositorio.crearComando
        con = New SqlConnection("Data Source=localhost;Initial Catalog=TicketYa;Integrated Security=SSPI;")
        cmd = New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        cmd.CommandText = nombre
    End Sub

    Public Sub transactionON() Implements IRepositorio.transactionON
        tx = con.BeginTransaction
        cmd.Transaction = tx
    End Sub

    Public Sub transactionCancel() Implements IRepositorio.transactionCancel
        tx.Rollback()
    End Sub

    Public Sub transactionOK() Implements IRepositorio.transactionOK
        tx.Commit()
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
        Return table
    End Function

    Public Function executeSearch() As Integer Implements IRepositorio.executeSearch
        con.Open()
        Try
            result = cmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        con.Close()
        Return result
    End Function

    Public Function executeSearchWithStatus() As Integer Implements IRepositorio.executeSearchWithStatus
        Dim status As Integer = 0
        con.Open()
        Try
            status = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Excepciones.ConexionImposibleExcepcion
        End Try
        con.Close()
        Return status
    End Function

    Public Sub crearComandoDirecto(ByVal nombre As String)
        con = New SqlConnection("Data Source=localhost;Initial Catalog=player1;Integrated Security=SSPI;")
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = nombre
    End Sub

    Public Sub addParam(ByVal p1 As String, ByVal p2 As Object) Implements IRepositorio.addParam
        cmd.Parameters.AddWithValue(p1, p2)
    End Sub
End Class
