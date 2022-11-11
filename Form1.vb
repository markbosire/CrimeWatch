Imports System.Data.OleDb

Public Class Form1

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With criminalrecords
            .TopLevel = False
            mainForm.Controls.Add(criminalrecords)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
        End With

        Dim userid As String
        If (Login.userID IsNot Nothing) Then
            userid = Login.userID
        End If
        If (SignUP.userID IsNot Nothing) Then
            userid = SignUP.userID
        End If
        Try
            Dim query, query2, qry As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command, order As New OleDb.OleDbCommand
            con.Open()
            query = "Select lastName from Police WHERE policeID ='" & userid & "'"
            query2 = "Select firstName from Police WHERE policeID ='" & userid & "'"
            qry = "Select photo from Police WHERE policeID ='" & userid & "'"
            Dim arrimg() As Byte
            cmd.Connection = con
            cmd.CommandText = query
            command.Connection = con
            command.CommandText = query2
            order.Connection = con
            order.CommandText = qry
            Dim value As Object = cmd.ExecuteScalar
            Dim value2 As Object = command.ExecuteScalar
            Dim value3 As Object = order.ExecuteScalar
            arrimg = value3
            Dim mstream As IO.MemoryStream
            mstream = New IO.MemoryStream(arrimg)
            unamepic.Image = Image.FromStream(mstream)
            usernamelbl.Text = value & " " & value2

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        btnHide.Visible = False
        btnShow.Visible = True
        Guna2Panel1.Visible = False

        Guna2Panel1.Width = 219
        Guna2Transition1.ShowSync(Guna2Panel1)
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        btnHide.Visible = True
        btnShow.Visible = False
        Guna2Panel1.Visible = False
        Guna2Panel1.Width = 67
        Guna2Transition1.ShowSync(Guna2Panel1)
    End Sub


    Private Sub btnCriminalRecords_Click(sender As Object, e As EventArgs) Handles btnCriminalRecords.Click
        With criminalrecords
            .TopLevel = False
            mainForm.Controls.Add(criminalrecords)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
        End With
    End Sub

    Private Sub btnNewCrime_Click(sender As Object, e As EventArgs) Handles btnNewCrime.Click
        With newcrime
            .TopLevel = False
            mainForm.Controls.Add(newcrime)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
        End With
    End Sub

    Private Sub btnCriminalInput_Click(sender As Object, e As EventArgs) Handles btnCriminalInput.Click
        With temp
            .TopLevel = False

            mainForm.Controls.Add(temp)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
        End With
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click
        With OfficerProfile
            .TopLevel = False

            mainForm.Controls.Add(OfficerProfile)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
            Guna2ControlBox1.BringToFront()
        End With
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        With crimeanalysis
            .TopLevel = False

            mainForm.Controls.Add(crimeanalysis)
            .BringToFront()
            .Show()
            btnHide.BringToFront()
            btnShow.BringToFront()
            Guna2ControlBox1.BringToFront()
        End With
    End Sub
End Class
