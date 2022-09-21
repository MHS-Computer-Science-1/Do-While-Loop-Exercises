Public Class Form1


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'MATH GAME 1
        Dim numRight, numWrong, num1, num2, answer As Integer
        Dim r As New Random

        'Generate a problem
        num1 = r.Next(0, 9)
        num2 = r.Next(0, 9)

        'Display and get user's answer
        answer = InputBox("What is " & num1 & " * " & num2 & "?")

        'Check answer
        If answer = num1 * num2 Then
            numRight = numRight + 1
            ListBox1.Items.Add("Right. " & vbCrLf & "Correct: " & numRight & " Incorrect: " & numWrong)
        Else
            numWrong = numWrong + 1
            ListBox1.Items.Add("Wrong. " & vbCrLf & "Correct: " & numRight & " Incorrect: " & numWrong)
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'MATH GAME 2
        Dim numRight, numWrong, num1, num2, answer As Integer
        Dim r As New Random

        'Generate a problem
        num1 = r.Next(0, 9)
        num2 = r.Next(0, 9)

        'Display and get user's answer
        answer = InputBox("What is " & num1 & " * " & num2 & "?")

        'Check answer
        If answer = num1 * num2 Then
            numRight = numRight + 1
            ListBox1.Items.Add("Right. " & vbCrLf & " Correct: " & numRight & " Incorrect: " & numWrong)
        Else
            numWrong = numWrong + 1
            ListBox1.Items.Add("Wrong. " & vbCrLf & " Correct: " & numRight & " Incorrect: " & numWrong)
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Clear()
    End Sub
End Class
