Public Class newcrime
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")
    Dim defaultID As String
    Private Sub newcrime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim criminalPrefix As String
        criminalPrefix = "CR"
        defaultID = System.DateTime.Now.Day.ToString("00") & System.DateTime.Now.Month.ToString("00") & Strings.Right(System.DateTime.Now.Year, 2) & System.DateTime.Now.Hour & System.DateTime.Now.Minute & System.DateTime.Now.Second
        CrimeIDTextBox.Text = criminalPrefix & defaultID
    End Sub



    Private Sub btnsubmitt_Click(sender As Object, e As EventArgs) Handles btnsubmitt.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO Crime ([crimeID],[crimename],[crimerating]) values ('" & CrimeIDTextBox.Text & "','" & CrimeNameTextBox.Text & "','" & CrimeStarRating.Value & "');"
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

    Private Sub CrimeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CrimeIDTextBox.TextChanged

    End Sub
End Class