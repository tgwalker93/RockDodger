Option Strict On
Imports System.Drawing.Drawing2D
Imports System.Timers

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
    Private aTimer As System.Timers.Timer
    Dim count As Integer = 0
    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click

        Console.WriteLine("Start game was selected!")
        Console.ReadLine()

        'Draw the initial board
        RedrawBoard(currentBirdXPosition, currentBirdYPosition)

        'Create/Summon a rock
        Dim firstRock As Rock = New Rock()
        gr.DrawImage(RockPic, firstRock.X, firstRock.Y, Square_Size, Square_Size)


    End Sub

    Private Sub RedrawBoard(birdXPosition As Integer, birdYPosition As Integer)

        GameBox.Width = Board_Width
        GameBox.Height = Board_Height
        gr = GameBox.CreateGraphics

        gr.Clear(Color.White)
        For intX = 0 To Board_Width - 1 Step Square_Size
            For intY = 0 To Board_Height - 1 Step Square_Size
                gr.DrawRectangle(Pens.Red, intX, intY, Square_Size, Square_Size)
                'Cannons
                If intY = 450 Then
                    Call gr.DrawImage(CannonPic, intX, intY, Square_Size, Square_Size)
                End If
            Next
        Next

        Call gr.DrawImage(BirdPic, birdXPosition, birdYPosition, Square_Size, Square_Size)

    End Sub

    'On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.KeyPreview = True


        'TIMER STUFF -----
        SetTimer()

        Console.WriteLine("{0}Press the Enter key to exit the application...{0}",
                        vbCrLf)
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}",
                        DateTime.Now)
        Console.ReadLine()

        aTimer.Start()
        Label1.Text = CStr(count)
        'aTimer.Stop()
        'aTimer.Dispose()

        'Console.WriteLine("Terminating the application...")


    End Sub


    'This is the method to run when the timer is raised.
    'Private Shared Sub TimerEventProcessor(ByVal myObject As Object,
    ' ByVal myEventArgs As EventArgs) _
    'Handles aTimer.Tick
    ' Dim counter As Integer
    'counter = counter + 1
    'Label1.Text = counter
    'End Sub


    Private Sub SetTimer()
        ' Create a timer with a one second interval.
        aTimer = New System.Timers.Timer(1000)
        ' Hook up the Elapsed event for the timer. 
        AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
        aTimer.AutoReset = True
        aTimer.Enabled = True
    End Sub
    ' The event handler for the Timer.Elapsed event. 
    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        count = count + 1

        'We have to use BeginInvoke because we need to update Label1 from another thread. 
        Me.BeginInvoke(Sub() Me.Label1.Text = CStr(count))

        'Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
        'e.SignalTime)
        'Console.WriteLine(e.SignalTime.ToString("yyyy-MM-dd HH:mm:ss"))
    End Sub

    ' ------ End Timer Stuff

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean

        GameBox.Width = Board_Width
        GameBox.Height = Board_Height

        Dim birdLocation As New Rectangle()
        birdLocation.Size = New Size(Square_Size, Square_Size)
        birdLocation.Location = New Point(currentBirdXPosition, currentBirdYPosition)
        Dim whiteBrush As New SolidBrush(Color.White)
        gr.FillRectangle(whiteBrush, birdLocation)
        gr.DrawRectangle(Pens.Red, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)

        Select Case keyData
            Case Keys.Up
                'Change current position of the bird
                currentBirdYPosition -= 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdYPosition < 0 Then
                    currentBirdYPosition = 0
                End If

                Debug.Print("Up")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Right
                'Change current position of the bird
                currentBirdXPosition += 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdXPosition > 450 Then
                    currentBirdXPosition = 450
                End If

                Debug.Print("Right")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Down
                'Change current position of the bird
                currentBirdYPosition += 50
                'Test to make sure that bird isn't outside of game board
                If currentBirdYPosition > 400 Then
                    currentBirdYPosition = 400
                End If

                Debug.Print("Down")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

            Case Keys.Left
                currentBirdXPosition -= 50

                'Test to make sure that bird isn't outside of game board
                If currentBirdXPosition < 0 Then
                    currentBirdXPosition = 0
                End If
                Debug.Print("Left")
                'RedrawBoard(currentBirdXPosition, currentBirdYPosition)
                Call gr.DrawImage(BirdPic, currentBirdXPosition, currentBirdYPosition, Square_Size, Square_Size)
                Return True ' <-- If you want to suppress default handling of arrow keys

        End Select


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


