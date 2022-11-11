Imports System.Data.OleDb

Public Class OfficerProfile
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Public Shared currentCard As Integer = 0
    Public Shared currentCardcrime As Integer = 0
    Public Shared CriminalIDValue As String
    Dim rowcount As Integer
    Public Shared changeTheme As Integer
    Private Sub OfficerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userid As String
        If (currentCard = 0) Then
            btnBack.Visible = False
        Else
            btnBack.Visible = True
        End If
        If (Login.userID IsNot Nothing) Then
            userid = Login.userID
        End If
        If (SignUP.userID IsNot Nothing) Then
            userid = SignUP.userID
        End If
        criminals()
        Dim da As OleDbDataAdapter
        Dim dt As DataTable

        Try


            con.Open()


            Dim query, query2, qry, qry2 As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command, order, order2 As New OleDb.OleDbCommand

            query = "Select lastName from Police WHERE policeID ='" & userid & "'"
            query2 = "Select firstName from Police WHERE policeID ='" & userid & "'"
            qry = "Select photo from Police WHERE policeID ='" & userid & "'"
            qry2 = "Select email from Police WHERE policeID ='" & userid & "'"

            Dim arrimg() As Byte
            cmd.Connection = con
            cmd.CommandText = query
            command.Connection = con
            command.CommandText = query2
            order.Connection = con
            order.CommandText = qry
            order2.Connection = con
            order2.CommandText = qry2
            Dim value As Object = cmd.ExecuteScalar
            Dim value2 As Object = command.ExecuteScalar
            Dim value3 As Object = order.ExecuteScalar
            Dim value4 As Object = order2.ExecuteScalar
            arrimg = value3
            Dim mstream As IO.MemoryStream
            mstream = New IO.MemoryStream(arrimg)
            usernamepic.Image = Image.FromStream(mstream)
            lblUserName.Text = value & " " & value2
            emaillbl.Text = value4

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub btnFront_Click(sender As Object, e As EventArgs) Handles btnFront.Click

        currentCard = currentCard + 1
            criminals()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If (rowcount > 0) Then
            currentCard = currentCard - 1

            criminals()
        Else
            MsgBox("This is the last record")
        End If
    End Sub
    Private Sub criminals()
        If (currentCard = 0) Then
            btnBack.Visible = False
        Else
            btnBack.Visible = True
        End If
        Dim arrimg() As Byte
        Dim userid As String
        If (Login.userID IsNot Nothing) Then
            userid = Login.userID
        End If
        If (SignUP.userID IsNot Nothing) Then
            userid = SignUP.userID
        End If
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim da1 As OleDbDataAdapter
        Dim dt1 As DataTable

        Try
            Dim sql, thequery, thequery2, thequery3, thequery4, thequery5 As String
            Dim crimeId, criminalID, doc, crimeName, firstName, LastName As String
            Dim thecmd As New OleDb.OleDbCommand
            Dim thecommand, theorder, Befehl, commande, elcommand As New OleDb.OleDbCommand

            con.Open()
            sql = "Select * from Crimes Where policeID = '" & userid & "'"

            da = New OleDbDataAdapter
            dt = New DataTable


            thecmd.Connection = con
            thecmd.CommandText = sql
            da.SelectCommand = thecmd
            da.Fill(dt)
            rowcount = dt.Rows.Count
            If rowcount > currentCard Then
                crimeId = dt.Rows(currentCard).Item("crimeID")
                criminalID = dt.Rows(currentCard).Item("criminalID")
                doc = dt.Rows(currentCard).Item("dateofcrime")

                thequery = "Select crimename from Crime where crimeID = '" & dt.Rows(currentCard).Item("crimeID") & "'"

                thecommand.Connection = con
                thecommand.CommandText = thequery
                Dim valuee As Object = thecommand.ExecuteScalar
                crimeName = valuee
                crimenamelbl.Text = crimeName
                criminalIDlbl.Text = criminalID

                thequery2 = "Select crimerating from Crime where crimeID = '" & dt.Rows(currentCard).Item("crimeID") & "'"
                theorder.Connection = con
                theorder.CommandText = thequery2
                Dim valuee2 As Object = theorder.ExecuteScalar
                crimeRating.Value = Convert.ToInt32(valuee2)
                thequery3 = "Select * from Criminal where criminalID = '" & dt.Rows(currentCard).Item("criminalID") & "'"


                dt1 = New DataTable
                Befehl.Connection = con
                Befehl.CommandText = thequery3
                da.SelectCommand = Befehl
                da.Fill(dt1)

                arrimg = dt1.Rows(0).Item("photo")
                Dim mstream As IO.MemoryStream
                mstream = New IO.MemoryStream(arrimg)
                criminalAvatar.Image = Image.FromStream(mstream)
                criminalFirstName.Text = dt1.Rows(0).Item("firstname")
                criminalSecondName.Text = dt1.Rows(0).Item("lastname")
                doclbl.Text = doc
            Else
                currentCard = currentCard - 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        changeTheme = 1
        Dim oForm As New profilechanger

        oForm.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        changeTheme = 2
        Dim oForm As New profilechanger

        oForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        changeTheme = 3
        Dim oForm As New profilechanger

        oForm.Show()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        OfficerProfile_Load(sender, e)
    End Sub

    Private Sub signoutbtn_Click(sender As Object, e As EventArgs) Handles signoutbtn.Click

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class