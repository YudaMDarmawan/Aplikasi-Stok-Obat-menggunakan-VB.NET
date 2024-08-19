Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Dataobatkeluar
    Dim sql As String
    Dim sql1 As String
    Dim ds As DataSet
    Sub awal()
        koneksivb()
        sql = "select kode_obat from tbl_obat"
        Try
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr.Item("kode_obat"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub
    Sub bersih()
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then x.Text = ""
        Next
        ComboBox1.Focus()
        btnsimpan.Enabled = True
        btnkeluar.Enabled = True
        txtcari.Text = "Cari Berdasarkan Kode Obat"
        txtcari.ForeColor = Color.Gray
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker3.Text = ""
        TextBox6.Text = ""
        dt.Rows.Clear()

    End Sub
    Sub tampil()
        koneksivb()
        da = New MySqlDataAdapter("select * from tbl_obatkeluar order by Kode_Obat", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_obatkeluar")
        DataGridView1.DataSource = (ds.Tables("tbl_obatkeluar"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New MySqlCommand("Select * from tbl_obat where Kode_Obat='" & ComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item("Produk_obat")
            TextBox2.Text = dr.Item("Jenis_obat")
            DateTimePicker1.Text = dr.Item("Tgl_produksi")
            DateTimePicker2.Text = dr.Item("Exp")
            TextBox3.Text = dr.Item("HET")
            TextBox4.Text = dr.Item("Ukuran")
            TextBox1.Focus()
        End If
        dr.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        koneksivb()
        If ComboBox1.Text = "" Or TextBox5.Text = "" Or DateTimePicker3.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Masih Ada Field Data yang Tidak Diisi")
            bersih()
        Else
            cmd = New MySqlCommand("Select * from tbl_obatkeluar where Kode_Obat='" & ComboBox1.Text & "'", conn)
            cmd1 = New MySqlCommand("Select * from tbl_stok where Kode_Obat='" & ComboBox1.Text & "'", conn)
            dr = cmd1.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                Try
                    Dim sql1 As String = "update tbl_stok set jumlah =jumlah-'" & TextBox6.Text & "' where kode_obat='" & ComboBox1.Text & "'"
                    cmd1 = New MySqlCommand(sql1, conn)
                    sql = "insert into tbl_obatkeluar values('" & ComboBox1.Text & "','" & TextBox5.Text & "','" & DateTimePicker3.Value.ToString & "','" & TextBox6.Text & "')"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                bersih()
                tampil()
                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub

    Private Sub Dataobatkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksivb()
        Call awal()
        Call bersih()
        Call tampil()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = ("MMMM yyyy")
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = ("MMMM yyyy")
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
        For counter = 1 To DataGridView1.RowCount - 1
            baca = DataGridView1.Rows(counter - 1).Cells(0).Value
            baca1 = DataGridView1.Rows(counter - 1).Cells(1).Value
            found = UCase(baca) Like UCase(pola) Or UCase(baca1) Like UCase(pola)
            If found = True Then
                DataGridView1.CurrentCell = DataGridView1.Item(0, counter - 1)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

    End Sub
End Class