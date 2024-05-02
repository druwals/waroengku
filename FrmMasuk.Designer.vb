<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasuk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pncari = New System.Windows.Forms.Panel()
        Me.dgvcari = New System.Windows.Forms.DataGridView()
        Me.bttpcari = New System.Windows.Forms.Button()
        Me.tdgvcari = New System.Windows.Forms.TextBox()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.bTmbhBrg = New System.Windows.Forms.Button()
        Me.bTmbhStok = New System.Windows.Forms.Button()
        Me.bCari = New System.Windows.Forms.Button()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBarang = New System.Windows.Forms.Label()
        Me.tHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.tsupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tJumlah = New System.Windows.Forms.TextBox()
        Me.dgvtampil = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bPrev = New System.Windows.Forms.Button()
        Me.BNext = New System.Windows.Forms.Button()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.pncari.SuspendLayout()
        CType(Me.dgvcari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pncari)
        Me.Panel1.Controls.Add(Me.bTutup)
        Me.Panel1.Controls.Add(Me.bTmbhBrg)
        Me.Panel1.Controls.Add(Me.bTmbhStok)
        Me.Panel1.Controls.Add(Me.bCari)
        Me.Panel1.Controls.Add(Me.lblSatuan)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblBarang)
        Me.Panel1.Controls.Add(Me.tHarga)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tkode)
        Me.Panel1.Controls.Add(Me.tsupplier)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tJumlah)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 461)
        Me.Panel1.TabIndex = 0
        '
        'pncari
        '
        Me.pncari.Controls.Add(Me.dgvcari)
        Me.pncari.Controls.Add(Me.bttpcari)
        Me.pncari.Controls.Add(Me.tdgvcari)
        Me.pncari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pncari.Location = New System.Drawing.Point(0, 0)
        Me.pncari.Name = "pncari"
        Me.pncari.Size = New System.Drawing.Size(339, 461)
        Me.pncari.TabIndex = 28
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
        Me.dgvcari.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcari.ColumnHeadersHeight = 30
        Me.dgvcari.EnableHeadersVisualStyles = False
        Me.dgvcari.Location = New System.Drawing.Point(3, 32)
        Me.dgvcari.MultiSelect = False
        Me.dgvcari.Name = "dgvcari"
        Me.dgvcari.ReadOnly = True
        Me.dgvcari.RowHeadersVisible = False
        Me.dgvcari.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvcari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcari.Size = New System.Drawing.Size(333, 426)
        Me.dgvcari.TabIndex = 26
        '
        'bttpcari
        '
        Me.bttpcari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttpcari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttpcari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttpcari.FlatAppearance.BorderSize = 0
        Me.bttpcari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttpcari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttpcari.ForeColor = System.Drawing.Color.White
        Me.bttpcari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttpcari.Location = New System.Drawing.Point(299, 3)
        Me.bttpcari.Name = "bttpcari"
        Me.bttpcari.Size = New System.Drawing.Size(37, 23)
        Me.bttpcari.TabIndex = 25
        Me.bttpcari.Text = " x"
        Me.bttpcari.UseVisualStyleBackColor = False
        '
        'tdgvcari
        '
        Me.tdgvcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tdgvcari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdgvcari.Location = New System.Drawing.Point(3, 3)
        Me.tdgvcari.Name = "tdgvcari"
        Me.tdgvcari.Size = New System.Drawing.Size(290, 23)
        Me.tdgvcari.TabIndex = 13
        '
        'bTutup
        '
        Me.bTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTutup.FlatAppearance.BorderSize = 0
        Me.bTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTutup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTutup.ForeColor = System.Drawing.Color.White
        Me.bTutup.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.bTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTutup.Location = New System.Drawing.Point(241, 179)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(90, 36)
        Me.bTutup.TabIndex = 27
        Me.bTutup.Text = "Tutup"
        Me.bTutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bTutup.UseVisualStyleBackColor = False
        '
        'bTmbhBrg
        '
        Me.bTmbhBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bTmbhBrg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTmbhBrg.FlatAppearance.BorderSize = 0
        Me.bTmbhBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTmbhBrg.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTmbhBrg.ForeColor = System.Drawing.Color.White
        Me.bTmbhBrg.Image = Global.Druwals72.My.Resources.Resources.plus16
        Me.bTmbhBrg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTmbhBrg.Location = New System.Drawing.Point(196, 94)
        Me.bTmbhBrg.Name = "bTmbhBrg"
        Me.bTmbhBrg.Size = New System.Drawing.Size(135, 25)
        Me.bTmbhBrg.TabIndex = 26
        Me.bTmbhBrg.Text = "Tambah barang"
        Me.bTmbhBrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTmbhBrg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bTmbhBrg.UseVisualStyleBackColor = False
        '
        'bTmbhStok
        '
        Me.bTmbhStok.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bTmbhStok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTmbhStok.FlatAppearance.BorderSize = 0
        Me.bTmbhStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTmbhStok.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTmbhStok.ForeColor = System.Drawing.Color.White
        Me.bTmbhStok.Image = Global.Druwals72.My.Resources.Resources.plus24
        Me.bTmbhStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTmbhStok.Location = New System.Drawing.Point(72, 179)
        Me.bTmbhStok.Name = "bTmbhStok"
        Me.bTmbhStok.Size = New System.Drawing.Size(148, 36)
        Me.bTmbhStok.TabIndex = 25
        Me.bTmbhStok.Text = "tambah Stok"
        Me.bTmbhStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTmbhStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bTmbhStok.UseVisualStyleBackColor = False
        '
        'bCari
        '
        Me.bCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCari.FlatAppearance.BorderSize = 0
        Me.bCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCari.ForeColor = System.Drawing.Color.White
        Me.bCari.Image = Global.Druwals72.My.Resources.Resources.cari161
        Me.bCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCari.Location = New System.Drawing.Point(271, 7)
        Me.bCari.Name = "bCari"
        Me.bCari.Size = New System.Drawing.Size(60, 23)
        Me.bCari.TabIndex = 24
        Me.bCari.Text = "Cari"
        Me.bCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bCari.UseVisualStyleBackColor = False
        '
        'lblSatuan
        '
        Me.lblSatuan.BackColor = System.Drawing.Color.Transparent
        Me.lblSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSatuan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatuan.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblSatuan.Location = New System.Drawing.Point(72, 65)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(259, 25)
        Me.lblSatuan.TabIndex = 23
        Me.lblSatuan.Text = " "
        Me.lblSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Location = New System.Drawing.Point(12, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Satuan"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(12, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Harga"
        '
        'lblBarang
        '
        Me.lblBarang.BackColor = System.Drawing.Color.Transparent
        Me.lblBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBarang.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarang.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblBarang.Location = New System.Drawing.Point(72, 35)
        Me.lblBarang.Name = "lblBarang"
        Me.lblBarang.Size = New System.Drawing.Size(259, 25)
        Me.lblBarang.TabIndex = 20
        Me.lblBarang.Text = " "
        Me.lblBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tHarga
        '
        Me.tHarga.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHarga.Location = New System.Drawing.Point(72, 151)
        Me.tHarga.Name = "tHarga"
        Me.tHarga.Size = New System.Drawing.Size(261, 23)
        Me.tHarga.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Barang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kode"
        '
        'tkode
        '
        Me.tkode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tkode.Location = New System.Drawing.Point(72, 7)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(193, 23)
        Me.tkode.TabIndex = 14
        '
        'tsupplier
        '
        Me.tsupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsupplier.Location = New System.Drawing.Point(72, 123)
        Me.tsupplier.Name = "tsupplier"
        Me.tsupplier.Size = New System.Drawing.Size(261, 23)
        Me.tsupplier.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jumlah"
        '
        'tJumlah
        '
        Me.tJumlah.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJumlah.Location = New System.Drawing.Point(72, 95)
        Me.tJumlah.Name = "tJumlah"
        Me.tJumlah.Size = New System.Drawing.Size(118, 23)
        Me.tJumlah.TabIndex = 13
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
        Me.dgvtampil.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvtampil.EnableHeadersVisualStyles = False
        Me.dgvtampil.Location = New System.Drawing.Point(339, 32)
        Me.dgvtampil.MultiSelect = False
        Me.dgvtampil.Name = "dgvtampil"
        Me.dgvtampil.ReadOnly = True
        Me.dgvtampil.RowHeadersVisible = False
        Me.dgvtampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtampil.Size = New System.Drawing.Size(563, 429)
        Me.dgvtampil.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 26)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.bPrev)
        Me.Panel2.Controls.Add(Me.BNext)
        Me.Panel2.Controls.Add(Me.tcari)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(339, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(563, 32)
        Me.Panel2.TabIndex = 3
        '
        'bPrev
        '
        Me.bPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPrev.FlatAppearance.BorderSize = 0
        Me.bPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPrev.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPrev.ForeColor = System.Drawing.Color.White
        Me.bPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPrev.Location = New System.Drawing.Point(484, 3)
        Me.bPrev.Name = "bPrev"
        Me.bPrev.Size = New System.Drawing.Size(37, 23)
        Me.bPrev.TabIndex = 27
        Me.bPrev.Text = "<"
        Me.bPrev.UseVisualStyleBackColor = False
        '
        'BNext
        '
        Me.BNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BNext.FlatAppearance.BorderSize = 0
        Me.BNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNext.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BNext.ForeColor = System.Drawing.Color.White
        Me.BNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BNext.Location = New System.Drawing.Point(523, 3)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(37, 23)
        Me.BNext.TabIndex = 26
        Me.BNext.Text = ">"
        Me.BNext.UseVisualStyleBackColor = False
        '
        'tcari
        '
        Me.tcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcari.Location = New System.Drawing.Point(0, 3)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(478, 23)
        Me.tcari.TabIndex = 15
        '
        'FrmMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(902, 461)
        Me.Controls.Add(Me.dgvtampil)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMasuk"
        Me.Text = " BARANG MASUK"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pncari.ResumeLayout(False)
        Me.pncari.PerformLayout()
        CType(Me.dgvcari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tkode As TextBox
    Friend WithEvents tsupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tJumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBarang As Label
    Friend WithEvents tHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvtampil As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tcari As TextBox
    Friend WithEvents lblSatuan As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bTmbhBrg As Button
    Friend WithEvents bTmbhStok As Button
    Friend WithEvents bCari As Button
    Friend WithEvents bTutup As Button
    Friend WithEvents pncari As Panel
    Friend WithEvents bttpcari As Button
    Friend WithEvents tdgvcari As TextBox
    Friend WithEvents dgvcari As DataGridView
    Friend WithEvents bPrev As Button
    Friend WithEvents BNext As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
End Class
