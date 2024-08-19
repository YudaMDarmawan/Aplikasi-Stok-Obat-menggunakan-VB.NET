Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MASTERToolStripMenuItem.Enabled = False
        MenudataToolStripMenuItem.Enabled = False
        LAPORANToolStripMenuItem.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call terkunci()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub
    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub PENGATURANUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PENGATURANUSERToolStripMenuItem.Click
        Fentryuser.ShowDialog()
    End Sub
    Private Sub DATAOBATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAOBATToolStripMenuItem.Click
        Form_obat.ShowDialog()
    End Sub
    Private Sub STOKOBATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOKOBATToolStripMenuItem.Click
        Stok_Obat.ShowDialog()
    End Sub
    Private Sub OBATMASUKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OBATMASUKToolStripMenuItem.Click
        Dataobatmasuk.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call terkunci()
    End Sub

    Private Sub OBATKELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OBATKELUARToolStripMenuItem.Click
        Dataobatkeluar.ShowDialog()
    End Sub
End Class
