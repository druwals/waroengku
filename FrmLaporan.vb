Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmLaporan
    Dim str As String = ""
    Dim tbl As New DataTable

    Private Sub aturgrid()
        'tinggi header
        Me.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ColumnHeadersHeight = 25
        'ukuran font
        Me.dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgv.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray

        Me.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
    End Sub

    Sub tampil()
        konek()
        Select Case cbJenis.SelectedIndex
            Case 0
                str = "select TGL,KODE,(select rtrim(barang) from tbl_barang" &
                    " where kode=tbl_transaksi.kode) as BARANG,JUMLAH,rtrim(supplier)" &
                    " as SUPPLIER,HARGA from tbl_transaksi where jenis='M' and tgl >= '" &
                    Format(DTPMulai.Value, "MM/dd/yyyy") & "' and tgl <='" &
                    Format(DTPSampai.Value, "MM/dd/yyyy") & "'"
            Case 1
                str = "select TGL,KODE,(select rtrim(barang) from tbl_barang" &
                    " where kode=tbl_transaksi.kode) as BARANG,JUMLAH," &
                    " HARGA from tbl_transaksi where jenis='K' and tgl >= '" &
                    Format(DTPMulai.Value, "MM/dd/yyyy") & "' and tgl <='" &
                    Format(DTPSampai.Value, "MM/dd/yyyy") & "'"
            Case 2
                str = "SELECT TR.ID,TR.TGL,TR.KODE,BR.BARANG,TR.JENIS,IIF(TR.JENIS='M',TR.JUMLAH,'') AS MASUK, " &
" IIF(TR.JENIS='K',TR.JUMLAH,'') AS KELUAR,TR.ADMIN FROM TBL_TRANSAKSI AS TR INNER JOIN TBL_BARANG AS BR ON TR.KODE=BR.KODE WHERE TR.TGL>='" &
Format(DTPMulai.Value, "MM/dd/yyyy") & "' AND TR.TGL<='" & Format(DTPSampai.Value, "MM/dd/yyyy") & "' ORDER BY TR.KODE,TR.TGL"
        End Select

        Dim da As New SqlDataAdapter(str, con)
        tbl.Clear()
        tbl.Columns.Clear()
        da.Fill(tbl)
        dgv.DataSource = tbl

        If cbJenis.SelectedIndex <> 2 Then
            dgv.Columns("HARGA").DefaultCellStyle.Format = "N0"
            dgv.Columns("HARGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub BView_Click(sender As Object, e As EventArgs) Handles BView.Click
        If cbJenis.Text <> "" Then
            tampil()
        End If
    End Sub

    Private Sub BCetak_Click(sender As Object, e As EventArgs) Handles BCetak.Click
        If dgv.Rows.Count > 0 Then
            If cbJenis.SelectedIndex = 2 Then
                FrmLapStok.ReportViewer1.LocalReport.ReportEmbeddedResource = "Druwals72.rptSTOK.rdlc"
                FrmLapStok.ReportViewer1.LocalReport.DataSources.Clear()
                FrmLapStok.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", tbl))

                Dim parameter(1) As ReportParameter
                parameter(0) = New ReportParameter("tglMulai", DTPMulai.Value)
                parameter(1) = New ReportParameter("tglSampai", DTPSampai.Value)


                FrmLapStok.ReportViewer1.LocalReport.SetParameters(parameter)
                FrmLapStok.ReportViewer1.LocalReport.Refresh()
                FrmLapStok.ShowDialog()
            Else
                Dim rpt As New RPT_MASUK
                With rpt
                    .SetDataSource(tbl)
                    .SetParameterValue("laporan", cbJenis.Text)
                    .SetParameterValue("tgl_mulai", DTPMulai.Value)
                    .SetParameterValue("tgl_sampai", DTPSampai.Value)
                End With

                Dim FR As New FrmPreview
                With FR
                    .CRV.ReportSource = rpt
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub FrmLaporan_Load(sender As Object, e As EventArgs) Handles Me.Load
        aturgrid()
    End Sub
End Class