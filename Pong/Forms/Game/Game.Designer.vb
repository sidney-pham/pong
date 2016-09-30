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
        Me.btnPause = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblGameOverScore = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPause
        '
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Font = New System.Drawing.Font("Century Gothic", 35.0!, System.Drawing.FontStyle.Bold)
        Me.btnPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPause.Location = New System.Drawing.Point(27, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(93, 107)
        Me.btnPause.TabIndex = 3
        Me.btnPause.TabStop = False
        Me.btnPause.Text = "❙❙"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 16
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(596, 147)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(114, 128)
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
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft YaHei UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(117, 110)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(593, 128)
        Me.lblGameOver.TabIndex = 7
        Me.lblGameOver.Text = "Game Over"
        '
        'lblGameOverScore
        '
        Me.lblGameOverScore.AutoSize = True
        Me.lblGameOverScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOverScore.ForeColor = System.Drawing.Color.White
        Me.lblGameOverScore.Location = New System.Drawing.Point(75, 266)
        Me.lblGameOverScore.Name = "lblGameOverScore"
        Me.lblGameOverScore.Size = New System.Drawing.Size(237, 62)
        Me.lblGameOverScore.TabIndex = 8
        Me.lblGameOverScore.Text = "Score: 24"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnPlayAgain.FlatAppearance.BorderSize = 0
        Me.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayAgain.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.ForeColor = System.Drawing.Color.White
        Me.btnPlayAgain.Location = New System.Drawing.Point(320, 165)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(231, 67)
        Me.btnPlayAgain.TabIndex = 9
        Me.btnPlayAgain.TabStop = False
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Brown
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(596, 147)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 75)
        Me.btnHome.TabIndex = 10
        Me.btnHome.TabStop = False
        Me.btnHome.Text = "🏠"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 708)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblGameOverScore)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnPause)
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
    Friend WithEvents lblScore As Label
    Friend WithEvents picBall As PictureBox
    Public WithEvents tmrGame As Timer
    Public WithEvents btnPause As Button
    Friend WithEvents lblGameOver As Label
    Friend WithEvents lblGameOverScore As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnHome As Button
End Class
