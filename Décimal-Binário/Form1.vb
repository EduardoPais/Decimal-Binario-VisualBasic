Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TextDecimal, TextBinario, x As Single
        TextBinario = 0
        While TextDecimal! = 0
            x = Math.Floor(Math.Log(TextDecimal, 2))
            TextDecimal = TextDecimal - 2 ^ x
            TextBinario = TextBinario + 10 ^ x
        End While
    End Sub
End Class
