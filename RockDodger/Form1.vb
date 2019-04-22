Option Strict On
Imports System.Drawing.Drawing2D

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
    Dim emptyGameBoard As GraphicsContainer
    Dim emptyGameState As GraphicsState
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

        ''Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)
        ''This subroutine will be called everytime the bird changes positions
        RedrawBoard(currentBirdXPosition, currentBirdYPosition)

    End Sub

    Private Sub RedrawBoard(birdXPosition As Integer, birdYPosition As Integer)
        'emptyGameBoard = gr.BeginContainer
        GameBox.Width = Board_Width
        GameBox.Height = Board_Height
        gr = GameBox.CreateGraphics
        gr.Clear(Color.White)
        For intX = 0 To Board_Width - 1 Step Square_Size
            For intY = 0 To Board_Height - 1 Step Square_Size
                gr.DrawRectangle(Pens.Green, intX, intY, Square_Size, Square_Size)
                If intY = 450 Then
                    Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)
                End If
            Next
        Next
        emptyGameState = gr.Save()
        'gr.EndContainer(emptyGameBoard)
        Call gr.DrawImage(BirdPic, birdXPosition, birdYPosition, Square_Size, Square_Size)
    End Sub

    ''On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.KeyPreview = True



    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean

        GameBox.Width = Board_Width
        GameBox.Height = Board_Height
        gr = GameBox.CreateGraphics
        gr.Restore(emptyGameState)

        Select Case keyData
            Case Keys.Up
                'gr.DrawImage(RockPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                ''Change current position of the bird
                currentBirdYPosition -= 50
                ''Test to make sure that bird isn't outside of game board
                If currentBirdYPosition > 500 Then
                    currentBirdYPosition = 500
                End If
                If currentBirdYPosition < 0 Then
                    currentBirdYPosition = 0
                End If

                Debug.Print("Up")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Right
                ''Change current position of the bird
                currentBirdXPosition += 50
                ''Test to make sure that bird isn't outside of game board
                If currentBirdXPosition > 500 Then
                    currentBirdXPosition = 500
                End If
                If currentBirdXPosition < 0 Then
                    currentBirdXPosition = 0
                End If

                Debug.Print("Right")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Down

                ''Change current position of the bird
                currentBirdYPosition += 50
                ''Test to make sure that bird isn't outside of game board
                If currentBirdYPosition > 500 Then
                    currentBirdYPosition = 500
                End If
                If currentBirdYPosition < 0 Then
                    currentBirdYPosition = 0
                End If

                Debug.Print("Down")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Left
                currentBirdXPosition -= 50
                If currentBirdXPosition > 500 Then
                    currentBirdXPosition = 500
                End If
                If currentBirdXPosition < 0 Then
                    currentBirdXPosition = 0
                End If
                Debug.Print("Left")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

        End Select

        'Draw the new location of the bird


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    '   Private Sub changeBirdPosition(xPosition As Integer, yPosition As Integer, direction As String)
    '   Select Case direction
    '   Case "Up"
    '   Case "Right"
    '   Case "Down"
    '   Case "Left"
    '
    '    End Select
    '    End Sub

End Class


