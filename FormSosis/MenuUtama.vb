Public Class MenuUtama
    Private Sub PenjualanProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanProdukToolStripMenuItem.Click
        Marketing.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        If MessageBox.Show("Akses pengguna akan ditutup!" & vbCrLf & "Lanjutkan?", "Validasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Login.txtuser.Text = ""
            Login.txtpass.Text = ""
            Login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub PurchasingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasingToolStripMenuItem.Click
        Purchasing.Show()

    End Sub
End Class