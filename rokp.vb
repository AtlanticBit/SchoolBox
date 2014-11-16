Public Class rokp
    Function isDivisible(x As Integer, d As Integer) As Boolean
        Return (x Mod d) = 0
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textint As Double
        Dim podzielna As Boolean
        Dim textstring As String
        Dim isprzestepny400 As Boolean
        textint = TextBox1.Text
        textstring = textint.ToString
        If textstring.EndsWith("00") Then
            isprzestepny400 = True
        Else
            isprzestepny400 = False
        End If
        If isprzestepny400 = True Then
            podzielna = isDivisible(textint, 400)
        Else
            podzielna = isDivisible(textint, 4)
        End If
        If podzielna = True Then
            Label3.Text = textstring
            Label5.Text = "jest"
        Else
            Label3.Text = textstring
            Label5.Text = "nie jest"
        End If
    End Sub
End Class