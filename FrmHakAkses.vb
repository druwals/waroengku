
Imports System.Data.SqlClient
Public Class FrmHakAkses
    Sub tampil_admin()
        Dim DA As SqlDataAdapter
        DA = New SqlDataAdapter("SELECT a.nik AS NIK,rtrim(b.nama) as NAMA,rtrim(a.type) as TYPE from tbl_admin as a inner join tbl_karyawan as b on a.nik=b.nik", con)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        dgvakses.DataSource = tbl
    End Sub

    Sub tampil_akses(ByVal nik As String)
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select rtrim(id_menu) as ID_MENU,rtrim(nama_menu) as NAMA_MENU from tbl_menu", con)
        Dim tbl As New DataTable
        da.Fill(tbl)

        Dim c_combo As New DataGridViewComboBoxColumn
        c_combo.HeaderText = "STATUS"
        c_combo.Items.AddRange(New String() {"AKTIF", "TIDAK AKTIF"})

        With dgvmenu
            .DataSource = Nothing
            .Columns.Clear()
            .DataSource = tbl
            .Columns.Add(c_combo)
            .Columns(0).Name = "c_idmenu"
            .Columns(1).Name = "c_namamenu"
            .Columns(2).Name = "c_status"
            For Each drow As DataGridViewRow In .Rows
                drow.Cells("c_status").Value = "TIDAK AKTIF"

            Next
            .ReadOnly = False
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .AllowUserToAddRows = False
            .AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
            .EditMode = DataGridViewEditMode.EditOnEnter
        End With

        Dim str As String = "select rtrim(B.ID_MENU) AS ID_MENU,rtrim(B.NAMA_MENU) AS NAMA_MENU,rtrim(A.STATUS) AS STATUS from tbl_hakakses" &
            " AS A INNER JOIN TBL_MENU AS B ON A.ID_MENU=B.ID_MENU where A.NIK='" & nik & "'"
        Dim tbl_data As New DataTable
        da = New SqlDataAdapter(str, con)
        da.Fill(tbl_data)

        Dim find_row() As DataRow
        For Each drow As DataGridViewRow In dgvmenu.Rows
            find_row = tbl_data.Select("ID_MENU='" & drow.Cells("c_idmenu").Value.ToString & "'")
            If find_row.Length > 0 Then
                drow.Cells("c_status").Value = RTrim(find_row(0).Item("STATUS").ToString)
            Else
                drow.Cells("c_status").Value = "TIDAK AKTIF"
            End If
        Next
    End Sub

    Private Sub dgvakses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvakses.CellClick
        tampil_akses(dgvakses.Item("NIK", e.RowIndex).Value)
    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        Dim cmd As SqlCommand
        cmd = New SqlCommand("delete from tbl_hakakses where rtrim(nik)='" & dgvakses.Item("NIK", dgvakses.CurrentRow.Index).Value & "'", con)
        cmd.ExecuteNonQuery()

        For Each drow As DataGridViewRow In dgvmenu.Rows
            cmd = New SqlCommand("insert into tbl_hakakses values('" & dgvakses.Item("NIK", dgvakses.CurrentRow.Index).Value &
                                   " ','" & drow.Cells("c_idmenu").Value.ToString & "','" &
                                   drow.Cells("c_status").Value.ToString & "')", con)

            cmd.ExecuteNonQuery()
        Next
        MsgBox("DATA TERSIMPAN...", vbInformation)
    End Sub

    Private Sub FrmHakAkses_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampil_admin()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub
End Class