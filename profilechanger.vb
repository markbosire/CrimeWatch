Public Class profilechanger
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")
    Dim isCorrect As Boolean
    Private Sub profilechanger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OfficerProfile.changeTheme = 1 Then
            tb1.Visible = False
            tb2.Visible = False
            label1.Visible = False
            label2.Visible = False
            pbimage.Visible = True
            btnImageUpload.Visible = True
        End If
        If OfficerProfile.changeTheme = 2 Then
            tb1.Visible = True
            tb2.Visible = False
            label1.Visible = True
            label2.Visible = False
            pbimage.Visible = False
            btnImageUpload.Visible = False
            label1.Text = "Email"
            tb1.PlaceholderText = "Email"
        End If
        If OfficerProfile.changeTheme = 3 Then
            tb1.Visible = True
            tb2.Visible = True
            label1.Visible = True
            label2.Visible = True
            pbimage.Visible = False
            btnImageUpload.Visible = False
            label1.Text = "Old Password"
            tb1.PlaceholderText = "Old Password"
            label2.Text = "New Password"
            tb2.PlaceholderText = "New Password"
        End If
    End Sub

    Private Sub signoutbtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If OfficerProfile.changeTheme = 1 Then
            imageSub()
        End If
        If OfficerProfile.changeTheme = 2 Then
            emailSub()
        End If
        If OfficerProfile.changeTheme = 3 Then
            passwordSub()
        End If
    End Sub
    Private Sub imageSub()
        Dim FileSize As UInt32
        Dim mstream As New System.IO.MemoryStream()
        pbimage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length
        mstream.Close()
        Try
            Dim userID As String
            If (Login.userID IsNot Nothing) Then
                userID = Login.userID
            End If
            If (SignUP.userID IsNot Nothing) Then
                userID = SignUP.userID
            End If
            Dim query As String
            Dim i As Integer
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            query = "update Police set [photo] = @photo  WHERE policeID ='" & userID & "'"
            cmd.Parameters.AddWithValue("@photo", arrImage)

            cmd.Connection = con
            cmd.CommandText = query
            i = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("photo updated")
            Else
                MsgBox("not updated")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub emailSub()
        Try
            Dim userID As String
            If (Login.userID IsNot Nothing) Then
                userid = Login.userID
            End If
            If (SignUP.userID IsNot Nothing) Then
                userid = SignUP.userID
            End If
            Dim query As String
            Dim i As Integer
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            query = "update Police set [email] ='" & tb1.Text & "'  WHERE policeID ='" & userID & "'"


            cmd.Connection = con
            cmd.CommandText = query
            i = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("Email updated")
            Else
                MsgBox("not updated")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub passwordSub()
        Try
            Dim userID As String
            If (Login.userID IsNot Nothing) Then
                userID = Login.userID
            End If
            If (SignUP.userID IsNot Nothing) Then
                userID = SignUP.userID
            End If


            passwordCheck()
            con.Open()
            Dim qry As String
                Dim i As Integer
                Dim command As New OleDb.OleDbCommand

                qry = "update Police set [password] ='" & tb2.Text & "'  WHERE policeID ='" & userID & "'"


                command.Connection = con
            command.CommandText = qry
            If (isCorrect = True) Then
                i = command.ExecuteNonQuery()
            Else
                MsgBox("Enter correct Password")
            End If

            If (i > 0) Then
                    MsgBox("Password updated")
                Else
                    MsgBox("not updated")
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
    Private Sub passwordCheck()
        Try
            Dim userID As String
            If (Login.userID IsNot Nothing) Then
                userID = Login.userID
            End If
            If (SignUP.userID IsNot Nothing) Then
                userID = SignUP.userID
            End If
            Dim query As String
            Dim cmd As New OleDb.OleDbCommand
            con.Open()
            query = "Select password from Police WHERE policeiD ='" & userID & "'"
            cmd.Connection = con
            cmd.CommandText = query
            Dim value As Object = cmd.ExecuteScalar
            If (tb1.Text = value) Then
                isCorrect = True
            Else
                isCorrect = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class