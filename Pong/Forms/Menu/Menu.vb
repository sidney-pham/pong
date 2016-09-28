Imports System
Public Class Menu
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(2, 37, 85)
        positionElements()
    End Sub

    Private Sub positionElements()
        ' lblPong
        lblPong.horizontallyCentre()
        lblPong.Top = Me.Height / 5

        ' lblDescription
        lblDescription.placeBelow(lblPong, 15)
        lblDescription.horizontallyCentre()

        ' btnPlay
        btnPlay.horizontallyCentre()
        btnPlay.placeBelow(lblPong, 160)

        ' btnExit
        btnExit.Left = 40
        btnExit.Top = Me.Height - btnExit.Height - 40
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Game.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Menu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            If GlobalVariables.closeProgram Then
                Me.Close()
            End If
        End If
    End Sub
End Class
