Imports System.Data.SqlClient

Public Class FrmMasuk
    Dim lebar As Integer
    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged
        konek()
        Dim str As String = "select * from tbl_barang where rtrim(KODE)='" & tkode.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            lblBarang.Text = rd.Item("BARANG").ToString.Trim
            lblSatuan.Text = rd.Item("SATUAN").ToString.Trim
            rd.Close()
        Else
            rd.Close()
            lblBarang.Text = ""
            lblSatuan.Text = ""
        End If
        rd.Close()
    End Sub

    Private Sub tHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tHarga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tJumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bCari_Click(sender As Object, e As EventArgs) Handles bCari.Click
        pncari.Visible = True
        tdgvcari.Focus()
        dgvcari.DataSource = Nothing
    End Sub

    Private Sub tdgvtampilcari_TextChanged(sender As Object, e As EventArgs) Handles tdgvcari.TextChanged
        konek()
        Dim str As String = "select rtrim(KODE) as KODE,rtrim(BARANG)AS BARANG,rtrim(SATUAN) AS SATUAN,HARGA_SATUAN from tbl_barang where BARANG like '%" & tdgvcari.Text & "%'"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(str, con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgvcari.DataSource = tbl
    End Sub

    Private Sub bttpcari_Click(sender As Object, e As EventArgs) Handles bttpcari.Click
        pncari.Visible = False
        dgvcari.DataSource = Nothing
    End Sub

    Private Sub dgvcari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcari.CellDoubleClick
        tkode.Text = dgvcari.Item("KODE", e.RowIndex).Value
        pncari.Visible = False
        dgvcari.DataSource = Nothing
    End Sub

    Private Sub bTmbhBrg_Click(sender As Object, e As EventArgs) Handles bTmbhBrg.Click
        Dim FR As New FrmBarang
        FR.ShowDialog()
    End Sub

    Private Sub bTmbhStok_Click(sender As Object, e As EventArgs) Handles bTmbhStok.Click
        If tkode.Text = "" Or lblBarang.Text = "" Or tJumlah.Text = "" Or tHarga.Text = "" Then
            MsgBox("Data tidak lengkap,silahkan lengkapi terlebih dahulu", vbCritical, "Peringatan")
        ElseIf CInt(tJumlah.Text) <= 0 Then
            MsgBox("Jumlah barang Harus lebih dari nol..")
        Else
            Dim str As String = "Insert into tbl_transaksi (KODE,JUMLAH,SUPPLIER,HARGA,TGL,JENIS,ADMIN) values" &
            "('" & tkode.Text & "','" & CInt(tJumlah.Text) & "','" & tsupplier.Text &
            "','" & CInt(tHarga.Text) & "','" & Format(Date.Now, "MM/dd/yyyy") & "','M','" & nikAdmin & "')"
            Dim cmd As New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhsail disimpan", vbInformation, "Pemberitahuan")
            tkode.Clear()
            TAMPIL()
        End If
    End Sub
    Dim START_RECORD As Integer = 0
    Dim TAMPIL_RECORD As Integer = 10


    Private Sub aturgrid()
        lebar = 0
        lebar = dgvtampil.Width
        lebar = lebar - 424

        'tinggi header
        Me.dgvtampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvtampil.ColumnHeadersHeight = 25

        'posisi header
        Me.dgvtampil.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'ukuran font
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgvtampil.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray

        Me.dgvtampil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Sub TAMPIL()
        konek()
        Dim STR As String = "SELECT ID,RTRIM(KODE) AS KODE,(SELECT RTRIM(BARANG) FROM TBL_BARANG" &
            " WHERE RTRIM(KODE)=RTRIM(TBL_TRANSAKSI.KODE)) AS BARANG,JUMLAH,RTRIM(SUPPLIER) AS SUPPLIER,HARGA,TGL " &
            " FROM TBL_TRANSAKSI WHERE JENIS='M' AND (SELECT BARANG FROM TBL_BARANG" &
            " WHERE RTRIM(KODE)=RTRIM(TBL_TRANSAKSI.KODE)) Like '%" & tcari.Text & "%'"
        Dim DA As SqlDataAdapter
        Dim TBL As New DataSet
        DA = New SqlDataAdapter(STR, con)
        DA.Fill(TBL, START_RECORD, TAMPIL_RECORD, 0)
        dgvtampil.DataSource = TBL.Tables(0)

        dgvtampil.Columns("HARGA").DefaultCellStyle.Format = "N0"

        bPrev.Enabled = True
        BNext.Enabled = True

        Dim TOTAL_RECORD As Integer = 0
        Dim TBL_DATA As New DataTable
        DA = New SqlDataAdapter(STR, con)
        DA.Fill(TBL_DATA)

        TOTAL_RECORD = TBL_DATA.Rows.Count

        If TOTAL_RECORD = 0 Then
            bPrev.Enabled = False
            BNext.Enabled = False
        ElseIf START_RECORD = 0 Then
            bPrev.Enabled = False
        ElseIf TOTAL_RECORD <= TAMPIL_RECORD Then
            BNext.Enabled = False
        ElseIf TOTAL_RECORD - START_RECORD <= TAMPIL_RECORD Then
            BNext.Enabled = False
        Else
            bPrev.Enabled = True
            BNext.Enabled = True
        End If
        aturgrid()
    End Sub

    Private Sub bTutup_Click(sender As Object, e As EventArgs) Handles bTutup.Click
        Me.Close()
    End Sub

    Private Sub bPrev_Click(sender As Object, e As EventArgs) Handles bPrev.Click
        START_RECORD = START_RECORD - TAMPIL_RECORD
        TAMPIL()
    End Sub

    Private Sub BNext_Click(sender As Object, e As EventArgs) Handles BNext.Click
        START_RECORD = START_RECORD + TAMPIL_RECORD
        TAMPIL()
    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged
        START_RECORD = 0
        TAMPIL()
    End Sub

    Private Sub FrmMasuk_Load(sender As Object, e As EventArgs) Handles Me.Load
        TAMPIL()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If MsgBox("Yakin Menghapus.???", vbYesNo) = vbYes Then
            Dim IDX As String = dgvtampil.Item("ID", dgvtampil.CurrentRow.Index).Value
            Dim CMD As New SqlCommand("DELETE FROM TBL_TRANSAKSI WHERE ID='" & IDX & "'", con)
            CMD.ExecuteNonQuery()
            TAMPIL()
            MsgBox("Data Terhapus...")
        End If
    End Sub

    Private Sub tkode_KeyDown(sender As Object, e As KeyEventArgs) Handles tkode.KeyDown
        If e.KeyCode = Keys.Enter Then
            tJumlah.Focus()
        End If
    End Sub

    Private Sub tJumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles tJumlah.KeyDown
        If e.KeyCode = Keys.Enter Then
            tsupplier.Focus()
        End If
    End Sub

    Private Sub tsupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles tsupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            tHarga.Focus()
        End If
    End Sub

    Private Sub tHarga_KeyDown(sender As Object, e As KeyEventArgs) Handles tHarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            bTmbhStok_Click(e, AcceptButton)
        End If
    End Sub
End Class