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
        Me.btnInvisible = New System.Windows.Forms.Button()
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
        'btnInvisible
        '
        Me.btnInvisible.Location = New System.Drawing.Point(59, 147)
        Me.btnInvisible.Name = "btnInvisible"
        Me.btnInvisible.Size = New System.Drawing.Size(75, 23)
        Me.btnInvisible.TabIndex = 6
        Me.btnInvisible.Text = "Button1"
        Me.btnInvisible.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 708)
        Me.Controls.Add(Me.btnInvisible)
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
    Friend WithEvents btnInvisible As Button
End Class
