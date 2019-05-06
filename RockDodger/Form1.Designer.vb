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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartGame
        '
        Me.StartGame.Location = New System.Drawing.Point(24, 21)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(75, 23)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = True
        '
        'TimeValue
        '
        Me.TimeValue.AutoSize = True
        Me.TimeValue.Location = New System.Drawing.Point(3, 24)
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(13, 13)
        Me.TimeValue.TabIndex = 2
        Me.TimeValue.Text = "0"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(-3, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(30, 13)
        Me.TimeLabel.TabIndex = 4
        Me.TimeLabel.Text = "Time"
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.AutoSize = True
        Me.HighScoreLabel.Location = New System.Drawing.Point(61, 0)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(60, 13)
        Me.HighScoreLabel.TabIndex = 6
        Me.HighScoreLabel.Text = "High Score"
        '
        'HighScoreValue
        '
        Me.HighScoreValue.AutoSize = True
        Me.HighScoreValue.Location = New System.Drawing.Point(90, 24)
        Me.HighScoreValue.Name = "HighScoreValue"
        Me.HighScoreValue.Size = New System.Drawing.Size(13, 13)
        Me.HighScoreValue.TabIndex = 7
        Me.HighScoreValue.Text = "0"
        '
        'GameBox
        '
        Me.GameBox.Location = New System.Drawing.Point(13, 67)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(501, 504)
        Me.GameBox.TabIndex = 1
        Me.GameBox.TabStop = False
        '
        'EndGame
        '
        Me.EndGame.Location = New System.Drawing.Point(105, 21)
        Me.EndGame.Name = "EndGame"
        Me.EndGame.Size = New System.Drawing.Size(75, 23)
        Me.EndGame.TabIndex = 8
        Me.EndGame.Text = "Stop Game"
        Me.EndGame.UseVisualStyleBackColor = True
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(172, 0)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(70, 13)
        Me.LevelLabel.TabIndex = 9
        Me.LevelLabel.Text = "Current Level"
        '
        'LevelValue
        '
        Me.LevelValue.AutoSize = True
        Me.LevelValue.Location = New System.Drawing.Point(210, 24)
        Me.LevelValue.Name = "LevelValue"
        Me.LevelValue.Size = New System.Drawing.Size(13, 13)
        Me.LevelValue.TabIndex = 10
        Me.LevelValue.Text = "1"
        '
        'secondTimer
        '
        Me.secondTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TimeLabel)
        Me.Panel1.Controls.Add(Me.LevelValue)
        Me.Panel1.Controls.Add(Me.TimeValue)
        Me.Panel1.Controls.Add(Me.LevelLabel)
        Me.Panel1.Controls.Add(Me.HighScoreLabel)
        Me.Panel1.Controls.Add(Me.HighScoreValue)
        Me.Panel1.Location = New System.Drawing.Point(194, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 51)
        Me.Panel1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(530, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EndGame)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.StartGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Rock Dodger"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As Panel
End Class
