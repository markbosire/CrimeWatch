Public Class existingcriminalentry
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Try
            Dim query, query2 As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand


            con.Open()
            query = "Select lastname from Criminal WHERE criminalID ='" & criminalIDSearchBox.Text & "'"
            query2 = "Select firstname from Criminal WHERE criminalID ='" & criminalIDSearchBox.Text & "'"

            cmd.Connection = con
            cmd.CommandText = query
            command.Connection = con
            command.CommandText = query2

            Dim value As Object = cmd.ExecuteScalar
            Dim value2 As Object = command.ExecuteScalar

            criminalNameTextBox.Text = value & " " & value2
            criminalIDTextBox.Text = criminalIDSearchBox.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub crimeNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles crimeNameTextBox.TextChanged
        Try
            Dim query As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            query = "Select crimeID from Crime WHERE crimename ='" & crimeNameTextBox.Text & "'"
            cmd.Connection = con
            cmd.CommandText = query
            Dim value As Object = cmd.ExecuteScalar
            crimeIDTextBox.Text = value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub officerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles officerIDTextBox.TextChanged
        Try
            Dim query, query2 As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand
            con.Open()
            query = "Select lastName from Police WHERE policeID ='" & officerIDTextBox.Text & "'"
            query2 = "Select firstName from Police WHERE policeID ='" & officerIDTextBox.Text & "'"
            cmd.Connection = con
            cmd.CommandText = query
            command.Connection = con
            command.CommandText = query2
            Dim value As Object = cmd.ExecuteScalar
            Dim value2 As Object = command.ExecuteScalar
            officerNameTextBox.Text = value & " " & value2
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Dim sql As String

            Dim cmd As New OleDb.OleDbCommand
            Dim crimesPrefix As String

            Dim defaultID As String

            crimesPrefix = "CRS"

            defaultID = System.DateTime.Now.Day.ToString("00") & System.DateTime.Now.Month.ToString("00") & Strings.Right(System.DateTime.Now.Year, 2) & System.DateTime.Now.Hour & System.DateTime.Now.Minute & System.DateTime.Now.Second

            Dim i As Integer
            con.Open()
            sql = "INSERT INTO Crimes([crimesid],[crimeID],[criminalID],[policeID],[dateofcrime]) values ('" & crimesPrefix & defaultID & "', '" & crimeIDTextBox.Text & "','" & criminalIDTextBox.Text & "', '" & officerIDTextBox.Text & "','" & CDpicker.Value & "');"

            cmd.Connection = con
            cmd.CommandText = sql


            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("No record has been inserted successfully!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class