Imports System.Data.SqlClient

Module partyModule

    Public SQLconnection As New SqlConnection
    Public connectionString As String
    Public Sub getConnectionString(ByVal datasource As String)
        connectionString = "Data Source='" & datasource & "';Network Library=DBMSSOCN;Initial Catalog='RAFFLEDATA';User ID='kmdiadmin';Password='kmdiadmin';"
        SQLconnection = New SqlConnection With {.ConnectionString = connectionString}
    End Sub
End Module
