<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendaftaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemeriksaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengambilanObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelesaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lHello = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lTanggal = New System.Windows.Forms.Label()
        Me.lWaktu = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendaftaranToolStripMenuItem, Me.PemeriksaanToolStripMenuItem, Me.PengambilanObatToolStripMenuItem, Me.SelesaiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PendaftaranToolStripMenuItem
        '
        Me.PendaftaranToolStripMenuItem.Name = "PendaftaranToolStripMenuItem"
        Me.PendaftaranToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PendaftaranToolStripMenuItem.Text = "Pendaftaran"
        '
        'PemeriksaanToolStripMenuItem
        '
        Me.PemeriksaanToolStripMenuItem.Name = "PemeriksaanToolStripMenuItem"
        Me.PemeriksaanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PemeriksaanToolStripMenuItem.Text = "Pemeriksaan"
        '
        'PengambilanObatToolStripMenuItem
        '
        Me.PengambilanObatToolStripMenuItem.Name = "PengambilanObatToolStripMenuItem"
        Me.PengambilanObatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PengambilanObatToolStripMenuItem.Text = "Pengambilan Obat"
        '
        'SelesaiToolStripMenuItem
        '
        Me.SelesaiToolStripMenuItem.Name = "SelesaiToolStripMenuItem"
        Me.SelesaiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelesaiToolStripMenuItem.Text = "Selesai"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.DokterToolStripMenuItem, Me.PasienToolStripMenuItem, Me.ObatToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.DokterToolStripMenuItem.Text = "Dokter"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'lHello
        '
        Me.lHello.AutoSize = True
        Me.lHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHello.Location = New System.Drawing.Point(242, 104)
        Me.lHello.Name = "lHello"
        Me.lHello.Size = New System.Drawing.Size(322, 63)
        Me.lHello.TabIndex = 1
        Me.lHello.Text = "Hello, User!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Semoga hari ini lancar ya"
        '
        'Timer1
        '
        '
        'lTanggal
        '
        Me.lTanggal.AutoSize = True
        Me.lTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTanggal.Location = New System.Drawing.Point(394, 267)
        Me.lTanggal.Name = "lTanggal"
        Me.lTanggal.Size = New System.Drawing.Size(119, 31)
        Me.lTanggal.TabIndex = 3
        Me.lTanggal.Text = "Tanggal"
        '
        'lWaktu
        '
        Me.lWaktu.AutoSize = True
        Me.lWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lWaktu.Location = New System.Drawing.Point(247, 267)
        Me.lWaktu.Name = "lWaktu"
        Me.lWaktu.Size = New System.Drawing.Size(96, 31)
        Me.lWaktu.TabIndex = 4
        Me.lWaktu.Text = "Waktu"
        '
        'HomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lWaktu)
        Me.Controls.Add(Me.lTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendaftaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemeriksaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengambilanObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelesaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lHello As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lTanggal As Label
    Friend WithEvents lWaktu As Label
End Class
