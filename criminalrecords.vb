Imports System.Data.OleDb
Public Class criminalrecords
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Public Shared currentCard As Integer = 0
    Public Shared currentCardcrime As Integer = 0
    Public Shared CriminalIDValue As String
    Dim rowcountcrime As Integer
    Dim rowcountcriminal As Integer
    Public Sub criminalrecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (currentCard = 0) Then
            btnBack.Visible = False
        Else
            btnBack.Visible = True
        End If

        Dim da As OleDbDataAdapter
        Dim dt As DataTable

        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand
            Dim dateofbirth As String
            Dim age As String

            con.Open()
            sql = "Select * from Criminal "


            da = New OleDbDataAdapter
            dt = New DataTable
            Dim arrimg() As Byte
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            rowcountcriminal = dt.Rows.Count
            If rowcountcriminal > currentCard Then
                CriminalIDValue = dt.Rows(currentCard).Item("criminalID")
                criminalFirstName.Text = dt.Rows(currentCard).Item("firstname")
                criminalSecondName.Text = dt.Rows(currentCard).Item("lastname")

                arrimg = dt.Rows(currentCard).Item("photo")

                Dim mstream As IO.MemoryStream
                mstream = New IO.MemoryStream(arrimg)
                criminalAvatar.Image = Image.FromStream(mstream)
                dateofbirth = Microsoft.VisualBasic.Right(dt.Rows(currentCard).Item("dateofbirth"), 4)
                age = Convert.ToInt32(System.DateTime.Now.Year) - Convert.ToInt32(dateofbirth)
                criminalRating.Value = 4
                criminalAge.Text = age

                mstream.Dispose()
            Else
                currentCard = currentCard - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (currentCard = 0) Then
            btnBack.Visible = False
        Else
        btnBack.Visible = True
        End If
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Try
                Dim sql As String
                Dim cmd As New OleDb.OleDbCommand
                Dim command As New OleDb.OleDbCommand
                Dim dateofbirth As String
                Dim age As String

                con.Open()
            sql = "Select * from Criminal WHERE criminalID ='" & searchBox.Text & "'"



            da = New OleDbDataAdapter
                dt = New DataTable
                Dim arrimg() As Byte
                cmd.Connection = con
                cmd.CommandText = sql
                da.SelectCommand = cmd
                da.Fill(dt)
            criminalFirstName.Text = dt.Rows(0).Item("firstname")
            criminalSecondName.Text = dt.Rows(0).Item("lastname")

            arrimg = dt.Rows(0).Item("photo")

            Dim mstream As IO.MemoryStream
                mstream = New IO.MemoryStream(arrimg)
                criminalAvatar.Image = Image.FromStream(mstream)
            dateofbirth = Microsoft.VisualBasic.Right(dt.Rows(0).Item("dateofbirth"), 4)
            age = Convert.ToInt32(System.DateTime.Now.Year) - Convert.ToInt32(dateofbirth)
                criminalRating.Value = 4
                criminalAge.Text = age

                mstream.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                da.Dispose()
            End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        currentCardcrime = 0
        If (rowcountcriminal > 0) Then
            currentCard = currentCard - 1


            criminalShow_Click(sender, e)
        End If
    End Sub

    Private Sub btnFront_Click(sender As Object, e As EventArgs) Handles btnFront.Click
        currentCardcrime = 0
        currentCard = currentCard + 1

        criminalShow_Click(sender, e)

    End Sub

    Public Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles showCrimes.Click
        Dim da As OleDbDataAdapter
        Dim dt As DataTable
        criminalShow.Visible = True
        criminalShow.BringToFront()
        crimenext.Visible = True
        crimeBack.Visible = True

        Try
            Dim sql, query As String
            Dim crimeId, policeID, doc, crimeName, policeName As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command, order, Befehl, commande As New OleDb.OleDbCommand

            con.Open()
            sql = "Select * from Crimes Where criminalID = '" & criminalrecords.CriminalIDValue & "'"

            da = New OleDbDataAdapter
            dt = New DataTable


            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            rowcountcrime = dt.Rows.Count
            If rowcountcrime > currentCardcrime Then
                crimeId = dt.Rows(currentCardcrime).Item("crimeID")
                policeID = dt.Rows(currentCardcrime).Item("policeID")
                doc = dt.Rows(currentCardcrime).Item("dateofcrime")
                query = "Select crimename from Crime where crimeID = '" & dt.Rows(currentCardcrime).Item("crimeID") & "'"
                command.Connection = con
                command.CommandText = query
                Dim value As Object = command.ExecuteScalar
                crimeName = value
                criminalFirstName.Text = crimeId & " " & crimeName
                criminalFirstName.Font = New Font("Verdana", 12, FontStyle.Bold)
                query = "Select crimerating from Crime where crimeID = '" & dt.Rows(currentCardcrime).Item("crimeID") & "'"
                order.Connection = con
                order.CommandText = query
                Dim value2 As Object = order.ExecuteScalar
                criminalRating.Value = Convert.ToInt32(value2)
                query = "Select firstName from Police where policeID = '" & dt.Rows(currentCardcrime).Item("policeID") & "'"
                Befehl.Connection = con
                Befehl.CommandText = query
                Dim value3 As Object = Befehl.ExecuteScalar

                query = "Select lastName from Police where policeID = '" & dt.Rows(currentCardcrime).Item("policeID") & "'"
                command.Connection = con
                command.CommandText = query
                Dim value4 As Object = command.ExecuteScalar
                policeName = value3 & " " & value4
                criminalSecondName.Font = New Font("Verdana", 12, FontStyle.Bold)
                criminalSecondName.Text = policeID & " " & policeName
                criminalAge.Text = dt.Rows(currentCardcrime).Item("dateofcrime")
                criminalAge.Font = New Font("Verdana", 12, FontStyle.Bold)
            Else
                currentCard = currentCard - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles crimenext.Click
        currentCardcrime = currentCardcrime + 1
        Guna2Button1_Click(sender, e)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles crimeBack.Click
        If (rowcountcrime > 0) Then
            currentCardcrime = currentCardcrime - 1

            Guna2Button1_Click(sender, e)
        End If
    End Sub

    Private Sub criminalShow_Click(sender As Object, e As EventArgs) Handles criminalShow.Click
        criminalSecondName.Font = New Font("Verdana", 24, FontStyle.Bold)
        criminalFirstName.Font = New Font("Verdana", 24, FontStyle.Bold)
        criminalAge.Font = New Font("Verdana", 24, FontStyle.Bold)
        showCrimes.Visible = True
        showCrimes.BringToFront()

        criminalrecords_Load(sender, e)
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class