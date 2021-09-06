Public Class Form1

    Private Sub opcaoAmenu1_Click(sender As Object, e As EventArgs) Handles opcaoAmenu1.Click
        MsgBox("Opção selecionada: A.", MsgBoxStyle.Information, "Resultado")
    End Sub

    Private Sub opcaoBmenu1_Click(sender As Object, e As EventArgs) Handles opcaoBmenu1.Click
        MsgBox("Opção selecionada: B.", MsgBoxStyle.Information, "Resultado")
    End Sub

    Private Sub opcaoCmenu1_Click(sender As Object, e As EventArgs) Handles opcaoCmenu1.Click
        MsgBox("Opção selecionada: C.", MsgBoxStyle.Information, "Resultado")
    End Sub

    Private Sub opcaoAbrirMenu2_Click(sender As Object, e As EventArgs) Handles opcaoAbrirMenu2.Click
        novaJanela.Show()
    End Sub

    Private Sub opcaoFecharMenu2_Click(sender As Object, e As EventArgs) Handles opcaoFecharMenu2.Click
        Me.Dispose()
    End Sub
End Class
