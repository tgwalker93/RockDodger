Option Strict On


Public Class Form1

    Dim gr As Graphics
    Const Square_Size = 50
    Const Board_Width = 500
    Const Board_Height = 500
    Dim CannonPic As Image = RockDodger.My.Resources.cannon
    Dim RockPic As Image = RockDodger.My.Resources.RockSprite
    Dim BirdPic As Image = RockDodger.My.Resources.giphy
    Dim currentBirdXPosition As Integer = 250
    Dim currentBirdYPosition As Integer = 250
    Dim gameBoard(20, 20) As PictureBox ''Currently not using this variable, might use later

    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click

        Console.WriteLine("Start game was selected!")
        Console.ReadLine()
        ''Dim pb As New PictureBox
        ''pb.Width = 100 'or whatever
        ''pb.Height = 200
        ''pb.Top = 50 'or whatever
        ''pb.Left = 50
        ''pb.ImageLocation = "cannon.png"

        ''Me.Controls.Add(pb)
        GameBox.Width = Board_Width
        GameBox.Height = Board_Height
        gr = GameBox.CreateGraphics

        For intX = 0 To Board_Width - 1 Step Square_Size
            For intY = 0 To Board_Height - 1 Step Square_Size
                gr.DrawRectangle(Pens.Green, intX, intY, Square_Size, Square_Size)
                If intY = 450 Then
                    Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)
                End If
                If intY = 250 AndAlso intX = 250 Then
                    Call gr.DrawImage(BirdPic, intX, intY, Square_Size, Square_Size)
                End If
            Next
        Next

        ''Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)

    End Sub



    ''On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.KeyPreview = True



    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                Debug.Print("Up")
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Right
                Debug.Print("Right")
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Down
                Debug.Print("Down")
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Left
                Debug.Print("Left")
                Return True ' <-- If you want to suppress default handling of arrow keys

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub changeBirdPosition(xPosition As Integer, yPosition As Integer)

    End Sub

End Class


