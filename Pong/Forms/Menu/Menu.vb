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
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Game.Show()
        Me.Hide()
    End Sub
End Class
