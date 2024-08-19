Imports System.Data
Imports MySql.Data.MySqlClient
Module koneksi
    Public conn As MySqlConnection
    Public cmd As New MySqlCommand
    Public cmd1 As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As DataSet
    Public Sub koneksivb()
        Dim konek As String
        konek = "server=localhost;port=3306;user id=root;" & _
                 "password=;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dbstok"
        conn = New MySqlConnection(konek)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
