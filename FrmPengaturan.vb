Imports System.Drawing.Printing
Public Class FrmPengaturan

    Sub isi_list_printer()
        cbprint.Items.Clear()
        For Each nama_printer As String In PrinterSettings.InstalledPrinters
            cbprint.Items.Add(nama_printer)
        Next
    End Sub

    Private Sub FrmPengaturan_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi_list_printer()
        ambil_data()
        tnmtoko.Text = nama_toko
        talmttoko.Text = alamat_toko
        tnotelp.Text = no_toko
        cbprint.Text = printer_nota
    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        masuk_data(tnmtoko.Text, talmttoko.Text, tnotelp.Text, cbprint.Text)
        MsgBox("Data sudah tersimpan....", vbInformation, "Informasi")
        Me.Close()
    End Sub
End Class