Public Class Game
    Public CENTRE_X As Double
    Public CENTRE_Y As Double
    Dim PADDLE_SIZE As Integer
    Dim BALL_SIZE As Integer
    Dim CIRCLE_RADIUS As Integer
    Dim BACKGROUND_COLOR As Color

    Dim gameGraphics As Graphics

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

    Private Sub preload()
        ' Basically constants. Can't initialise constants at the very top because form hasn't loaded yet.
        ' Everything will be a variable, for consistency. (Who needs constants?)
        CENTRE_X = Me.Width / 2
        CENTRE_Y = Me.Height / 2
        PADDLE_SIZE = 40
        BALL_SIZE = 40
        CIRCLE_RADIUS = Me.Height / 2 * 0.9
        BACKGROUND_COLOR = Color.FromArgb(21, 18, 71)

        ' Create graphics
        gameGraphics = Me.CreateGraphics()

    End Sub

    Private Sub create()
        ' Set size of ball
        picBall.Width = BALL_SIZE

        ' Position score
        lblScore.horizontallyCentre()
        lblScore.verticallyCentre()
    End Sub

    Private Sub update()
        movePaddle(getMouseAngle(Cursor.Position()), CIRCLE_RADIUS)
    End Sub

    Private Sub movePaddle(angle As Double, distance As Double)
        Dim rect As New Rectangle(CENTRE_X - CIRCLE_RADIUS, CENTRE_Y - CIRCLE_RADIUS, CIRCLE_RADIUS * 2, CIRCLE_RADIUS * 2)
        Dim startAngle As Integer = angle / (2 * Math.PI) * 360 - PADDLE_SIZE / 2
        gameGraphics.Clear(BACKGROUND_COLOR)
        gameGraphics.DrawArc(New Pen(Color.Orange, 10), rect, startAngle, PADDLE_SIZE)

        Dim x As Single = CENTRE_X + distance * Math.Cos(angle)
        Dim y As Single = CENTRE_Y + distance * Math.Sin(angle)
        'picBall.setX(x)
        'picBall.setY(y)
    End Sub

    Private Sub Game_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Draw centre dot.
        'e.Graphics.FillEllipse(New SolidBrush(Color.Yellow), CSng(CENTRE_X), CSng(CENTRE_Y), 10, 10)
    End Sub
End Class