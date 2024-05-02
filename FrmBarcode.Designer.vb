<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarcode))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTutup = New System.Windows.Forms.Button()
        Me.BView = New System.Windows.Forms.Button()
        Me.tjumlah = New System.Windows.Forms.TextBox()
        Me.tbarang = New System.Windows.Forms.TextBox()
        Me.tkode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RPT = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.bHapus)
        Me.Panel1.Controls.Add(Me.BTutup)
        Me.Panel1.Controls.Add(Me.BView)
        Me.Panel1.Controls.Add(Me.tjumlah)
        Me.Panel1.Controls.Add(Me.tbarang)
        Me.Panel1.Controls.Add(Me.tkode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 519)
        Me.Panel1.TabIndex = 0
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
        Me.BTutup.Location = New System.Drawing.Point(172, 101)
        Me.BTutup.Name = "BTutup"
        Me.BTutup.Size = New System.Drawing.Size(95, 35)
        Me.BTutup.TabIndex = 18
        Me.BTutup.Text = "  &Tutup"
        Me.BTutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTutup.UseVisualStyleBackColor = False
        '
        'BView
        '
        Me.BView.BackColor = System.Drawing.Color.Silver
        Me.BView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BView.FlatAppearance.BorderSize = 0
        Me.BView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BView.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BView.ForeColor = System.Drawing.Color.White
        Me.BView.Image = Global.Druwals72.My.Resources.Resources.barcode24
        Me.BView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BView.Location = New System.Drawing.Point(65, 101)
        Me.BView.Name = "BView"
        Me.BView.Size = New System.Drawing.Size(101, 35)
        Me.BView.TabIndex = 17
        Me.BView.Text = "  &View"
        Me.BView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BView.UseVisualStyleBackColor = False
        '
        'tjumlah
        '
        Me.tjumlah.Location = New System.Drawing.Point(65, 72)
        Me.tjumlah.Name = "tjumlah"
        Me.tjumlah.Size = New System.Drawing.Size(202, 23)
        Me.tjumlah.TabIndex = 5
        '
        'tbarang
        '
        Me.tbarang.Location = New System.Drawing.Point(65, 46)
        Me.tbarang.Name = "tbarang"
        Me.tbarang.ReadOnly = True
        Me.tbarang.Size = New System.Drawing.Size(202, 23)
        Me.tbarang.TabIndex = 4
        '
        'tkode
        '
        Me.tkode.Location = New System.Drawing.Point(65, 20)
        Me.tkode.Name = "tkode"
        Me.tkode.Size = New System.Drawing.Size(202, 23)
        Me.tkode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'RPT
        '
        Me.RPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RPT.LocalReport.ReportEmbeddedResource = "Druwals72.LabelBarcode.rdlc"
        Me.RPT.Location = New System.Drawing.Point(279, 0)
        Me.RPT.Name = "RPT"
        Me.RPT.ServerReport.BearerToken = Nothing
        Me.RPT.Size = New System.Drawing.Size(646, 519)
        Me.RPT.TabIndex = 1
        '
        'bHapus
        '
        Me.bHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bHapus.FlatAppearance.BorderSize = 0
        Me.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHapus.ForeColor = System.Drawing.Color.White
        Me.bHapus.Image = Global.Druwals72.My.Resources.Resources.sapu24
        Me.bHapus.Location = New System.Drawing.Point(136, 142)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(131, 35)
        Me.bHapus.TabIndex = 19
        Me.bHapus.Text = "  &Hapus"
        Me.bHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bHapus.UseVisualStyleBackColor = False
        '
        'FrmBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(925, 519)
        Me.Controls.Add(Me.RPT)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BARCODE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tkode As TextBox
    Friend WithEvents tjumlah As TextBox
    Friend WithEvents tbarang As TextBox
    Friend WithEvents RPT As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BTutup As Button
    Friend WithEvents BView As Button
    Friend WithEvents bHapus As Button
End Class
