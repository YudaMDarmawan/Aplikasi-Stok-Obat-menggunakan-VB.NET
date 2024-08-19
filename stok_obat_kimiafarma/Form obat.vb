Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Form_obat
    Dim sql As String
    Dim sql1 As String
    Dim ds As DataSet
    Sub tampil()
        da = New MySqlDataAdapter("select * from tbl_obat order by Kode_Obat", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_obat")
        conn.Close()
        dg.DataSource = (ds.Tables("tbl_obat"))
        dg.ReadOnly = True
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        txtno.Focus()
        txtno.ReadOnly = False
        bttambah.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
        btsimpan.Enabled = True
        btkeluar.Enabled = True
        bttambah.Text = "TAMBAH"
        txtcari.Text = "Cari Berdasarkan Kode Obat"
        txtcari.ForeColor = Color.Gray
        cbjenis.Text = ""
        If cbjenis.Items.Count = 0 Then
            cbjenis.Items.Add("Sirup")
            cbjenis.Items.Add("Tablet")
        End If
    End Sub
    Private Sub Form_obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = ("MMMM yyyy")
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = ("MMMM yyyy")
        Call bersih()
        Call koneksivb()
        Call tampil()
    End Sub
    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        Me.Close()
        Menu_Utama.Show()
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
        If txtno.Text = "" Then
            MsgBox("Pilih Data yang Akan Diedit!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Mengedit Data yang Telah Anda Pilih?(OK untuk update / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Edit Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Open()
                cmd = New MySqlCommand("Select * from tbl_obat where Kode_Obat='" & txtno.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    sql = " UPDATE tbl_obat SET Kode_Obat='" & txtno.Text & "',produk_obat='" & txtprodk.Text & "',jenis_obat='" & cbjenis.Text & "',Tgl_produksi='" & DateTimePicker1.Text & "',Exp='" & DateTimePicker2.Text & "',HET='" & txthet.Text & "',Ukuran='" & txtukuran.Text & "' WHERE username='" & txtno.Text & "'"
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
        End If
    End Sub
    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        conn.Open()
        If txtno.Text = "" Or txtprodk.Text = "" Or cbjenis.Text = "" Or DateTimePicker1.Text = "" Or DateTimePicker2.Text = "" Or txthet.Text = "" Or txtukuran.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tbl_obat where Kode_Obat='" & txtno.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            dr.Close()
            If dr.HasRows Then
                MsgBox("Data Sudah Ada, Masukan data yg Lain", , "Perhatian")
                bersih()
                conn.Close()
            Else
                sql = "insert into tbl_obat values('" & txtno.Text & "','" & txtprodk.Text & "','" & cbjenis.Text & "','" & DateTimePicker1.Value.ToString & "','" & DateTimePicker2.Value.ToString & "','" & txthet.Text & "','" & _
                txtukuran.Text & "')"
                cmd = New MySqlCommand(sql, conn)
                sql1 = "insert into tbl_stok values('" & txtno.Text & "','" & 0 & "')"
                cmd1 = New MySqlCommand(sql1, conn)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()
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
        If txtno.Text = "" Then
            MsgBox("Pilih Data yang Akan Dihapus!", , "Info")
        Else
            Dim respons = MsgBox("Anda Yakin Akan Menghapus Data yang Telah Anda Pilih?(OK untuk menghapus / Cancel untuk memilih data lain)", MsgBoxStyle.OkCancel, "Perhatian Menghapus Data!")
            If respons = MsgBoxResult.Ok Then
                conn.Close()
                conn.Open()
                cmd = New MySqlCommand("Select * from tbl_obat where Kode_Obat='" & txtno.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    conn.Close()
                    conn.Open()
                    sql = "Delete from tbl_obat where Kode_Obat='" & txtno.Text & "'"
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
End Class