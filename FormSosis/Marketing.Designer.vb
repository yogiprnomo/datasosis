<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marketing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidpemesanmar = New System.Windows.Forms.TextBox()
        Me.txtnamapemesanmar = New System.Windows.Forms.TextBox()
        Me.txttujuanmar = New System.Windows.Forms.TextBox()
        Me.txthargasatuanmar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtjumlahprodukmar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalhargamar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btninsertmar = New System.Windows.Forms.Button()
        Me.btneditmar = New System.Windows.Forms.Button()
        Me.btndeletemar = New System.Windows.Forms.Button()
        Me.btnresetmar = New System.Windows.Forms.Button()
        Me.btncetakinvoicemar = New System.Windows.Forms.Button()
        Me.btncetakdatamar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datemar = New System.Windows.Forms.DateTimePicker()
        Me.gridviewmar = New System.Windows.Forms.DataGridView()
        Me.txtidkaryawan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.gridviewmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pemesan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pemesan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tujuan Pengiriman"
        '
        'txtidpemesanmar
        '
        Me.txtidpemesanmar.Location = New System.Drawing.Point(165, 38)
        Me.txtidpemesanmar.Name = "txtidpemesanmar"
        Me.txtidpemesanmar.Size = New System.Drawing.Size(228, 20)
        Me.txtidpemesanmar.TabIndex = 4
        '
        'txtnamapemesanmar
        '
        Me.txtnamapemesanmar.Location = New System.Drawing.Point(165, 63)
        Me.txtnamapemesanmar.Name = "txtnamapemesanmar"
        Me.txtnamapemesanmar.Size = New System.Drawing.Size(228, 20)
        Me.txtnamapemesanmar.TabIndex = 5
        '
        'txttujuanmar
        '
        Me.txttujuanmar.Location = New System.Drawing.Point(165, 141)
        Me.txttujuanmar.Multiline = True
        Me.txttujuanmar.Name = "txttujuanmar"
        Me.txttujuanmar.Size = New System.Drawing.Size(228, 73)
        Me.txttujuanmar.TabIndex = 7
        '
        'txthargasatuanmar
        '
        Me.txthargasatuanmar.Location = New System.Drawing.Point(533, 37)
        Me.txthargasatuanmar.Name = "txthargasatuanmar"
        Me.txthargasatuanmar.Size = New System.Drawing.Size(228, 20)
        Me.txthargasatuanmar.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(410, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Harga Satuan"
        '
        'txtjumlahprodukmar
        '
        Me.txtjumlahprodukmar.Location = New System.Drawing.Point(533, 63)
        Me.txtjumlahprodukmar.Name = "txtjumlahprodukmar"
        Me.txtjumlahprodukmar.Size = New System.Drawing.Size(197, 20)
        Me.txtjumlahprodukmar.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah Produk"
        '
        'txttotalhargamar
        '
        Me.txttotalhargamar.Location = New System.Drawing.Point(533, 89)
        Me.txttotalhargamar.Name = "txttotalhargamar"
        Me.txttotalhargamar.Size = New System.Drawing.Size(228, 20)
        Me.txttotalhargamar.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(410, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Harga"
        '
        'btninsertmar
        '
        Me.btninsertmar.Location = New System.Drawing.Point(44, 227)
        Me.btninsertmar.Name = "btninsertmar"
        Me.btninsertmar.Size = New System.Drawing.Size(75, 23)
        Me.btninsertmar.TabIndex = 14
        Me.btninsertmar.Text = "Insert"
        Me.btninsertmar.UseVisualStyleBackColor = True
        '
        'btneditmar
        '
        Me.btneditmar.Location = New System.Drawing.Point(135, 227)
        Me.btneditmar.Name = "btneditmar"
        Me.btneditmar.Size = New System.Drawing.Size(75, 23)
        Me.btneditmar.TabIndex = 15
        Me.btneditmar.Text = "Edit"
        Me.btneditmar.UseVisualStyleBackColor = True
        '
        'btndeletemar
        '
        Me.btndeletemar.Location = New System.Drawing.Point(318, 227)
        Me.btndeletemar.Name = "btndeletemar"
        Me.btndeletemar.Size = New System.Drawing.Size(75, 23)
        Me.btndeletemar.TabIndex = 16
        Me.btndeletemar.Text = "Delete"
        Me.btndeletemar.UseVisualStyleBackColor = True
        '
        'btnresetmar
        '
        Me.btnresetmar.Location = New System.Drawing.Point(226, 227)
        Me.btnresetmar.Name = "btnresetmar"
        Me.btnresetmar.Size = New System.Drawing.Size(75, 23)
        Me.btnresetmar.TabIndex = 17
        Me.btnresetmar.Text = "Cancel"
        Me.btnresetmar.UseVisualStyleBackColor = True
        '
        'btncetakinvoicemar
        '
        Me.btncetakinvoicemar.Location = New System.Drawing.Point(413, 227)
        Me.btncetakinvoicemar.Name = "btncetakinvoicemar"
        Me.btncetakinvoicemar.Size = New System.Drawing.Size(96, 23)
        Me.btncetakinvoicemar.TabIndex = 18
        Me.btncetakinvoicemar.Text = "Cetak Invoice"
        Me.btncetakinvoicemar.UseVisualStyleBackColor = True
        '
        'btncetakdatamar
        '
        Me.btncetakdatamar.Location = New System.Drawing.Point(686, 227)
        Me.btncetakdatamar.Name = "btncetakdatamar"
        Me.btncetakdatamar.Size = New System.Drawing.Size(75, 23)
        Me.btncetakdatamar.TabIndex = 19
        Me.btncetakdatamar.Text = "Cetak Data"
        Me.btncetakdatamar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(736, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Pcs"
        '
        'datemar
        '
        Me.datemar.Location = New System.Drawing.Point(165, 115)
        Me.datemar.Name = "datemar"
        Me.datemar.Size = New System.Drawing.Size(228, 20)
        Me.datemar.TabIndex = 22
        '
        'gridviewmar
        '
        Me.gridviewmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewmar.Location = New System.Drawing.Point(44, 266)
        Me.gridviewmar.Name = "gridviewmar"
        Me.gridviewmar.Size = New System.Drawing.Size(717, 150)
        Me.gridviewmar.TabIndex = 23
        '
        'txtidkaryawan
        '
        Me.txtidkaryawan.Location = New System.Drawing.Point(165, 89)
        Me.txtidkaryawan.Name = "txtidkaryawan"
        Me.txtidkaryawan.Size = New System.Drawing.Size(228, 20)
        Me.txtidkaryawan.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ID Karyawan"
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 438)
        Me.Controls.Add(Me.txtidkaryawan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gridviewmar)
        Me.Controls.Add(Me.datemar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncetakdatamar)
        Me.Controls.Add(Me.btncetakinvoicemar)
        Me.Controls.Add(Me.btnresetmar)
        Me.Controls.Add(Me.btndeletemar)
        Me.Controls.Add(Me.btneditmar)
        Me.Controls.Add(Me.btninsertmar)
        Me.Controls.Add(Me.txttotalhargamar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtjumlahprodukmar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txthargasatuanmar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttujuanmar)
        Me.Controls.Add(Me.txtnamapemesanmar)
        Me.Controls.Add(Me.txtidpemesanmar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        CType(Me.gridviewmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidpemesanmar As TextBox
    Friend WithEvents txtnamapemesanmar As TextBox
    Friend WithEvents txttujuanmar As TextBox
    Friend WithEvents txthargasatuanmar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtjumlahprodukmar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttotalhargamar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btninsertmar As Button
    Friend WithEvents btneditmar As Button
    Friend WithEvents btndeletemar As Button
    Friend WithEvents btnresetmar As Button
    Friend WithEvents btncetakinvoicemar As Button
    Friend WithEvents btncetakdatamar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents datemar As DateTimePicker
    Friend WithEvents gridviewmar As DataGridView
    Friend WithEvents txtidkaryawan As TextBox
    Friend WithEvents Label9 As Label
End Class
