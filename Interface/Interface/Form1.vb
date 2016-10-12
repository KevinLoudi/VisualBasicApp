Public Class Form1

    Private Sub Write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Write.Click
        Output.Text = "The input string is " + Input.Text + " , is it right?"
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Output.Text = ""
    End Sub

    Private Sub Exiting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exiting.Click
        End
    End Sub
End Class
