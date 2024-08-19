<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenudataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOKOBATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBATMASUKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBATKELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGATURANUSERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAOBATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MenudataToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.LAPORANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(890, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LoginToolStripMenuItem.Text = "LOGIN"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LogoutToolStripMenuItem.Text = "LOGOUT"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        '
        'MenudataToolStripMenuItem
        '
        Me.MenudataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STOKOBATToolStripMenuItem, Me.OBATMASUKToolStripMenuItem, Me.OBATKELUARToolStripMenuItem})
        Me.MenudataToolStripMenuItem.Name = "MenudataToolStripMenuItem"
        Me.MenudataToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.MenudataToolStripMenuItem.Text = "MENU DATA"
        '
        'STOKOBATToolStripMenuItem
        '
        Me.STOKOBATToolStripMenuItem.Name = "STOKOBATToolStripMenuItem"
        Me.STOKOBATToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.STOKOBATToolStripMenuItem.Text = "STOK OBAT"
        '
        'OBATMASUKToolStripMenuItem
        '
        Me.OBATMASUKToolStripMenuItem.Name = "OBATMASUKToolStripMenuItem"
        Me.OBATMASUKToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OBATMASUKToolStripMenuItem.Text = "OBAT MASUK"
        '
        'OBATKELUARToolStripMenuItem
        '
        Me.OBATKELUARToolStripMenuItem.Name = "OBATKELUARToolStripMenuItem"
        Me.OBATKELUARToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OBATKELUARToolStripMenuItem.Text = "OBAT KELUAR"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENGATURANUSERToolStripMenuItem, Me.DATAOBATToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'PENGATURANUSERToolStripMenuItem
        '
        Me.PENGATURANUSERToolStripMenuItem.Name = "PENGATURANUSERToolStripMenuItem"
        Me.PENGATURANUSERToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PENGATURANUSERToolStripMenuItem.Text = "PENGATURAN USER"
        '
        'DATAOBATToolStripMenuItem
        '
        Me.DATAOBATToolStripMenuItem.Name = "DATAOBATToolStripMenuItem"
        Me.DATAOBATToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DATAOBATToolStripMenuItem.Text = "DATA OBAT"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 418)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenudataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGATURANUSERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAOBATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOKOBATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OBATMASUKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OBATKELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
