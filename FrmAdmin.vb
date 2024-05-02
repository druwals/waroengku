Imports System.Data.SqlClient

Public Class FrmAdmin
    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        If tuser.Text = "" Or tpass.Text = "" Or trepass.Text = "" Then
            MsgBox("Data tidak lengkap,silahkan lengkapi dulu datanya", vbCritical, "Peringatan")
        ElseIf tpass.Text <> trepass.Text Then
            MsgBox("Ulangi penulisan password", vbCritical, "Peringatan")
        Else
            Dim str As String = ""
            str = "select nik from tbl_admin where nik='" & lblNIK.Text & "'"
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            cmd = New SqlCommand(str, con)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                cmd = New SqlCommand("update tbl_admin set username='" & tuser.Text & "',password='" & trepass.Text & "',type='" & cbType.Text & "' where rtrim(nik)='" & lblNIK.Text & "'", con)
                cmd.ExecuteNonQuery()
            Else
                rd.Close()
                cmd = New SqlCommand("insert into tbl_admin values('" & lblNIK.Text & "','" & tuser.Text & "','" & trepass.Text & "','" & cbType.Text & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan", vbInformation, "Informasi")
            End If
            tuser.Clear()
            tpass.Clear()
            trepass.Clear()
            cbType.Text = Nothing
            tuser.Focus()
        End If
    End Sub

    Private Sub tuser_KeyDown(sender As Object, e As KeyEventArgs) Handles tuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            tpass.Focus()
        End If
    End Sub

    Private Sub tpass_KeyDown(sender As Object, e As KeyEventArgs) Handles tpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            trepass.Focus()
        End If
    End Sub

    Private Sub trepass_KeyDown(sender As Object, e As KeyEventArgs) Handles trepass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbType.Focus()
        End If
    End Sub

    Private Sub cbType_KeyDown(sender As Object, e As KeyEventArgs) Handles cbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            BSimpan_Click(e, AcceptButton)
        End If
    End Sub

    Private Sub bTutup_Click(sender As Object, e As EventArgs) Handles bTutup.Click
        Me.Close()
    End Sub
End Class