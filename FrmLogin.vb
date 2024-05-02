
Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        konek()
        If tusername.Text = "" Then
            MsgBox("Username Kosong", vbInformation, "Informasi")
        ElseIf tPassword.Text = "" Then
            MsgBox("Password Kosong", vbInformation, "Informasi")
        Else
            Dim CMD As SqlCommand
            CMD = New SqlCommand("SELECT * FROM TBL_ADMIN", con)
            Dim RD As SqlDataReader
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                RD.Close()
                CMD = New SqlCommand("SELECT * FROM TBL_ADMIN WHERE RTRIM(USERNAME)='" & tusername.Text & "'", con)
                RD = CMD.ExecuteReader
                If RD.HasRows Then
                    RD.Read()
                    nikAdmin = RD.Item("NIK").ToString.Trim
                    Dim pwd As String = RD.Item("PASSWORD").ToString.Trim
                    RD.Close()

                    If tPassword.Text = pwd Then

                        Dim FR As New FrmMenu
                        FR.Show()
                        Me.Hide()
                    Else
                        MsgBox("Password Salah..!!")
                    End If
                Else
                    MsgBox("User tidak ditemukan...")
                End If
            Else
                RD.Close()
                If tusername.Text = "masgie" And tPassword.Text = "123" Then
                    nikAdmin = "SuperUser"
                    Dim FR As New FrmMenu
                    FR.Show()
                    Me.Hide()
                Else
                    MsgBox("Username / Password Salah!", vbCritical, "Peringatan")
                End If
            End If

            tusername.Clear()
            tPassword.Clear()
            tusername.Focus()
        End If
    End Sub

    Private Sub tusername_KeyDown(sender As Object, e As KeyEventArgs) Handles tusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tusername.Text = "" Then
                MsgBox("User tidak boleh kosong")
            Else
                tPassword.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tPassword.Text = "" Then
                MsgBox("Password tidak boleh kosong")
                tPassword.Focus()
            Else
                BLogin_Click(e, AcceptButton)
            End If
        End If
    End Sub

    Private Sub BBatal_Click(sender As Object, e As EventArgs) Handles BBatal.Click
        Dim tanya As MsgBoxResult
        tanya = MsgBox("Apakah ingin keluar sekarang?", MsgBoxStyle.YesNo, "Peringatan!")
        If tanya = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.SERVER = "" Or My.Settings.USER = "" Or My.Settings.PASSWORD = "" Or My.Settings.DATABASE = "" Then
            MsgBox("Database belum disetting,Silahkan setting database terlebih dahulu", vbInformation, "Informasi")
            FrmKoneksi.ShowDialog()
        End If
        tusername.Clear()
        tPassword.Clear()
        tusername.Focus()
    End Sub
End Class
