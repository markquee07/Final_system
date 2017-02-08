Imports MySql.Data.MySqlClient
Public Class Database

    Public server As String
    Public user As String
    Public password As String
    Public db As String
    Public port As String
    Public conn As New MySqlConnection
    Public reader As MySqlDataReader

    Public Function connect() As Boolean
        Dim constring As String = ""
        constring = "server=" & Me.server & _
                    ";user=" & Me.user & _
                    ";password=" & Me.password & _
                    ";port=" & Me.port & _
                    ";database=" & Me.db
        Me.conn.ConnectionString = constring
        Try
            Me.conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Sub executeNonReader(ByVal sql As String)
        Try
            Dim comm As New MySqlCommand
            comm.Connection = Me.conn
            comm.CommandText = sql
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function execute(ByVal sql As String) As MySqlDataReader
        Try
            Dim comm As New MySqlCommand
            comm.Connection = Me.conn
            comm.CommandText = sql
            Me.reader = comm.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Me.reader
    End Function

    Public Function getLastId() As Long
        Dim sql As String
        Dim comm As New MySqlCommand
        Dim id As Long
        sql = "SELECT last_insert_id()"
        comm.Connection = Me.conn
        comm.CommandText = sql
        Me.reader = comm.ExecuteReader
        While Me.reader.Read()
            id = reader.GetInt64(0)
        End While
        Me.reader.Close()
        Return id
    End Function
End Class
