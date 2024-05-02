Public Class FrmTentang
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start(String.Format("mailto:{0}", "slmtsgmn@gmail.com"))
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(String.Format("mailto:{0}", "836589012@ecampus.ut.ac.id"))
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(String.Format("mailto:{0}", "ismetmasgie@gmail.com"))
    End Sub
End Class