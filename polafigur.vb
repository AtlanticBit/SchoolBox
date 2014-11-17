Public Class polafigur

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Decimal
        a = TextBox1.Text
        Dim b As Decimal
        b = a * a
        Label4.Text = b.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Decimal
        Dim y As Decimal
        Dim c As Decimal
        x = TextBox2.Text
        y = TextBox3.Text
        c = x * y
        Label7.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim z As Decimal
        Dim p As Decimal
        Dim h As Decimal
        Dim finished As Decimal
        z = TextBox4.Text
        p = TextBox5.Text
        h = TextBox6.Text
        finished = z + p
        finished = finished / 2
        finished = finished * h
        Label12.Text = finished
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numbera As Decimal
        Dim numberb As Decimal
        Dim heuheu As Decimal
        numbera = TextBox7.Text
        numberb = TextBox8.Text
        heuheu = numbera * numberb
        Label16.Text = heuheu
    End Sub
End Class