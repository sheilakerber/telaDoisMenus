Public Class novaJanela

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Dispose()
        Form1.Show()
    End Sub
End Class