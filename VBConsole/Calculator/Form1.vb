Public Class Form1

    Private isAdding As Boolean = False 'a gobal variable for state
    'Click event
    Private Sub ButAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAdd.Click
        If Num1.Text.Length <> 0 And Num2.Text.Length <> 0 And isAdding = False Then
            Dim answer As Double = add(CType(Num1.Text, Double), CType(Num2.Text, Double))
            Res.Text = answer.ToString()
            Num1.ReadOnly = True
            isAdding = True 'keep on adding
        ElseIf isAdding Then
            Dim ans As Double = add(CType(Num1.Text, Double), CType(Num2.Text, Double))
            Res.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSubtract.Click
        Dim answer As Double = abstract(CType(Num1.Text, Double), CType(Num2.Text, Double))
        Res.Text = answer
    End Sub

    Private Sub ButDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDivide.Click
        Dim answer As Double = divide(CType(Num1.Text, Double), CType(Num2.Text, Double))
        Res.Text = answer
    End Sub

    Private Sub ButMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMultiply.Click
        Dim answer As Double = multiply(CType(Num1.Text, Double), CType(Num2.Text, Double))
        Res.Text = answer
    End Sub

    Private Sub Pie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pie.Click
        Dim answer As Double = Piee(CType(Num1.Text, Double))
        Res.Text = answer
    End Sub

    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function abstract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Return num1 Mod num2
    End Function

    Private Function Piee(ByVal num As Double) As Double
        Return num * Math.PI
    End Function

    Private Sub ButClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClear.Click
        Num1.ReadOnly = False
        Num2.ReadOnly = False
        Num1.Clear()
        Num2.Clear()
    End Sub
End Class
