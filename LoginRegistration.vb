

Public Class LoginRegistration


    Private Sub signinBtn_Click(sender As Object, e As EventArgs) Handles signinBtn.Click
        signinBtn.Visible = False
        signinBtn.SendToBack()
        signinBtnActive.Visible = True
        signinBtnActive.BringToFront()
        signupBtnActive.Visible = False
        signupBtnActive.SendToBack()
        signupBtn.Visible = True
        signupBtn.BringToFront()
        Loginsub()
    End Sub

    Private Sub LoginRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        signupBtnActive.Visible = False
        signinBtn.Visible = False
        signinBtn.SendToBack()
        signinBtnActive.Visible = True
        signinBtnActive.BringToFront()
        Loginsub()

    End Sub

    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        signupBtn.Visible = False
        signupBtn.SendToBack()
        signupBtnActive.Visible = True
        signupBtnActive.BringToFront()
        signinBtnActive.Visible = False
        signinBtnActive.SendToBack()
        signinBtn.Visible = True
        signinBtn.BringToFront()
        SignUpsub()

    End Sub
    Private Sub Loginsub()
        With Login
            .TopLevel = False
            signForm.Controls.Add(Login)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub SignUpsub()
        With SignUP
            .TopLevel = False
            signForm.Controls.Add(SignUP)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class