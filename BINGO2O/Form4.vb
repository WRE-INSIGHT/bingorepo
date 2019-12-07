Imports System.Data.SqlClient

Public Class Form4
    Public sqlcon As New SqlConnection With {.ConnectionString = "Data Source=KMDI-ACER-E15\KMDISQLSERVER;Network Library=DBMSSOCN;Initial Catalog=RAFFLEDATA;User ID=kmdiadmin;Password=kmdiadmin;"}
    Dim SQLCMD As SqlCommand
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        TXTCOMBO()
    End Sub
    Public Sub TXTCOMBO()
        Try
            sqlcon.Open()
            Dim DS As New DataSet
            Dim DA As New SqlDataAdapter
            Dim BS As New BindingSource
            DS.Clear()
            Dim S As String = "SELECT DISTINCT(SERIAL) FROM checker"
            SQLCMD = New SqlCommand(S, sqlcon)
            DA.SelectCommand = SQLCMD
            DA.Fill(DS, "checker")
            BS.DataSource = DS
            BS.DataMember = "checker"
            TXT.DataSource = BS
            TXT.ValueMember = "SERIAL"
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Public Sub REMOVE()
        B1.Text = B1.Text.Replace("'", "")
        B1.Text = B1.Text.Replace("""", "")
        B2.Text = B2.Text.Replace("'", "")
        B2.Text = B2.Text.Replace("""", "")
        B3.Text = B3.Text.Replace("'", "")
        B3.Text = B3.Text.Replace("""", "")
        B4.Text = B4.Text.Replace("'", "")
        B4.Text = B4.Text.Replace("""", "")
        B5.Text = B5.Text.Replace("'", "")
        B5.Text = B5.Text.Replace("""", "")

        I1.Text = I1.Text.Replace("'", "")
        I1.Text = I1.Text.Replace("""", "")
        I2.Text = I2.Text.Replace("'", "")
        I2.Text = I2.Text.Replace("""", "")
        I3.Text = I3.Text.Replace("'", "")
        I3.Text = I3.Text.Replace("""", "")
        I4.Text = I4.Text.Replace("'", "")
        I4.Text = I4.Text.Replace("""", "")
        I5.Text = I5.Text.Replace("'", "")
        I5.Text = I5.Text.Replace("""", "")


        N1.Text = N1.Text.Replace("'", "")
        N1.Text = N1.Text.Replace("""", "")
        N2.Text = N2.Text.Replace("'", "")
        N2.Text = N2.Text.Replace("""", "")

        N4.Text = N4.Text.Replace("'", "")
        N4.Text = N4.Text.Replace("""", "")
        N5.Text = N5.Text.Replace("'", "")
        N5.Text = N5.Text.Replace("""", "")

        G1.Text = G1.Text.Replace("'", "")
        G1.Text = G1.Text.Replace("""", "")
        G2.Text = G2.Text.Replace("'", "")
        G2.Text = G2.Text.Replace("""", "")
        G3.Text = G3.Text.Replace("'", "")
        G3.Text = G3.Text.Replace("""", "")
        G4.Text = G4.Text.Replace("'", "")
        G4.Text = G4.Text.Replace("""", "")
        G5.Text = G5.Text.Replace("'", "")
        G5.Text = G5.Text.Replace("""", "")

        O1.Text = O1.Text.Replace("'", "")
        O1.Text = O1.Text.Replace("""", "")
        O2.Text = O2.Text.Replace("'", "")
        O2.Text = O2.Text.Replace("""", "")
        O3.Text = O3.Text.Replace("'", "")
        O3.Text = O3.Text.Replace("""", "")
        O4.Text = O4.Text.Replace("'", "")
        O4.Text = O4.Text.Replace("""", "")
        O5.Text = O5.Text.Replace("'", "")
        O5.Text = O5.Text.Replace("""", "")

        SERIAL.Text = SERIAL.Text.Replace("'", "")
        SERIAL.Text = SERIAL.Text.Replace("""", "")
        employee.Text = employee.Text.Replace("'", "")
        employee.Text = employee.Text.Replace("""", "")
        type.Text = type.Text.Replace("'", "")
        type.Text = type.Text.Replace("""", "")
        SERIAL.Text = Trim(SERIAL.Text)
        employee.Text = Trim(employee.Text)
        type.Text = Trim(type.Text)
        B1.Text = Trim(B1.Text)
        B2.Text = Trim(B2.Text)
        B3.Text = Trim(B3.Text)
        B4.Text = Trim(B4.Text)
        B5.Text = Trim(B5.Text)

        I1.Text = Trim(I1.Text)
        I2.Text = Trim(I2.Text)
        I3.Text = Trim(I3.Text)
        I4.Text = Trim(I4.Text)
        I5.Text = Trim(I5.Text)

        N1.Text = Trim(N1.Text)
        N2.Text = Trim(N2.Text)
        N4.Text = Trim(N4.Text)
        N5.Text = Trim(N5.Text)

        G1.Text = Trim(G1.Text)
        G2.Text = Trim(G2.Text)
        G3.Text = Trim(G3.Text)
        G4.Text = Trim(G4.Text)
        G5.Text = Trim(G5.Text)

        O1.Text = Trim(O1.Text)
        O2.Text = Trim(O2.Text)
        O3.Text = Trim(O3.Text)
        O4.Text = Trim(O4.Text)
        O5.Text = Trim(O5.Text)
    End Sub

    Private Sub KryptonButton141_Click(sender As Object, e As EventArgs) Handles KryptonButton141.Click
        If MessageBox.Show("click yes to continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("operation cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Try
            REMOVE()
            sqlcon.Open()
            Dim STR As String = " INSERT INTO checker (SERIAL,EMPLOYEE,TYPE,
B1,
B2,
B3,
B4,
B5,
I1,
I2,
I3,
I4,
I5,
N1,
N2,
N4,
N5,
G1,
G2,
G3,
G4,
G5,
O1,
O2,
O3,
O4,
O5) VALUES(
'" & SERIAL.Text & "'," &
 "'" & employee.Text & "'," &
  "'" & type.Text & "'," &
  "'" & B1.Text & "'," &
  "'" & B2.Text & "'," &
  "'" & B3.Text & "'," &
  "'" & B4.Text & "'," &
  "'" & B5.Text & "'," &
  "'" & I1.Text & "'," &
  "'" & I2.Text & "'," &
  "'" & I3.Text & "'," &
  "'" & I4.Text & "'," &
  "'" & I5.Text & "'," &
  "'" & N1.Text & "'," &
  "'" & N2.Text & "'," &
  "'" & N4.Text & "'," &
  "'" & N5.Text & "'," &
  "'" & G1.Text & "'," &
  "'" & G2.Text & "'," &
  "'" & G3.Text & "'," &
  "'" & G4.Text & "'," &
  "'" & G5.Text & "'," &
  "'" & O1.Text & "'," &
  "'" & O2.Text & "'," &
  "'" & O3.Text & "'," &
  "'" & O4.Text & "'," &
  "'" & O5.Text & "')"
            SQLCMD = New SqlCommand(STR, sqlcon)
            SQLCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
        loaddata()
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        If TXT.Text = "" Then
        Else

            Try
                sqlcon.Open()
                Dim DS As New DataSet
                Dim da As New SqlDataAdapter
                Dim bs As New BindingSource
                DS.Clear()
                Dim STR As String = "SELECT * FROM checker WHERE SERIAL = '" & TXT.Text & "'"
                SQLCMD = New SqlCommand(STR, sqlcon)
                da.SelectCommand = SQLCMD
                da.Fill(DS, "checker")
                bs.DataSource = DS
                bs.DataMember = "checker"
                EMPNAME.DataBindings.Clear()
                EMPNAME.DataBindings.Add("TEXT", bs, "EMPLOYEE")

                a11.DataBindings.Clear()
                a11.DataBindings.Add("text", bs, "b1")
                a22.DataBindings.Clear()
                a22.DataBindings.Add("text", bs, "b2")
                a33.DataBindings.Clear()
                a33.DataBindings.Add("text", bs, "b3")
                a44.DataBindings.Clear()
                a44.DataBindings.Add("text", bs, "b4")
                a55.DataBindings.Clear()
                a55.DataBindings.Add("text", bs, "b5")

                b11.DataBindings.Clear()
                b11.DataBindings.Add("text", bs, "i1")
                b22.DataBindings.Clear()
                b22.DataBindings.Add("text", bs, "i2")
                b33.DataBindings.Clear()
                b33.DataBindings.Add("text", bs, "i3")
                b44.DataBindings.Clear()
                b44.DataBindings.Add("text", bs, "i4")
                b55.DataBindings.Clear()
                b55.DataBindings.Add("text", bs, "i5")

                c11.DataBindings.Clear()
                c11.DataBindings.Add("text", bs, "n1")
                c22.DataBindings.Clear()
                c22.DataBindings.Add("text", bs, "n2")

                c44.DataBindings.Clear()
                c44.DataBindings.Add("text", bs, "n4")
                c55.DataBindings.Clear()
                c55.DataBindings.Add("text", bs, "n5")

                d11.DataBindings.Clear()
                d11.DataBindings.Add("text", bs, "g1")
                d22.DataBindings.Clear()
                d22.DataBindings.Add("text", bs, "g2")
                d33.DataBindings.Clear()
                d33.DataBindings.Add("text", bs, "g3")
                d44.DataBindings.Clear()
                d44.DataBindings.Add("text", bs, "g4")
                d55.DataBindings.Clear()
                d55.DataBindings.Add("text", bs, "g5")

                e11.DataBindings.Clear()
                e11.DataBindings.Add("text", bs, "o1")
                e22.DataBindings.Clear()
                e22.DataBindings.Add("text", bs, "o2")
                e33.DataBindings.Clear()
                e33.DataBindings.Add("text", bs, "o3")
                e44.DataBindings.Clear()
                e44.DataBindings.Add("text", bs, "o4")
                e55.DataBindings.Clear()
                e55.DataBindings.Add("text", bs, "o5")

                checked()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                sqlcon.Close()
            End Try
        End If
    End Sub
    Public Sub checked()
        If a11.Text = 1 And Form1.KryptonCheckButton1.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 2 And Form1.KryptonCheckButton2.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 3 And Form1.KryptonCheckButton3.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 4 And Form1.KryptonCheckButton4.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 5 And Form1.KryptonCheckButton5.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 6 And Form1.KryptonCheckButton6.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 7 And Form1.KryptonCheckButton7.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 8 And Form1.KryptonCheckButton8.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 9 And Form1.KryptonCheckButton9.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 10 And Form1.KryptonCheckButton10.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 11 And Form1.KryptonCheckButton11.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 12 And Form1.KryptonCheckButton12.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 13 And Form1.KryptonCheckButton13.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 14 And Form1.KryptonCheckButton14.Checked = True Then
            a11.Checked = True
        ElseIf a11.Text = 15 And Form1.KryptonCheckButton15.Checked = True Then
            a11.Checked = True
        Else
            a11.Checked = False
        End If

        If a22.Text = 1 And Form1.KryptonCheckButton1.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 2 And Form1.KryptonCheckButton2.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 3 And Form1.KryptonCheckButton3.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 4 And Form1.KryptonCheckButton4.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 5 And Form1.KryptonCheckButton5.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 6 And Form1.KryptonCheckButton6.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 7 And Form1.KryptonCheckButton7.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 8 And Form1.KryptonCheckButton8.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 9 And Form1.KryptonCheckButton9.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 10 And Form1.KryptonCheckButton10.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 11 And Form1.KryptonCheckButton11.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 12 And Form1.KryptonCheckButton12.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 13 And Form1.KryptonCheckButton13.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 14 And Form1.KryptonCheckButton14.Checked = True Then
            a22.Checked = True
        ElseIf a22.Text = 15 And Form1.KryptonCheckButton15.Checked = True Then
            a22.Checked = True
        Else
            a22.Checked = False
        End If

        If a33.Text = 1 And Form1.KryptonCheckButton1.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 2 And Form1.KryptonCheckButton2.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 3 And Form1.KryptonCheckButton3.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 4 And Form1.KryptonCheckButton4.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 5 And Form1.KryptonCheckButton5.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 6 And Form1.KryptonCheckButton6.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 7 And Form1.KryptonCheckButton7.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 8 And Form1.KryptonCheckButton8.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 9 And Form1.KryptonCheckButton9.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 10 And Form1.KryptonCheckButton10.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 11 And Form1.KryptonCheckButton11.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 12 And Form1.KryptonCheckButton12.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 13 And Form1.KryptonCheckButton13.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 14 And Form1.KryptonCheckButton14.Checked = True Then
            a33.Checked = True
        ElseIf a33.Text = 15 And Form1.KryptonCheckButton15.Checked = True Then
            a33.Checked = True
        Else
            a33.Checked = False
        End If

        If a44.Text = 1 And Form1.KryptonCheckButton1.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 2 And Form1.KryptonCheckButton2.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 3 And Form1.KryptonCheckButton3.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 4 And Form1.KryptonCheckButton4.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 5 And Form1.KryptonCheckButton5.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 6 And Form1.KryptonCheckButton6.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 7 And Form1.KryptonCheckButton7.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 8 And Form1.KryptonCheckButton8.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 9 And Form1.KryptonCheckButton9.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 10 And Form1.KryptonCheckButton10.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 11 And Form1.KryptonCheckButton11.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 12 And Form1.KryptonCheckButton12.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 13 And Form1.KryptonCheckButton13.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 14 And Form1.KryptonCheckButton14.Checked = True Then
            a44.Checked = True
        ElseIf a44.Text = 15 And Form1.KryptonCheckButton15.Checked = True Then
            a44.Checked = True
        Else
            a44.Checked = False
        End If

        If a55.Text = 1 And Form1.KryptonCheckButton1.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 2 And Form1.KryptonCheckButton2.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 3 And Form1.KryptonCheckButton3.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 4 And Form1.KryptonCheckButton4.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 5 And Form1.KryptonCheckButton5.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 6 And Form1.KryptonCheckButton6.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 7 And Form1.KryptonCheckButton7.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 8 And Form1.KryptonCheckButton8.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 9 And Form1.KryptonCheckButton9.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 10 And Form1.KryptonCheckButton10.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 11 And Form1.KryptonCheckButton11.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 12 And Form1.KryptonCheckButton12.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 13 And Form1.KryptonCheckButton13.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 14 And Form1.KryptonCheckButton14.Checked = True Then
            a55.Checked = True
        ElseIf a55.Text = 15 And Form1.KryptonCheckButton15.Checked = True Then
            a55.Checked = True
        Else
            a55.Checked = False
        End If


        If b11.Text = 16 And Form1.KryptonCheckButton16.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 17 And Form1.KryptonCheckButton17.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 18 And Form1.KryptonCheckButton18.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 19 And Form1.KryptonCheckButton19.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 20 And Form1.KryptonCheckButton20.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 21 And Form1.KryptonCheckButton21.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 22 And Form1.KryptonCheckButton22.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 23 And Form1.KryptonCheckButton23.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 24 And Form1.KryptonCheckButton24.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 25 And Form1.KryptonCheckButton25.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 26 And Form1.KryptonCheckButton26.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 27 And Form1.KryptonCheckButton27.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 28 And Form1.KryptonCheckButton28.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 29 And Form1.KryptonCheckButton29.Checked = True Then
            b11.Checked = True
        ElseIf b11.Text = 30 And Form1.KryptonCheckButton30.Checked = True Then
            b11.Checked = True
        Else
            b11.Checked = False
        End If

        If b22.Text = 16 And Form1.KryptonCheckButton16.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 17 And Form1.KryptonCheckButton17.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 18 And Form1.KryptonCheckButton18.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 19 And Form1.KryptonCheckButton19.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 20 And Form1.KryptonCheckButton20.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 21 And Form1.KryptonCheckButton21.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 22 And Form1.KryptonCheckButton22.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 23 And Form1.KryptonCheckButton23.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 24 And Form1.KryptonCheckButton24.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 25 And Form1.KryptonCheckButton25.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 26 And Form1.KryptonCheckButton26.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 27 And Form1.KryptonCheckButton27.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 28 And Form1.KryptonCheckButton28.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 29 And Form1.KryptonCheckButton29.Checked = True Then
            b22.Checked = True
        ElseIf b22.Text = 30 And Form1.KryptonCheckButton30.Checked = True Then
            b22.Checked = True
        Else
            b22.Checked = False
        End If


        If b33.Text = 16 And Form1.KryptonCheckButton16.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 17 And Form1.KryptonCheckButton17.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 18 And Form1.KryptonCheckButton18.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 19 And Form1.KryptonCheckButton19.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 20 And Form1.KryptonCheckButton20.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 21 And Form1.KryptonCheckButton21.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 22 And Form1.KryptonCheckButton22.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 23 And Form1.KryptonCheckButton23.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 24 And Form1.KryptonCheckButton24.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 25 And Form1.KryptonCheckButton25.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 26 And Form1.KryptonCheckButton26.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 27 And Form1.KryptonCheckButton27.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 28 And Form1.KryptonCheckButton28.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 29 And Form1.KryptonCheckButton29.Checked = True Then
            b33.Checked = True
        ElseIf b33.Text = 30 And Form1.KryptonCheckButton30.Checked = True Then
            b33.Checked = True
        Else
            b33.Checked = False
        End If

        If b44.Text = 16 And Form1.KryptonCheckButton16.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 17 And Form1.KryptonCheckButton17.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 18 And Form1.KryptonCheckButton18.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 19 And Form1.KryptonCheckButton19.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 20 And Form1.KryptonCheckButton20.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 21 And Form1.KryptonCheckButton21.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 22 And Form1.KryptonCheckButton22.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 23 And Form1.KryptonCheckButton23.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 24 And Form1.KryptonCheckButton24.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 25 And Form1.KryptonCheckButton25.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 26 And Form1.KryptonCheckButton26.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 27 And Form1.KryptonCheckButton27.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 28 And Form1.KryptonCheckButton28.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 29 And Form1.KryptonCheckButton29.Checked = True Then
            b44.Checked = True
        ElseIf b44.Text = 30 And Form1.KryptonCheckButton30.Checked = True Then
            b44.Checked = True
        Else
            b44.Checked = False
        End If

        If b55.Text = 16 And Form1.KryptonCheckButton16.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 17 And Form1.KryptonCheckButton17.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 18 And Form1.KryptonCheckButton18.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 19 And Form1.KryptonCheckButton19.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 20 And Form1.KryptonCheckButton20.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 21 And Form1.KryptonCheckButton21.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 22 And Form1.KryptonCheckButton22.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 23 And Form1.KryptonCheckButton23.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 24 And Form1.KryptonCheckButton24.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 25 And Form1.KryptonCheckButton25.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 26 And Form1.KryptonCheckButton26.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 27 And Form1.KryptonCheckButton27.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 28 And Form1.KryptonCheckButton28.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 29 And Form1.KryptonCheckButton29.Checked = True Then
            b55.Checked = True
        ElseIf b55.Text = 30 And Form1.KryptonCheckButton30.Checked = True Then
            b55.Checked = True
        Else
            b55.Checked = False
        End If

        If c11.Text = 31 And Form1.KryptonCheckButton31.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 32 And Form1.KryptonCheckButton32.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 33 And Form1.KryptonCheckButton33.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 34 And Form1.KryptonCheckButton34.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 35 And Form1.KryptonCheckButton35.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 36 And Form1.KryptonCheckButton36.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 37 And Form1.KryptonCheckButton37.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 38 And Form1.KryptonCheckButton38.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 39 And Form1.KryptonCheckButton39.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 40 And Form1.KryptonCheckButton40.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 41 And Form1.KryptonCheckButton41.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 42 And Form1.KryptonCheckButton42.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 43 And Form1.KryptonCheckButton43.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 44 And Form1.KryptonCheckButton44.Checked = True Then
            c11.Checked = True
        ElseIf c11.Text = 45 And Form1.KryptonCheckButton45.Checked = True Then
            c11.Checked = True
        Else
            c11.Checked = False
        End If

        If c22.Text = 31 And Form1.KryptonCheckButton31.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 32 And Form1.KryptonCheckButton32.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 33 And Form1.KryptonCheckButton33.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 34 And Form1.KryptonCheckButton34.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 35 And Form1.KryptonCheckButton35.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 36 And Form1.KryptonCheckButton36.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 37 And Form1.KryptonCheckButton37.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 38 And Form1.KryptonCheckButton38.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 39 And Form1.KryptonCheckButton39.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 40 And Form1.KryptonCheckButton40.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 41 And Form1.KryptonCheckButton41.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 42 And Form1.KryptonCheckButton42.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 43 And Form1.KryptonCheckButton43.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 44 And Form1.KryptonCheckButton44.Checked = True Then
            c22.Checked = True
        ElseIf c22.Text = 45 And Form1.KryptonCheckButton45.Checked = True Then
            c22.Checked = True
        Else
            c22.Checked = False
        End If

        If c44.Text = 31 And Form1.KryptonCheckButton31.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 32 And Form1.KryptonCheckButton32.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 33 And Form1.KryptonCheckButton33.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 34 And Form1.KryptonCheckButton34.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 35 And Form1.KryptonCheckButton35.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 36 And Form1.KryptonCheckButton36.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 37 And Form1.KryptonCheckButton37.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 38 And Form1.KryptonCheckButton38.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 39 And Form1.KryptonCheckButton39.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 40 And Form1.KryptonCheckButton40.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 41 And Form1.KryptonCheckButton41.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 42 And Form1.KryptonCheckButton42.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 43 And Form1.KryptonCheckButton43.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 44 And Form1.KryptonCheckButton44.Checked = True Then
            c44.Checked = True
        ElseIf c44.Text = 45 And Form1.KryptonCheckButton45.Checked = True Then
            c44.Checked = True
        Else
            c44.Checked = False
        End If

        If c55.Text = 31 And Form1.KryptonCheckButton31.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 32 And Form1.KryptonCheckButton32.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 33 And Form1.KryptonCheckButton33.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 34 And Form1.KryptonCheckButton34.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 35 And Form1.KryptonCheckButton35.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 36 And Form1.KryptonCheckButton36.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 37 And Form1.KryptonCheckButton37.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 38 And Form1.KryptonCheckButton38.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 39 And Form1.KryptonCheckButton39.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 40 And Form1.KryptonCheckButton40.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 41 And Form1.KryptonCheckButton41.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 42 And Form1.KryptonCheckButton42.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 43 And Form1.KryptonCheckButton43.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 44 And Form1.KryptonCheckButton44.Checked = True Then
            c55.Checked = True
        ElseIf c55.Text = 45 And Form1.KryptonCheckButton45.Checked = True Then
            c55.Checked = True
        Else
            c55.Checked = False
        End If

        If d11.Text = 46 And Form1.KryptonCheckButton46.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 47 And Form1.KryptonCheckButton47.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 48 And Form1.KryptonCheckButton48.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 49 And Form1.KryptonCheckButton49.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 50 And Form1.KryptonCheckButton50.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 51 And Form1.KryptonCheckButton51.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 52 And Form1.KryptonCheckButton52.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 53 And Form1.KryptonCheckButton53.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 54 And Form1.KryptonCheckButton54.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 55 And Form1.KryptonCheckButton55.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 56 And Form1.KryptonCheckButton56.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 57 And Form1.KryptonCheckButton57.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 58 And Form1.KryptonCheckButton58.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 59 And Form1.KryptonCheckButton59.Checked = True Then
            d11.Checked = True
        ElseIf d11.Text = 60 And Form1.KryptonCheckButton60.Checked = True Then
            d11.Checked = True
        Else
            d11.Checked = False
        End If

        If d22.Text = 46 And Form1.KryptonCheckButton46.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 47 And Form1.KryptonCheckButton47.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 48 And Form1.KryptonCheckButton48.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 49 And Form1.KryptonCheckButton49.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 50 And Form1.KryptonCheckButton50.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 51 And Form1.KryptonCheckButton51.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 52 And Form1.KryptonCheckButton52.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 53 And Form1.KryptonCheckButton53.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 54 And Form1.KryptonCheckButton54.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 55 And Form1.KryptonCheckButton55.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 56 And Form1.KryptonCheckButton56.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 57 And Form1.KryptonCheckButton57.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 58 And Form1.KryptonCheckButton58.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 59 And Form1.KryptonCheckButton59.Checked = True Then
            d22.Checked = True
        ElseIf d22.Text = 60 And Form1.KryptonCheckButton60.Checked = True Then
            d22.Checked = True
        Else
            d22.Checked = False
        End If

        If d33.Text = 46 And Form1.KryptonCheckButton46.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 47 And Form1.KryptonCheckButton47.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 48 And Form1.KryptonCheckButton48.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 49 And Form1.KryptonCheckButton49.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 50 And Form1.KryptonCheckButton50.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 51 And Form1.KryptonCheckButton51.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 52 And Form1.KryptonCheckButton52.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 53 And Form1.KryptonCheckButton53.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 54 And Form1.KryptonCheckButton54.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 55 And Form1.KryptonCheckButton55.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 56 And Form1.KryptonCheckButton56.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 57 And Form1.KryptonCheckButton57.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 58 And Form1.KryptonCheckButton58.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 59 And Form1.KryptonCheckButton59.Checked = True Then
            d33.Checked = True
        ElseIf d33.Text = 60 And Form1.KryptonCheckButton60.Checked = True Then
            d33.Checked = True
        Else
            d33.Checked = False
        End If

        If d44.Text = 46 And Form1.KryptonCheckButton46.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 47 And Form1.KryptonCheckButton47.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 48 And Form1.KryptonCheckButton48.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 49 And Form1.KryptonCheckButton49.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 50 And Form1.KryptonCheckButton50.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 51 And Form1.KryptonCheckButton51.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 52 And Form1.KryptonCheckButton52.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 53 And Form1.KryptonCheckButton53.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 54 And Form1.KryptonCheckButton54.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 55 And Form1.KryptonCheckButton55.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 56 And Form1.KryptonCheckButton56.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 57 And Form1.KryptonCheckButton57.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 58 And Form1.KryptonCheckButton58.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 59 And Form1.KryptonCheckButton59.Checked = True Then
            d44.Checked = True
        ElseIf d44.Text = 60 And Form1.KryptonCheckButton60.Checked = True Then
            d44.Checked = True
        Else
            d44.Checked = False
        End If

        If d55.Text = 46 And Form1.KryptonCheckButton46.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 47 And Form1.KryptonCheckButton47.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 48 And Form1.KryptonCheckButton48.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 49 And Form1.KryptonCheckButton49.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 50 And Form1.KryptonCheckButton50.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 51 And Form1.KryptonCheckButton51.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 52 And Form1.KryptonCheckButton52.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 53 And Form1.KryptonCheckButton53.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 54 And Form1.KryptonCheckButton54.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 55 And Form1.KryptonCheckButton55.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 56 And Form1.KryptonCheckButton56.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 57 And Form1.KryptonCheckButton57.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 58 And Form1.KryptonCheckButton58.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 59 And Form1.KryptonCheckButton59.Checked = True Then
            d55.Checked = True
        ElseIf d55.Text = 60 And Form1.KryptonCheckButton60.Checked = True Then
            d55.Checked = True
        Else
            d55.Checked = False
        End If

        If e11.Text = 61 And Form1.KryptonCheckButton61.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 62 And Form1.KryptonCheckButton62.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 63 And Form1.KryptonCheckButton63.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 64 And Form1.KryptonCheckButton64.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 65 And Form1.KryptonCheckButton65.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 66 And Form1.KryptonCheckButton66.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 67 And Form1.KryptonCheckButton67.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 68 And Form1.KryptonCheckButton68.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 69 And Form1.KryptonCheckButton69.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 70 And Form1.KryptonCheckButton70.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 71 And Form1.KryptonCheckButton71.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 72 And Form1.KryptonCheckButton72.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 73 And Form1.KryptonCheckButton73.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 74 And Form1.KryptonCheckButton74.Checked = True Then
            e11.Checked = True
        ElseIf e11.Text = 75 And Form1.KryptonCheckButton75.Checked = True Then
            e11.Checked = True
        Else
            e11.Checked = False
        End If

        If e22.Text = 61 And Form1.KryptonCheckButton61.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 62 And Form1.KryptonCheckButton62.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 63 And Form1.KryptonCheckButton63.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 64 And Form1.KryptonCheckButton64.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 65 And Form1.KryptonCheckButton65.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 66 And Form1.KryptonCheckButton66.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 67 And Form1.KryptonCheckButton67.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 68 And Form1.KryptonCheckButton68.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 69 And Form1.KryptonCheckButton69.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 70 And Form1.KryptonCheckButton70.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 71 And Form1.KryptonCheckButton71.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 72 And Form1.KryptonCheckButton72.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 73 And Form1.KryptonCheckButton73.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 74 And Form1.KryptonCheckButton74.Checked = True Then
            e22.Checked = True
        ElseIf e22.Text = 75 And Form1.KryptonCheckButton75.Checked = True Then
            e22.Checked = True
        Else
            e22.Checked = False
        End If

        If e33.Text = 61 And Form1.KryptonCheckButton61.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 62 And Form1.KryptonCheckButton62.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 63 And Form1.KryptonCheckButton63.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 64 And Form1.KryptonCheckButton64.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 65 And Form1.KryptonCheckButton65.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 66 And Form1.KryptonCheckButton66.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 67 And Form1.KryptonCheckButton67.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 68 And Form1.KryptonCheckButton68.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 69 And Form1.KryptonCheckButton69.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 70 And Form1.KryptonCheckButton70.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 71 And Form1.KryptonCheckButton71.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 72 And Form1.KryptonCheckButton72.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 73 And Form1.KryptonCheckButton73.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 74 And Form1.KryptonCheckButton74.Checked = True Then
            e33.Checked = True
        ElseIf e33.Text = 75 And Form1.KryptonCheckButton75.Checked = True Then
            e33.Checked = True
        Else
            e33.Checked = False
        End If

        If e44.Text = 61 And Form1.KryptonCheckButton61.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 62 And Form1.KryptonCheckButton62.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 63 And Form1.KryptonCheckButton63.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 64 And Form1.KryptonCheckButton64.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 65 And Form1.KryptonCheckButton65.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 66 And Form1.KryptonCheckButton66.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 67 And Form1.KryptonCheckButton67.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 68 And Form1.KryptonCheckButton68.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 69 And Form1.KryptonCheckButton69.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 70 And Form1.KryptonCheckButton70.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 71 And Form1.KryptonCheckButton71.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 72 And Form1.KryptonCheckButton72.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 73 And Form1.KryptonCheckButton73.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 74 And Form1.KryptonCheckButton74.Checked = True Then
            e44.Checked = True
        ElseIf e44.Text = 75 And Form1.KryptonCheckButton75.Checked = True Then
            e44.Checked = True
        Else
            e44.Checked = False
        End If

        If e55.Text = 61 And Form1.KryptonCheckButton61.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 62 And Form1.KryptonCheckButton62.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 63 And Form1.KryptonCheckButton63.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 64 And Form1.KryptonCheckButton64.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 65 And Form1.KryptonCheckButton65.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 66 And Form1.KryptonCheckButton66.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 67 And Form1.KryptonCheckButton67.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 68 And Form1.KryptonCheckButton68.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 69 And Form1.KryptonCheckButton69.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 70 And Form1.KryptonCheckButton70.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 71 And Form1.KryptonCheckButton71.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 72 And Form1.KryptonCheckButton72.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 73 And Form1.KryptonCheckButton73.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 74 And Form1.KryptonCheckButton74.Checked = True Then
            e55.Checked = True
        ElseIf e55.Text = 75 And Form1.KryptonCheckButton75.Checked = True Then
            e55.Checked = True
        Else
            e55.Checked = False
        End If
    End Sub
    Public Sub CONFIRM()
        If a11.Checked = Form1.a11.Checked Then
            MsgBox("CONGRATULATIONS")
        End If
    End Sub
    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        Try
            REMOVE()
            sqlcon.Open()
            Dim update As String = "update checker set serial='" & SERIAL.Text & "',
EMPLOYEE='" & employee.Text & "',
TYPE='" & type.Text & "',
B1='" & B1.Text & "',
B2='" & B2.Text & "',
B3='" & B3.Text & "',
B4='" & B4.Text & "',
B5='" & B5.Text & "',
I1='" & I1.Text & "',
I2='" & I2.Text & "',
I3='" & I3.Text & "',
I4='" & I4.Text & "',
I5='" & I5.Text & "',
N1='" & N1.Text & "',
N2='" & N2.Text & "',
N4='" & N4.Text & "',
N5='" & N5.Text & "',
G1='" & G1.Text & "',
G2='" & G2.Text & "',
G3='" & G3.Text & "',
G4='" & G4.Text & "',
G5='" & G5.Text & "',
O1='" & O1.Text & "',
O2='" & O2.Text & "',
O3='" & O3.Text & "',
O4='" & O4.Text & "',
O5='" & O5.Text & "' where serial = '" & id.Text & "'"
            SQLCMD = New SqlCommand(update, sqlcon)
            SQLCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
        loaddata()
    End Sub
    Public Sub loaddata()
        Try
            sqlcon.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            Dim bs As New BindingSource
            ds.Clear()
            Dim str As String = "select * from checker"
            SQLCMD = New SqlCommand(str, sqlcon)
            da.SelectCommand = SQLCMD
            da.Fill(ds, "checker")
            bs.DataSource = ds
            bs.DataMember = "checker"
            KryptonDataGridView37.DataSource = bs
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Private Sub KryptonDataGridView37_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView37.CellClick
        If KryptonDataGridView37.RowCount >= 0 And e.RowIndex >= 0 Then
            SERIAL.Text = KryptonDataGridView37.Item(0, e.RowIndex).Value.ToString
            id.Text = KryptonDataGridView37.Item(0, e.RowIndex).Value.ToString
            employee.Text = KryptonDataGridView37.Item(1, e.RowIndex).Value.ToString
            type.Text = KryptonDataGridView37.Item(2, e.RowIndex).Value.ToString


            B1.Text = KryptonDataGridView37.Item(3, e.RowIndex).Value.ToString
            B2.Text = KryptonDataGridView37.Item(4, e.RowIndex).Value.ToString
            B3.Text = KryptonDataGridView37.Item(5, e.RowIndex).Value.ToString
            B4.Text = KryptonDataGridView37.Item(6, e.RowIndex).Value.ToString
            B5.Text = KryptonDataGridView37.Item(7, e.RowIndex).Value.ToString

            I1.Text = KryptonDataGridView37.Item(8, e.RowIndex).Value.ToString
            I2.Text = KryptonDataGridView37.Item(9, e.RowIndex).Value.ToString
            I3.Text = KryptonDataGridView37.Item(10, e.RowIndex).Value.ToString
            I4.Text = KryptonDataGridView37.Item(11, e.RowIndex).Value.ToString
            I5.Text = KryptonDataGridView37.Item(12, e.RowIndex).Value.ToString

            N1.Text = KryptonDataGridView37.Item(13, e.RowIndex).Value.ToString
            N2.Text = KryptonDataGridView37.Item(14, e.RowIndex).Value.ToString
            N4.Text = KryptonDataGridView37.Item(15, e.RowIndex).Value.ToString
            N5.Text = KryptonDataGridView37.Item(16, e.RowIndex).Value.ToString

            G1.Text = KryptonDataGridView37.Item(17, e.RowIndex).Value.ToString
            G2.Text = KryptonDataGridView37.Item(18, e.RowIndex).Value.ToString
            G3.Text = KryptonDataGridView37.Item(19, e.RowIndex).Value.ToString
            G4.Text = KryptonDataGridView37.Item(20, e.RowIndex).Value.ToString
            G5.Text = KryptonDataGridView37.Item(21, e.RowIndex).Value.ToString

            O1.Text = KryptonDataGridView37.Item(22, e.RowIndex).Value.ToString
            O2.Text = KryptonDataGridView37.Item(23, e.RowIndex).Value.ToString
            O3.Text = KryptonDataGridView37.Item(24, e.RowIndex).Value.ToString
            O4.Text = KryptonDataGridView37.Item(25, e.RowIndex).Value.ToString
            O5.Text = KryptonDataGridView37.Item(26, e.RowIndex).Value.ToString
        End If
        REMOVE()
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        If MessageBox.Show("click yes to continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("operation cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Try
            sqlcon.Open()
            For i As Integer = 0 To ComboBox1.Items.Count - 1
                Dim x As String = ComboBox1.Items(i)
                Dim delete As String = "delete from checker where serial = '" & x & "'"
                SQLCMD = New SqlCommand(delete, sqlcon)
                SQLCMD.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
        loaddata()
    End Sub

    Private Sub KryptonDataGridView37_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView37.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = KryptonDataGridView37.SelectedRows
        Dim x As String
        ComboBox1.Items.Clear()
        For Each selecteditem As DataGridViewRow In selecteditems
            x = selecteditem.Cells("serial").Value.ToString
            ComboBox1.Items.Add(x)
        Next

    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        loaddata()
    End Sub

    Private Sub KryptonCheckButton79_Click(sender As Object, e As EventArgs) Handles KryptonCheckButton79.Click
        If KryptonCheckButton79.Checked = True Then
            KryptonDataGridView37.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        ElseIf KryptonCheckButton79.Checked = False Then
            KryptonDataGridView37.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        End If
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click

        a11.Text = ""
        a22.Text = ""
        a33.Text = ""
        a44.Text = ""
        a55.Text = ""

        b11.Text = ""
        b22.Text = ""
        b33.Text = ""
        b44.Text = ""
        b55.Text = ""

        c11.Text = ""
        c22.Text = ""

        c44.Text = ""
        c55.Text = ""

        d11.Text = ""
        d22.Text = ""
        d33.Text = ""
        d44.Text = ""
        d55.Text = ""

        e11.Text = ""
        e22.Text = ""
        e33.Text = ""
        e44.Text = ""
        e55.Text = ""

        a11.Checked = False
        a22.Checked = False
        a33.Checked = False
        a44.Checked = False
        a55.Checked = False

        b11.Checked = False
        b22.Checked = False
        b33.Checked = False
        b44.Checked = False
        b55.Checked = False

        c11.Checked = False
        c22.Checked = False

        c44.Checked = False
        c55.Checked = False

        d11.Checked = False
        d22.Checked = False
        d33.Checked = False
        d44.Checked = False
        d55.Checked = False

        e11.Checked = False
        e22.Checked = False
        e33.Checked = False
        e44.Checked = False
        e55.Checked = False
    End Sub

    Private Sub TXT_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT.KeyDown
        If e.KeyCode = Keys.Enter Then
            KryptonButton1.PerformClick()
        End If
    End Sub

    Private Sub Form4_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Panel1.Location = New Point((TabPage2.Width - Panel1.Width) / 2, (TabPage2.Height - Panel1.Height) / 2)
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class