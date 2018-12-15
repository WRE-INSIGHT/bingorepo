Imports System.Data.SqlClient

Public Class Form5
    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=KMDI-ACER-E15\KMDISQLSERVER;Network Library=DBMSSOCN;Initial Catalog=RAFFLEDATA;User ID=kmdiadmin;Password=kmdiadmin;"}
    Dim sqlcmd As SqlCommand
    Private Sub KryptonButton13_Click(sender As Object, e As EventArgs) Handles KryptonButton13.Click
        MYFILL1()
    End Sub
    Public Sub MYFILL1()
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim str As String = "select * from kakanta"
            sqlcmd = New SqlCommand(str, sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "kakanta")
            bs.DataSource = ds
            bs.DataMember = "kakanta"
            KryptonDataGridView3.DataSource = bs
            KryptonDataGridView3.Columns("ANUM").Visible = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton10_Click(sender As Object, e As EventArgs) Handles KryptonButton10.Click
        REMOVE()
        ADDSINGER(ID.Text, EMPLOYEE.Text)
        MYFILL1()
    End Sub
    Public Sub ADDSINGER(ByVal ID As String, ByVal EMP As String)
        Try
            sqlcon.Open()
            Dim ADD = "insert INTO KAKANTA (ID,EMPLOYEE) VALUES('" & ID & "','" & EMP & "')"
            sqlcmd = New SqlCommand(ADD, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Public Sub REMOVE()
        ID.Text = ID.Text.Replace("'", "")
        ID.Text = ID.Text.Replace("""", "")
        EMPLOYEE.Text = EMPLOYEE.Text.Replace("'", "")
        EMPLOYEE.Text = EMPLOYEE.Text.Replace("""", "")
        empout.Text = empout.Text.Replace("'", "")
        empout.Text = empout.Text.Replace("""", "")
        ID.Text = Trim(ID.Text)
        EMPLOYEE.Text = Trim(EMPLOYEE.Text)
        empout.Text = Trim(empout.Text)
        NUMBER.Text = NUMBER.Text.Replace("'", "")
        NUMBER.Text = NUMBER.Text.Replace("""", "")
        TITLE.Text = TITLE.Text.Replace("'", "")
        TITLE.Text = TITLE.Text.Replace("""", "")
        SINGER.Text = SINGER.Text.Replace("'", "")
        SINGER.Text = SINGER.Text.Replace("""", "")
        songout.Text = songout.Text.Replace("'", "")
        songout.Text = songout.Text.Replace("""", "")
        NUMBER.Text = Trim(NUMBER.Text)
        TITLE.Text = Trim(TITLE.Text)
        songout.Text = Trim(songout.Text)
        SINGER.Text = Trim(SINGER.Text)
    End Sub

    Private Sub KryptonButton11_Click(sender As Object, e As EventArgs) Handles KryptonButton11.Click
        REMOVE()
        EDIT(ID.Text, EMPLOYEE.Text, empout.Text)
        MYFILL1()
    End Sub
    Public Sub EDIT(ByVal ID As String, ByVal EMP As String, ByVal out As String)
        Try
            sqlcon.Open()
            Dim ADD = "UPDATE KAKANTA SET ID='" & ID & "',EMPLOYEE='" & EMP & "',out='" & out & "' WHERE ANUM = '" & ANUM.Text & "'"
            sqlcmd = New SqlCommand(ADD, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonDataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView3.CellClick
        If KryptonDataGridView3.RowCount >= 0 And e.RowIndex >= 0 Then
            ANUM.Text = KryptonDataGridView3.Item(0, e.RowIndex).Value.ToString
            ID.Text = KryptonDataGridView3.Item(1, e.RowIndex).Value.ToString
            EMPLOYEE.Text = KryptonDataGridView3.Item(2, e.RowIndex).Value.ToString
            empout.Text = KryptonDataGridView3.Item(3, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonDataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView3.SelectionChanged
        Dim SELECTEDITEMS As DataGridViewSelectedRowCollection = KryptonDataGridView3.SelectedRows
        Dim S As String

        ComboBox1.Items.Clear()

        For Each SELECTEDITEM As DataGridViewRow In SELECTEDITEMS
            S = SELECTEDITEM.Cells("ANUM").Value.ToString

            ComboBox1.Items.Add(S)

        Next
    End Sub

    Private Sub KryptonButton12_Click(sender As Object, e As EventArgs) Handles KryptonButton12.Click
        REMOVE()
        For I As Integer = 0 To ComboBox1.Items.Count - 1
            Dim X As String = ComboBox1.Items(I)
            DELETE(X)
        Next
        MYFILL1()
    End Sub
    Public Sub DELETE(ByVal X As String)
        Try
            sqlcon.Open()
            Dim ADD = "DELETE KAKANTA WHERE ANUM = '" & X & "'"
            sqlcmd = New SqlCommand(ADD, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NToolStripMenuItem.Click

        TabControl1.SelectedTab = TabPage2
        MYFILL1()
        MYFILL2()
        ProgressBar3.Value = 0
        ProgressBar2.Value = 0
        ProgressBar1.Value = 0
        ProgressBar2.Maximum = 13
        Dim range = Enumerable.Range(0, 14).ToList()
        Dim myrandom As New Random()
        Dim mynum As Integer
        For i As Integer = 1 To 13
            mynum = myrandom.Next(1, range.Count)
            ComboBox3.Items.Add(range(mynum))
            range.RemoveAt(mynum)
        Next

        KryptonDataGridView3.SelectAll()
        Dim selecteditems2 As DataGridViewSelectedRowCollection = KryptonDataGridView3.SelectedRows
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox7.Text = ""
        Dim c2 As String
        Dim rec2 As String
        For Each selecteditem As DataGridViewRow In selecteditems2
            c2 = selecteditem.Cells("ID").Value.ToString
            rec2 = selecteditem.Cells("OUT").Value.ToString
            If rec2 = "" Then
                ComboBox6.Items.Add(c2)
            Else
            End If
        Next
        Dim h2 = Enumerable.Range(0, ComboBox6.Items.Count).ToList()
        Dim j2 As New Random()
        Dim k2 As Integer
        For i2 As Integer = 0 To ComboBox6.Items.Count - 1
            k2 = j2.Next(0, h2.Count)
            ComboBox7.Items.Add(ComboBox6.Items(h2(k2)))
            h2.RemoveAt(k2)
        Next
        ProgressBar3.Maximum = ComboBox6.Items.Count


        KryptonDataGridView1.SelectAll()
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox5.Text = ""
        Dim c As String
        Dim rec As String
        For Each selecteditem As DataGridViewRow In selecteditems
            c = selecteditem.Cells("NUMBER").Value.ToString
            rec = selecteditem.Cells("OUT").Value.ToString
            If rec = "" Then
                ComboBox4.Items.Add(c)
            Else
            End If
        Next
        Dim h = Enumerable.Range(0, ComboBox4.Items.Count).ToList()
        Dim j As New Random()
        Dim k As Integer
        For i As Integer = 0 To ComboBox4.Items.Count - 1
            k = j.Next(0, h.Count)
            ComboBox5.Items.Add(ComboBox4.Items(h(k)))
            h.RemoveAt(k)
        Next
        ProgressBar1.Maximum = ComboBox4.Items.Count
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYFILL1()
        MYFILL2()
    End Sub

    Private Sub KryptonButton9_Click(sender As Object, e As EventArgs) Handles KryptonButton9.Click
        KryptonLabel4.Text = ""
        NToolStripMenuItem.PerformClick()
        KryptonLabel3.Text = ""
        ProgressBar3.Increment(1)
        ComboBox7.SelectedIndex = ProgressBar3.Value - 1
        search(ComboBox7.Text)
        BeLazy()
        Timer1.Start()
        Timer1.Interval = 100

    End Sub
    Public Sub BeLazy()
        For i = 1 To 15
            Threading.Thread.Sleep(17)
            Application.DoEvents()
        Next
    End Sub
    Public Sub search(ByVal number As String)
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim search As String = "select * from KAKANTA where ID ='" & number & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(search, sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "KAKANTA")
            bs.DataSource = ds
            bs.DataMember = "KAKANTA"
            KryptonLabel4.DataBindings.Clear()
            KryptonLabel4.DataBindings.Add("text", bs, "EMPLOYEE")
            If KryptonLabel4.Text = "" Then
                KryptonLabel4.Text = "0 RESULT"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Public Sub search2(ByVal number As String)
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim search As String = "select * from SONG where NUMBER ='" & number & "'"
            Dim sqlcmd As SqlCommand = New SqlCommand(search, sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "SONG")
            bs.DataSource = ds
            bs.DataMember = "SONG"
            KryptonLabel9.DataBindings.Clear()
            KryptonLabel14.DataBindings.Clear()
            KryptonLabel9.DataBindings.Add("text", bs, "title")
            KryptonLabel14.DataBindings.Add("text", bs, "SINGER")
            If KryptonLabel9.Text = "" Then
                KryptonLabel9.Text = "0 RESULT"
                KryptonLabel14.Text = "ARTIST"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(1)
        ComboBox3.SelectedIndex = ProgressBar2.Value - 1
        KryptonLabel5.Text = ComboBox3.Text
        If KryptonLabel5.Text = 1 Then
            KryptonLabel5.Text = "sknvjhd gjhcdj"
        ElseIf KryptonLabel5.Text = 2 Then
            KryptonLabel5.Text = "hdhfbh dfgfdtswq"
        ElseIf KryptonLabel5.Text = 3 Then
            KryptonLabel5.Text = "qaweqcx cgfbcv"
        ElseIf KryptonLabel5.Text = 4 Then
            KryptonLabel5.Text = "vdzeertv cvcvbcvb"
        ElseIf KryptonLabel5.Text = 5 Then
            KryptonLabel5.Text = "xfgfggbffvsd hjgnd"
        ElseIf KryptonLabel5.Text = 6 Then
            KryptonLabel5.Text = "fxcvbgh bnhgjj"
        ElseIf KryptonLabel5.Text = 7 Then
            KryptonLabel5.Text = "axzazcds opojukm"
        ElseIf KryptonLabel5.Text = 8 Then
            KryptonLabel5.Text = "ioopkjjj vhjhgjh"
        ElseIf KryptonLabel5.Text = 9 Then
            KryptonLabel5.Text = "pllkkopi mkomkyk"
        ElseIf KryptonLabel5.Text = 10 Then
            KryptonLabel5.Text = "dthnrts dfgbdbt"
        ElseIf KryptonLabel5.Text = 11 Then
            KryptonLabel5.Text = "ehbtnv awerryn"
        ElseIf KryptonLabel5.Text = 12 Then
            KryptonLabel5.Text = "bvb jhhghjjhyu"
        ElseIf KryptonLabel5.Text = 13 Then
            KryptonLabel5.Text = "fghhfcxc bnnnmjh"
        End If
        KryptonLabel3.Text = KryptonLabel5.Text
        If ProgressBar2.Value = 13 Then
            Timer1.Stop()
            KryptonLabel5.Text = ComboBox7.Text
            ProgressBar2.Value = 0
            Dim mystr As String = KryptonLabel4.Text
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            KryptonLabel3.Text = mystr
        End If
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        MYFILL2()
    End Sub
    Public Sub MYFILL2()
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim str As String = "select * from SONG"
            sqlcmd = New SqlCommand(str, sqlcon)
            da.SelectCommand = sqlcmd
            da.Fill(ds, "SONG")
            bs.DataSource = ds
            bs.DataMember = "SONG"
            KryptonDataGridView1.DataSource = bs
            KryptonDataGridView1.Columns("ANUM").Visible = False
            With KryptonDataGridView1
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        REMOVE()
        NEWSONG(NUMBER.Text, TITLE.Text, SINGER.Text)
        MYFILL2()
    End Sub
    Public Sub NEWSONG(ByVal NUMBER As String, ByVal TITLE As String, ByVal SINGER As String)
        Try
            sqlcon.Open()
            Dim STR As String = "INSERT INTO SONG (NUMBER,TITLE,SINGER)VALUES('" & NUMBER & "','" & TITLE & "','" & SINGER & "')"
            sqlcmd = New SqlCommand(STR, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        REMOVE()
        UPDATESONG(TITLE.Text, NUMBER.Text, SINGER.Text, songout.Text)
        MYFILL2()
    End Sub
    Public Sub UPDATESONG(ByVal TITLE As String, ByVal NUMBER As String, ByVal SINGER As String, ByVal out As String)
        Try
            sqlcon.Open()
            Dim STR As String = "UPDATE SONG SET NUMBER='" & NUMBER & "',TITLE='" & TITLE & "',SINGER='" & SINGER & "',out='" & out & "' WHERE ANUM = '" & anum2.Text & "'"
            sqlcmd = New SqlCommand(STR, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView1.CellClick
        If KryptonDataGridView1.RowCount >= 0 And e.RowIndex >= 0 Then
            anum2.Text = KryptonDataGridView1.Item(0, e.RowIndex).Value.ToString
            NUMBER.Text = KryptonDataGridView1.Item(1, e.RowIndex).Value.ToString
            TITLE.Text = KryptonDataGridView1.Item(2, e.RowIndex).Value.ToString
            SINGER.Text = KryptonDataGridView1.Item(3, e.RowIndex).Value.ToString
            songout.Text = KryptonDataGridView1.Item(4, e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub KryptonDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView1.SelectionChanged
        Dim SELECTEDITEMS As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        ComboBox2.Items.Clear()
        Dim X As String
        For Each SELECTEDITEM As DataGridViewRow In SELECTEDITEMS
            X = SELECTEDITEM.Cells("ANUM").Value.ToString
            ComboBox2.Items.Add(X)
        Next
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        REMOVE()
        For I As Integer = 0 To ComboBox2.Items.Count - 1
            Dim X As String = ComboBox2.Items(I)
            DELETESONG(X)
        Next
        MYFILL2()
    End Sub
    Public Sub DELETESONG(ByVal X As String)
        Try
            sqlcon.Open()
            Dim STR As String = "DELETE FROM SONG WHERE ANUM = '" & X & "'"
            sqlcmd = New SqlCommand(STR, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        KryptonLabel9.Text = ""
        KryptonLabel10.Text = "0000"
        KryptonLabel11.Text = ""
        KryptonLabel14.Text = "ARTIST"
        NToolStripMenuItem.PerformClick()
        ProgressBar1.Increment(1)
        ComboBox5.SelectedIndex = ProgressBar1.Value - 1
        search2(ComboBox5.Text)
        BeLazy()

        Timer2.Start()
        Timer2.Interval = 100

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        ComboBox3.SelectedIndex = ProgressBar2.Value - 1
        KryptonLabel10.Text = ComboBox3.Text
        If ProgressBar2.Value = 13 Then
            Timer2.Stop()
            KryptonLabel10.Text = ComboBox5.Text
            ProgressBar2.Value = 0
            Dim mystr As String = KryptonLabel9.Text
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            KryptonLabel11.Text = mystr
        End If
    End Sub

    Private Sub KryptonButton6_Click(sender As Object, e As EventArgs) Handles KryptonButton6.Click
        If MessageBox.Show("Remove From List", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Try
            sqlcon.Open()
            Dim str As String = "update kakanta set out = 'yes' where id = '" & KryptonLabel5.Text & "'"
            sqlcmd = New SqlCommand(str, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
            KryptonLabel3.Text = ""
        End Try
        NToolStripMenuItem.PerformClick()
    End Sub

    Private Sub KryptonButton7_Click(sender As Object, e As EventArgs) Handles KryptonButton7.Click
        If MessageBox.Show("Remove From List", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Try
            sqlcon.Open()
            Dim str As String = "update song set out = 'yes' where number = '" & KryptonLabel10.Text & "'"
            sqlcmd = New SqlCommand(str, sqlcon)
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
            KryptonLabel10.Text = "0000"
            KryptonLabel11.Text = ""
            KryptonLabel14.Text = "ARTIST"
        End Try
        NToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub KryptonDataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles KryptonDataGridView1.RowPostPaint
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class