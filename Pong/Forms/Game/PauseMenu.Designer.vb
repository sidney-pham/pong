<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PauseMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.lblPaused = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnResume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnResume.FlatAppearance.BorderSize = 0
        Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResume.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(178, 129)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(418, 89)
        Me.btnResume.TabIndex = 3
        Me.btnResume.TabStop = False
        Me.btnResume.Text = "RESUME"
        Me.btnResume.UseVisualStyleBackColor = False
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaused.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPaused.Location = New System.Drawing.Point(259, 26)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(268, 77)
        Me.lblPaused.TabIndex = 4
        Me.lblPaused.Text = "PAUSED"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Brown
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(23, 319)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 75)
        Me.btnHome.TabIndex = 5
        Me.btnHome.TabStop = False
        Me.btnHome.Text = "🏠"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PauseMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 406)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblPaused)
        Me.Controls.Add(Me.btnResume)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PauseMenu"
        Me.Text = "PauseMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnResume As Button
    Friend WithEvents lblPaused As Label
    Friend WithEvents btnHome As Button
End Class
