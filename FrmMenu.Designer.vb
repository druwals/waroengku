<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.PnAtas = New System.Windows.Forms.Panel()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.culek = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingPrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.waduk = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TSJam = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TSTanggal = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PnForm = New System.Windows.Forms.Panel()
        Me.PnAtas.SuspendLayout()
        Me.culek.SuspendLayout()
        Me.waduk.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnAtas
        '
        Me.PnAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnAtas.Controls.Add(Me.lblForm)
        Me.PnAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnAtas.Location = New System.Drawing.Point(0, 0)
        Me.PnAtas.Name = "PnAtas"
        Me.PnAtas.Size = New System.Drawing.Size(833, 48)
        Me.PnAtas.TabIndex = 1
        '
        'lblForm
        '
        Me.lblForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblForm.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lblForm.Location = New System.Drawing.Point(0, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(833, 48)
        Me.lblForm.TabIndex = 0
        Me.lblForm.Text = "DASHBOARD"
        Me.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'culek
        '
        Me.culek.BackColor = System.Drawing.Color.Gainsboro
        Me.culek.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.culek.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.culek.Location = New System.Drawing.Point(0, 48)
        Me.culek.Name = "culek"
        Me.culek.Size = New System.Drawing.Size(833, 38)
        Me.culek.TabIndex = 3
        Me.culek.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.folder24
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 34)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.kelua24r
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(151, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataKaryawanToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.base
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(155, 34)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.shopping24
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(225, 34)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.orang24
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(225, 34)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.market24
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(124, 34)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.shop24
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(182, 34)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.suppl
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(182, 34)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapBarangToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.laporan24
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(116, 34)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LapBarangToolStripMenuItem
        '
        Me.LapBarangToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.grafik24
        Me.LapBarangToolStripMenuItem.Name = "LapBarangToolStripMenuItem"
        Me.LapBarangToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.LapBarangToolStripMenuItem.Text = "Lap Barang"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingPrinterToolStripMenuItem, Me.BarcodeToolStripMenuItem, Me.HakAksesToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.pengaturan24
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(147, 34)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'SettingPrinterToolStripMenuItem
        '
        Me.SettingPrinterToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.printer
        Me.SettingPrinterToolStripMenuItem.Name = "SettingPrinterToolStripMenuItem"
        Me.SettingPrinterToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.SettingPrinterToolStripMenuItem.Text = "Setting Printer"
        '
        'BarcodeToolStripMenuItem
        '
        Me.BarcodeToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.barcode24
        Me.BarcodeToolStripMenuItem.Name = "BarcodeToolStripMenuItem"
        Me.BarcodeToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.BarcodeToolStripMenuItem.Text = "Label Barcode"
        '
        'HakAksesToolStripMenuItem
        '
        Me.HakAksesToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.gmbk24
        Me.HakAksesToolStripMenuItem.Name = "HakAksesToolStripMenuItem"
        Me.HakAksesToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.HakAksesToolStripMenuItem.Text = "Hak Akses"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Image = Global.Druwals72.My.Resources.Resources.memo24
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(115, 34)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'Timer1
        '
        '
        'waduk
        '
        Me.waduk.BackColor = System.Drawing.Color.SandyBrown
        Me.waduk.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.waduk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.TSJam, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.TSTanggal})
        Me.waduk.Location = New System.Drawing.Point(0, 86)
        Me.waduk.Name = "waduk"
        Me.waduk.Size = New System.Drawing.Size(833, 33)
        Me.waduk.TabIndex = 5
        Me.waduk.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Druwals72.My.Resources.Resources.pngwing_com
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 30)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TSJam
        '
        Me.TSJam.Name = "TSJam"
        Me.TSJam.Size = New System.Drawing.Size(51, 30)
        Me.TSJam.Text = "Jam"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Druwals72.My.Resources.Resources.kalender16
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 30)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'TSTanggal
        '
        Me.TSTanggal.Name = "TSTanggal"
        Me.TSTanggal.Size = New System.Drawing.Size(88, 30)
        Me.TSTanggal.Text = "Tanggal"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.OrangeRed
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSSUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(833, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripStatusLabel1.Image = Global.Druwals72.My.Resources.Resources.BOS_ADMIN24
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'TSSUser
        '
        Me.TSSUser.Name = "TSSUser"
        Me.TSSUser.Size = New System.Drawing.Size(41, 17)
        Me.TSSUser.Text = "admin"
        '
        'PnForm
        '
        Me.PnForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnForm.Location = New System.Drawing.Point(0, 119)
        Me.PnForm.Name = "PnForm"
        Me.PnForm.Size = New System.Drawing.Size(833, 291)
        Me.PnForm.TabIndex = 7
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnForm)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.waduk)
        Me.Controls.Add(Me.culek)
        Me.Controls.Add(Me.PnAtas)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnAtas.ResumeLayout(False)
        Me.culek.ResumeLayout(False)
        Me.culek.PerformLayout()
        Me.waduk.ResumeLayout(False)
        Me.waduk.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnAtas As Panel
    Friend WithEvents lblForm As Label
    Friend WithEvents culek As MenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LapBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingPrinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HakAksesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents waduk As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TSJam As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents TSTanggal As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSSUser As ToolStripStatusLabel
    Friend WithEvents PnForm As Panel
End Class
