Imports System.Data.OleDb

Public Class DBcontrol

    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                         "Data Source=New Coin.accdb;")

    Private DBcmd As OleDbCommand

    'DB Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable

    'Query Parameters
    Public Params As New List(Of OleDbParameter)

    'Query Statistics
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'Reset query stats
        RecordCount = 0
        Exception = ""

        Try
            'Open a connection
            DBCon.Open()

            'Create DB command
            DBcmd = New OleDbCommand(Query, DBCon)

            'Load params into DB command
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))

            'Clear params list
            Params.Clear()

            'Execute command and fill data table
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBcmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        'Close your connection
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    'Include query and command parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
