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
    End Sub
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


End Class