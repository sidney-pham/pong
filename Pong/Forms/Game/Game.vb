' KNOWN BUG(S):
' - You can 'trap' the ball in the paddle with the right timing, and it 'organically manifests' itself
' through normal gameplay, unfortunately. I'm not going to bother to fix this, because VB provides
' a terrible mechanism for collision detection which is already unreliable enough, so it's 
' not worth the effort to fix a small bug in an already buggy system.


Partial Public Class Game
    ' Declaring 'constants' without actually giving them a value. How strange.
    Public CENTRE_X As Double           ' The x-position of the centre of the screen
    Public CENTRE_Y As Double           ' The y-position of the centre of the screen
    Dim PADDLE_SIZE As Integer          ' The size of the paddle in degrees. Not radians, because Microsoft is ridiculously inconsistent, and has sweepAngle in degrees.
    Dim PADDLE_WIDTH As Integer         ' The thickness of the paddle in pixels.
    Dim BALL_SIZE As Integer            ' The diameter of the ball in pixels.
    Dim CIRCLE_RADIUS As Integer        ' The radius of the circle in pixels.
    Dim BACKGROUND_COLOR As Color
    Dim PADDLE_COLOR As Color
    Dim CIRCLE_COLOR As Color
    Dim SPEED As Single                 ' Basically the magnitude of the velocity vector.
    Dim SPEED_INCREASE As Single        ' How much the speed increases every time the ball bounces.
    Dim MAX_SPEED As Single             ' The cap for the speed increase.

    ' Not 'constants'. Actual form-level variables.
    Dim lastAngle As Double             ' The last angle of the ball, measured to the positive x-axis.
    Dim xVel As Single                  ' The x-velocity.
    Dim yVel As Single                  ' The y-velocity.
    Dim score As Integer                ' The game score.
    Dim RANDOM_REBOUND_RANGE As Double  ' Angle in radians indicating the possible range of angles of deflection. E.g. 1 means the ball can rebound up to 0.5 radians up from the normal and 0.5 down.
    Dim gameOver As Boolean = False     ' Is the damn game over yet?
    Dim cursorAngle As Double           ' What angle is formed at the origin (centre of the screen) by the positive x-axis and the mouse cursor??
    Dim endSoundPlayed As Boolean       ' :(

    ' Run once on form load.
    Private Sub preload()
        ' Basically constants. Can't initialise constants at the very top because form hasn't loaded yet.
        ' Everything will be a variable, for consistency. (Who needs constants?)
        CENTRE_X = Me.Width / 2
        CENTRE_Y = Me.Height / 2
        PADDLE_SIZE = 40
        PADDLE_WIDTH = 15
        BALL_SIZE = 40
        RANDOM_REBOUND_RANGE = 1
        CIRCLE_RADIUS = Me.Height / 2 * 0.9
        SPEED_INCREASE = 0.5
        MAX_SPEED = 20
        BACKGROUND_COLOR = Color.FromArgb(2, 37, 85)
        PADDLE_COLOR = Color.FromArgb(99, 155, 42)
        CIRCLE_COLOR = Color.White

        Me.BackColor = BACKGROUND_COLOR
        btnPause.Location = New Point(30, 30)

        ' Play music.
        My.Computer.Audio.Play(My.Resources.Tetris, AudioPlayMode.BackgroundLoop)
    End Sub

    ' Run after preload() once.
    ' Call create() again to restart the game.
    Private Sub create()
        ' Ball
        SPEED = 10 ' Ball Speed
        Dim randomAngle As Double = New Random().NextDouble() * 2 * Math.PI ' Random double between 0 and 2pi (radians).
        lastAngle = randomAngle

        xVel = Math.Cos(randomAngle) * SPEED
        yVel = Math.Sin(randomAngle) * SPEED

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

        ' Just ignore this. I'm very sad this is here.
        endSoundPlayed = False
    End Sub

    ' update() is run every timer tick.
    Private Sub update()
        moveBall()
        drawPaddle()
        checkCollisions()
        checkGameEnd()
    End Sub
End Class