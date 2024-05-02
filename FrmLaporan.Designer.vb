<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLaporan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btutup = New System.Windows.Forms.Button()
        Me.BCetak = New System.Windows.Forms.Button()
        Me.BView = New System.Windows.Forms.Button()
        Me.DTPSampai = New System.Windows.Forms.DateTimePicker()
        Me.DTPMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btutup)
        Me.Panel1.Controls.Add(Me.BCetak)
        Me.Panel1.Controls.Add(Me.BView)
        Me.Panel1.Controls.Add(Me.DTPSampai)
        Me.Panel1.Controls.Add(Me.DTPMulai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbJenis)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 50)
        Me.Panel1.TabIndex = 0
        '
        'btutup
        '
        Me.btutup.BackColor = System.Drawing.Color.Green
        Me.btutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btutup.FlatAppearance.BorderSize = 0
        Me.btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btutup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btutup.ForeColor = System.Drawing.Color.White
        Me.btutup.Image = Global.Druwals72.My.Resources.Resources.fgaga16
        Me.btutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btutup.Location = New System.Drawing.Point(1165, 12)
        Me.btutup.Margin = New System.Windows.Forms.Padding(2)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(93, 26)
        Me.btutup.TabIndex = 10
        Me.btutup.Text = "  &Tutup"
        Me.btutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btutup.UseVisualStyleBackColor = False
        '
        'BCetak
        '
        Me.BCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCetak.FlatAppearance.BorderSize = 0
        Me.BCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCetak.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCetak.ForeColor = System.Drawing.Color.White
        Me.BCetak.Image = Global.Druwals72.My.Resources.Resources.printer16
        Me.BCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCetak.Location = New System.Drawing.Point(1068, 12)
        Me.BCetak.Margin = New System.Windows.Forms.Padding(2)
        Me.BCetak.Name = "BCetak"
        Me.BCetak.Size = New System.Drawing.Size(93, 26)
        Me.BCetak.TabIndex = 9
        Me.BCetak.Text = "  &Cetak"
        Me.BCetak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCetak.UseVisualStyleBackColor = False
        '
        'BView
        '
        Me.BView.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BView.FlatAppearance.BorderSize = 0
        Me.BView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BView.ForeColor = System.Drawing.Color.White
        Me.BView.Image = Global.Druwals72.My.Resources.Resources.kalender16
        Me.BView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BView.Location = New System.Drawing.Point(970, 12)
        Me.BView.Margin = New System.Windows.Forms.Padding(2)
        Me.BView.Name = "BView"
        Me.BView.Size = New System.Drawing.Size(93, 26)
        Me.BView.TabIndex = 8
        Me.BView.Text = "  View"
        Me.BView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BView.UseVisualStyleBackColor = False
        '
        'DTPSampai
        '
        Me.DTPSampai.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPSampai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSampai.Location = New System.Drawing.Point(790, 12)
        Me.DTPSampai.Name = "DTPSampai"
        Me.DTPSampai.Size = New System.Drawing.Size(175, 26)
        Me.DTPSampai.TabIndex = 5
        '
        'DTPMulai
        '
        Me.DTPMulai.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPMulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPMulai.Location = New System.Drawing.Point(488, 12)
        Me.DTPMulai.Name = "DTPMulai"
        Me.DTPMulai.Size = New System.Drawing.Size(175, 26)
        Me.DTPMulai.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(668, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sampai  Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(386, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mulai Tanggal"
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Laporan Barang Masuk", "Laporan Barang Keluar", "Laporan Stok Barang"})
        Me.cbJenis.Location = New System.Drawing.Point(113, 12)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(268, 26)
        Me.cbJenis.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Laporan"
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
        Me.dgv.Location = New System.Drawing.Point(0, 50)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1300, 464)
        Me.dgv.TabIndex = 1
        '
        'FrmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 514)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DTPSampai As DateTimePicker
    Friend WithEvents DTPMulai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BCetak As Button
    Friend WithEvents BView As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btutup As Button
End Class
