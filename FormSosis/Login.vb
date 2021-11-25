Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtpass.Text = "" Or txtuser.Text = "" Then
            MsgBox("Data Belum Lengkap")
        Else
            Call KoneksiDB()
            CMD = New OleDb.OleDbCommand("select * from Karyawan where id_karyawan='" & txtuser.Text & "' and password='" & txtpass.Text & "'", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Hide()
                MenuUtama.Show()
            End If
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btncancellog.Click
        Me.Close()
    End Sub
End Class
