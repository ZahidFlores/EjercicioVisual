Public Class Distancia
    Inherits datos
    Public Sub New(x1 As Double, y1 As Double, x2 As Double, y2 As Double)
        MyBase.New(x1, y1)
        Dim x As Double = x2 - x1
        Dim y As Double = y2 - y1
        MsgBox("La distancia entre 2 puntos es: " & Math.Sqrt(x * x + y * y), MsgBoxStyle.Information, "Sistema")
    End Sub
End Class
