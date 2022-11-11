Imports System.Data.SqlClient
Public Class SignUP
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")
    Public Shared userID As String
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles signUpbtn.Click
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbimage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Dim birthDay As String
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim i As Integer
            con.Open()
            sql = "INSERT INTO Police([policeID],[firstName],[lastName],[password],[email],[dateofbirth],[photo]) values (@policeid,@firstname,@lastname,@password,@email,@dob,@photo)"
            birthDay = Format(DOBpicker.Value, "dd/mm/yyyy")
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@policeid", POLIDTextBox.Text)
            cmd.Parameters.AddWithValue("@firstname", FirstNameTextBox.Text)
            cmd.Parameters.AddWithValue("@lastname", LastNameTextBox.Text)
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text)
            cmd.Parameters.AddWithValue("@email", emailtextBox.Text)

            cmd.Parameters.AddWithValue("@dateofbirth", birthDay)
            cmd.Parameters.AddWithValue("@photo", arrImage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
                Dim oForm As New Form1
                userID = POLIDTextBox.Text
                oForm.Show()
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
End Class