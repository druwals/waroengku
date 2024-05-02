Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmTrAdmin
    Sub tampil()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.barang) as BARANG,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_barang as b on a.kode=b.kode where admin='" & tNIK.Text & "' and tgl='" & Format(DTPTanggal.Value, "MM-dd-yyyy") & "' AND JENIS='K'", con)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgvtampil.DataSource = tbl
        dgvtampil.Columns("HARGA").DefaultCellStyle.Format = "N0"
        dgvtampil.Columns("HARGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvtampil.Columns("JUMLAH").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        hitung_total()
        aturgrid()
    End Sub

    Sub aturgrid()
        'tinggi header
        Me.dgvtampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvtampil.ColumnHeadersHeight = 25

        'ukuran font
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgvtampil.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgvtampil.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray

        Me.dgvtampil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub hitung_total()
        Dim jlh As Long = 0
        For n = 0 To dgvtampil.Rows.Count - 1
            jlh = jlh + dgvtampil.Item("HARGA", n).Value
        Next
        tJumlah.Text = FormatCurrency(jlh, 0)
    End Sub

    Private Sub tNIK_TextChanged(sender As Object, e As EventArgs) Handles tNIK.TextChanged
        Dim cmd As New SqlCommand("select rtrim(nama) as nama from tbl_karyawan where rtrim(nik)='" & tNIK.Text & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tNama.Text = rd.Item("nama").ToString
            rd.Close()
        Else
            rd.Close()
            tNama.Clear()
        End If
        tampil()
    End Sub

    Private Sub DTPTanggal_ValueChanged(sender As Object, e As EventArgs) Handles DTPTanggal.ValueChanged
        tampil()
    End Sub

    Private Sub FrmTrAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        tNIK.Text = nikAdmin
    End Sub

    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        If Chk.Checked = True Then
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.barang) as BARANG,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_barang as b on a.kode=b.kode where admin='" & tNIK.Text & "' and tgl='" & Format(DTPTanggal.Value, "MM-dd-yyyy") & "' AND JENIS='K'", con)
            da.Fill(tbl)
            FrmTransKasir.ReportViewer1.LocalReport.DataSources.Clear()
            FrmTransKasir.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", tbl))

            Dim parameter(2) As ReportParameter
            parameter(0) = New ReportParameter("NIK", tNIK.Text)
            parameter(1) = New ReportParameter("NAMA", tNama.Text)
            parameter(2) = New ReportParameter("TGLTR", DTPTanggal.Value)

            FrmTransKasir.ReportViewer1.LocalReport.SetParameters(parameter)
            FrmTransKasir.ReportViewer1.LocalReport.Refresh()
            FrmTransKasir.ShowDialog()
        Else
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.barang) as BARANG,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_barang as b on a.kode=b.kode where admin='" & tNIK.Text & "' and tgl='" & Format(DTPTanggal.Value, "MM-dd-yyyy") & "' AND JENIS='K'", con)
            da.Fill(tbl)
            Dim rdlc As New LocalReport
            rdlc.ReportEmbeddedResource = "Druwals72.TRKasir.rdlc"
            With rdlc
                .DataSources.Clear()
                .DataSources.Add(New ReportDataSource("DataSet1", tbl))
                Dim parameters(2) As ReportParameter
                parameters(0) = New ReportParameter("NIK", tNIK.Text)
                parameters(1) = New ReportParameter("NAMA", tNama.Text)
                parameters(2) = New ReportParameter("TGLTR", DTPTanggal.Value)
                .SetParameters(parameters)
                .Refresh()
            End With

            print_microsoft_report(rdlc, "A4", False, "Microsoft Print to PDF")
        End If
    End Sub
End Class