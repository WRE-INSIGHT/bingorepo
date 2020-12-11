Imports System.Data.SqlClient

Public Class WinnerModel
    Private id As Integer
    Private winner As String
    Private item As String
    Private number As String
    Public Function getWinner(ByVal number As String) As BindingSource
        Dim bs As New BindingSource
        Dim ds As New DataSet
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select * from winnerTB where number = '" & number & "'"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "winnerTB")
                    End Using
                    bs.DataSource = ds
                    bs.DataMember = "winnerTB"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Return bs
            End Using
        End Using
    End Function

    Public Function addWinner(ByVal w As String, ByVal i As String, ByVal n As String) As Integer
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "insert into winnertb (winner,item,number) values ('" & w & "','" & i & "','" & n & "')"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                sqlcon.Open()
                Return sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function removeWinner(ByVal i As Integer) As Integer
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "delete from winnertb where id = " & i & ""
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                sqlcon.Open()
                Return sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function loademployees() As BindingSource
        Dim bs = New BindingSource
        Dim dt As New DataSet
        dt.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Using sqlcmd As SqlCommand = New SqlCommand("select employee from checker", sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(dt, "checker")
                        bs.DataSource = dt
                        bs.DataMember = "checker"
                    End Using

                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
                Return bs
            End Using
        End Using
    End Function
End Class
