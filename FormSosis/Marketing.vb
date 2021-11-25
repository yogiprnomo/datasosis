Public Class Marketing
    Sub tampilanawal()
        txthargasatuanmar.Text = ""
        txtidpemesanmar.Text = ""
        txtidkaryawan.Text = ""
        txtjumlahprodukmar.Text = ""
        txtnamapemesanmar.Text = ""
        txttotalhargamar.Text = ""
        txttujuanmar.Text = ""
        txthargasatuanmar.Enabled = True
        txtidpemesanmar.Enabled = True
        txtidkaryawan.Enabled = False
        txtjumlahprodukmar.Enabled = True
        txtnamapemesanmar.Enabled = True
        txttotalhargamar.Enabled = True
        txttujuanmar.Enabled = True
    End Sub
    Sub tampilgridview()
        Call KoneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from Marketing", Conn)
        DS = New DataSet
        DA.Fill(DS)
        gridviewmar.DataSource = DS.Tables(0)
        gridviewmar.ReadOnly = True
    End Sub
    Sub refreashgrid()
        DA = New OleDb.OleDbDataAdapter("select * from Marketing", Conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Marketing")
        gridviewmar.DataSource = (DS.Tables("Marketing"))
    End Sub
    Private Sub Marketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgridview()
        txtidkaryawan.Text = Login.txtuser.Text
        txtidkaryawan.Enabled = False
    End Sub
    Private Sub btninsertmar_Click(sender As Object, e As EventArgs) Handles btninsertmar.Click
        If txthargasatuanmar.Text = "" Or txtidpemesanmar.Text = "" Or txtidkaryawan.Text = "" Or txtjumlahprodukmar.Text = "" Or txtnamapemesanmar.Text = "" Or txttotalhargamar.Text = "" Or txttujuanmar.Text = "" Then
            MsgBox("Data belum terisi")
            Exit Sub
        Else
            Call KoneksiDB()
            CMD = New OleDb.OleDbCommand("select * from Marketing where id_pemesan='" & txtidpemesanmar.Text & "'", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call KoneksiDB()
                Dim simpan As String = "insert into Marketing values ('" & txtidpemesanmar.Text & "','" & txtnamapemesanmar.Text & "','" & txtidkaryawan.Text & "','" & datemar.Text & "','" & txttujuanmar.Text & "','" & txthargasatuanmar.Text & "','" & txtjumlahprodukmar.Text & "','" & txttotalhargamar.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Sudah tersimpan")
            End If
            Call tampilanawal()
            Call refreashgrid()
            Call tampilgridview()
        End If
    End Sub
    Private Sub btnresetmar_Click(sender As Object, e As EventArgs) Handles btnresetmar.Click
        Call tampilanawal()
    End Sub
    Private Sub btneditmar_Click(sender As Object, e As EventArgs) Handles btneditmar.Click
        If txthargasatuanmar.Text = "" Or txtidpemesanmar.Text = "" Or txtidkaryawan.Text = "" Or txtjumlahprodukmar.Text = "" Or txtnamapemesanmar.Text = "" Or txttotalhargamar.Text = "" Or txttujuanmar.Text = "" Then
            MsgBox("Data belum terisi")
            Exit Sub
        Else
            Call KoneksiDB()
            CMD = New OleDb.OleDbCommand("Update Marketing set id_pemesan='" & txtidpemesanmar.Text & "',nama_pemesan='" & txtnamapemesanmar.Text & "',id_karyawan='" & txtidkaryawan.Text & "',tanggal_pesan='" & datemar.Text & "',tujuan_pengiriman='" & txttujuanmar.Text & "',harga_satuan='" & txthargasatuanmar.Text & "',jumlah_pesanan='" & txtjumlahprodukmar.Text & "',total_harga='" & txttotalhargamar.Text & "' where id_pemesan='" & txtidpemesanmar.Text & "'", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data Update")
        End If
        Call tampilanawal()
        Call tampilgridview()
    End Sub
    Private Sub gridviewmar_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridviewmar.CellMouseClick
        On Error Resume Next
        txtidpemesanmar.Text = gridviewmar.Rows(e.RowIndex).Cells(0).Value
        txtnamapemesanmar.Text = gridviewmar.Rows(e.RowIndex).Cells(1).Value
        txtidkaryawan.Text = gridviewmar.Rows(e.RowIndex).Cells(2).Value
        datemar.Text = gridviewmar.Rows(e.RowIndex).Cells(3).Value
        txttujuanmar.Text = gridviewmar.Rows(e.RowIndex).Cells(4).Value
        txthargasatuanmar.Text = gridviewmar.Rows(e.RowIndex).Cells(5).Value
        txtjumlahprodukmar.Text = gridviewmar.Rows(e.RowIndex).Cells(6).Value
        txttotalhargamar.Text = gridviewmar.Rows(e.RowIndex).Cells(7).Value
        txtidpemesanmar.Enabled = False
        txtidkaryawan.Enabled = False
    End Sub
    Private Sub btndeletemar_Click(sender As Object, e As EventArgs) Handles btndeletemar.Click
        If txtidpemesanmar.Text = "" Then
            MsgBox("Data yang akan dihapus tidak ada")
            Exit Sub
        Else
            If MessageBox.Show("Yakin ingin menghapus data ini", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Call KoneksiDB()
                CMD = New OleDb.OleDbCommand("delete * from Marketing where id_pemesan='" & txtidpemesanmar.Text & "'", Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil")
                Call tampilanawal()
                Call tampilgridview()
            Else
                tampilanawal()
            End If
        End If
    End Sub
End Class