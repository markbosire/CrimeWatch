Imports System.Data.OleDb

Public Class crimeanalysis
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\CrimeWatch.accdb")

    Private Sub crimeanalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim arrimg() As Byte
        Dim userid As String

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
            sql = "Select * from Crimes Where crimeID = '" & searchBox.Text & "'"

            da = New OleDbDataAdapter
            dt = New DataTable


            thecmd.Connection = con
            thecmd.CommandText = sql
            da.SelectCommand = thecmd
            da.Fill(dt)

            crimeId = dt.Rows(0).Item("crimeID")
            criminalID = dt.Rows(0).Item("criminalID")
            doc = dt.Rows(0).Item("dateofcrime")

            thequery = "Select crimename from Crime where crimeID = '" & dt.Rows(0).Item("crimeID") & "'"

            thecommand.Connection = con
            thecommand.CommandText = thequery
            Dim valuee As Object = thecommand.ExecuteScalar
            crimeName = valuee
            crimenamelbl.Text = crimeName
            criminalIDlbl.Text = criminalID

            thequery2 = "Select crimerating from Crime where crimeID = '" & dt.Rows(0).Item("crimeID") & "'"
            theorder.Connection = con
            theorder.CommandText = thequery2
            Dim valuee2 As Object = theorder.ExecuteScalar
            crimeRating.Value = Convert.ToInt32(valuee2)
            thequery3 = "Select * from Criminal where criminalID = '" & dt.Rows(0).Item("criminalID") & "'"


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


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class