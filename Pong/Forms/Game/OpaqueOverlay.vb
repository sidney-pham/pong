Public Class OpaqueOverlay
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            'Turn on WS_EX_TOOLWINDOW style bit
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H80
            Return cp
        End Get
    End Property

    Private Sub OpaqueOverlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Size = Game.Size
        Me.BackColor = Color.Black
        Me.Opacity = 0.5
    End Sub
End Class