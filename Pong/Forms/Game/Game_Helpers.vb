
' The really boring stuff.
Partial Public Class Game
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Pong.Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preload()
        create()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        update()
    End Sub

    Private Sub drawPaddle()
        cursorAngle = getMouseAngle(Cursor.Position())
        Me.Refresh()
    End Sub

    Private Sub moveBall()
        picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)
    End Sub

    Private Sub checkCollisions()

    End Sub

    Private Sub Game_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Actually draw the paddle.
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = cursorAngle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2
        e.Graphics.DrawArc(New Pen(Color.Orange, 10), rect, startAngle, PADDLE_SIZE)
    End Sub
End Class
