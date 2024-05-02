Imports System.Data.SqlClient

Public Class FrmBrgKeluar

    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged
        konek()
        Dim str As String = "select kode,barang,satuan,harga_satuan from tbl_barang where rtrim(kode)='" & tkode.Text & "'"
        Dim cmd As New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tnmbrg.Text = rd.Item("barang").ToString.Trim
            tsatuan.Text = rd.Item("satuan").ToString.Trim
            thrga.Text = CInt(rd.Item("harga_satuan"))
            rd.Close()
            If cari_stok(tkode.Text) <= 0 Then
                MsgBox("Stok Barang Habis...")
                tkode.Clear()
                Exit Sub
            End If
            masuk_data()
            tkode.Clear()
        Else
            rd.Close()
        End If
    End Sub


    Private Sub dgvtampil_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtampil.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim QTY As String = ""
            QTY = dgvtampil.Item("QTY", e.RowIndex).Value
            Dim kodebr As String = dgvtampil.Item("KODE", e.RowIndex).Value
            If IsNumeric(QTY) Then
                If cari_stok(kodebr) < 0 Then
                    MsgBox("Stok barang Kurang...")
                    dgvtampil.Item("QTY", e.RowIndex).Value = QTY_LAMA
                Else
                    dgvtampil.Item("TOTAL", e.RowIndex).Value = QTY * dgvtampil.Item("HARGA", e.RowIndex).Value
                    total_harga()
                End If
            Else
                MsgBox("Nilai Tidak Valid...")
                dgvtampil.Item("QTY", e.RowIndex).Value = QTY_LAMA
            End If
        End If
    End Sub

    Dim QTY_LAMA As Integer = 0
    Private Sub dgvtampil_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvtampil.CellBeginEdit
        If e.ColumnIndex = 4 Then
            QTY_LAMA = dgvtampil.Item("QTY", e.RowIndex).Value
        End If
    End Sub

    Private Function cari_stok(ByVal kode As String) As Integer
        cari_stok = 0
        Dim str As String
        str = "select kode,rtrim(barang) as barang,rtrim(satuan) as satuan,harga_satuan," &
            " ((select coalesce(sum(jumlah),0) from tbl_transaksi where" &
            " kode=tbl_barang.kode And jenis='M')-(select coalesce(sum(jumlah),0) from tbl_transaksi" &
            " where kode=tbl_barang.kode And jenis='K')) as stok from tbl_barang where kode='" & kode & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        Dim stok_data As Integer = 0
        If rd.HasRows Then
            rd.Read()
            stok_data = rd.Item("stok")
            rd.Close()
        Else
            rd.Close()
            stok_data = 0
        End If

        Dim stok_order As Integer = 0
        For n = 0 To dgvtampil.RowCount - 1
            If dgvtampil.Item("KODE", n).Value = kode Then
                stok_order = stok_order + dgvtampil.Item("QTY", n).Value
                Exit For
            End If
        Next

        cari_stok = stok_data - stok_order
    End Function

    Private Sub masuk_data()
        Dim QTY As Integer = 0
        Dim ADA_DATA As Boolean = False
        Dim BARIS_DATA As Integer = 0

        For N = 0 To dgvtampil.Rows.Count - 1
            Dim KODE As String = dgvtampil.Item("KODE", N).Value
            If KODE = tkode.Text Then
                ADA_DATA = True
                BARIS_DATA = N
                Exit For
            End If
        Next

        If ADA_DATA = True Then
            dgvtampil.Rows(BARIS_DATA).Cells("QTY").Value = dgvtampil.Rows(BARIS_DATA).Cells("QTY").Value + 1
            dgvtampil.Rows(BARIS_DATA).Cells("TOTAL").Value =
                dgvtampil.Rows(BARIS_DATA).Cells("QTY").Value * dgvtampil.Rows(BARIS_DATA).Cells("HARGA").Value
        Else
            dgvtampil.Rows.Add()
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("KODE").Value = tkode.Text
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("BARANG").Value = tnmbrg.Text
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("SATUAN").Value = tsatuan.Text
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("HARGA").Value = thrga.Text
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("QTY").Value = "1"
            dgvtampil.Rows(dgvtampil.Rows.Count - 1).Cells("TOTAL").Value = thrga.Text
        End If

        total_harga()
    End Sub

    Private Sub total_harga()
        Dim totharga As Integer = 0
        For n = 0 To dgvtampil.Rows.Count - 1
            totharga = totharga + dgvtampil.Item("TOTAL", n).Value
        Next

        lbltotharga.Text = FormatCurrency(totharga, 0)
    End Sub

    Sub TUTUP_CARI()
        pncari.Visible = False
        tkode.Select()
    End Sub

    Sub TUTUP_BAYAR()
        pnbayar.Visible = False
        dgvtampil.Enabled = True
        tkode.Select()
    End Sub

    Sub buka_cari()
        pnbayar.Visible = False
        pncari.Visible = True
        tdgvcari.Clear()
        tdgvcari.Select()
    End Sub

    Sub buka_bayar()
        If CInt(lbltotharga.Text) <= 0 Then Exit Sub
        dgvtampil.Enabled = False
        pncari.Visible = False
        pnbayar.Visible = True
        tgrdtot.Text = CInt(lbltotharga.Text)
        ttunai.Clear()
        ttunai.Select()
    End Sub

    Private Sub bcari_Click(sender As Object, e As EventArgs) Handles bcari.Click
        buka_cari()
    End Sub

    Private Sub bBayar_Click(sender As Object, e As EventArgs) Handles bBayar.Click
        buka_bayar()
    End Sub

    Private Sub masuk_database()
        If dgvtampil.Rows.Count <= 0 Then Exit Sub
        For Each erow As DataGridViewRow In dgvtampil.Rows
            Dim kode As String = erow.Cells("KODE").Value
            Dim jumlah As Integer = erow.Cells("QTY").Value
            Dim harga As Integer = erow.Cells("TOTAL").Value

            Dim str As String = "insert into tbl_transaksi" &
                " (kode,jumlah,harga,tgl,jenis,admin) values ('" & kode &
                "','" & jumlah & "','" & harga & "','" &
                Format(Date.Now, "MM/dd/yyyy") & "','K','" & nikAdmin & "')"

            Dim cmd As New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
        Next

        print_nota()
        TUTUP_BAYAR()
        dgvtampil.Rows.Clear()
        total_harga()
        tkode.Select()
    End Sub

    Private Sub print_nota()
        nota.PrinterSettings.PrinterName = printer_nota
        nota.Print()
    End Sub

    Private Sub thrga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles thrga.KeyPress
        If IsNumeric(thrga.Text) Then
            thrga.Text = FormatNumber(CDbl(thrga.Text), 0)
            thrga.SelectionStart = thrga.TextLength
        Else
            thrga.Text = 0
        End If
    End Sub

    Private Sub FrmBrgKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ambil_data()
        aturgrid()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        For Each ecell As DataGridViewCell In dgvtampil.SelectedCells
            dgvtampil.Rows.RemoveAt(ecell.RowIndex)
        Next
        total_harga()
    End Sub

    Private Sub dgvtampil_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvtampil.CellMouseClick
        If dgvtampil.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
            klik_kanan.Show(Cursor.Position.X, Cursor.Position.Y)
        End If
    End Sub

    Private Sub nota_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles nota.PrintPage
        Dim tinggi As Integer = 10
        e.Graphics.DrawString(nama_toko, New Font("courier New", 8), Brushes.Black, 45%, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(no_toko, New Font("courier New", 8), Brushes.Black, 45%, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(alamat_toko, New Font("courier New", 8), Brushes.Black, 45%, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("--------------------------", New Font("courier New", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "Qty" & vbTab & "Total", New Font("courier New", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------", New Font("courier New", 8), Brushes.Black, 2, tinggi)

        For Each erow As DataGridViewRow In dgvtampil.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(erow.Cells("BARANG").Value, New Font("courier New", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & erow.Cells("QTY").Value & vbTab & erow.Cells("TOTAL").Value, New Font("courier New", 8), Brushes.Black, 2, tinggi)
        Next

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------", New Font("courier New", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ": " & FormatCurrency(tgrdtot.Text, 0), New Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ": " & FormatCurrency(ttunai.Text, 0), New Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ": " & FormatCurrency(tkembali.Text, 0), New Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------", New Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 40
        e.Graphics.DrawString("Terimakasih.", New Font("courier new", 8), Brushes.Black, 45%, tinggi)
    End Sub

    Private Sub aturgrid()
        'tinggi header
        Me.dgvtampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvtampil.ColumnHeadersHeight = 25

        'posisi header
        Me.dgvtampil.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvtampil.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        'ukuran font
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgvtampil.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        Me.dgvtampil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    End Sub

    Private Sub FrmBrgKeluar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If pncari.Visible = False Then
                    buka_cari()
                Else
                    TUTUP_CARI()
                End If
            Case Keys.F2
                If pnbayar.Visible = False Then
                    buka_bayar()
                Else
                    TUTUP_BAYAR()
                End If
            Case Keys.F3
                FrmTrAdmin.ShowDialog()
        End Select
    End Sub

    Private Sub btmenu_Click(sender As Object, e As EventArgs) Handles btmenu.Click
        Dim fr As New FrmMenu
        fr.Show()
        Me.Close()
    End Sub

    Private Sub bMin_Click(sender As Object, e As EventArgs) Handles bMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bMax_Click(sender As Object, e As EventArgs) Handles bMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bclosecari_Click(sender As Object, e As EventArgs) Handles bclosecari.Click
        TUTUP_CARI()
    End Sub

    Private Sub tdgvcari_TextChanged(sender As Object, e As EventArgs) Handles tdgvcari.TextChanged
        konek()
        Dim str As String = "select TOP 10 rtrim(kode) as KODE,rtrim(barang) as BARANG,rtrim(satuan)" &
         " as SATUAN,HARGA_SATUAN from tbl_barang where barang Like '%" & tdgvcari.Text & "%'"
        Dim da As New SqlDataAdapter(str, con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgvcari.DataSource = tbl
    End Sub

    Private Sub dgvcari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcari.CellDoubleClick
        tkode.Text = dgvcari.Item("KODE", e.RowIndex).Value
        pncari.Visible = False
    End Sub

    Private Sub bclosebyr_Click(sender As Object, e As EventArgs) Handles bclosebyr.Click
        TUTUP_BAYAR()
    End Sub

    Private Sub ttunai_TextChanged(sender As Object, e As EventArgs) Handles ttunai.TextChanged
        If ttunai.Text = "0" Then Exit Sub
        tkembali.Text = Val(ttunai.Text) - Val(tgrdtot.Text)
    End Sub

    Private Sub ttunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ttunai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If CInt(tkembali.Text) >= 0 Then
                masuk_database()
            Else
                MsgBox("Pembayaran kurang...")
            End If

        End If
    End Sub

    Private Sub bLapTrans_Click(sender As Object, e As EventArgs) Handles bLapTrans.Click
        Dim fr As New FrmTrAdmin
        fr.ShowDialog()
    End Sub
End Class