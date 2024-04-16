﻿Imports System.Data.SqlClient

Public Class RaffleModel
    Public Property item As String
    Public Property img As String
    Public Property number As String
    Public Property supplier As String
    Public Function searchItem() As RaffleModel
        Try
            Dim raffled As RaffleModel = New RaffleModel
            Using sqlcon As SqlConnection = New SqlConnection(connectionString)
                Dim sql As String = Nothing
                If raffleSearchBy = "Item Number" Then
                    sql = "select item,img,number,supplier from [RAFFLETABLE] where number = '" & raffleSearch & "'"
                ElseIf raffleSearchBy = "Item" Then
                    sql = "select item,img,number,supplier from [RAFFLETABLE] where item = '" & raffleSearch & "'"
                End If
                Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                    sqlcon.Open()
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read

                            raffled.item = rd(0).ToString()
                            raffled.img = rd(1).ToString()
                            raffled.number = rd(2).ToString()
                            raffled.supplier = rd(3).ToString()
                        End While
                    End Using
                    Return raffled
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Function raffleitems() As BindingSource
        Dim bs = New BindingSource
        Dim dt As New DataSet
        dt.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = " select number as item from RAFFLETABLE"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(dt, "item")
                        bs.DataSource = dt
                        bs.DataMember = "item"
                    End Using

                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
                Return bs
            End Using
        End Using
    End Function
End Class
