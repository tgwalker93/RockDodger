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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 608)
        Me.Controls.Add(Me.GameBox)
        Me.Controls.Add(Me.StartGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartGame As Button
    Friend WithEvents GameBox As PictureBox
End Class
