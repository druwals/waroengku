Imports ZXing
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmBarcode
    Dim _tbl As New DataTable
    Dim brcode As New BarcodeWriter


    Private Sub FrmBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _tbl.Columns.Add("qrcode", Type.GetType("System.Byte[]"))
        tkode.Clear()
        tbarang.Clear()
        tjumlah.Clear()
        tkode.Focus()
    End Sub

    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged
        Dim str As String = "select rtrim(barang) barang from tbl_barang where rtrim(kode)='" & tkode.Text & "'"
        Dim cmd As New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tbarang.Text = rd.Item("barang").ToString
            rd.Close()
        Else
            rd.Close()
            tbarang.Clear()
        End If
    End Sub

    Private Sub tjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BView_Click(sender As Object, e As EventArgs) Handles BView.Click
        If tkode.Text = "" Or tbarang.Text = "" Or tjumlah.Text = "" Then Exit Sub

        If CInt(tjumlah.Text) <= 0 Then Exit Sub

        Dim ms As New MemoryStream
        brcode.Format = BarcodeFormat.CODE_128
        brcode.Write(tkode.Text).Save(ms, ImageFormat.Png)

        For n = 0 To CInt(tjumlah.Text) - 1
            _tbl.Rows.Add({ms.ToArray})
        Next

        RPT.LocalReport.DataSources.Clear()
        RPT.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _tbl))
        RPT.RefreshReport()
    End Sub

    Private Sub tkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tkode.KeyPress
        If e.KeyChar = Chr(13) Then
            tjumlah.Focus()
        End If
    End Sub

    Private Sub BTutup_Click(sender As Object, e As EventArgs) Handles BTutup.Click
        Me.Close()
    End Sub

    Private Sub tjumlah_KeyDown(sender As Object, e As KeyEventArgs) Handles tjumlah.KeyDown
        If e.KeyCode = Keys.Enter Then
            BView_Click(e, AcceptButton)
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        _tbl.Rows.Clear()
        RPT.LocalReport.DataSources.Clear()
        RPT.RefreshReport()
    End Sub
End Class