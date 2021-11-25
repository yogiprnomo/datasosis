Imports System.Data.OleDb
Imports MetroFramework.Controls
Module Koneksi
    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public LokasiDB As String
    Public Sub KoneksiDB()
        LokasiDB = "provider=microsoft.ace.oledb.12.0; data source = DataSosis.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
