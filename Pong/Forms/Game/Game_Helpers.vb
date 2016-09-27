Imports System.Drawing.Drawing2D

' The really boring stuff.
Partial Public Class Game
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        tmrGame.Stop()
        btnPause.Hide()
        OpaqueOverlay.Show()
        PauseMenu.ShowDialog()
        OpaqueOverlay.Close()
        ' I really don't know why it doesn't work without global variables, but it doesn't.
        ' I'm disgusted by this.
        If GlobalVariables.closeForm Then
            Pong.Menu.Show()
            GlobalVariables.closeForm = False
            Me.Close()
        Else
            tmrGame.Start()
            btnPause.Show()
        End If
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
        'pnlPaddle.Update()
        'formPaddle.Refresh()
    End Sub

    Private Sub moveBall()
        picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)
    End Sub

    Private Sub checkCollisions()
        Dim path As New GraphicsPath()

        Dim point As Point = getContactPoint()
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = cursorAngle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2
        path.AddArc(rect, startAngle, PADDLE_SIZE)
        If path.IsVisible(point) Then
            Dim centre As New Point(Math.Cos(cursorAngle) * CIRCLE_RADIUS, Math.Sin(cursorAngle) * CIRCLE_RADIUS)
            Dim distanceFromCentre As Double = Math.Sqrt((centre.X - point.X) ^ 2 + (centre.Y - point.Y) ^ 2)
            xVel = -xVel
            yVel = -yVel

            score = score + 1
            lblScore.Text = score
            lblScore.horizontallyCentre()
        End If
    End Sub

    Private Sub checkGameEnd()
        If picBall.Location.X < 0 Or picBall.Location.Y < 0 Or picBall.Location.X > Me.Width - picBall.Width Or picBall.Location.Y > Me.Height - picBall.Height Then
            create()
        End If
    End Sub

    Private Sub Game_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = cursorAngle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2

        ' Draw a white circle
        e.Graphics.DrawEllipse(New Pen(CIRCLE_COLOR, 1), rect)

        ' Actually draw the paddle.
        e.Graphics.DrawArc(New Pen(PADDLE_COLOR, 20), rect, startAngle, PADDLE_SIZE)
    End Sub

    Private Function getContactPoint() As Point
        Dim ballRadius As Double = picBall.Width / 2
        Dim centre As New Point(picBall.Left + ballRadius, picBall.Top + ballRadius)
        centre.X += Math.Cos(cursorAngle)
        centre.Y += Math.Sin(cursorAngle)
        Return centre
    End Function

    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            btnPause.PerformClick()
        End If
    End Sub
End Class
