<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHakAkses))
        Me.dgvakses = New System.Windows.Forms.DataGridView()
        Me.dgvmenu = New System.Windows.Forms.DataGridView()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.btutup = New System.Windows.Forms.Button()
        CType(Me.dgvakses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvakses
        '
        Me.dgvakses.AllowUserToAddRows = False
        Me.dgvakses.AllowUserToDeleteRows = False
        Me.dgvakses.AllowUserToResizeColumns = False
        Me.dgvakses.AllowUserToResizeRows = False
        Me.dgvakses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvakses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvakses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvakses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvakses.Location = New System.Drawing.Point(12, 12)
        Me.dgvakses.MultiSelect = False
        Me.dgvakses.Name = "dgvakses"
        Me.dgvakses.ReadOnly = True
        Me.dgvakses.RowHeadersVisible = False
        Me.dgvakses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvakses.Size = New System.Drawing.Size(293, 471)
        Me.dgvakses.TabIndex = 0
        '
        'dgvmenu
        '
        Me.dgvmenu.AllowUserToAddRows = False
        Me.dgvmenu.AllowUserToDeleteRows = False
        Me.dgvmenu.AllowUserToResizeColumns = False
        Me.dgvmenu.AllowUserToResizeRows = False
        Me.dgvmenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvmenu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmenu.Location = New System.Drawing.Point(311, 55)
        Me.dgvmenu.MultiSelect = False
        Me.dgvmenu.Name = "dgvmenu"
        Me.dgvmenu.ReadOnly = True
        Me.dgvmenu.RowHeadersVisible = False
        Me.dgvmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmenu.Size = New System.Drawing.Size(588, 428)
        Me.dgvmenu.TabIndex = 1
        '
        'BSimpan
        '
        Me.BSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSimpan.FlatAppearance.BorderSize = 0
        Me.BSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSimpan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSimpan.ForeColor = System.Drawing.Color.White
        Me.BSimpan.Image = Global.Druwals72.My.Resources.Resources.savew24
        Me.BSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.Location = New System.Drawing.Point(691, 14)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(101, 35)
        Me.BSimpan.TabIndex = 8
        Me.BSimpan.Text = " Simpan"
        Me.BSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSimpan.UseVisualStyleBackColor = False
        '
        'btutup
        '
        Me.btutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btutup.FlatAppearance.BorderSize = 0
        Me.btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btutup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btutup.ForeColor = System.Drawing.Color.White
        Me.btutup.Image = Global.Druwals72.My.Resources.Resources.off24
        Me.btutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btutup.Location = New System.Drawing.Point(798, 14)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(101, 35)
        Me.btutup.TabIndex = 9
        Me.btutup.Text = "  &Tutup"
        Me.btutup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btutup.UseVisualStyleBackColor = False
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Druwals72.My.Resources.Resources.bgaplikasi
        Me.ClientSize = New System.Drawing.Size(911, 495)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.dgvmenu)
        Me.Controls.Add(Me.dgvakses)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmHakAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " HAK AKSES"
        CType(Me.dgvakses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvakses As DataGridView
    Friend WithEvents dgvmenu As DataGridView
    Friend WithEvents BSimpan As Button
    Friend WithEvents btutup As Button
End Class
