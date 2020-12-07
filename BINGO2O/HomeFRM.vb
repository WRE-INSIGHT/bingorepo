Public Class HomeFRM
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        getConnectionString(TBOXdatasource.Text)
        BingoFRM.Show()
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        getConnectionString(TBOXdatasource.Text)
        RaffleFRM.Show()
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        getConnectionString(TBOXdatasource.Text)
        SongsFRM.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBOXdatasource.SelectedIndex = 1
    End Sub
End Class