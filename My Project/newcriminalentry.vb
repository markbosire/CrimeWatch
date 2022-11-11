Imports System.Data.SqlClient

Public Class newcriminalentry
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Dim defaultID As String

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbimage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try
            Dim sql, query As String

            Dim crimesPrefix As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand
            Dim birthDay As String

            crimesPrefix = "CRS"

            defaultID = System.DateTime.Now.Day.ToString("00") & System.DateTime.Now.Month.ToString("00") & Strings.Right(System.DateTime.Now.Year, 2) & System.DateTime.Now.Hour & System.DateTime.Now.Minute & System.DateTime.Now.Second

            Dim i, j As Integer
            con.Open()
            sql = "INSERT INTO Criminal ([criminalID],[firstname],[lastname],[photo],[dateofbirth]) values (@criminalid,@firstname,@secondname,@photo,@dob)"
            query = "INSERT INTO Crimes([crimesid],[crimeID],[criminalID],[policeID],[dateofcrime]) values ('" & crimesPrefix & defaultID & "', '" & CrimeIDTextBox.Text & "','" & CriminalIDTextBox.Text & "', '" & OfficerIDTextBox.Text & "','" & CDpicker.Value & "');"
            birthDay = Format(DOBpicker.Value, "dd/mm/yyyy")
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@criminalid", CriminalIDTextBox.Text)
            cmd.Parameters.AddWithValue("@firstname", FirstNameTextBox.Text)
            cmd.Parameters.AddWithValue("@lastname", LastNameTextBox.Text)
            cmd.Parameters.AddWithValue("@photo", arrImage)
            cmd.Parameters.AddWithValue("@dateofbirth", birthDay)
            command.Connection = con
            command.CommandText = query
            i = cmd.ExecuteNonQuery
            j = command.ExecuteNonQuery
            If i > 0 & j > 0 Then
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

    Private Sub btnImageUpload_Click(sender As Object, e As EventArgs) Handles btnImageUpload.Click
        OpenFileDialog1.Title = "Get Criminal Image"


        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbimage.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub CrimeNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CrimeNameTextBox.TextChanged
        Try
            Dim query As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            query = "Select crimeID from Crime WHERE crimename ='" & CrimeNameTextBox.Text & "'"
            cmd.Connection = con
            cmd.CommandText = query
            Dim value As Object = cmd.ExecuteScalar
            CrimeIDTextBox.Text = value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub OfficerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles OfficerIDTextBox.TextChanged
        Try
            Dim query, query2 As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand
            con.Open()
            query = "Select lastName from Police WHERE policeID ='" & OfficerIDTextBox.Text & "'"
            query2 = "Select firstName from Police WHERE policeID ='" & OfficerIDTextBox.Text & "'"
            cmd.Connection = con
            cmd.CommandText = query
            command.Connection = con
            command.CommandText = query2
            Dim value As Object = cmd.ExecuteScalar
            Dim value2 As Object = command.ExecuteScalar
            OfficerNameTextBox.Text = value & " " & value2
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub newcriminalentry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim criminalPrefix As String
        criminalPrefix = "CL"
        defaultID = System.DateTime.Now.Day.ToString("00") & System.DateTime.Now.Month.ToString("00") & Strings.Right(System.DateTime.Now.Year, 2) & System.DateTime.Now.Hour & System.DateTime.Now.Minute & System.DateTime.Now.Second
        CriminalIDTextBox.Text = criminalPrefix & defaultID
    End Sub
End Class