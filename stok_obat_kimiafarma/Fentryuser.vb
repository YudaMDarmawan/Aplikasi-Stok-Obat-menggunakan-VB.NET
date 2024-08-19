Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Fentryuser
    Dim sql As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbl_admin order by Kode_admin", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_admin")
        conn.Close()
        dg.DataSource = (ds.Tables("tbl_admin"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        txtusername.Focus()
        txtusername.ReadOnly = False
        bttambah.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
        btsimpan.Enabled = True
        btselesai.Enabled = True
        bttambah.Text = "Tambah"
        txtcari.Text = "Cari Berdasarkan Username"
        txtcari.ForeColor = Color.Gray
        cbstat.Text = ""
        If cbstat.Items.Count = 0 Then
            cbstat.Items.Add("Admin")
            cbstat.Items.Add("Petugas")
        End If
    End Sub
    Private Sub Fentryuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        Call koneksivb()
        Call tampil()
    End Sub
    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        If bttambah.Text = "Batal" Then
            bersih()
        Else
            bersih()
            btedit.Enabled = False
            bthapus.Enabled = False
            bttambah.Text = "Batal"
        End If
    End Sub
    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        conn.Open()
        If txtnama.Text = "" Or txtpw.Text = "" Or cbstat.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tbl_admin where Kode_admin='" & txtusername.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            If dr.HasRows Then
                MsgBox("Username Sudah Ada, Masukan Username yg Lain", , "Perhatian")
                bersih()
                conn.Close()
            Else
                sql = "insert into tbl_admin values('" & txtusername.Text & "','" & txtnama.Text & "','" & txtpw.Text & "','" & _
                                cbstat.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Simpan Data Berhasil", , "Info")
                    bersih()
                    tampil()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
                bersih()
            End If
            conn.Close()
        End If
    End Sub
    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If txtusername.Text = "" Then
            MsgBox("Pilih Data yang Akan Dihapus!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Menghapus Data yang Telah Anda Pilih?(OK untuk menghapus / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Menghapus Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("Select * from tbl_admin where kode_admin='" & txtusername.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    conn.Close()
                    conn.Open()
                    sql = "Delete from tbl_admin where kode_admin='" & txtusername.Text & "'"
                    cmd = New MySqlCommand(sql, conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Penghapusan Data Berhasil", , "Info")
                        bersih()
                        tampil()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn.Close()
                    bersih()
                End If
            Else
                conn.Open()
                bersih()
            End If
        End If
    End Sub
    Private Sub btselesai_Click(sender As Object, e As EventArgs) Handles btselesai.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub
    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        If bthapus.Enabled = False Then
        Else
            Dim row As DataGridViewRow = dg.Rows(dg.CurrentRow.Index)
            If Not IsDBNull(row.Cells("Kode_admin").Value) Then
                txtusername.Text = row.Cells("Kode_admin").Value
                If Not IsDBNull(row.Cells("Nama_admin").Value) Then
                    txtnama.Text = row.Cells("Nama_admin").Value
                    If Not IsDBNull(row.Cells("password_admin").Value) Then
                        txtpw.Text = row.Cells("Password_admin").Value
                        If Not IsDBNull(row.Cells("Level_admin").Value) Then
                            cbstat.Text = row.Cells("Level_admin").Value
                        End If
                    End If
                End If
            End If
        End If
        btsimpan.Enabled = False
        btselesai.Enabled = False
        bttambah.Text = "Batal"
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        txtcari.Clear()
        txtcari.Focus()
    End Sub
    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
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

    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        If txtusername.Text = "" Then
            MsgBox("Pilih Data yang Akan Diedit!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Mengedit Data yang Telah Anda Pilih?(OK untuk update / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Edit Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Open()
                cmd = New MySqlCommand("Select * from tbl_admin where kode_admin='" & txtusername.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    sql = " UPDATE tbl_admin SET kode_admin='" & txtusername.Text & "',nama_admin='" & txtnama.Text & "',password_admin='" & txtpw.Text & "',Level_admin='" & cbstat.Text & "' WHERE username='" & txtusername.Text & "'"

                    Dim cmd As New MySqlCommand(sql, conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Update Data Berhasil", , "Info")
                        bersih()
                        tampil()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    conn.Close()
                    bersih()

                End If
            Else
                bersih()
            End If
            conn.Close()
        End If
    End Sub
End Class