Partial Public Class Game
    Public CENTRE_X As Double
    Public CENTRE_Y As Double
    Dim PADDLE_SIZE As Integer
    Dim BALL_SIZE As Integer
    Dim CIRCLE_RADIUS As Integer
    Dim BACKGROUND_COLOR As Color
    Dim speed As Single
    Dim randomAngle As Double
    Dim xVel As Single
    Dim yVel As Single

    Dim cursorAngle As Double

    Private Sub preload()
        ' Basically constants. Can't initialise constants at the very top because form hasn't loaded yet.
        ' Everything will be a variable, for consistency. (Who needs constants?)
        CENTRE_X = Me.Width / 2
        CENTRE_Y = Me.Height / 2
        PADDLE_SIZE = 40
        BALL_SIZE = 40
        CIRCLE_RADIUS = Me.Height / 2 * 0.9
        BACKGROUND_COLOR = Color.FromArgb(21, 18, 71)

        ' Ball
        speed = 5 ' Ball Speed
        randomAngle = New Random().NextDouble() * 2 * Math.PI ' Random double between 0 and 2pi.

        xVel = Math.Cos(randomAngle) * speed
        yVel = Math.Sin(randomAngle) * speed
    End Sub

    Private Sub create()
        ' Set size of ball
        picBall.Width = BALL_SIZE
        picBall.Height = BALL_SIZE

        ' Position ball
        picBall.setX(CENTRE_X)
        picBall.setY(CENTRE_Y)

        ' Position score
        lblScore.horizontallyCentre()
        lblScore.verticallyCentre()
    End Sub

    Private Sub update()
        drawPaddle()
        moveBall()
        checkCollisions()
    End Sub
End Class