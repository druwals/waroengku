<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengaturan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengaturan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnotelp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.talmttoko = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnmtoko = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbprint = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BSimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tnotelp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.talmttoko)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tnmtoko)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbprint)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Toko Dan Printer"
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
        Me.BSimpan.Location = New System.Drawing.Point(90, 150)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(101, 35)
        Me.BSimpan.TabIndex = 4
        Me.BSimpan.Text = " &Simpan"
        Me.BSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Printer"
        '
        'tnotelp
        '
        Me.tnotelp.Location = New System.Drawing.Point(90, 91)
        Me.tnotelp.Name = "tnotelp"
        Me.tnotelp.Size = New System.Drawing.Size(272, 23)
        Me.tnotelp.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "No Telpon"
        '
        'talmttoko
        '
        Me.talmttoko.Location = New System.Drawing.Point(90, 62)
        Me.talmttoko.Name = "talmttoko"
        Me.talmttoko.Size = New System.Drawing.Size(272, 23)
        Me.talmttoko.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Alamat "
        '
        'tnmtoko
        '
        Me.tnmtoko.Location = New System.Drawing.Point(90, 33)
        Me.tnmtoko.Name = "tnmtoko"
        Me.tnmtoko.Size = New System.Drawing.Size(272, 23)
        Me.tnmtoko.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Toko"
        '
        'cbprint
        '
        Me.cbprint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprint.FormattingEnabled = True
        Me.cbprint.Location = New System.Drawing.Point(90, 120)
        Me.cbprint.Name = "cbprint"
        Me.cbprint.Size = New System.Drawing.Size(272, 24)
        Me.cbprint.TabIndex = 3
        '
        'FrmPengaturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(426, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPengaturan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENGATURAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbprint As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tnotelp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents talmttoko As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tnmtoko As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BSimpan As Button
End Class
