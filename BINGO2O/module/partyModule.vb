Imports System.Data.SqlClient

Module partyModule

    Public SQLconnection As New SqlConnection

    Public Sub getConnectionString(ByVal datasource As String)
        Dim connectionString As String = "Data Source='" & datasource & "';Network Library=DBMSSOCN;Initial Catalog='RAFFLEDATA';User ID='kmdiadmin';Password='kmdiadmin';"
        SQLconnection = New SqlConnection With {.ConnectionString = connectionString}
    End Sub
End Module
