<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picBall = New System.Windows.Forms.PictureBox()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(27, 12)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(64, 58)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.TabStop = False
        Me.btnPlay.Text = "X"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 16
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(596, 147)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(36, 37)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'picBall
        '
        Me.picBall.Image = CType(resources.GetObject("picBall.Image"), System.Drawing.Image)
        Me.picBall.Location = New System.Drawing.Point(196, 31)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(81, 88)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBall.TabIndex = 5
        Me.picBall.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 708)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnPlay)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Game"
        Me.Text = "formGame"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents tmrGame As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents picBall As PictureBox
End Class
