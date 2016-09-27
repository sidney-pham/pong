<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.lblPong = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPong
        '
        Me.lblPong.AutoSize = True
        Me.lblPong.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPong.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPong.Location = New System.Drawing.Point(259, 86)
        Me.lblPong.Name = "lblPong"
        Me.lblPong.Size = New System.Drawing.Size(824, 112)
        Me.lblPong.TabIndex = 1
        Me.lblPong.Text = "CIRCULAR PONG"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(141, 324)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(563, 111)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.TabStop = False
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescription.Location = New System.Drawing.Point(347, 214)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(389, 39)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "A REMADE RETRO GAME"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Brown
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(26, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 75)
        Me.btnExit.TabIndex = 6
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "🏠"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 747)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblPong)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Pong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPong As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnExit As Button
End Class
