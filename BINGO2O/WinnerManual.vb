Imports System.Data.SqlClient

Public Class WinnerManual
    Private Sub WinnerManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gv.DataSource = getAllWinner()
        formatGV()
    End Sub
    Public Function getAllWinner() As BindingSource
        Dim bs As New BindingSource
        Dim ds As New DataSet
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select a.[ID]
      ,a.[NUMBER] as ITEM_NO
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
order by a.id desc"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "winnertb")
                    End Using
                    bs.DataSource = ds
                    bs.DataMember = "winnertb"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Return bs
            End Using
        End Using
    End Function
    Private Sub formatGV()
        gv.Columns("ID").Visible = False
        gv.Columns("ITEM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.Columns("WINNER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.Columns("ITEM_NO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        gv.Columns("ITEM_NO").Width = 100
        gv.Columns("ITEM").Width = 450
        gv.Columns("WINNER_ID").Width = 100
        gv.Columns("WINNER").Width = 450
        gv.Columns("SUPPLIER").Width = 200
    End Sub


End Class