Imports System.Data.SqlClient

Public Class RepositorioSQL
    Implements IRepositorio

    Dim cmd As SqlCommand
    Dim con As New SqlConnection("Integrated security=SSPI;Initial Catalog=encuesta; Data Source=localhost")


    Public Sub addIntegerParam(ByVal p1 As String, ByVal p2 As Integer) Implements IRepositorio.addIntegerParam
        cmd.Parameters.AddWithValue(p1, p2)
    End Sub

    Public Sub addStringParam(ByVal p1 As String, ByVal p2 As String) Implements IRepositorio.addStringParam
        cmd.Parameters.AddWithValue(p1, p2)
    End Sub

    Public Function ejecutarConEstado() As Integer Implements IRepositorio.ejecutarConEstado
        Dim res As Integer
        con.Open()
        res = cmd.ExecuteNonQuery
        con.Close()
        Return res
    End Function

    Public Function ejecutarConTabla() As System.Data.DataTable Implements IRepositorio.ejecutarConTabla
        Dim table As New DataTable
        Dim adap As New SqlDataAdapter
        adap.SelectCommand = cmd
        adap.Fill(table)
        Return table
    End Function

    Public Sub generarAcceso(ByVal p1 As String) Implements IRepositorio.generarAcceso
        cmd = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = p1
    End Sub
End Class
