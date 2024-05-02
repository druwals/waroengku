Imports System.Data.SqlClient

Public Class FrmKaryawan
    Dim lebar As Integer

    Private Function autonik() As String
        konek()
        Dim NIK_AWAL As String = Format(Date.Now, "yyyyMM")
        Dim NIK_AKHIR As String = ""
        Dim str As String = "SELECT MAX(NIK) AS NIK FROM TBL_KARYAWAN"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If Not IsDBNull(rd.Item("NIK")) Then
            Dim NIK As Integer = Mid(rd.Item("NIK"), 7, 6) + 1
            rd.Close()
            autonik = NIK_AWAL & Format(NIK, "000000")
        Else
            rd.Close()
            autonik = NIK_AWAL & Format(1, "000000")
        End If
        rd.Close()
    End Function

    Private Sub tampil()
        konek()
        Dim str As String = "SELECT NIK,RTRIM(NAMA) AS NAMA,RTRIM(ASAL) AS ASAL,TGL,JK,RTRIM(ALAMAT) AS ALAMAT,RTRIM(NOHP) AS NOHP from TBL_KARYAWAN WHERE NAMA LIKE '%" & tCari.Text & "%'"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(str, con)
        Dim tbl As New DataTable
        dgv.Columns.Clear()
        da.Fill(tbl)
        dgv.DataSource = tbl
        aturgrid()
        tNIK.Text = autonik()

    End Sub

    Private Sub FrmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tNIK.Text = autonik()
        tampil()
    End Sub

    Private Sub aturgrid()
        lebar = 0
        lebar = dgv.Width
        lebar = lebar - 424

        'tinggi header
        Me.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ColumnHeadersHeight = 25

        'posisi header
        Me.dgv.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'ukuran font
        Me.dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgv.DefaultCellStyle.Font = New Font("Arial", 10)
        Me.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray

        Me.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Bersih()
        BSimpan.Enabled = True
        BSimpan.Text = "Tambah"
        bHapus.Enabled = False

        tNIK.Enabled = False
        tNama.Clear()
        tAsal.Clear()
        cbJenis.Text = Nothing
        tAlamat.Clear()
        tNoHp.Clear()
        tCari.Clear()

        tNIK.Enabled = False
        tNama.Enabled = False
        tAsal.Enabled = False
        DtpTgl.Enabled = False
        cbJenis.Enabled = False
        tAlamat.Enabled = False
        tNoHp.Enabled = False
        tCari.Clear()
        dgv.Enabled = True
    End Sub

    Private Sub BTutup_Click(sender As Object, e As EventArgs) Handles BTutup.Click
        Me.Close()
    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        If tNIK.Text = "" Or tNama.Text = "" Then
            MsgBox("Data tidak lengkap", vbExclamation, "Perhatian")
        Else
            Dim jk As String = ""
            If cbJenis.Text = "LAKI-LAKI" Then
                jk = "L"
            ElseIf cbJenis.Text = "PEREMPUAN" Then
                jk = "P"
            End If
            Dim str As String = "select * from TBL_KARYAWAN WHERE NIK='" & tNIK.Text & "'"
            Dim cmd As New SqlCommand(str, con)
            Dim rd As SqlDataReader
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                str = "Update TBL_KARYAWAN set NAMA='" & tNama.Text & "',ASAL='" & tAsal.Text & "',TGL='" & Format(DtpTgl.Value, "MM/dd/yyyy") &
                    "', JK='" & jk & "',ALAMAT='" & tAlamat.Text & "',NOHP='" & tNoHp.Text & "' where NIK='" & tNIK.Text & "'"
                cmd = New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
            Else
                rd.Close()
                str = "INSERT INTO TBL_KARYAWAN VALUES('" & tNIK.Text & "','" & tNama.Text &
                    "','" & tAsal.Text & "','" & Format(DtpTgl.Value, "MM/dd/yyyy") &
                    "','" & jk & "','" & tAlamat.Text & "','" & tNoHp.Text & "')"
            End If
            cmd = New SqlCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call tampil()
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub FrmKaryawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub tCari_TextChanged(sender As Object, e As EventArgs) Handles tCari.TextChanged
        tampil()
    End Sub

    Private Sub tNIK_TextChanged(sender As Object, e As EventArgs) Handles tNIK.TextChanged
        konek()
        Dim str As String = "select * from TBL_KARYAWAN WHERE NIK='" & tNIK.Text & "'"
        Dim cmd As New SqlCommand(str, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            tNama.Text = rd.Item("NAMA").ToString.Trim
            tAsal.Text = rd.Item("ASAL").ToString.Trim
            DtpTgl.Value = rd.Item("TGL")
            If rd.Item("JK") = "L" Then
                cbJenis.Text = "LAKI-LAKI"
            ElseIf rd.Item("JK") = "P" Then
                cbJenis.Text = "PEREMPUAN"
            End If
            tAlamat.Text = rd.Item("ALAMAT").ToString.Trim
            tNoHp.Text = rd.Item("NOHP").ToString.Trim
            rd.Close()
        Else
            tNama.Clear()
            tAsal.Clear()
            tAsal.Clear()
            tAlamat.Clear()
            tNoHp.Clear()
            cbJenis.Text = Nothing
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        tNIK.Text = dgv.Item("NIK", e.RowIndex).Value
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If tNIK.Text = "" Then
            MsgBox("NIK tidak boleh kosong", vbExclamation, "Peringatan!")
        Else
            If MsgBox("Yakin Menghapus data ini?", vbYesNo) = vbYes Then
                Dim str As String = "DELETE FROM tbl_karyawan WHERE NIK='" & tNIK.Text & "'"
                Dim cmd As New SqlCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus", vbInformation, "Informasi")
                Call tampil()
            End If
        End If
    End Sub

    Private Sub tNama_KeyDown(sender As Object, e As KeyEventArgs) Handles tNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            tAsal.Focus()
        End If
    End Sub

    Private Sub tAsal_KeyDown(sender As Object, e As KeyEventArgs) Handles tAsal.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtpTgl.Focus()
        End If
    End Sub

    Private Sub DtpTgl_KeyDown(sender As Object, e As KeyEventArgs) Handles DtpTgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbJenis.Focus()
        End If
    End Sub

    Private Sub cbJenis_KeyDown(sender As Object, e As KeyEventArgs) Handles cbJenis.KeyDown
        If e.KeyCode = Keys.Enter Then
            tAlamat.Focus()
        End If
    End Sub

    Private Sub tAlamat_KeyDown(sender As Object, e As KeyEventArgs) Handles tAlamat.KeyDown
        If e.KeyCode = Keys.Enter Then
            tNoHp.Focus()
        End If
    End Sub

    Private Sub tNoHp_KeyDown(sender As Object, e As KeyEventArgs) Handles tNoHp.KeyDown
        If e.KeyCode = Keys.Enter Then
            BSimpan_Click(e, AcceptButton)
        End If
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If dgv.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
                klik_kanan.Show(Cursor.Position.X, Cursor.Position.Y)
            End If
        End If
    End Sub

    Private Sub JadikanAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadikanAdminToolStripMenuItem.Click
        Dim fr As New FrmAdmin
        With fr
            .lblNIK.Text = dgv.Item("NIK", dgv.CurrentRow.Index).Value
            .lblNama.Text = dgv.Item("NAMA", dgv.CurrentRow.Index).Value
            .ShowDialog()
        End With
    End Sub
End Class