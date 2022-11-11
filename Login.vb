Public Class Login
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")
    Public Shared userID As String
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Dim query As String
            Dim cmd As New OleDb.OleDbCommand
            Dim command As New OleDb.OleDbCommand
            con.Open()
            query = "Select password from Police WHERE policeID ='" & polIDTextBox.Text & "'"

            cmd.Connection = con
            cmd.CommandText = query

            Dim value As Object = cmd.ExecuteScalar

            If (value = passwordTextBox.Text) Then
                Dim oForm As New Form1
                userID = polIDTextBox.Text
                oForm.Show()
            Else
                MsgBox("Wrong  Credentials")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class