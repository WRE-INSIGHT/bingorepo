Imports System.Data.SqlClient

Module partyModule

    Public SQLconnection As New SqlConnection
    Public connectionString As String
    Public patternSTR As String = Nothing
    Public priceSTR As String = Nothing

    Public raffleSearchBy As String = Nothing
    Public raffleSearch As String = Nothing
    Public winnerStr As String = Nothing
    Public Sub getConnectionString(ByVal datasource As String)
        connectionString = "Data Source='" & datasource & "';Network Library=DBMSSOCN;Initial Catalog='RAFFLEDATA';User ID='kmdiadmin';Password='kmdiadmin';"
        SQLconnection = New SqlConnection With {.ConnectionString = connectionString}
    End Sub
End Module
