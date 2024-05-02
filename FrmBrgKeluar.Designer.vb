<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrgKeluar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrgKeluar))
        Me.pnatas = New System.Windows.Forms.Panel()
        Me.pnbayar = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tkembali = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ttunai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tgrdtot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pncari = New System.Windows.Forms.Panel()
        Me.dgvcari = New System.Windows.Forms.DataGridView()
        Me.tdgvcari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotharga = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.thrga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tsatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnmbrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnbawah = New System.Windows.Forms.Panel()
        Me.dgvtampil = New System.Windows.Forms.DataGridView()
        Me.KODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SATUAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nota = New System.Drawing.Printing.PrintDocument()
        Me.bLapTrans = New System.Windows.Forms.Button()
        Me.bBayar = New System.Windows.Forms.Button()
        Me.bclosebyr = New System.Windows.Forms.Button()
        Me.bclosecari = New System.Windows.Forms.Button()
        Me.bMin = New System.Windows.Forms.Button()
        Me.bMax = New System.Windows.Forms.Button()
        Me.btmenu = New System.Windows.Forms.Button()
        Me.bcari = New System.Windows.Forms.Button()
        Me.pnatas.SuspendLayout()
        Me.pnbayar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pncari.SuspendLayout()
        CType(Me.dgvcari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnbawah.SuspendLayout()
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnatas
        '
        Me.pnatas.BackColor = System.Drawing.Color.Purple
        Me.pnatas.Controls.Add(Me.pnbayar)
        Me.pnatas.Controls.Add(Me.pncari)
        Me.pnatas.Controls.Add(Me.bMin)
        Me.pnatas.Controls.Add(Me.bMax)
        Me.pnatas.Controls.Add(Me.btmenu)
        Me.pnatas.Controls.Add(Me.GroupBox2)
        Me.pnatas.Controls.Add(Me.GroupBox1)
        Me.pnatas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnatas.Location = New System.Drawing.Point(0, 0)
        Me.pnatas.Name = "pnatas"
        Me.pnatas.Size = New System.Drawing.Size(1004, 218)
        Me.pnatas.TabIndex = 1
        '
        'pnbayar
        '
        Me.pnbayar.Controls.Add(Me.GroupBox3)
        Me.pnbayar.Controls.Add(Me.Panel2)
        Me.pnbayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnbayar.Location = New System.Drawing.Point(0, 0)
        Me.pnbayar.Name = "pnbayar"
        Me.pnbayar.Size = New System.Drawing.Size(1004, 218)
        Me.pnbayar.TabIndex = 36
        Me.pnbayar.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.tkembali)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ttunai)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tgrdtot)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1004, 188)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'tkembali
        '
        Me.tkembali.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tkembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tkembali.ForeColor = System.Drawing.SystemColors.Info
        Me.tkembali.Location = New System.Drawing.Point(148, 107)
        Me.tkembali.Name = "tkembali"
        Me.tkembali.ReadOnly = True
        Me.tkembali.Size = New System.Drawing.Size(332, 33)
        Me.tkembali.TabIndex = 13
        Me.tkembali.Text = "0"
        Me.tkembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Kembali"
        '
        'ttunai
        '
        Me.ttunai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ttunai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttunai.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ttunai.Location = New System.Drawing.Point(148, 68)
        Me.ttunai.Name = "ttunai"
        Me.ttunai.Size = New System.Drawing.Size(332, 33)
        Me.ttunai.TabIndex = 11
        Me.ttunai.Text = "0"
        Me.ttunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tunai"
        '
        'tgrdtot
        '
        Me.tgrdtot.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tgrdtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tgrdtot.ForeColor = System.Drawing.Color.Aqua
        Me.tgrdtot.Location = New System.Drawing.Point(148, 29)
        Me.tgrdtot.Name = "tgrdtot"
        Me.tgrdtot.ReadOnly = True
        Me.tgrdtot.Size = New System.Drawing.Size(332, 33)
        Me.tgrdtot.TabIndex = 9
        Me.tgrdtot.Text = "0"
        Me.tgrdtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Grand Total"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.bclosebyr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 30)
        Me.Panel2.TabIndex = 1
        '
        'pncari
        '
        Me.pncari.Controls.Add(Me.dgvcari)
        Me.pncari.Controls.Add(Me.bclosecari)
        Me.pncari.Controls.Add(Me.tdgvcari)
        Me.pncari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pncari.Location = New System.Drawing.Point(0, 0)
        Me.pncari.Name = "pncari"
        Me.pncari.Size = New System.Drawing.Size(1004, 218)
        Me.pncari.TabIndex = 35
        Me.pncari.Visible = False
        '
        'dgvcari
        '
        Me.dgvcari.AllowUserToAddRows = False
        Me.dgvcari.AllowUserToDeleteRows = False
        Me.dgvcari.AllowUserToResizeColumns = False
        Me.dgvcari.AllowUserToResizeRows = False
        Me.dgvcari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvcari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcari.Location = New System.Drawing.Point(3, 32)
        Me.dgvcari.MultiSelect = False
        Me.dgvcari.Name = "dgvcari"
        Me.dgvcari.ReadOnly = True
        Me.dgvcari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcari.Size = New System.Drawing.Size(998, 183)
        Me.dgvcari.TabIndex = 28
        '
        'tdgvcari
        '
        Me.tdgvcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tdgvcari.Location = New System.Drawing.Point(3, 3)
        Me.tdgvcari.Name = "tdgvcari"
        Me.tdgvcari.Size = New System.Drawing.Size(969, 23)
        Me.tdgvcari.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Purple
        Me.GroupBox2.Controls.Add(Me.lbltotharga)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(363, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 185)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Harga"
        '
        'lbltotharga
        '
        Me.lbltotharga.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbltotharga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltotharga.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotharga.ForeColor = System.Drawing.Color.Lime
        Me.lbltotharga.Location = New System.Drawing.Point(3, 19)
        Me.lbltotharga.Name = "lbltotharga"
        Me.lbltotharga.Size = New System.Drawing.Size(635, 163)
        Me.lbltotharga.TabIndex = 0
        Me.lbltotharga.Text = "0"
        Me.lbltotharga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Purple
        Me.GroupBox1.Controls.Add(Me.bcari)
        Me.GroupBox1.Controls.Add(Me.thrga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tsatuan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tnmbrg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tkode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 185)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'thrga
        '
        Me.thrga.Location = New System.Drawing.Point(65, 117)
        Me.thrga.Name = "thrga"
        Me.thrga.Size = New System.Drawing.Size(283, 23)
        Me.thrga.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Harga"
        '
        'tsatuan
        '
        Me.tsatuan.Location = New System.Drawing.Point(65, 88)
        Me.tsatuan.Name = "tsatuan"
        Me.tsatuan.Size = New System.Drawing.Size(283, 23)
        Me.tsatuan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Satuan"
        '
        'tnmbrg
        '
        Me.tnmbrg.Location = New System.Drawing.Point(65, 59)
        Me.tnmbrg.Name = "tnmbrg"
        Me.tnmbrg.Size = New System.Drawing.Size(283, 23)
        Me.tnmbrg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barang"
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(65, 30)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(217, 23)
        Me.tkode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode"
        '
        'pnbawah
        '
        Me.pnbawah.Controls.Add(Me.bLapTrans)
        Me.pnbawah.Controls.Add(Me.bBayar)
        Me.pnbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnbawah.Location = New System.Drawing.Point(0, 460)
        Me.pnbawah.Name = "pnbawah"
        Me.pnbawah.Size = New System.Drawing.Size(1004, 50)
        Me.pnbawah.TabIndex = 2
        '
        'dgvtampil
        '
        Me.dgvtampil.AllowUserToAddRows = False
        Me.dgvtampil.AllowUserToDeleteRows = False
        Me.dgvtampil.AllowUserToResizeColumns = False
        Me.dgvtampil.AllowUserToResizeRows = False
        Me.dgvtampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvtampil.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvtampil.ColumnHeadersHeight = 30
        Me.dgvtampil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KODE, Me.BARANG, Me.SATUAN, Me.HARGA, Me.QTY, Me.TOTAL})
        Me.dgvtampil.ContextMenuStrip = Me.klik_kanan
        Me.dgvtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvtampil.EnableHeadersVisualStyles = False
        Me.dgvtampil.Location = New System.Drawing.Point(0, 218)
        Me.dgvtampil.MultiSelect = False
        Me.dgvtampil.Name = "dgvtampil"
        Me.dgvtampil.RowHeadersVisible = False
        Me.dgvtampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvtampil.Size = New System.Drawing.Size(1004, 242)
        Me.dgvtampil.TabIndex = 3
        '
        'KODE
        '
        Me.KODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.KODE.HeaderText = "KODE"
        Me.KODE.Name = "KODE"
        Me.KODE.ReadOnly = True
        Me.KODE.Width = 150
        '
        'BARANG
        '
        Me.BARANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BARANG.HeaderText = "BARANG"
        Me.BARANG.Name = "BARANG"
        Me.BARANG.ReadOnly = True
        Me.BARANG.Width = 680
        '
        'SATUAN
        '
        Me.SATUAN.HeaderText = "SATUAN"
        Me.SATUAN.Name = "SATUAN"
        Me.SATUAN.ReadOnly = True
        Me.SATUAN.Width = 80
        '
        'HARGA
        '
        Me.HARGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.HARGA.DefaultCellStyle = DataGridViewCellStyle1
        Me.HARGA.HeaderText = "HARGA"
        Me.HARGA.Name = "HARGA"
        Me.HARGA.ReadOnly = True
        Me.HARGA.Width = 200
        '
        'QTY
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle2
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 56
        '
        'TOTAL
        '
        Me.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 200
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusToolStripMenuItem})
        Me.klik_kanan.Name = "klik_kanan"
        Me.klik_kanan.Size = New System.Drawing.Size(109, 26)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'nota
        '
        '
        'bLapTrans
        '
        Me.bLapTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bLapTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bLapTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLapTrans.FlatAppearance.BorderSize = 0
        Me.bLapTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLapTrans.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLapTrans.ForeColor = System.Drawing.Color.White
        Me.bLapTrans.Image = Global.Druwals72.My.Resources.Resources.Microsoft_Excel_24
        Me.bLapTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLapTrans.Location = New System.Drawing.Point(193, 8)
        Me.bLapTrans.Name = "bLapTrans"
        Me.bLapTrans.Size = New System.Drawing.Size(192, 35)
        Me.bLapTrans.TabIndex = 21
        Me.bLapTrans.Text = " Laporan  Transaksi"
        Me.bLapTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLapTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLapTrans.UseVisualStyleBackColor = False
        '
        'bBayar
        '
        Me.bBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bBayar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBayar.FlatAppearance.BorderSize = 0
        Me.bBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBayar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBayar.ForeColor = System.Drawing.Color.White
        Me.bBayar.Image = Global.Druwals72.My.Resources.Resources.savew24
        Me.bBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBayar.Location = New System.Drawing.Point(12, 8)
        Me.bBayar.Name = "bBayar"
        Me.bBayar.Size = New System.Drawing.Size(175, 35)
        Me.bBayar.TabIndex = 20
        Me.bBayar.Text = "  Bayar (F2)"
        Me.bBayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBayar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bBayar.UseVisualStyleBackColor = False
        '
        'bclosebyr
        '
        Me.bclosebyr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bclosebyr.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bclosebyr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bclosebyr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bclosebyr.FlatAppearance.BorderSize = 0
        Me.bclosebyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclosebyr.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclosebyr.ForeColor = System.Drawing.Color.White
        Me.bclosebyr.Image = Global.Druwals72.My.Resources.Resources.silang16
        Me.bclosebyr.Location = New System.Drawing.Point(975, 4)
        Me.bclosebyr.Name = "bclosebyr"
        Me.bclosebyr.Size = New System.Drawing.Size(23, 23)
        Me.bclosebyr.TabIndex = 28
        Me.bclosebyr.UseVisualStyleBackColor = False
        '
        'bclosecari
        '
        Me.bclosecari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bclosecari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bclosecari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bclosecari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bclosecari.FlatAppearance.BorderSize = 0
        Me.bclosecari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclosecari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bclosecari.ForeColor = System.Drawing.Color.White
        Me.bclosecari.Image = Global.Druwals72.My.Resources.Resources.silang16
        Me.bclosecari.Location = New System.Drawing.Point(978, 3)
        Me.bclosecari.Name = "bclosecari"
        Me.bclosecari.Size = New System.Drawing.Size(23, 23)
        Me.bclosecari.TabIndex = 27
        Me.bclosecari.UseVisualStyleBackColor = False
        '
        'bMin
        '
        Me.bMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bMin.FlatAppearance.BorderSize = 0
        Me.bMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMin.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMin.ForeColor = System.Drawing.Color.White
        Me.bMin.Image = Global.Druwals72.My.Resources.Resources.min16
        Me.bMin.Location = New System.Drawing.Point(911, 12)
        Me.bMin.Name = "bMin"
        Me.bMin.Size = New System.Drawing.Size(23, 23)
        Me.bMin.TabIndex = 34
        Me.bMin.UseVisualStyleBackColor = False
        '
        'bMax
        '
        Me.bMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bMax.FlatAppearance.BorderSize = 0
        Me.bMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMax.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMax.ForeColor = System.Drawing.Color.White
        Me.bMax.Image = Global.Druwals72.My.Resources.Resources.blok16
        Me.bMax.Location = New System.Drawing.Point(940, 12)
        Me.bMax.Name = "bMax"
        Me.bMax.Size = New System.Drawing.Size(23, 23)
        Me.bMax.TabIndex = 33
        Me.bMax.UseVisualStyleBackColor = False
        '
        'btmenu
        '
        Me.btmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmenu.FlatAppearance.BorderSize = 0
        Me.btmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmenu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmenu.ForeColor = System.Drawing.Color.White
        Me.btmenu.Image = Global.Druwals72.My.Resources.Resources.silang16
        Me.btmenu.Location = New System.Drawing.Point(969, 12)
        Me.btmenu.Name = "btmenu"
        Me.btmenu.Size = New System.Drawing.Size(23, 23)
        Me.btmenu.TabIndex = 32
        Me.btmenu.UseVisualStyleBackColor = False
        '
        'bcari
        '
        Me.bcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bcari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bcari.FlatAppearance.BorderSize = 0
        Me.bcari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bcari.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcari.ForeColor = System.Drawing.Color.White
        Me.bcari.Image = Global.Druwals72.My.Resources.Resources.cari161
        Me.bcari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bcari.Location = New System.Drawing.Point(288, 30)
        Me.bcari.Name = "bcari"
        Me.bcari.Size = New System.Drawing.Size(60, 23)
        Me.bcari.TabIndex = 8
        Me.bcari.Text = "Cari"
        Me.bcari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bcari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bcari.UseVisualStyleBackColor = False
        '
        'FrmBrgKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvtampil)
        Me.Controls.Add(Me.pnbawah)
        Me.Controls.Add(Me.pnatas)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBrgKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " TRANSAKSI "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnatas.ResumeLayout(False)
        Me.pnbayar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pncari.ResumeLayout(False)
        Me.pncari.PerformLayout()
        CType(Me.dgvcari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnbawah.ResumeLayout(False)
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnatas As Panel
    Friend WithEvents pnbawah As Panel
    Friend WithEvents dgvtampil As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotharga As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bcari As Button
    Friend WithEvents thrga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tsatuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tnmbrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tkode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bLapTrans As Button
    Friend WithEvents bBayar As Button
    Friend WithEvents klik_kanan As ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nota As Printing.PrintDocument
    Friend WithEvents bMin As Button
    Friend WithEvents bMax As Button
    Friend WithEvents btmenu As Button
    Friend WithEvents pncari As Panel
    Friend WithEvents dgvcari As DataGridView
    Friend WithEvents bclosecari As Button
    Friend WithEvents tdgvcari As TextBox
    Friend WithEvents pnbayar As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tkembali As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ttunai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tgrdtot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bclosebyr As Button
    Friend WithEvents KODE As DataGridViewTextBoxColumn
    Friend WithEvents BARANG As DataGridViewTextBoxColumn
    Friend WithEvents SATUAN As DataGridViewTextBoxColumn
    Friend WithEvents HARGA As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
End Class
