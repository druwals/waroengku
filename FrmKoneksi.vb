Public Class FrmKoneksi
    Private Sub BKeluar_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        End
    End Sub

    Private Sub BKonek_Click(sender As Object, e As EventArgs) Handles BKonek.Click
        If tserver.Text = "" Or tuser.Text = "" Or tpass.Text = "" Or tdatabase.Text = "" Then
            MsgBox("Data tidak lengkap,silahkan lengkapi terlebih dahulu", vbInformation, "Informasi")
        Else
            With My.Settings
                .SERVER = tserver.Text
                .USER = tuser.Text
                .PASSWORD = tpass.Text
                .DATABASE = tdatabase.Text
                .Save()
            End With
            konek()

            FrmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class