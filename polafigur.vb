﻿Public Class polafigur

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = TextBox1.Text
        Dim b As Double
        b = a * a
        Label4.Text = b.ToString
    End Sub
End Class