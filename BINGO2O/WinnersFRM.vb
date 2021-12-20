﻿Imports System.Data.SqlClient

Public Class WinnersFRM

    Private Sub WinnersFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gv.DataSource = getAllWinner()
        formatGV()
    End Sub
    Public Function getAllWinner() As BindingSource
        Dim bs As New BindingSource
        Dim ds As New DataSet
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select number AS ITEM_NO,ITEM,RECEIVED_ID AS WINNER_ID,RECEIVED AS WINNER from raffletable where not received = '' order by id asc"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "raffletable")
                    End Using
                    bs.DataSource = ds
                    bs.DataMember = "raffletable"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Return bs
            End Using
        End Using
    End Function
    Private Sub formatGV()
        gv.Columns("ITEM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.Columns("WINNER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.Columns("ITEM_NO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gv.Columns("ITEM_NO").Width = 150
    End Sub
End Class