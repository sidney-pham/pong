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
        Me.Refresh() ' Force a redraw of the screen to draw the paddle.
    End Sub

    Private Sub moveBall()
        picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)
    End Sub

    Private Sub checkCollisions()
        ' Create a GraphicsPath, which is what we use to detect collisions between our arc (a graphics object)
        ' and a PictureBox.
        ' Thanks to http://stackoverflow.com/questions/7836110/detect-collision-between-a-graphics-object-and-picture-object-in-visual-basic
        Dim path As New GraphicsPath()

        ' Add the same arc that we've already drawn to the path.
        Dim point As Point = getContactPoint()
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = cursorAngle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2
        path.AddArc(rect, startAngle, PADDLE_SIZE)

        ' Check if the paddle is in contact with the ball
        If path.IsVisible(point) Then
            ' Get the angle to the positive x-axis of the collision point (i'm calling it the radius, too bad..)
            Dim angleRadius As Double = Math.Atan2(point.Y - CENTRE_Y, point.X - CENTRE_X)
            ' Normalise atan2's results to be like normal maths.
            If angleRadius < 0 Then
                angleRadius = angleRadius + 2 * Math.PI
            End If

            ' Calculate the reflected angle. This took like 24 hours to figure out.
            Dim newAngle As Double = 2 * angleRadius - lastAngle + Math.PI

            ' Add an element of randomness to the reflection. 
            Dim randomReboundFactor As Double = randomNumber(RANDOM_REBOUND_RANGE / 2, -RANDOM_REBOUND_RANGE / 2)
            newAngle = newAngle + randomReboundFactor

            ' Set velocity of the ball based on newAngle and speed.
            xVel = Math.Cos(newAngle) * speed
            yVel = Math.Sin(newAngle) * speed
            lastAngle = newAngle

            ' Update score
            score = score + 1
            lblScore.Text = score
            lblScore.horizontallyCentre()
        End If
    End Sub

    Private Sub checkGameEnd()
        Dim ballRadius As Double = picBall.Width / 2
        Dim centre As New Point(picBall.Left + ballRadius, picBall.Top + ballRadius)

        ' Hey look, the maths we learnt at school actually works.
        If ((centre.X - CENTRE_X) ^ 2 + (centre.Y - CENTRE_Y) ^ 2) > CIRCLE_RADIUS ^ 2 Then
            endGame()
        End If
    End Sub

    Private Sub endGame()
        gameOver = True
        lblScore.Hide()
        lblGameOver.Show()
        lblGameOverScore.Text = "Score: " & score
        lblGameOverScore.Show()
        btnPlayAgain.Show()
        btnHome.Show()

        btnPause.Hide()
    End Sub

    Private Sub Game_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = cursorAngle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2

        ' Draw a white circle.
        e.Graphics.DrawEllipse(New Pen(CIRCLE_COLOR, 1), rect)

        ' Actually draw the paddle.
        e.Graphics.DrawArc(New Pen(PADDLE_COLOR, PADDLE_WIDTH), rect, startAngle, PADDLE_SIZE)
    End Sub

    ' Gets the point on the PictureBox where the ball would collide with the paddle. Not actually 100% accurate.
    Private Function getContactPoint() As Point
        Dim ballRadius As Double = picBall.Width / 2
        Dim centre As New Point(picBall.Left + ballRadius, picBall.Top + ballRadius)
        Dim contactPoint As Point

        contactPoint = New Point(centre.X + Math.Cos(cursorAngle) * ballRadius, centre.Y + Math.Sin(cursorAngle) * ballRadius)

        Return contactPoint
    End Function

    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If gameOver Then
            If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Space Then
                create()
            End If

            If e.KeyValue = Keys.Escape Then
                btnHome.PerformClick()
            End If
        Else
            If e.KeyValue = Keys.Escape Then
                btnPause.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnPause_MouseEnter(sender As Object, e As EventArgs) Handles btnPause.MouseEnter
        btnPause.ForeColor = Color.Orange
    End Sub

    Private Sub btnPause_MouseLeave(sender As Object, e As EventArgs) Handles btnPause.MouseLeave
        btnPause.ForeColor = Color.FromArgb(255, 202, 82)
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        create()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Pong.Menu.Show()
        Me.Close()
    End Sub
End Class
