Imports System
Public Class formGame
    Const PADDLE_WIDTH = 40
    Const PADDLE_HEIGHT = 200
    Private Sub formGame_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Draw the left paddle
        e.Graphics.FillRectangle(Brushes.White, 0, CSng(Me.Height / 2 - PADDLE_HEIGHT / 2), PADDLE_WIDTH, PADDLE_HEIGHT)

        ' Draw the right paddle
        e.Graphics.FillRectangle(Brushes.White, CSng(Me.Width - PADDLE_WIDTH), CSng(Me.Height / 2 - PADDLE_HEIGHT / 2), PADDLE_WIDTH, PADDLE_HEIGHT)

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        formMain.Show()
        Me.Hide()
    End Sub
End Class