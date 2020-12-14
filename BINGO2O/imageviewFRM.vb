Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class imageviewFRM
    Dim objImage As MemoryStream
    Dim objwebClient As WebClient
    Dim srcBmp As Bitmap
    Dim totalPages As Integer
    Dim currentPage As Integer = 0
    Private Sub imageviewFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadimagetopicturebox(RaffleFRM.selectedpath, PictureBox1)
        serialTBOX.DataSource = serialList()
        serialTBOX.DisplayMember = "serial"
        serialTBOX.ValueMember = "serial"
        serialTBOX.SelectedIndex = -1

    End Sub
    Public Function getwinner() As String
        Dim str = Nothing
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Using sqlcmd As SqlCommand = New SqlCommand("select RECEIVED from RAFFLETABLE where number = '" & rafflenumber & "'", sqlcon)
                sqlcon.Open()
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    If (rd.HasRows) Then
                        While rd.Read
                            str = "WINNER: " + rd(0).ToString()
                        End While
                    Else
                        str = ""
                    End If
                End Using
            End Using
        End Using
        Return str
    End Function
    Public Sub loadimagetopicturebox(ByVal path As String, ByVal ob As Object)
        Dim objwebClient As WebClient
        Dim sURL As String = Trim(path)
        Try
            objwebClient = New WebClient()
            objImage = New MemoryStream(objwebClient.DownloadData(sURL))
            srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)
            totalPages = CInt(srcBmp.GetFrameCount(FrameDimension.Page) - 1)
            srcBmp.SelectActiveFrame(FrameDimension.Page, currentPage)
            ob.Image = srcBmp
        Catch ex As Exception
        End Try
    End Sub
    Private Sub imageviewFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If employeeLBL.Text = Nothing Or employeeLBL.Text = "0 result found" Or employeeLBL.Text = "select a winner" Or employeeLBL.Text = "" Then
            MessageBox.Show("select a winner", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            RaffleFRM.receiverTBOX.Text = employeeName
            RaffleFRM.KryptonButton4.PerformClick()
            winnerLBL.Text = getwinner()
            employeeLBL.Text = ""
        End If
    End Sub
    Private Function serialList() As BindingSource
        Dim bs As New BindingSource
        Dim ds As DataSet = New DataSet()
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Using sqlcmd As SqlCommand = New SqlCommand("select serial from checker", sqlcon)
                sqlcon.Open()
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    da.SelectCommand = sqlcmd
                    da.Fill(ds, "checker")
                    bs.DataSource = ds
                    bs.DataMember = "checker"
                End Using
            End Using
        End Using
        Return bs
    End Function
    Private Sub checkBTN_Click(sender As Object, e As EventArgs) Handles checkBTN.Click
        employeeSerial = serialTBOX.Text
        employeeName = verifySerial()
        employeeLBL.Text = employeeName
    End Sub

    Private Function verifySerial() As String
        Dim str As String = Nothing
        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Using sqlcmd As SqlCommand = New SqlCommand("select isnull(employee,'') from checker where serial = '" & employeeSerial & "'", sqlcon)
                sqlcon.Open()
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    If (rd.HasRows) Then
                        While rd.Read
                            str = rd(0).ToString()
                        End While
                    Else
                        str = "0 result found"
                    End If
                End Using
            End Using
        End Using
        Return str
    End Function
End Class