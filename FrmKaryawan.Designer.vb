<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKaryawan))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.tCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tNoHp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.DtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tAsal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNIK = New System.Windows.Forms.TextBox()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTutup = New System.Windows.Forms.Button()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.klik_kanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JadikanAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.klik_kanan.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(0, 169)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(885, 342)
        Me.dgv.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.GroupBox1.Controls.Add(Me.bHapus)
        Me.GroupBox1.Controls.Add(Me.tCari)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tNoHp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tAlamat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbJenis)
        Me.GroupBox1.Controls.Add(Me.DtpTgl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tAsal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tNIK)
        Me.GroupBox1.Controls.Add(Me.tNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BTutup)
        Me.GroupBox1.Controls.Add(Me.BSimpan)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(885, 169)
        Me.GroupBox1.TabIndex = 1
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
        Me.bHapus.Location = New System.Drawing.Point(516, 126)
        Me.bHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(93, 34)
        Me.bHapus.TabIndex = 18
        Me.bHapus.Text = "  Hapus"
        Me.bHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bHapus.UseVisualStyleBackColor = False
        '
        'tCari
        '
        Me.tCari.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCari.Location = New System.Drawing.Point(86, 142)
        Me.tCari.Margin = New System.Windows.Forms.Padding(2)
        Me.tCari.Name = "tCari"
        Me.tCari.Size = New System.Drawing.Size(290, 23)
        Me.tCari.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(22, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cari Data"
        '
        'tNoHp
        '
        Me.tNoHp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNoHp.Location = New System.Drawing.Point(369, 72)
        Me.tNoHp.Margin = New System.Windows.Forms.Padding(2)
        Me.tNoHp.Name = "tNoHp"
        Me.tNoHp.Size = New System.Drawing.Size(191, 23)
        Me.tNoHp.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(281, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "No Hp"
        '
        'tAlamat
        '
        Me.tAlamat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAlamat.Location = New System.Drawing.Point(369, 46)
        Me.tAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.tAlamat.Name = "tAlamat"
        Me.tAlamat.Size = New System.Drawing.Size(191, 23)
        Me.tAlamat.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(281, 49)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(281, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jenis Kelamin"
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.cbJenis.Location = New System.Drawing.Point(369, 19)
        Me.cbJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(156, 24)
        Me.cbJenis.TabIndex = 4
        '
        'DtpTgl
        '
        Me.DtpTgl.CustomFormat = "dd/MM/yyyy"
        Me.DtpTgl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpTgl.Location = New System.Drawing.Point(86, 98)
        Me.DtpTgl.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpTgl.Name = "DtpTgl"
        Me.DtpTgl.Size = New System.Drawing.Size(156, 23)
        Me.DtpTgl.TabIndex = 3
        Me.DtpTgl.Value = New Date(2024, 4, 30, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tgl Lahir"
        '
        'tAsal
        '
        Me.tAsal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAsal.Location = New System.Drawing.Point(86, 72)
        Me.tAsal.Margin = New System.Windows.Forms.Padding(2)
        Me.tAsal.Name = "tAsal"
        Me.tAsal.Size = New System.Drawing.Size(191, 23)
        Me.tAsal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Asal"
        '
        'tNIK
        '
        Me.tNIK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNIK.Location = New System.Drawing.Point(86, 20)
        Me.tNIK.Margin = New System.Windows.Forms.Padding(2)
        Me.tNIK.Name = "tNIK"
        Me.tNIK.Size = New System.Drawing.Size(191, 23)
        Me.tNIK.TabIndex = 0
        '
        'tNama
        '
        Me.tNama.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNama.Location = New System.Drawing.Point(86, 46)
        Me.tNama.Margin = New System.Windows.Forms.Padding(2)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(191, 23)
        Me.tNama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NIK"
        '
        'BTutup
        '
        Me.BTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTutup.FlatAppearance.BorderSize = 0
        Me.BTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTutup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTutup.ForeColor = System.Drawing.Color.White
        Me.BTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTutup.Location = New System.Drawing.Point(614, 126)
        Me.BTutup.Margin = New System.Windows.Forms.Padding(2)
        Me.BTutup.Name = "BTutup"
        Me.BTutup.Size = New System.Drawing.Size(93, 34)
        Me.BTutup.TabIndex = 8
        Me.BTutup.Text = "  Tutup"
        Me.BTutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTutup.UseVisualStyleBackColor = False
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
        Me.BSimpan.Location = New System.Drawing.Point(419, 126)
        Me.BSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(93, 34)
        Me.BSimpan.TabIndex = 7
        Me.BSimpan.Text = " Simpan"
        Me.BSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSimpan.UseVisualStyleBackColor = False
        '
        'klik_kanan
        '
        Me.klik_kanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JadikanAdminToolStripMenuItem})
        Me.klik_kanan.Name = "klik_kanan"
        Me.klik_kanan.Size = New System.Drawing.Size(181, 48)
        '
        'JadikanAdminToolStripMenuItem
        '
        Me.JadikanAdminToolStripMenuItem.Name = "JadikanAdminToolStripMenuItem"
        Me.JadikanAdminToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JadikanAdminToolStripMenuItem.Text = "Jadikan Admin"
        '
        'FrmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 511)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DATA KARYAWAN"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.klik_kanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tNIK As TextBox
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTutup As Button
    Friend WithEvents BSimpan As Button
    Friend WithEvents tAsal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tNoHp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents DtpTgl As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tCari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bHapus As Button
    Friend WithEvents klik_kanan As ContextMenuStrip
    Friend WithEvents JadikanAdminToolStripMenuItem As ToolStripMenuItem
End Class
