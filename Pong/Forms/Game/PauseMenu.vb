Public Class PauseMenu
    Private Sub PauseMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' I'm terribly inconsistent with choosing between the designer view and code to change properties.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Game.Size
        Me.TransparencyKey = Me.BackColor

        positionElements()
    End Sub

    Private Sub positionElements()
        ' lblPaused
        lblPaused.horizontallyCentre()
        lblPaused.Top = 100

        ' btnResume
        btnResume.placeBelow(lblPaused, 100)
        btnResume.horizontallyCentre()

        ' btnHome
        btnHome.Top = Me.Height - btnHome.Height - 40
        btnHome.Left = 40

        ' btnSound
        btnSound.Top = btnHome.Top
        btnSound.Left = Me.Width - btnSound.Width - 40
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        Me.Close()
    End Sub

    Private Sub PauseMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Space Or e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Escape Then
            btnResume.PerformClick()
        End If

        If e.Alt And e.KeyValue = Keys.F4 Then
            e.SuppressKeyPress = True
            GlobalVariables.closeForm = True
            GlobalVariables.closeProgram = True
            Me.Close()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If MessageBox.Show("All progress will be lost. Are you sure?", "Pong", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            GlobalVariables.closeForm = True
            My.Computer.Audio.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        GlobalVariables.gameMusic = Not GlobalVariables.gameMusic
        If GlobalVariables.gameMusic Then
            btnSound.Text = "Sound: On"
            My.Computer.Audio.Play(My.Resources.Tetris, AudioPlayMode.BackgroundLoop)
        Else
            btnSound.Text = "Sound: Off"
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class