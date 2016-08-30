Imports System
Public Class formMain
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        ' lblPong
        lblPong.horizontallyCentre()
        lblPong.Top = Me.Height / 5

        ' btnPlay
        btnPlay.horizontallyCentre()
        btnPlay.placeBelow(lblPong, 100)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        formGame.Show()
        Me.Hide()
    End Sub
End Class
