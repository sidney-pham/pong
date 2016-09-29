' KNOWN BUG(S):
' - You can 'trap' the ball in the paddle with the right timing, and it 'organically manifests' itself
' through normal gameplay, unfortunately. I'm not going to bother to fix this, because VB provides
' a terrible mechanism for collision detection which is already unreliable enough, so it's 
' not worth the effort to fix a small bug in an already buggy system.


Partial Public Class Game
    Public CENTRE_X As Double
    Public CENTRE_Y As Double
    Dim PADDLE_SIZE As Integer
    Dim PADDLE_WIDTH As Integer
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
    Dim gameOver As Boolean = False

    Dim cursorAngle As Double

    Private Sub preload()
        ' Basically constants. Can't initialise constants at the very top because form hasn't loaded yet.
        ' Everything will be a variable, for consistency. (Who needs constants?)
        CENTRE_X = Me.Width / 2
        CENTRE_Y = Me.Height / 2
        PADDLE_SIZE = 40
        PADDLE_WIDTH = 15
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

        ' Position game over screen
        Const AGAIN_HOME_MARGIN = 20

        lblGameOver.horizontallyCentre()
        lblGameOver.Top = Me.Height / 2 - lblGameOver.Height / 2 - 100

        lblGameOverScore.horizontallyCentre()
        lblGameOverScore.Top = Me.Height / 2 - lblGameOverScore.Height / 2

        btnPlayAgain.Left = Me.Width / 2 - (btnPlayAgain.Width + btnHome.Width + AGAIN_HOME_MARGIN) / 2
        btnPlayAgain.Top = Me.Height / 2 - btnPlayAgain.Height / 2 + 100

        btnHome.Height = btnPlayAgain.Height
        btnHome.Width = btnHome.Height
        btnHome.placeRight(btnPlayAgain, AGAIN_HOME_MARGIN)
        btnHome.Top = btnPlayAgain.Top

        ' Hide game over screen at first
        lblGameOver.Hide()
        lblGameOverScore.Hide()
        btnPlayAgain.Hide()
        btnHome.Hide()

        btnPause.Show()

        score = 0
        lblScore.Text = score
        lblScore.Show()

        gameOver = False
    End Sub

    Private Sub update()
        moveBall()
        drawPaddle()
        checkCollisions()
        checkGameEnd()
    End Sub
End Class