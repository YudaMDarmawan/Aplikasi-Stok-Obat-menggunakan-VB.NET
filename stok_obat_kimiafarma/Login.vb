Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Dim sql As String
    Dim ds As DataSet
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
        txtpw.PasswordChar = "X"
        txtpw.Clear()
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        If ComboBox1.Text = "" Or txtpw.Text = "" Then
            MsgBox("data login belum lengkap")
            Exit Sub
        Else
            Call koneksivb()
            cmd = New MySqlCommand("select * from tbl_admin where kode_admin='" & ComboBox1.Text & "' and password_admin='" & txtpw.Text & "' and level_admin='admin'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Close()
                Form1.Show()
                Form1.LoginToolStripMenuItem.Enabled = False
                Form1.LogoutToolStripMenuItem.Enabled = True
                Form1.MenudataToolStripMenuItem.Enabled = True
                Form1.MASTERToolStripMenuItem.Enabled = True
                Form1.LAPORANToolStripMenuItem.Enabled = True
            Else
                Call koneksivb()
                cmd = New MySqlCommand("select * from tbl_admin where kode_admin='" & ComboBox1.Text & "' and password_admin='" & txtpw.Text & "' and level_admin='petugas'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Me.Close()
                    Form1.Show()
                    Form1.LoginToolStripMenuItem.Enabled = False
                    Form1.LogoutToolStripMenuItem.Enabled = True
                    Form1.MenudataToolStripMenuItem.Enabled = True
                    Form1.MASTERToolStripMenuItem.Enabled = False
                    Form1.LAPORANToolStripMenuItem.Enabled = True
                    Dataobatkeluar.btnhapus.Enabled = False
                    Dataobatmasuk.btnhapus.Enabled = False
                Else
                    MsgBox("Kode Admin atau Password salah")
                End If
            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksivb()
        cmd = New MySqlCommand("Select * from tbl_admin where kode_admin='" & ComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        dr.Close()
    End Sub
    Sub awal()
        koneksivb()
        sql = "select kode_admin from tbl_admin"
        Try
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr.Item("kode_admin"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Close()
    End Sub
End Class