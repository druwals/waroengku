Imports System.Data.SqlClient

Public Class FrmBarang
    Dim lebar As Integer
    Private Sub BTutup_Click(sender As Object, e As EventArgs) Handles BTutup.Click
        Me.Close()
    End Sub

    'Private Sub mnculsat()
    '    Dim str As String = "select distinct SATUAN from tbl_barang"
    '    Dim da As SqlDataAdapter
    '    da = New SqlDataAdapter(str, con)

    '    cbsat.Items.Clear()
    '    cbsat.Items.Add("SATUAN")
    'End Sub

    Sub tampil()
        konek()
        Dim str As String = "SELECT RTRIM(KODE) AS KODE,RTRIM(BARANG) AS BARANG,RTRIM(SATUAN) AS SATUAN,HARGA_SATUAN AS HARGA,(COALESCE((SELECT SUM(JUMLAH) FROM TBL_TRANSAKSI WHERE KODE=TBL_BARANG.KODE AND JENIS='M'),0)- COALESCE((SELECT SUM(JUMLAH) FROM TBL_TRANSAKSI WHERE KODE=TBL_BARANG.KODE AND JENIS='K'),0)) AS STOK FROM TBL_BARANG WHERE BARANG LIKE '%" & tCari.Text & "%'"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(str, con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgv.DataSource = tbl
        aturgrid()
        'mnculsat()
    End Sub

    Private Sub aturgrid()
        lebar = 0
        lebar = dgv.Width
        lebar = lebar - 424

        'tinggi header
        Me.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ColumnHeadersHeight = 25

        'posisi header
        Me.dgv.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        'ukuran font
        Me.dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgv.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        Me.dgv.Columns("HARGA").DefaultCellStyle.Format = "N0"
        Me.dgv.Columns("HARGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv.Columns("STOK").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampil()
    End Sub

    Private Sub tCari_TextChanged(sender As Object, e As EventArgs) Handles tCari.TextChanged
        tampil()
    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        If tKode.Text = "" Or tNama.Text = "" Then
            MsgBox("Username tidak boleh kosong", vbCritical, "Peringatan")
        Else
            Dim str As String = "select * from tbl_barang where rtrim(KODE)='" & tKode.Text & "'"
            Dim cmd As New SqlCommand(str, con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Read()
                str = "update TBL_BARANG set BARANG='" & tNama.Text & "',SATUAN='" & cbsat.Text & "',HARGA_SATUAN='" & thrgbrg.Text & "' where rtrim(KODE)='" & tKode.Text & "'"
            Else
                rd.Close()
                str = "insert into tbl_barang values('" & tKode.Text & "','" & tNama.Text & "','" & cbsat.Text & "','" & thrgbrg.Text & "')"
            End If
            rd.Close()
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan", vbInformation, "Informasi")
        End If
        tampil()
        tKode.Clear()
        tNama.Clear()
        cbsat.Text = Nothing
        thrgbrg.Clear()
    End Sub

    Private Sub tKode_KeyDown(sender As Object, e As KeyEventArgs) Handles tKode.KeyDown
        If e.KeyCode = Keys.Enter Then
            tNama.Focus()
        End If
    End Sub

    Private Sub tNama_KeyDown(sender As Object, e As KeyEventArgs) Handles tNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbsat.Focus()
        End If
    End Sub

    Private Sub cbsat_KeyDown(sender As Object, e As KeyEventArgs) Handles cbsat.KeyDown
        If e.KeyCode = Keys.Enter Then
            thrgbrg.Focus()
        End If
    End Sub

    Private Sub thrgbrg_KeyDown(sender As Object, e As KeyEventArgs) Handles thrgbrg.KeyDown
        If e.KeyCode = Keys.Enter Then
            BSimpan_Click(e, AcceptButton)
        End If
    End Sub

    Private Sub tKode_TextChanged(sender As Object, e As EventArgs) Handles tKode.TextChanged
        Dim str As String = "Select * from tbl_barang where rtrim(KODE)='" & tKode.Text & "'"
        Dim cmd As New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tNama.Text = rd.Item("BARANG").ToString.Trim
            cbsat.Text = rd.Item("SATUAN").ToString.Trim
            thrgbrg.Text = CInt(rd.Item("HARGA_SATUAN"))
            rd.Close()
        Else
            rd.Close()
            thrgbrg.Clear()
            tNama.Clear()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        tKode.Text = dgv.Item("KODE", e.RowIndex).Value
    End Sub

    Private Sub thrgbrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles thrgbrg.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Dim str As String = "delete from tbl_Barang where rtrim(KODE)='" & dgv.Item("KODE", dgv.CurrentRow.Index).Value & "'"
        If MsgBox("Yakin Menghapus data ini?", vbYesNo) = vbYes Then
            Dim cmd As New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            tampil()
        End If

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Dim str As String = "delete from tbl_Barang where rtrim(KODE)='" & dgv.Item("KODE", dgv.CurrentRow.Index).Value & "'"
        If MsgBox("Yakin Menghapus data ini?", vbYesNo) = vbYes Then
            Dim cmd As New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            tampil()
        End If
    End Sub
End Class