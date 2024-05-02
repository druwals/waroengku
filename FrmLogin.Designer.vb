<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tusername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBatal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tusername)
        Me.Panel2.Controls.Add(Me.tPassword)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BBatal)
        Me.Panel2.Controls.Add(Me.BLogin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(272, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 240)
        Me.Panel2.TabIndex = 8
        '
        'tusername
        '
        Me.tusername.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tusername.Location = New System.Drawing.Point(9, 64)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(244, 27)
        Me.tusername.TabIndex = 12
        Me.tusername.Text = " "
        '
        'tPassword
        '
        Me.tPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(9, 120)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(244, 27)
        Me.tPassword.TabIndex = 13
        Me.tPassword.Text = " "
        Me.tPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'BBatal
        '
        Me.BBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBatal.FlatAppearance.BorderSize = 0
        Me.BBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBatal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBatal.ForeColor = System.Drawing.Color.White
        Me.BBatal.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.BBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBatal.Location = New System.Drawing.Point(134, 155)
        Me.BBatal.Name = "BBatal"
        Me.BBatal.Size = New System.Drawing.Size(119, 45)
        Me.BBatal.TabIndex = 15
        Me.BBatal.Text = "  &Batal"
        Me.BBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBatal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Druwals72.My.Resources.Resources.Warungkulogo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 240)
        Me.Panel1.TabIndex = 6
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BLogin.FlatAppearance.BorderSize = 0
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Image = Global.Druwals72.My.Resources.Resources.cent1
        Me.BLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLogin.Location = New System.Drawing.Point(9, 155)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(119, 45)
        Me.BLogin.TabIndex = 14
        Me.BLogin.Text = "  &Login"
        Me.BLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 240)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tusername As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BBatal As Button
    Friend WithEvents BLogin As Button
End Class
