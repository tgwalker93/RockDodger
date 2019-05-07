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
        Me.GameBox = New System.Windows.Forms.PictureBox()
        Me.EndGame = New System.Windows.Forms.Button()
        Me.secondTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HighScoreValue = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.TimeValue = New System.Windows.Forms.Label()
        Me.LevelValue = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.EndGame.Location = New System.Drawing.Point(24, 21)
        Me.EndGame.Name = "EndGame"
        Me.EndGame.Size = New System.Drawing.Size(75, 23)
        Me.EndGame.TabIndex = 8
        Me.EndGame.Text = "Stop Game"
        Me.EndGame.UseVisualStyleBackColor = True
        '
        'secondTimer
        '
        Me.secondTimer.Interval = 1000
        '
        'HighScoreValue
        '
        Me.HighScoreValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HighScoreValue.AutoSize = True
        Me.HighScoreValue.Location = New System.Drawing.Point(84, 29)
        Me.HighScoreValue.Name = "HighScoreValue"
        Me.HighScoreValue.Size = New System.Drawing.Size(73, 28)
        Me.HighScoreValue.TabIndex = 7
        Me.HighScoreValue.Text = "00:00"
        Me.HighScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.AutoSize = True
        Me.HighScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HighScoreLabel.Location = New System.Drawing.Point(84, 1)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(73, 27)
        Me.HighScoreLabel.TabIndex = 6
        Me.HighScoreLabel.Text = "High Score"
        Me.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelLabel
        '
        Me.LevelLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(164, 1)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(75, 27)
        Me.LevelLabel.TabIndex = 9
        Me.LevelLabel.Text = "Level"
        Me.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeValue
        '
        Me.TimeValue.AutoSize = True
        Me.TimeValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeValue.Location = New System.Drawing.Point(4, 29)
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(73, 28)
        Me.TimeValue.TabIndex = 2
        Me.TimeValue.Text = "00:00"
        Me.TimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelValue
        '
        Me.LevelValue.AutoSize = True
        Me.LevelValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LevelValue.Location = New System.Drawing.Point(164, 29)
        Me.LevelValue.Name = "LevelValue"
        Me.LevelValue.Size = New System.Drawing.Size(75, 28)
        Me.LevelValue.TabIndex = 10
        Me.LevelValue.Text = "1"
        Me.LevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeLabel.Location = New System.Drawing.Point(4, 1)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(73, 27)
        Me.TimeLabel.TabIndex = 4
        Me.TimeLabel.Text = "Time"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.LevelValue, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LevelLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HighScoreValue, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HighScoreLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeValue, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(196, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 58)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(530, 567)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.EndGame)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.StartGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Rock Dodger"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartGame As Button
    Friend WithEvents GameBox As PictureBox
    Friend WithEvents EndGame As Button
    Friend WithEvents secondTimer As Timer
    Friend WithEvents HighScoreValue As Label
    Friend WithEvents HighScoreLabel As Label
    Friend WithEvents LevelLabel As Label
    Friend WithEvents TimeValue As Label
    Friend WithEvents LevelValue As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
