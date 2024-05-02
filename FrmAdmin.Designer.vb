<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.trepass = New System.Windows.Forms.TextBox()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bTutup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.bTutup)
        Me.GroupBox1.Controls.Add(Me.BSimpan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.trepass)
        Me.GroupBox1.Controls.Add(Me.tpass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblNama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblNIK)
        Me.GroupBox1.Controls.Add(Me.cbType)
        Me.GroupBox1.Controls.Add(Me.tuser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Admin"
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
        Me.BSimpan.Location = New System.Drawing.Point(127, 168)
        Me.BSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(93, 34)
        Me.BSimpan.TabIndex = 6
        Me.BSimpan.Text = " Simpan"
        Me.BSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSimpan.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TYPE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "RE_PASSWORD"
        '
        'trepass
        '
        Me.trepass.Location = New System.Drawing.Point(127, 112)
        Me.trepass.Name = "trepass"
        Me.trepass.Size = New System.Drawing.Size(236, 23)
        Me.trepass.TabIndex = 4
        Me.trepass.UseSystemPasswordChar = True
        '
        'tpass
        '
        Me.tpass.Location = New System.Drawing.Point(127, 85)
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(236, 23)
        Me.tpass.TabIndex = 3
        Me.tpass.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "USERNAME"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(124, 38)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(11, 16)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NAMA"
        '
        'lblNIK
        '
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Location = New System.Drawing.Point(124, 18)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(11, 16)
        Me.lblNIK.TabIndex = 0
        Me.lblNIK.Text = " "
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"ADMIN", "KASIR"})
        Me.cbType.Location = New System.Drawing.Point(127, 139)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(167, 24)
        Me.cbType.TabIndex = 5
        '
        'tuser
        '
        Me.tuser.Location = New System.Drawing.Point(127, 58)
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(236, 23)
        Me.tuser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NIK"
        '
        'bTutup
        '
        Me.bTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTutup.FlatAppearance.BorderSize = 0
        Me.bTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTutup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTutup.ForeColor = System.Drawing.Color.White
        Me.bTutup.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.bTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTutup.Location = New System.Drawing.Point(235, 168)
        Me.bTutup.Margin = New System.Windows.Forms.Padding(2)
        Me.bTutup.Name = "bTutup"
        Me.bTutup.Size = New System.Drawing.Size(93, 34)
        Me.bTutup.TabIndex = 13
        Me.bTutup.Text = "Tutup"
        Me.bTutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bTutup.UseVisualStyleBackColor = False
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 220)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents trepass As TextBox
    Friend WithEvents tpass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNIK As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents tuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BSimpan As Button
    Friend WithEvents bTutup As Button
End Class
