Partial Public Class Game
    Public CENTRE_X As Double
    Public CENTRE_Y As Double
    Dim PADDLE_SIZE As Integer
    Dim BALL_SIZE As Integer
    Dim CIRCLE_RADIUS As Integer
    Dim BACKGROUND_COLOR As Color
    Dim PADDLE_COLOR As Color
    Dim CIRCLE_COLOR As Color
    Dim speed As Single
    Dim randomAngle As Double
    Dim xVel As Single
    Dim yVel As Single
    Dim score As Integer

    Dim cursorAngle As Double

    Private Sub preload()
        ' Basically constants. Can't initialise constants at the very top because form hasn't loaded yet.
        ' Everything will be a variable, for consistency. (Who needs constants?)
        CENTRE_X = Me.Width / 2
        CENTRE_Y = Me.Height / 2
        PADDLE_SIZE = 40
        BALL_SIZE = 40
        CIRCLE_RADIUS = Me.Height / 2 * 0.9
        BACKGROUND_COLOR = Color.FromArgb(2, 37, 85)
        PADDLE_COLOR = Color.FromArgb(99, 155, 42)
        CIRCLE_COLOR = Color.White
        '79, 133, 208

        Me.BackColor = BACKGROUND_COLOR
        btnPause.Location = New Point(30, 30)
    End Sub

    Private Sub create()
        ' Ball
        speed = 10 ' Ball Speed
        randomAngle = New Random().NextDouble() * 2 * Math.PI ' Random double between 0 and 2pi.

        xVel = Math.Cos(randomAngle) * speed
        yVel = Math.Sin(randomAngle) * speed

        ' Set size of ball
        picBall.Width = BALL_SIZE
        picBall.Height = BALL_SIZE

        ' Position ball
        picBall.setX(CENTRE_X)
        picBall.setY(CENTRE_Y)

        ' Position score
        lblScore.horizontallyCentre()
        lblScore.verticallyCentre()

        score = 0
        lblScore.Text = score
    End Sub

    Private Sub update()
        moveBall()
        drawPaddle()
        checkCollisions()
        checkGameEnd()
    End Sub

    Private Sub btnPause_MouseEnter(sender As Object, e As EventArgs) Handles btnPause.MouseEnter
        btnPause.ForeColor = Color.Orange
    End Sub

    Private Sub btnPause_MouseLeave(sender As Object, e As EventArgs) Handles btnPause.MouseLeave
        btnPause.ForeColor = Color.FromArgb(255, 202, 82)
    End Sub

    Private Sub btnInvisible_Click(sender As Object, e As EventArgs) Handles btnInvisible.Click
        Pong.Menu.Show()
        Me.Close()
    End Sub
End Class