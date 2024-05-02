Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FrmMenu
    Private currentChildForm As Form

    Sub data_menu(ToolTrip1 As ToolStrip)
        Dim CMD As SqlCommand
        CMD = New SqlCommand("DELETE FROM TBL_MENU", con)
        CMD.ExecuteNonQuery()

        For Each MENU1 As ToolStripMenuItem In culek.Items
            CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU1.Name & "','" & MENU1.Text & "')", con)
            CMD.ExecuteNonQuery()
            For Each MENU2 In MENU1.DropDownItems
                If TypeOf MENU2 Is ToolStripSeparator Then Continue For
                CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU2.Name & "','" & MENU2.Text & "')", con)
                CMD.ExecuteNonQuery()
                For Each MENU3 In MENU2.DropDownItems
                    If TypeOf MENU3 Is ToolStripSeparator Then Continue For
                    CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU3.Name & "','" & MENU3.Text & "')", con)
                    CMD.ExecuteNonQuery()
                    For Each MENU4 In MENU3.DropDownItems
                        If TypeOf MENU4 Is ToolStripSeparator Then Continue For
                        CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU4.Name & "','" & MENU4.Text & "')", con)
                        CMD.ExecuteNonQuery()
                        For Each MENU5 In MENU4.DropDownItems
                            If TypeOf MENU5 Is ToolStripSeparator Then Continue For
                            CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU5.Name & "','" & MENU5.Text & "')", con)
                            CMD.ExecuteNonQuery()
                        Next
                    Next
                Next
            Next
        Next

        For Each MENU As ToolStripItem In waduk.Items
            If TypeOf MENU Is ToolStripSeparator Then Continue For
            CMD = New SqlCommand("INSERT INTO TBL_MENU VALUES('" & MENU.Name & "','" & MENU.Text & "')", con)
            CMD.ExecuteNonQuery()
        Next
        CMD = New SqlCommand("DELETE FROM TBL_HAKAKSES WHERE ID_MENU NOT IN(SELECT ID_MENU FROM TBL_MENU)", con)
        CMD.ExecuteNonQuery()
    End Sub

    Sub setAkses(ByVal nik As String)
        Dim TBL_TEMP As New DataTable
        Dim DA As SqlDataAdapter
        DA = New SqlDataAdapter("SELECT RTRIM(nik) AS nik FROM TBL_ADMIN", con)
        DA.Fill(TBL_TEMP)

        For N = 0 To TBL_TEMP.Rows.Count - 1
            Dim ADM As String = TBL_TEMP.Rows(N).Item("nik").ToString()
            Dim CMD As SqlCommand
            CMD = New SqlCommand("INSERT INTO TBL_HAKAKSES SELECT '" & ADM & "' AS NIK,ID_MENU,'TIDAK AKTIF' AS STATUS FROM TBL_MENU WHERE ID_MENU NOT IN (SELECT ID_MENU FROM TBL_HAKAKSES WHERE RTRIM(nik)='" & ADM & "')", con)
            CMD.ExecuteNonQuery()
        Next

        Dim TBL As New DataTable
        DA = New SqlDataAdapter("SELECT RTRIM(id_menu) AS id_menu,RTRIM(status) AS status FROM TBL_HAKAKSES WHERE RTRIM(nik)='" & nik & "'", con)
        DA.Fill(TBL)

        If TBL.Rows.Count <= 0 Then
            culek.Visible = False
            waduk.Visible = False
            Exit Sub
        End If

        Dim FINDROW() As DataRow = Nothing
        For Each MENU1 As ToolStripMenuItem In culek.Items
            FINDROW = TBL.Select("id_menu='" & MENU1.Name & "'")
            MENU1.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)
            For Each MENU2 In MENU1.DropDownItems
                If TypeOf MENU2 Is ToolStripSeparator Then Continue For
                FINDROW = TBL.Select("id_menu='" & MENU2.Name & "'")
                MENU2.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)
                For Each MENU3 In MENU2.DropDownItems
                    If TypeOf MENU3 Is ToolStripSeparator Then Continue For
                    FINDROW = TBL.Select("id_menu='" & MENU3.Name & "'")
                    MENU3.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)
                    For Each MENU4 In MENU2.DropDownItems
                        If TypeOf MENU4 Is ToolStripSeparator Then Continue For
                        FINDROW = TBL.Select("id_menu='" & MENU4.Name & "'")
                        MENU4.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)
                        For Each MENU5 In MENU2.DropDownItems
                            If TypeOf MENU5 Is ToolStripSeparator Then Continue For
                            FINDROW = TBL.Select("id_menu='" & MENU5.Name & "'")
                            MENU5.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)

                        Next
                    Next
                Next
            Next
        Next

        For Each MenuItem As ToolStripItem In waduk.Items
            FINDROW = TBL.Select("id_menu='" & MenuItem.Name & "'")
            If FINDROW.Length > 0 Then MenuItem.Visible = IIf(FINDROW(0).Item("status").ToString = "AKTIF", True, False)
        Next
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnForm.BackgroundImage = Image.FromFile("bgaplikasi.png")
        Timer1.Enabled = True
        TSJam.Text = TimeOfDay
        TSTanggal.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
        Me.WindowState = FormWindowState.Maximized
        data_menu(waduk)
        TSSUser.Text = nikAdmin
        If nikAdmin = "SuperUser" Then
            Exit Sub
        End If
        Dim cmd As New SqlCommand("select type from tbl_admin where rtrim(nik)='" & nikAdmin & "'", con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            Dim adm As String = rd.Item("type").ToString.Trim
            rd.Close()
            If adm = "ADMIN" Then
                Exit Sub
            End If
        End If
        setAkses(nikAdmin)
    End Sub

    Private Sub OpenChildForm(ByVal childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PnForm.Controls.Add(childForm)
        PnForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblForm.Text = childForm.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TSJam.Text = TimeOfDay
        TSTanggal.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
    End Sub

    Private Sub PnAtas_MouseDown(sender As Object, e As MouseEventArgs) Handles PnAtas.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim takon As MsgBoxResult
        takon = MsgBox("Apakah ingin keluar sekarang?", MsgBoxStyle.YesNo, "Peringatan!")
        If takon = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        OpenChildForm(New FrmKaryawan)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        OpenChildForm(New FrmBarang)
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim fr As New FrmBrgKeluar
        fr.Show()
        Me.Hide()
    End Sub

    Private Sub SettingPrinterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingPrinterToolStripMenuItem.Click
        Dim fr As New FrmPengaturan
        fr.ShowDialog()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Dim fr As New FrmTentang
        fr.ShowDialog()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        OpenChildForm(New FrmHakAkses)
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        OpenChildForm(FrmMasuk)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim fr As New FrmLogin
        fr.Show()
        fr.tusername.Clear()
        fr.tPassword.Clear()
        fr.tusername.Focus()
        Me.Hide()
    End Sub

    Private Sub LapBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapBarangToolStripMenuItem.Click
        OpenChildForm(New FrmLaporan)
    End Sub

    Private Sub BarcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarcodeToolStripMenuItem.Click
        OpenChildForm(New FrmBarcode)
    End Sub
End Class
