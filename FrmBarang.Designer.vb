<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.BTutup = New System.Windows.Forms.Button()
        Me.tCari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbsat = New System.Windows.Forms.ComboBox()
        Me.thrgbrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKode = New System.Windows.Forms.TextBox()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.GroupBox1.Controls.Add(Me.bHapus)
        Me.GroupBox1.Controls.Add(Me.BTutup)
        Me.GroupBox1.Controls.Add(Me.tCari)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbsat)
        Me.GroupBox1.Controls.Add(Me.thrgbrg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tKode)
        Me.GroupBox1.Controls.Add(Me.tNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BSimpan)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 162)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'bHapus
        '
        Me.bHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bHapus.FlatAppearance.BorderSize = 0
        Me.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHapus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHapus.ForeColor = System.Drawing.Color.White
        Me.bHapus.Image = Global.Druwals72.My.Resources.Resources.sapu24
        Me.bHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHapus.Location = New System.Drawing.Point(470, 26)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(103, 35)
        Me.bHapus.TabIndex = 19
        Me.bHapus.Text = "  Hapus"
        Me.bHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bHapus.UseVisualStyleBackColor = False
        '
        'BTutup
        '
        Me.BTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTutup.FlatAppearance.BorderSize = 0
        Me.BTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTutup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTutup.ForeColor = System.Drawing.Color.White
        Me.BTutup.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.BTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTutup.Location = New System.Drawing.Point(579, 26)
        Me.BTutup.Name = "BTutup"
        Me.BTutup.Size = New System.Drawing.Size(95, 35)
        Me.BTutup.TabIndex = 16
        Me.BTutup.Text = "  Tutup"
        Me.BTutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTutup.UseVisualStyleBackColor = False
        '
        'tCari
        '
        Me.tCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCari.Location = New System.Drawing.Point(579, 127)
        Me.tCari.Name = "tCari"
        Me.tCari.Size = New System.Drawing.Size(343, 23)
        Me.tCari.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(488, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cari Barang"
        '
        'cbsat
        '
        Me.cbsat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsat.FormattingEnabled = True
        Me.cbsat.Location = New System.Drawing.Point(76, 88)
        Me.cbsat.Name = "cbsat"
        Me.cbsat.Size = New System.Drawing.Size(281, 25)
        Me.cbsat.TabIndex = 13
        '
        'thrgbrg
        '
        Me.thrgbrg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thrgbrg.Location = New System.Drawing.Point(76, 121)
        Me.thrgbrg.Name = "thrgbrg"
        Me.thrgbrg.Size = New System.Drawing.Size(281, 23)
        Me.thrgbrg.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Satuan"
        '
        'tKode
        '
        Me.tKode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKode.Location = New System.Drawing.Point(76, 26)
        Me.tKode.Name = "tKode"
        Me.tKode.Size = New System.Drawing.Size(281, 23)
        Me.tKode.TabIndex = 0
        '
        'tNama
        '
        Me.tNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNama.Location = New System.Drawing.Point(76, 57)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(281, 23)
        Me.tNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode"
        '
        'BSimpan
        '
        Me.BSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSimpan.FlatAppearance.BorderSize = 0
        Me.BSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSimpan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSimpan.ForeColor = System.Drawing.Color.White
        Me.BSimpan.Image = Global.Druwals72.My.Resources.Resources.savew24
        Me.BSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.Location = New System.Drawing.Point(363, 26)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(101, 35)
        Me.BSimpan.TabIndex = 7
        Me.BSimpan.Text = " Simpan"
        Me.BSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSimpan.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv.ColumnHeadersHeight = 30
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(0, 162)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(928, 299)
        Me.dgv.TabIndex = 3
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
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(928, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DATA BARANG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents thrgbrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tKode As TextBox
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BSimpan As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cbsat As ComboBox
    Friend WithEvents tCari As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BTutup As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
End Class
