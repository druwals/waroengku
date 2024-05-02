<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKoneksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKoneksi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.tdatabase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tserver = New System.Windows.Forms.TextBox()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BKeluar = New System.Windows.Forms.Button()
        Me.BKonek = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.GroupBox1.Controls.Add(Me.tpass)
        Me.GroupBox1.Controls.Add(Me.tdatabase)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tserver)
        Me.GroupBox1.Controls.Add(Me.tuser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BKeluar)
        Me.GroupBox1.Controls.Add(Me.BKonek)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting Database"
        '
        'tpass
        '
        Me.tpass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpass.Location = New System.Drawing.Point(104, 92)
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(320, 23)
        Me.tpass.TabIndex = 2
        Me.tpass.UseSystemPasswordChar = True
        '
        'tdatabase
        '
        Me.tdatabase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdatabase.Location = New System.Drawing.Point(104, 124)
        Me.tdatabase.Name = "tdatabase"
        Me.tdatabase.Size = New System.Drawing.Size(320, 23)
        Me.tdatabase.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(26, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'tserver
        '
        Me.tserver.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tserver.Location = New System.Drawing.Point(104, 28)
        Me.tserver.Name = "tserver"
        Me.tserver.Size = New System.Drawing.Size(320, 23)
        Me.tserver.TabIndex = 0
        '
        'tuser
        '
        Me.tuser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuser.Location = New System.Drawing.Point(104, 60)
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(320, 23)
        Me.tuser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server"
        '
        'BKeluar
        '
        Me.BKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BKeluar.FlatAppearance.BorderSize = 0
        Me.BKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BKeluar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKeluar.ForeColor = System.Drawing.Color.White
        Me.BKeluar.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.BKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BKeluar.Location = New System.Drawing.Point(313, 157)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(111, 31)
        Me.BKeluar.TabIndex = 5
        Me.BKeluar.Text = "  Keluar"
        Me.BKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BKeluar.UseVisualStyleBackColor = False
        '
        'BKonek
        '
        Me.BKonek.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BKonek.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BKonek.FlatAppearance.BorderSize = 0
        Me.BKonek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BKonek.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKonek.ForeColor = System.Drawing.Color.White
        Me.BKonek.Image = Global.Druwals72.My.Resources.Resources.cent
        Me.BKonek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BKonek.Location = New System.Drawing.Point(104, 157)
        Me.BKonek.Name = "BKonek"
        Me.BKonek.Size = New System.Drawing.Size(111, 31)
        Me.BKonek.TabIndex = 4
        Me.BKonek.Text = "  Konek"
        Me.BKonek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BKonek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BKonek.UseVisualStyleBackColor = False
        '
        'FrmKoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 217)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmKoneksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tpass As TextBox
    Friend WithEvents tdatabase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tserver As TextBox
    Friend WithEvents tuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BKeluar As Button
    Friend WithEvents BKonek As Button
End Class
