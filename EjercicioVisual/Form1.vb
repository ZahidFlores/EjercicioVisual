Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim dist As New Distancia(txtX1.Text, txtY1.Text, txtX2.Text, txtY2.Text)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtX1.Text = ""
        txtX2.Text = ""
        txtY1.Text = ""
        txtY2.Text = ""
    End Sub
End Class
