Public Class temp
    Private Sub temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With newcriminalentry
            .TopLevel = False
            mainForm.Controls.Add(newcriminalentry)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnNewCriminal_Click(sender As Object, e As EventArgs) Handles btnNewCriminal.Click
        With newcriminalentry
            .TopLevel = False
            mainForm.Controls.Add(newcriminalentry)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnExistingCriminal_Click(sender As Object, e As EventArgs) Handles btnExistingCriminal.Click
        With existingcriminalentry
            .TopLevel = False
            mainForm.Controls.Add(existingcriminalentry)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class