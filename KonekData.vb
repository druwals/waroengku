Imports System.Data.SqlClient
Module KonekData
    Public con As SqlConnection
    Public nama_toko As String
    Public alamat_toko As String
    Public no_toko As String
    Public printer_nota As String
    Public nikAdmin As String
    Public Sub masuk_data(ByVal toko As String, ByVal alamat As String, ByVal no As String, ByVal prints As String)
        Call SaveSetting("toko", "setting", "nama_toko", toko)
        Call SaveSetting("toko", "setting", "alamat_toko", alamat)
        Call SaveSetting("toko", "setting", "no_toko", no)
        Call SaveSetting("toko", "setting", "print_nota", prints)
        ambil_data()
    End Sub

    Public Sub ambil_data()
        nama_toko = GetSetting("toko", "setting", "nama_toko", "")
        alamat_toko = GetSetting("toko", "setting", "alamat_toko", "")
        no_toko = GetSetting("toko", "setting", "no_toko", "")
        printer_nota = GetSetting("toko", "setting", "print_nota", "")
    End Sub

    Public Sub konek()
        Dim str As String = "SERVER=" & My.Settings.SERVER & "; USER ID=" & My.Settings.USER & ";PASSWORD=" & My.Settings.PASSWORD & ";DATABASE=" & My.Settings.DATABASE & ";"
        Try
            con = New SqlConnection(str)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal", vbCritical, "Peringatan")
            With My.Settings
                .SERVER = ""
                .USER = ""
                .PASSWORD = ""
                .DATABASE = ""
                .Save()
            End With
            End
        End Try
    End Sub
End Module
