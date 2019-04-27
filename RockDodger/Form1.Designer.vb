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
        Me.StartGame = New System.Windows.Forms.Button()
        Me.GameBox = New System.Windows.Forms.PictureBox()
        Me.TimeValue = New System.Windows.Forms.Label()
        Me.LivesLeftValue = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.LivesLabel = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.HighScoreValue = New System.Windows.Forms.Label()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartGame
        '
        Me.StartGame.Location = New System.Drawing.Point(115, 23)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(75, 23)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = True
        '
        'GameBox
        '
        Me.GameBox.Location = New System.Drawing.Point(12, 67)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(1189, 517)
        Me.GameBox.TabIndex = 1
        Me.GameBox.TabStop = False
        '
        'TimeValue
        '
        Me.TimeValue.AutoSize = True
        Me.TimeValue.Location = New System.Drawing.Point(343, 26)
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(13, 13)
        Me.TimeValue.TabIndex = 2
        Me.TimeValue.Text = "0"
        '
        'LivesLeftValue
        '
        Me.LivesLeftValue.AutoSize = True
        Me.LivesLeftValue.Location = New System.Drawing.Point(468, 27)
        Me.LivesLeftValue.Name = "LivesLeftValue"
        Me.LivesLeftValue.Size = New System.Drawing.Size(13, 13)
        Me.LivesLeftValue.TabIndex = 3
        Me.LivesLeftValue.Text = "1"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(334, 9)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(30, 13)
        Me.TimeLabel.TabIndex = 4
        Me.TimeLabel.Text = "Time"
        '
        'LivesLabel
        '
        Me.LivesLabel.AutoSize = True
        Me.LivesLabel.Location = New System.Drawing.Point(448, 10)
        Me.LivesLabel.Name = "LivesLabel"
        Me.LivesLabel.Size = New System.Drawing.Size(53, 13)
        Me.LivesLabel.TabIndex = 5
        Me.LivesLabel.Text = "Lives Left"
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.AutoSize = True
        Me.HighScoreLabel.Location = New System.Drawing.Point(374, 9)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(60, 13)
        Me.HighScoreLabel.TabIndex = 6
        Me.HighScoreLabel.Text = "High Score"
        '
        'HighScoreValue
        '
        Me.HighScoreValue.AutoSize = True
        Me.HighScoreValue.Location = New System.Drawing.Point(396, 27)
        Me.HighScoreValue.Name = "HighScoreValue"
        Me.HighScoreValue.Size = New System.Drawing.Size(13, 13)
        Me.HighScoreValue.TabIndex = 7
        Me.HighScoreValue.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 608)
        Me.Controls.Add(Me.HighScoreValue)
        Me.Controls.Add(Me.HighScoreLabel)
        Me.Controls.Add(Me.LivesLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.LivesLeftValue)
        Me.Controls.Add(Me.TimeValue)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.StartGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGame As Button
    Friend WithEvents GameBox As PictureBox
    Friend WithEvents TimeValue As Label
    Friend WithEvents LivesLeftValue As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents LivesLabel As Label
    Friend WithEvents HighScoreLabel As Label
    Friend WithEvents HighScoreValue As Label
End Class
