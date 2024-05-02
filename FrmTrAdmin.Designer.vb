<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCetak = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPTanggal = New System.Windows.Forms.DateTimePicker()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tNIK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tJumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvtampil = New System.Windows.Forms.DataGridView()
        Me.Chk = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DTPTanggal)
        Me.Panel1.Controls.Add(Me.tNama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tNIK)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 105)
        Me.Panel1.TabIndex = 3
        '
        'BCetak
        '
        Me.BCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCetak.FlatAppearance.BorderSize = 0
        Me.BCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCetak.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCetak.ForeColor = System.Drawing.Color.White
        Me.BCetak.Image = Global.Druwals72.My.Resources.Resources.printer16
        Me.BCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCetak.Location = New System.Drawing.Point(11, 5)
        Me.BCetak.Margin = New System.Windows.Forms.Padding(2)
        Me.BCetak.Name = "BCetak"
        Me.BCetak.Size = New System.Drawing.Size(123, 33)
        Me.BCetak.TabIndex = 10
        Me.BCetak.Text = "    &Cetak"
        Me.BCetak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCetak.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TANGGAL"
        '
        'DTPTanggal
        '
        Me.DTPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTanggal.Location = New System.Drawing.Point(79, 72)
        Me.DTPTanggal.Name = "DTPTanggal"
        Me.DTPTanggal.Size = New System.Drawing.Size(135, 23)
        Me.DTPTanggal.TabIndex = 4
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(79, 45)
        Me.tNama.Name = "tNama"
        Me.tNama.ReadOnly = True
        Me.tNama.Size = New System.Drawing.Size(223, 23)
        Me.tNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA"
        '
        'tNIK
        '
        Me.tNIK.Location = New System.Drawing.Point(79, 18)
        Me.tNIK.Name = "tNIK"
        Me.tNIK.ReadOnly = True
        Me.tNIK.Size = New System.Drawing.Size(223, 23)
        Me.tNIK.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Chk)
        Me.Panel2.Controls.Add(Me.BCetak)
        Me.Panel2.Controls.Add(Me.tJumlah)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 511)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(933, 43)
        Me.Panel2.TabIndex = 4
        '
        'tJumlah
        '
        Me.tJumlah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tJumlah.Location = New System.Drawing.Point(774, 6)
        Me.tJumlah.Name = "tJumlah"
        Me.tJumlah.ReadOnly = True
        Me.tJumlah.Size = New System.Drawing.Size(156, 23)
        Me.tJumlah.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(662, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah Transaksi"
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
        Me.dgvtampil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvtampil.EnableHeadersVisualStyles = False
        Me.dgvtampil.Location = New System.Drawing.Point(0, 105)
        Me.dgvtampil.MultiSelect = False
        Me.dgvtampil.Name = "dgvtampil"
        Me.dgvtampil.ReadOnly = True
        Me.dgvtampil.RowHeadersVisible = False
        Me.dgvtampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtampil.Size = New System.Drawing.Size(933, 406)
        Me.dgvtampil.TabIndex = 5
        '
        'Chk
        '
        Me.Chk.AutoSize = True
        Me.Chk.ForeColor = System.Drawing.Color.White
        Me.Chk.Location = New System.Drawing.Point(139, 12)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(71, 20)
        Me.Chk.TabIndex = 11
        Me.Chk.Text = "Preview"
        Me.Chk.UseVisualStyleBackColor = True
        '
        'FrmTrAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.dgvtampil)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTrAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSAKSI KASIR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPTanggal As DateTimePicker
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tNIK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tJumlah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvtampil As DataGridView
    Friend WithEvents BCetak As Button
    Friend WithEvents Chk As CheckBox
End Class
