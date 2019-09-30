Public Class Intro
    'this button starts the tool
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        Calculator.Show()
    End Sub
    'this button goes to a window showing method 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub
    'this button closes the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class