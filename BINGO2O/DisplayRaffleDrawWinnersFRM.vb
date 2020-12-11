
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net

Public Class DisplayRaffleDrawWinnersFRM
    Dim bgw As New BackgroundWorker
    Dim bs As New BindingSource
    Dim action As String
    Dim raffled As RaffleModel = New RaffleModel
    Dim winner As WinnerModel = New WinnerModel

    Dim objImage As MemoryStream
    Dim objwebClient As WebClient
    Dim srcBmp As Bitmap
    Dim totalPages As Integer
    Dim currentPage As Integer = 0


    Private Sub DisplayRaffleDrawWinnersFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_DoWork
        AddHandler bgw.ProgressChanged, AddressOf bgw_Progress
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_Completed
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True

        winnerTXT.DataSource = winner.loademployees()
        winnerTXT.DisplayMember = "employee"
        winnerTXT.ValueMember = "employee"
        searchTxt.DataSource = raffled.raffleitems()
        searchTxt.DisplayMember = "item"
        searchTxt.ValueMember = "item"
        winnerTXT.SelectedIndex = -1
        searchTxt.SelectedIndex = -1
        searchByTxt.SelectedIndex = 0
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy Then
            action = act
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show("I'm busy, try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub formatGV()
        gv.Columns("id").Visible = False
        gv.Columns("number").Visible = False
        gv.Columns("item").Visible = False
        gv.Columns("winner").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub bgw_Completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "search item"
                PictureBox1.Image = srcBmp
                itemLabel.Text = raffled.item

            Case "add winner"

        End Select
    End Sub

    Private Sub bgw_Progress(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "search item"
                If raffled.img = Nothing Then
                    srcBmp = Nothing
                Else
                    loadimage(raffled.img)
                End If
                gv.DataSource = winner.getWinner(raffled.number)
                formatGV()
            Case "add winner"
                gv.DataSource = winner.getWinner(raffled.number)
                formatGV()
            Case "get winner"
                gv.DataSource = winner.getWinner(raffled.number)
                formatGV()
        End Select
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "search item"
                raffled = raffled.searchItem()
                bgw.ReportProgress(0)
            Case "add winner"
                winner.addWinner(winnerStr, raffled.item, raffled.number)
                bgw.ReportProgress(0)
            Case "get winner"
                bgw.ReportProgress(0)
        End Select
    End Sub
    Private Sub buttonclick(sender As Object, e As EventArgs) Handles searchBTN.Click, winnerBTN.Click
        Select Case sender.name
            Case "searchBTN"
                raffleSearchBy = searchByTxt.Text
                raffleSearch = searchTxt.Text
                starter("search item")
            Case "winnerBTN"
                If raffled.item = Nothing Then
                    MessageBox.Show("Please select a raffle item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    winnerStr = winnerTXT.Text
                    starter("add winner")
                End If

        End Select
    End Sub

    Private Function loadimage(ByVal path As String) As Bitmap
        Dim objwebClient As WebClient
        Dim sURL As String = Trim(path)

        objwebClient = New WebClient()
        objImage = New MemoryStream(objwebClient.DownloadData(sURL))
        srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)
        totalPages = CInt(srcBmp.GetFrameCount(FrameDimension.Page) - 1)
        srcBmp.SelectActiveFrame(FrameDimension.Page, currentPage)
        Return srcBmp

    End Function

    Private Sub DisplayRaffleDrawWinnersFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub gv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gv.CellDoubleClick
        If gv.RowCount > 0 And e.RowIndex >= 0 Then
            If MessageBox.Show("delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If
            Dim row As DataGridViewRow = gv.Rows(e.RowIndex)
            Dim x As Integer = winner.removeWinner(row.Cells("id").Value)
            If x > 0 Then
                starter("get winner")
            End If

        End If
    End Sub
End Class