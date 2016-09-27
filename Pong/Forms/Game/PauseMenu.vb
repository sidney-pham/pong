﻿Public Class PauseMenu
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            'Turn on WS_EX_TOOLWINDOW style bit
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

    Private Sub PauseMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        Me.Close()
    End Sub

    Private Sub PauseMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Space Or e.KeyValue = Keys.Enter Then
            btnResume.PerformClick()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If MessageBox.Show("All progress will be lost. Are you sure?", "Pong", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Game.btnInvisible.PerformClick()
            Me.Close()
        End If
    End Sub
End Class