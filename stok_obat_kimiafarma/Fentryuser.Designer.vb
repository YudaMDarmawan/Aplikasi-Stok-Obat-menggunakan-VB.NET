<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fentryuser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fentryuser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.cbstat = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btselesai = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "STATUS"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(114, 107)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(161, 20)
        Me.txtusername.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(114, 136)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(231, 20)
        Me.txtnama.TabIndex = 5
        '
        'txtpw
        '
        Me.txtpw.Location = New System.Drawing.Point(114, 168)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(161, 20)
        Me.txtpw.TabIndex = 6
        '
        'cbstat
        '
        Me.cbstat.FormattingEnabled = True
        Me.cbstat.Location = New System.Drawing.Point(114, 195)
        Me.cbstat.Name = "cbstat"
        Me.cbstat.Size = New System.Drawing.Size(161, 21)
        Me.cbstat.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btselesai)
        Me.GroupBox1.Controls.Add(Me.bthapus)
        Me.GroupBox1.Controls.Add(Me.bttambah)
        Me.GroupBox1.Controls.Add(Me.btsimpan)
        Me.GroupBox1.Controls.Add(Me.btedit)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 166)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'btselesai
        '
        Me.btselesai.Image = CType(resources.GetObject("btselesai.Image"), System.Drawing.Image)
        Me.btselesai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btselesai.Location = New System.Drawing.Point(252, 52)
        Me.btselesai.Name = "btselesai"
        Me.btselesai.Size = New System.Drawing.Size(111, 69)
        Me.btselesai.TabIndex = 11
        Me.btselesai.Text = "Keluar"
        Me.btselesai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btselesai.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Image = CType(resources.GetObject("bthapus.Image"), System.Drawing.Image)
        Me.bthapus.Location = New System.Drawing.Point(135, 86)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(111, 66)
        Me.bthapus.TabIndex = 3
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Image = CType(resources.GetObject("bttambah.Image"), System.Drawing.Image)
        Me.bttambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttambah.Location = New System.Drawing.Point(13, 14)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(116, 66)
        Me.bttambah.TabIndex = 0
        Me.bttambah.Text = "Tambah"
        Me.bttambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Image = CType(resources.GetObject("btsimpan.Image"), System.Drawing.Image)
        Me.btsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsimpan.Location = New System.Drawing.Point(135, 14)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(111, 66)
        Me.btsimpan.TabIndex = 1
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Image = CType(resources.GetObject("btedit.Image"), System.Drawing.Image)
        Me.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btedit.Location = New System.Drawing.Point(13, 86)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(116, 66)
        Me.btedit.TabIndex = 2
        Me.btedit.Text = "Edit Data"
        Me.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btedit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(430, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(466, 200)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(246, 22)
        Me.txtcari.TabIndex = 10
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(30, 237)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(769, 196)
        Me.dg.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 26)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "PENGATURAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " USER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fentryuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(811, 445)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbstat)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fentryuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fentryuser"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents cbstat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btselesai As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
