<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.StartGame = New System.Windows.Forms.Button()
        Me.TimeValue = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.HighScoreValue = New System.Windows.Forms.Label()
        Me.GameBox = New System.Windows.Forms.PictureBox()
        Me.EndGame = New System.Windows.Forms.Button()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.LevelValue = New System.Windows.Forms.Label()
        Me.secondTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartGame
        '
        Me.StartGame.Location = New System.Drawing.Point(59, 27)
        Me.StartGame.Margin = New System.Windows.Forms.Padding(4)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(100, 28)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = True
        '
        'TimeValue
        '
        Me.TimeValue.AutoSize = True
        Me.TimeValue.Location = New System.Drawing.Point(457, 32)
        Me.TimeValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(16, 17)
        Me.TimeValue.TabIndex = 2
        Me.TimeValue.Text = "0"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(445, 11)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 17)
        Me.TimeLabel.TabIndex = 4
        Me.TimeLabel.Text = "Time"
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.AutoSize = True
        Me.HighScoreLabel.Location = New System.Drawing.Point(499, 11)
        Me.HighScoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(78, 17)
        Me.HighScoreLabel.TabIndex = 6
        Me.HighScoreLabel.Text = "High Score"
        '
        'HighScoreValue
        '
        Me.HighScoreValue.AutoSize = True
        Me.HighScoreValue.Location = New System.Drawing.Point(528, 33)
        Me.HighScoreValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HighScoreValue.Name = "HighScoreValue"
        Me.HighScoreValue.Size = New System.Drawing.Size(16, 17)
        Me.HighScoreValue.TabIndex = 7
        Me.HighScoreValue.Text = "0"
        '
        'GameBox
        '
        Me.GameBox.Location = New System.Drawing.Point(16, 82)
        Me.GameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(1585, 636)
        Me.GameBox.TabIndex = 1
        Me.GameBox.TabStop = False
        '
        'EndGame
        '
        Me.EndGame.Location = New System.Drawing.Point(183, 26)
        Me.EndGame.Margin = New System.Windows.Forms.Padding(4)
        Me.EndGame.Name = "EndGame"
        Me.EndGame.Size = New System.Drawing.Size(100, 28)
        Me.EndGame.TabIndex = 8
        Me.EndGame.Text = "Stop Game"
        Me.EndGame.UseVisualStyleBackColor = True
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(586, 12)
        Me.LevelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(93, 17)
        Me.LevelLabel.TabIndex = 9
        Me.LevelLabel.Text = "Current Level"
        '
        'LevelValue
        '
        Me.LevelValue.AutoSize = True
        Me.LevelValue.Location = New System.Drawing.Point(621, 32)
        Me.LevelValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LevelValue.Name = "LevelValue"
        Me.LevelValue.Size = New System.Drawing.Size(16, 17)
        Me.LevelValue.TabIndex = 10
        Me.LevelValue.Text = "1"
        '
        'secondTimer
        '
        Me.secondTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1637, 748)
        Me.Controls.Add(Me.LevelValue)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.EndGame)
        Me.Controls.Add(Me.HighScoreValue)
        Me.Controls.Add(Me.HighScoreLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.TimeValue)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.StartGame)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGame As Button
    Friend WithEvents GameBox As PictureBox
    Friend WithEvents TimeValue As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents HighScoreLabel As Label
    Friend WithEvents HighScoreValue As Label
    Friend WithEvents EndGame As Button
    Friend WithEvents LevelLabel As Label
    Friend WithEvents LevelValue As Label
    Friend WithEvents secondTimer As Timer
End Class
