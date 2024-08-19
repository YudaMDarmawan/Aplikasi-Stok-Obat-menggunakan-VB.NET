<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_obat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.txtprodk = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtukuran = New System.Windows.Forms.TextBox()
        Me.txthet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbjenis)
        Me.GroupBox1.Controls.Add(Me.txtprodk)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA OBAT"
        '
        'cbjenis
        '
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Location = New System.Drawing.Point(89, 74)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(119, 21)
        Me.cbjenis.TabIndex = 5
        '
        'txtprodk
        '
        Me.txtprodk.Location = New System.Drawing.Point(90, 46)
        Me.txtprodk.Name = "txtprodk"
        Me.txtprodk.Size = New System.Drawing.Size(184, 20)
        Me.txtprodk.TabIndex = 4
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(89, 20)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(119, 20)
        Me.txtno.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Produk Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(319, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MASA KADALUARSA OBAT"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(99, 74)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "EXP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tanggal Produksi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtukuran)
        Me.GroupBox3.Controls.Add(Me.txthet)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(558, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 104)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RINCIAN OBAT"
        '
        'txtukuran
        '
        Me.txtukuran.Location = New System.Drawing.Point(70, 69)
        Me.txtukuran.Name = "txtukuran"
        Me.txtukuran.Size = New System.Drawing.Size(142, 20)
        Me.txtukuran.TabIndex = 3
        '
        'txthet
        '
        Me.txthet.Location = New System.Drawing.Point(69, 25)
        Me.txthet.Name = "txthet"
        Me.txthet.Size = New System.Drawing.Size(142, 20)
        Me.txthet.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "UKURAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "HET"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btkeluar)
        Me.GroupBox4.Controls.Add(Me.bttambah)
        Me.GroupBox4.Controls.Add(Me.btedit)
        Me.GroupBox4.Controls.Add(Me.bthapus)
        Me.GroupBox4.Controls.Add(Me.btsimpan)
        Me.GroupBox4.Location = New System.Drawing.Point(84, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(639, 111)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MENU "
        '
        'btkeluar
        '
        Me.btkeluar.Image = CType(resources.GetObject("btkeluar.Image"), System.Drawing.Image)
        Me.btkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btkeluar.Location = New System.Drawing.Point(513, 27)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(120, 73)
        Me.btkeluar.TabIndex = 4
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Image = CType(resources.GetObject("bttambah.Image"), System.Drawing.Image)
        Me.bttambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttambah.Location = New System.Drawing.Point(6, 27)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(126, 73)
        Me.bttambah.TabIndex = 1
        Me.bttambah.Text = "TAMBAH"
        Me.bttambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Image = CType(resources.GetObject("btedit.Image"), System.Drawing.Image)
        Me.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btedit.Location = New System.Drawing.Point(138, 27)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(127, 73)
        Me.btedit.TabIndex = 0
        Me.btedit.Text = "EDIT DATA"
        Me.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btedit.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Image = CType(resources.GetObject("bthapus.Image"), System.Drawing.Image)
        Me.bthapus.Location = New System.Drawing.Point(391, 27)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(113, 73)
        Me.bthapus.TabIndex = 3
        Me.bthapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Image = CType(resources.GetObject("btsimpan.Image"), System.Drawing.Image)
        Me.btsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsimpan.Location = New System.Drawing.Point(271, 27)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(113, 73)
        Me.btsimpan.TabIndex = 2
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(25, 285)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(758, 208)
        Me.dg.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(541, 250)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(575, 254)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(208, 25)
        Me.txtcari.TabIndex = 6
        '
        'Form_obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(798, 505)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_obat"
        Me.Text = "Form_obat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents txtprodk As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtukuran As System.Windows.Forms.TextBox
    Friend WithEvents txthet As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bttambah As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
End Class
