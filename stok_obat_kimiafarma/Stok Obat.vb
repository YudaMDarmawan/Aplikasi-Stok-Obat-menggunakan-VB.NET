Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Stok_Obat
    Dim sql As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbl_stok order by Kode_Obat", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_stok")
        conn.Close()
        dg.DataSource = (ds.Tables("tbl_stok"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        btselesai.Enabled = True
        txtcari.Text = "Cari Berdasarkan Kode Obat"
        txtcari.ForeColor = Color.Gray
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btselesai.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        txtcari.Clear()
        txtcari.Focus()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Dim counter As Integer
        Dim pola As String
        Dim baca, baca1 As String
        Dim found As Boolean
        txtcari.ForeColor = Color.Black
        pola = txtcari.Text + "*"
        For counter = 1 To dg.RowCount - 1
            baca = dg.Rows(counter - 1).Cells(0).Value
            baca1 = dg.Rows(counter - 1).Cells(1).Value
            found = UCase(baca) Like UCase(pola) Or UCase(baca1) Like UCase(pola)
            If found = True Then
                dg.CurrentCell = dg.Item(0, counter - 1)
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Stok_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call koneksivb()
        Call tampil()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class