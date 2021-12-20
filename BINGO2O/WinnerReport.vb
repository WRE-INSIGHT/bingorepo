Imports System.Data.SqlClient

Public Class WinnerReport
    Private Sub WinnerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadreport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub WinnerReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub loadreport()
        Dim ds As New DataSet1
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select
      a.[NUMBER]
      ,a.[ITEM]
      ,b.[SUPPLIER]
      ,a.[WINNER_ID] 
      ,a.[WINNER]
      from 
winnertb as a
      LEFT JOIN 
RAFFLETABLE AS b 
on 
a.number = b.number
order by a.[WINNER] ASC"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds.winnerTB)
                    End Using
                    winnerTBBindingSource.DataSource = ds.winnerTB.DefaultView
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class