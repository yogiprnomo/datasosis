<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchasing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtnopopur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkodermpur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtjumlahRMpur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotalpembayaranpur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstatuspembayaranpur = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnresetpur = New System.Windows.Forms.Button()
        Me.btndeletepur = New System.Windows.Forms.Button()
        Me.btneditpur = New System.Windows.Forms.Button()
        Me.btninsertpur = New System.Windows.Forms.Button()
        Me.datepurchas = New System.Windows.Forms.DateTimePicker()
        Me.txtidsupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnamasupplier = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnotelpsupplier = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtalamatsupplier = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btncetakdatasup = New System.Windows.Forms.Button()
        Me.btncetakinvoicesup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnopopur
        '
        Me.txtnopopur.Location = New System.Drawing.Point(159, 29)
        Me.txtnopopur.Name = "txtnopopur"
        Me.txtnopopur.Size = New System.Drawing.Size(228, 20)
        Me.txtnopopur.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No. PO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tanggal"
        '
        'txtkodermpur
        '
        Me.txtkodermpur.Location = New System.Drawing.Point(159, 81)
        Me.txtkodermpur.Name = "txtkodermpur"
        Me.txtkodermpur.Size = New System.Drawing.Size(228, 20)
        Me.txtkodermpur.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Kode Raw Material"
        '
        'txtjumlahRMpur
        '
        Me.txtjumlahRMpur.Location = New System.Drawing.Point(159, 107)
        Me.txtjumlahRMpur.Name = "txtjumlahRMpur"
        Me.txtjumlahRMpur.Size = New System.Drawing.Size(228, 20)
        Me.txtjumlahRMpur.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jumlah Raw Material"
        '
        'txttotalpembayaranpur
        '
        Me.txttotalpembayaranpur.Location = New System.Drawing.Point(159, 133)
        Me.txttotalpembayaranpur.Name = "txttotalpembayaranpur"
        Me.txttotalpembayaranpur.Size = New System.Drawing.Size(228, 20)
        Me.txttotalpembayaranpur.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total Pembayaran"
        '
        'txtstatuspembayaranpur
        '
        Me.txtstatuspembayaranpur.Location = New System.Drawing.Point(159, 159)
        Me.txtstatuspembayaranpur.Name = "txtstatuspembayaranpur"
        Me.txtstatuspembayaranpur.Size = New System.Drawing.Size(228, 20)
        Me.txtstatuspembayaranpur.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Status Pembayaran"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(39, 234)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(725, 97)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnresetpur
        '
        Me.btnresetpur.Location = New System.Drawing.Point(313, 195)
        Me.btnresetpur.Name = "btnresetpur"
        Me.btnresetpur.Size = New System.Drawing.Size(75, 23)
        Me.btnresetpur.TabIndex = 21
        Me.btnresetpur.Text = "Reset"
        Me.btnresetpur.UseVisualStyleBackColor = True
        '
        'btndeletepur
        '
        Me.btndeletepur.Location = New System.Drawing.Point(222, 195)
        Me.btndeletepur.Name = "btndeletepur"
        Me.btndeletepur.Size = New System.Drawing.Size(75, 23)
        Me.btndeletepur.TabIndex = 20
        Me.btndeletepur.Text = "Delete"
        Me.btndeletepur.UseVisualStyleBackColor = True
        '
        'btneditpur
        '
        Me.btneditpur.Location = New System.Drawing.Point(130, 195)
        Me.btneditpur.Name = "btneditpur"
        Me.btneditpur.Size = New System.Drawing.Size(75, 23)
        Me.btneditpur.TabIndex = 19
        Me.btneditpur.Text = "Edit"
        Me.btneditpur.UseVisualStyleBackColor = True
        '
        'btninsertpur
        '
        Me.btninsertpur.Location = New System.Drawing.Point(39, 195)
        Me.btninsertpur.Name = "btninsertpur"
        Me.btninsertpur.Size = New System.Drawing.Size(75, 23)
        Me.btninsertpur.TabIndex = 18
        Me.btninsertpur.Text = "Insert"
        Me.btninsertpur.UseVisualStyleBackColor = True
        '
        'datepurchas
        '
        Me.datepurchas.Location = New System.Drawing.Point(159, 56)
        Me.datepurchas.Name = "datepurchas"
        Me.datepurchas.Size = New System.Drawing.Size(228, 20)
        Me.datepurchas.TabIndex = 22
        '
        'txtidsupplier
        '
        Me.txtidsupplier.Location = New System.Drawing.Point(536, 29)
        Me.txtidsupplier.Name = "txtidsupplier"
        Me.txtidsupplier.Size = New System.Drawing.Size(228, 20)
        Me.txtidsupplier.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ID Supplier"
        '
        'txtnamasupplier
        '
        Me.txtnamasupplier.Location = New System.Drawing.Point(536, 55)
        Me.txtnamasupplier.Name = "txtnamasupplier"
        Me.txtnamasupplier.Size = New System.Drawing.Size(228, 20)
        Me.txtnamasupplier.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(413, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Nama Supplier"
        '
        'txtnotelpsupplier
        '
        Me.txtnotelpsupplier.Location = New System.Drawing.Point(536, 81)
        Me.txtnotelpsupplier.Name = "txtnotelpsupplier"
        Me.txtnotelpsupplier.Size = New System.Drawing.Size(228, 20)
        Me.txtnotelpsupplier.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "No. Telp"
        '
        'txtalamatsupplier
        '
        Me.txtalamatsupplier.Location = New System.Drawing.Point(536, 107)
        Me.txtalamatsupplier.Multiline = True
        Me.txtalamatsupplier.Name = "txtalamatsupplier"
        Me.txtalamatsupplier.Size = New System.Drawing.Size(228, 72)
        Me.txtalamatsupplier.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(413, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Alamat Supplier"
        '
        'btncetakdatasup
        '
        Me.btncetakdatasup.Location = New System.Drawing.Point(686, 195)
        Me.btncetakdatasup.Name = "btncetakdatasup"
        Me.btncetakdatasup.Size = New System.Drawing.Size(78, 23)
        Me.btncetakdatasup.TabIndex = 32
        Me.btncetakdatasup.Text = "Cetak Data"
        Me.btncetakdatasup.UseVisualStyleBackColor = True
        '
        'btncetakinvoicesup
        '
        Me.btncetakinvoicesup.Location = New System.Drawing.Point(403, 195)
        Me.btncetakinvoicesup.Name = "btncetakinvoicesup"
        Me.btncetakinvoicesup.Size = New System.Drawing.Size(86, 23)
        Me.btncetakinvoicesup.TabIndex = 31
        Me.btncetakinvoicesup.Text = "Cetak Invoice"
        Me.btncetakinvoicesup.UseVisualStyleBackColor = True
        '
        'Purchasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 363)
        Me.Controls.Add(Me.btncetakdatasup)
        Me.Controls.Add(Me.btncetakinvoicesup)
        Me.Controls.Add(Me.txtalamatsupplier)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtnotelpsupplier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnamasupplier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtidsupplier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datepurchas)
        Me.Controls.Add(Me.btnresetpur)
        Me.Controls.Add(Me.btndeletepur)
        Me.Controls.Add(Me.btneditpur)
        Me.Controls.Add(Me.btninsertpur)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtstatuspembayaranpur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttotalpembayaranpur)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtjumlahRMpur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkodermpur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnopopur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Purchasing"
        Me.Text = "Purchasing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnopopur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkodermpur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtjumlahRMpur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttotalpembayaranpur As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstatuspembayaranpur As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnresetpur As Button
    Friend WithEvents btndeletepur As Button
    Friend WithEvents btneditpur As Button
    Friend WithEvents btninsertpur As Button
    Friend WithEvents datepurchas As DateTimePicker
    Friend WithEvents txtidsupplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnamasupplier As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnotelpsupplier As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtalamatsupplier As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btncetakdatasup As Button
    Friend WithEvents btncetakinvoicesup As Button
End Class
