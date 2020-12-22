Imports System.Data.SqlClient

Public Class BingoOption

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        priceSTR = priceTBOX.Text
        patternSTR = patternTBOX.Text
        callSpeedValue = callspeedCbox.Text
        animationSpeedValue = animationspeedCbox.Text
        Me.Close()
    End Sub

    Private Sub BingoOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
        priceTBOX.Text = priceSTR
        patternTBOX.Text = patternSTR
        callspeedCbox.Text = callSpeedValue
        animationspeedCbox.Text = animationSpeedValue

        Dim bs As New BindingSource
        bs.DataSource = getDistinctSet()
        setCbox.DataSource = bs
        setCbox.DisplayMember = "setcount"
        setCbox.ValueMember = "setcount"
        prevPatternTbox.DataBindings.Clear()
        prevPatternTbox.DataBindings.Add("Text", bs, "pattern")
        prevPriceTbox.DataBindings.Clear()
        prevPriceTbox.DataBindings.Add("Text", bs, "price")
    End Sub
    Private Function getDistinctSet() As BindingSource
        Dim bs As New BindingSource
        Dim ds As New DataSet
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select distinct setcount,pattern,price from bingoset"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "bingoset")
                    End Using
                    bs.DataSource = ds
                    bs.DataMember = "bingoset"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Return bs
            End Using
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BingoFRM.reset()
        BingoFRM.ComboBox1.Items.Clear()
        BingoFRM.ComboBox2.Items.Clear()
        BingoFRM.ComboBox3.Items.Clear()
        BingoFRM.ComboBox4.Items.Clear()
        BingoFRM.randomSET = New ArrayList


        Using sqlcon As SqlConnection = New SqlConnection(connectionString)
            Dim sql As String = "select nindex,number from bingoset where setcount = '" & setCbox.SelectedValue & "' order by nindex asc"
            Using sqlcmd As SqlCommand = New SqlCommand(sql, sqlcon)
                Try
                    sqlcon.Open()
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            BingoFRM.ComboBox1.Items.Add(rd(1).ToString())
                            BingoFRM.ComboBox2.Items.Add(rd(1).ToString())
                            BingoFRM.ComboBox3.Items.Add(rd(1).ToString())
                            BingoFRM.randomSET.Add(rd(1).ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        priceSTR = prevPriceTbox.Text
        patternSTR = prevPatternTbox.Text
        saveSet = False
        Me.Close()
    End Sub
End Class